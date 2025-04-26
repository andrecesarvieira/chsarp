using MySQL_Gerador.Modules;
using System;
using System.Windows.Forms;

namespace MySQL_Gerador
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            txtCampos.Text = "id int;";
        }

        private void Btn_Gerar_Click(object sender, EventArgs e)
        {
            if (txtCampos.TextLength == 0)
                return;

            string[] comandos = GerarComandos.Gerar(txtCampos.Text);

            txtPropriedades.Text = comandos[0];
            txtParamentros.Text = comandos[1];
            txtInsertCampos.Text = comandos[2];
            txtInsertValues.Text = comandos[3];
            txtUpdate.Text = comandos[4];
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            foreach (Control item in this.Controls)
            {
                if (item is RichTextBox)
                {
                    item.Text = string.Empty;
                }
            }
        }
    }
}
