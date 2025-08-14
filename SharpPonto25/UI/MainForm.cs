using SharpPonto25.Data;
using SharpPonto25.Entities;
using SharpPonto25.Interfaces;
using SharpPonto25.Services;

namespace SharpPonto25
{
    /// <summary>
    /// Classe principal do formulário
    /// </summary>
    public partial class MainForm : Form
    {
        private readonly IRegistroService _registroService;
        private readonly IExportarService _exportarService;

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="registroService"></param>
        /// <param name="exportarService"></param>
        public MainForm(IRegistroService registroService, IExportarService exportarService)
        {
            InitializeComponent();

            // Configurar tema baseado nas configurações do sistema
            ConfigurarTemaVisual();

            _registroService = registroService;
            _exportarService = exportarService;

            //dgvRegistros.Columns["gridManha"].HeaderCell.Style.BackColor = Color.LightSteelBlue;
            //dgvRegistros.Columns["gridTarde"].HeaderCell.Style.BackColor = Color.LightSteelBlue;
            //dgvRegistros.Columns["gridTotal"].HeaderCell.Style.BackColor = Color.LightGoldenrodYellow;

            //lblPath.Text = $"Banco de dados => {AppDbContext.CaminhoDb()}";
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            using (var ctx = new AppDbContext())
            {
                ctx.AplicarMigracao();
            }
            ;

            await CarregarDadosAsync();
        }

        private async Task CarregarDadosAsync()
        {
            try
            {
                var registros = await _registroService.ObterTodosRegistrosAsync();
                dgvRegistros.DataSource = registros;
                dgvRegistros.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                bool registrar = await _registroService.RegistrarPontoAsync();

                if (registrar)
                {
                    await CarregarDadosAsync();
                }
                else
                {
                    MessageBox.Show("Não foi possível registrar o ponto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao registrar ponto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRegistros.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Selecionar um registro para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (dgvRegistros.CurrentRow?.DataBoundItem is not Registro r)
                {
                    return;
                }

                var op = MessageBox.Show("Confirma a exclusão?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (op == DialogResult.Yes)
                {
                    bool excluir = await _registroService.ExcluirRegistroAsync(r.Id);

                    if (excluir)
                    {
                        await CarregarDadosAsync();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível excluir o registro.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir registro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                string[] dados = [textData.Text, textEntrada.Text, textAlmoco.Text, textRetorno.Text, textSaida.Text];

                ConverterDataHoraService conv = new();
                Registro novoRegistro = conv.ConverterDataHora(dados);

                if (novoRegistro.Data == DateOnly.MinValue)
                {
                    MessageBox.Show("Insira uma data válida.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool inserir = await _registroService.InserirPontoAsync(novoRegistro);

                if (inserir)
                {
                    await CarregarDadosAsync();
                }
                else
                {
                    MessageBox.Show($"Já existe registro com a data de {novoRegistro.Data}.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao registrar ponto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRegistros.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecionar pelo menos um registro para exportar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                List<Registro> selecionados = [];

                foreach (DataGridViewRow row in dgvRegistros.SelectedRows)
                {
                    if (row.DataBoundItem is Registro registro)
                    {
                        selecionados.Add(registro);
                    }
                }

                if (selecionados.Count == 0)
                {
                    return;
                }

                var (exportar, caminho) = await _exportarService.ExportarArquivoAsync(selecionados);

                if (exportar)
                {
                    MessageBox.Show($"Exportação concluída com sucesso! {caminho}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não foi possível exportar os registros", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao exportar registros: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvRegistros_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvRegistros.CurrentRow?.DataBoundItem is Registro r)
                {
                    textData.Text = r.Data.ToString();
                    textEntrada.Text = r.Entrada.ToString();
                    textAlmoco.Text = r.Almoco.ToString();
                    textRetorno.Text = r.Retorno.ToString();
                    textSaida.Text = r.Saida.ToString();
                }
            }
        }
        private void ConfigurarTemaVisual()
        {
            // Verifica se o sistema está usando tema escuro
            bool temaEscuro = false;
            try
            {
                // Tenta obter a configuração de tema do Windows
                using (var key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize"))
                {
                    if (key != null)
                    {
                        object value = key.GetValue("AppsUseLightTheme");
                        if (value != null && value is int intValue)
                        {
                            temaEscuro = intValue == 0;
                        }
                    }
                }
            }
            catch
            {
                // Em caso de falha, usa o tema claro como padrão
                temaEscuro = false;
            }

            // Aplica o tema aos controles
            if (temaEscuro)
            {
                // Tema escuro
                BackColor = Color.FromArgb(32, 32, 32);
                ForeColor = Color.White;

                dgvRegistros.BackgroundColor = Color.FromArgb(45, 45, 45);
                dgvRegistros.DefaultCellStyle.BackColor = Color.FromArgb(45, 45, 45);
                dgvRegistros.DefaultCellStyle.ForeColor = Color.White;
                dgvRegistros.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);
                dgvRegistros.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvRegistros.GridColor = Color.FromArgb(70, 70, 70);

                foreach (Control control in Controls)
                {
                    if (control is Button btn)
                    {
                        btn.BackColor = Color.FromArgb(60, 60, 60);
                        btn.ForeColor = Color.White;
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.FlatAppearance.BorderColor = Color.FromArgb(100, 100, 100);
                    }
                    else if (control is TextBox txt)
                    {
                        txt.BackColor = Color.FromArgb(50, 50, 50);
                        txt.ForeColor = Color.White;
                    }
                    else if (control is Label lbl)
                    {
                        lbl.ForeColor = Color.White;
                    }
                    else if (control is Panel pnl)
                    {
                        pnl.BackColor = Color.FromArgb(40, 40, 40);
                    }
                }
            }
            else
            {
                // Tema claro (padrão)
                BackColor = SystemColors.Control;
                ForeColor = SystemColors.ControlText;

                dgvRegistros.BackgroundColor = SystemColors.Window;
                dgvRegistros.DefaultCellStyle.BackColor = SystemColors.Window;
                dgvRegistros.DefaultCellStyle.ForeColor = SystemColors.ControlText;
                dgvRegistros.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Control;
                dgvRegistros.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.ControlText;
                dgvRegistros.GridColor = SystemColors.ControlDark;

                foreach (Control control in Controls)
                {
                    if (control is Button btn)
                    {
                        btn.UseVisualStyleBackColor = true;
                        btn.FlatStyle = FlatStyle.Standard;
                    }
                    else if (control is TextBox txt)
                    {
                        txt.BackColor = SystemColors.Window;
                        txt.ForeColor = SystemColors.WindowText;
                    }
                    else if (control is Label lbl)
                    {
                        lbl.ForeColor = SystemColors.ControlText;
                    }
                    else if (control is Panel pnl)
                    {
                        pnl.BackColor = SystemColors.Control;
                    }
                }
            }
        }
    }
}