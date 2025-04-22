using SharpPonto.Entidades;
using System.Data;
using System.Text;

namespace SharpPonto
{
    public partial class Form1 : Form
    {
        private readonly Registro registro = new();
        private DataTable dt = new();

        public Form1()
        {
            InitializeComponent();
            
            dataGridView1.Columns["gridManha"].HeaderCell.Style.BackColor = Color.LightSteelBlue;
            dataGridView1.Columns["gridTarde"].HeaderCell.Style.BackColor = Color.LightSteelBlue;
            dataGridView1.Columns["gridTotal"].HeaderCell.Style.BackColor = Color.LightGoldenrodYellow;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            this.Text = $"SharpPonto - Versão {version}";

            Dados.Database.CriarBancoDeDados();
            Dados.Database.CriarTabela();
            Dados.Database.LerRegistros();

            lblPath.Text = Dados.Database.path;

            ExibirDados();
        }

        private void ExibirDados()
        {
            try
            {
                dataGridView1.DataSource = Dados.Database.LerRegistros();
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ler a tabela" + ex.Message);
            }

        }

        #region "Funções dos botões"
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            registro.Data = DateOnly.FromDateTime(DateTime.Now);

            try
            {
                var dataFmt = registro.Data.ToString("yyyy/MM/dd");
                dt = Dados.Database.LerRegistro(dataFmt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ler o registro pela chave: " + ex.Message);
            }

            var n = 0;

            if (dt.Rows.Count == 0)
            {
                registro.Entrada = TimeOnly.FromDateTime(DateTime.Now);
                registro.Almoco = TimeOnly.Parse("00:00");
                registro.Retorno = TimeOnly.Parse("00:00");
                registro.Saida = TimeOnly.Parse("00:00");
                registro.Manha = TimeOnly.Parse("00:00");
                registro.Tarde = TimeOnly.Parse("00:00");
                registro.TotalDia = TimeOnly.Parse("00:00");
                
                n = 1;
            }
            else if (TimeOnly.Parse(dt.Rows[0]["Almoco"].ToString()!) == TimeOnly.Parse("00:00"))
            {
                registro.Almoco = TimeOnly.FromDateTime(DateTime.Now);

                var hrInicial = dt.Rows[0]["Entrada"].ToString()!;
                var hrFinal = registro.Almoco.ToString("HH:mm");

                registro.Manha = TimeOnly.FromTimeSpan(CalcularPeriodo(hrInicial, hrFinal, 1));

                n = 2;
            }
            else if (TimeOnly.Parse(dt.Rows[0]["Retorno"].ToString()!) == TimeOnly.Parse("00:00"))
            {
                registro.Retorno = TimeOnly.FromDateTime(DateTime.Now);

                n = 3;
            }
            else if (TimeOnly.Parse(dt.Rows[0]["Saida"].ToString()!) == TimeOnly.Parse("00:00"))
            {
                registro.Saida = TimeOnly.FromDateTime(DateTime.Now);

                var hrInicial = dt.Rows[0]["Retorno"].ToString()!;
                var hrFinal = registro.Saida.ToString("HH:mm");

                registro.Tarde = TimeOnly.FromTimeSpan(CalcularPeriodo(hrInicial, hrFinal, 1));

                var totalManha = dt.Rows[0]["Manha"].ToString()!;
                var totalTarde = registro.Tarde.ToString("HH:mm");

                registro.TotalDia = TimeOnly.FromTimeSpan(CalcularPeriodo(totalManha, totalTarde, 2));

                n = 4;
            }

            try
            {
                Dados.Database.InserirRegistro(registro, n);
                ExibirDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar o dado: " + ex.Message);
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                try
                {
                    string? dataFmt = dataGridView1.SelectedRows[0].Cells["gridData"].Value?.ToString();

                    if (string.IsNullOrEmpty(dataFmt))
                    {
                        MessageBox.Show("O valor da data selecionada é inválido ou nulo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    DialogResult result = MessageBox.Show("Deseja realmente excluir o registro do dia " + dataFmt + "?",
                                                        "Confirmar exclusão",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        Dados.Database.ExcluirRegistro(dataFmt);
                        ExibirDados();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir o registro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            if (!DateOnly.TryParse(textData.Text, out _) ||
                !TimeOnly.TryParse(textEntrada.Text, out _) ||
                !TimeOnly.TryParse(textAlmoco.Text, out _) ||
                !TimeOnly.TryParse(textRetorno.Text, out _) ||
                !TimeOnly.TryParse(textSaida.Text, out _))
            {
                MessageBox.Show("Preencha todos os campos com valores válidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            registro.Data = DateOnly.Parse(textData.Text);
            registro.Entrada = TimeOnly.Parse(textEntrada.Text);
            registro.Almoco = TimeOnly.Parse(textAlmoco.Text);
            registro.Retorno = TimeOnly.Parse(textRetorno.Text);
            registro.Saida = TimeOnly.Parse(textSaida.Text);

            try
            {
                var dataFmt = registro.Data.ToString("yyyy/MM/dd");
                dt = Dados.Database.LerRegistro(dataFmt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ler o registro pela chave: " + ex.Message);
            }

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Já existe registro para a data.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                var hrInicial = registro.Entrada.ToString("HH:mm");
                var hrFinal = registro.Almoco.ToString("HH:mm");
                if (hrInicial != "00:00" && hrFinal != "00:00")
                {
                    registro.Manha = TimeOnly.FromTimeSpan(CalcularPeriodo(hrInicial, hrFinal, 1));
                }

                hrInicial = registro.Retorno.ToString("HH:mm");
                hrFinal = registro.Saida.ToString("HH:mm");
                
                if (hrInicial != "00:00" && hrFinal != "00:00")
                {
                    registro.Tarde = TimeOnly.FromTimeSpan(CalcularPeriodo(hrInicial, hrFinal, 1));
                }

                var totalManha = registro.Manha.ToString("HH:mm");
                var totalTarde = registro.Tarde.ToString("HH:mm");

                if (totalManha != "00:00" && totalTarde != "00:00")
                {
                    registro.TotalDia = TimeOnly.FromTimeSpan(CalcularPeriodo(totalManha, totalTarde, 2));
                }
            }

            try
            {
                Dados.Database.InserirRegistro(registro, 5);
                ExibirDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar o dado: " + ex.Message);
            }
        }

        private void BtnExportar_Click(object sender, EventArgs e)
        {
            // Função auxiliar para pegar o texto da célula com segurança
            string GetCellText(int row, int col)
            {
                var cell = dataGridView1.Rows[row].Cells[col];
                return cell.Value != null ? cell.Value.ToString()! : "";
            }

            // Verifica se há itens selecionados
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione pelo menos um registro.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Identifica as linhas únicas selecionadas
            var linhasSelecionadas = new HashSet<int>();
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                linhasSelecionadas.Add(cell.RowIndex);
            }

            // Nome do arquivo: pontos_yyyymm.csv (ano e mês corrente)
            string nomeArquivo = $"Timesheet_{DateTime.Now:yyyyMM}.csv";
            string caminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, nomeArquivo);

            try
            {
                using (var writer = new StreamWriter(caminhoArquivo, false, Encoding.UTF8))
                {
                    foreach (int linha in linhasSelecionadas.OrderBy(l => l))
                    {
                        string dataStr = GetCellText(linha, 0); 
                        string entrada = GetCellText(linha, 1); 
                        string almoco = GetCellText(linha, 2); 
                        string retorno = GetCellText(linha, 3); 
                        string saida = GetCellText(linha, 4); 
                        string manha = GetCellText(linha, 5); 
                        string tarde = GetCellText(linha, 6); 

                        // Verifica se a data está preenchida antes de converter
                        var dataFormatada = string.Empty;

                        if (!string.IsNullOrEmpty(dataStr))
                        {
                            try
                            {
                                var dt = DateTime.ParseExact(dataStr, "yyyy/MM/dd", null);
                                dataFormatada = dt.ToString("dd/MMM/yy", new System.Globalization.CultureInfo("pt-BR"));
                                dataFormatada = dataFormatada.Replace("/", "/").Replace("jan", "Jan").Replace("fev", "Fev")
                                    .Replace("mar", "Mar").Replace("abr", "Abr").Replace("mai", "Mai").Replace("jun", "Jun")
                                    .Replace("jul", "Jul").Replace("ago", "Ago").Replace("set", "Set").Replace("out", "Out")
                                    .Replace("nov", "Nov").Replace("dez", "Dez").Replace(".", "");
                            }
                            catch
                            {
                                dataFormatada = dataStr;
                            }
                        }

                        // Monta as duas linhas conforme o padrão informado
                        string linhaTarde = dataFormatada + "#|#APROVADO#|#" + retorno + "#|#" + saida + "#|#" + tarde +
                                            "#|#00:00#|#0000#|#0000-0000#|#SIM#|#0000#|#ANALISE DE SISTEMAS#|#";
                        string linhaManha = dataFormatada + "#|#APROVADO#|#" + entrada + "#|#" + almoco + "#|#" + manha +
                                            "#|#00:00#|#0000#|#0000-0000#|#SIM#|#0000#|#ANALISE DE SISTEMAS#|#";

                        // Escreve cada período em uma linha do arquivo
                        writer.WriteLine(linhaTarde);
                        writer.WriteLine(linhaManha);
                    }
                }

                MessageBox.Show($"Arquivo exportado com sucesso:\n{caminhoArquivo}", "Exportação Concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao exportar o arquivo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "Calculos"
        private static TimeSpan CalcularPeriodo(string hrInicial, string hrFinal, int tipo)
        {
            try
            {
                var inicio = TimeOnly.Parse(hrInicial);
                var fim = TimeOnly.Parse(hrFinal);

                if (tipo == 1)
                {
                    return fim.ToTimeSpan() - inicio.ToTimeSpan();
                }
                else
                {
                    return fim.ToTimeSpan() + inicio.ToTimeSpan();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao calcular o tempo percorrido: " + ex.Message);
            }

            return TimeSpan.Zero;
        }
        #endregion
    }
}