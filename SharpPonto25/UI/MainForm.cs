using SharpPonto25.Data;
using SharpPonto25.Entities;
using SharpPonto25.Interfaces;
using SharpPonto25.Services;

namespace SharpPonto25
{
    public partial class MainForm : Form
    {
        private readonly IRegistroService _registroService;
        private readonly IExportarService _exportarService;

        public MainForm(IRegistroService registroService, IExportarService exportarService)
        {
            InitializeComponent();

            _registroService = registroService;
            _exportarService = exportarService;

            dgvRegistros.Columns["gridManha"].HeaderCell.Style.BackColor = Color.LightSteelBlue;
            dgvRegistros.Columns["gridTarde"].HeaderCell.Style.BackColor = Color.LightSteelBlue;
            dgvRegistros.Columns["gridTotal"].HeaderCell.Style.BackColor = Color.LightGoldenrodYellow;

            lblPath.Text = $"Banco de dados => {AppDbContext.CaminhoDb()}";
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
                string[] dados =
                {
                    textData.Text,
                    textEntrada.Text,
                    textAlmoco.Text,
                    textRetorno.Text,
                    textSaida.Text,
                };

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
    }
}