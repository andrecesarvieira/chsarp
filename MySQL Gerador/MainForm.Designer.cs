
namespace MySQL_Gerador
{
    partial class MainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtCampos = new System.Windows.Forms.RichTextBox();
            this.txtInsertCampos = new System.Windows.Forms.RichTextBox();
            this.Btn_Gerar = new System.Windows.Forms.Button();
            this.txtUpdate = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtParamentros = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPropriedades = new System.Windows.Forms.RichTextBox();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.txtInsertValues = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_Campos
            // 
            this.txtCampos.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCampos.Location = new System.Drawing.Point(15, 46);
            this.txtCampos.Name = "Txt_Campos";
            this.txtCampos.Size = new System.Drawing.Size(372, 303);
            this.txtCampos.TabIndex = 0;
            this.txtCampos.Text = "";
            // 
            // Txt_Insert_Campos
            // 
            this.txtInsertCampos.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsertCampos.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtInsertCampos.Location = new System.Drawing.Point(403, 225);
            this.txtInsertCampos.Name = "Txt_Insert_Campos";
            this.txtInsertCampos.ReadOnly = true;
            this.txtInsertCampos.Size = new System.Drawing.Size(818, 124);
            this.txtInsertCampos.TabIndex = 1;
            this.txtInsertCampos.Text = "";
            // 
            // Btn_Gerar
            // 
            this.Btn_Gerar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Gerar.Location = new System.Drawing.Point(381, 684);
            this.Btn_Gerar.Name = "Btn_Gerar";
            this.Btn_Gerar.Size = new System.Drawing.Size(250, 47);
            this.Btn_Gerar.TabIndex = 2;
            this.Btn_Gerar.Text = "Gerar Comandos";
            this.Btn_Gerar.UseVisualStyleBackColor = true;
            this.Btn_Gerar.Click += new System.EventHandler(this.Btn_Gerar_Click);
            // 
            // Txt_Update
            // 
            this.txtUpdate.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdate.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtUpdate.Location = new System.Drawing.Point(403, 524);
            this.txtUpdate.Name = "Txt_Update";
            this.txtUpdate.ReadOnly = true;
            this.txtUpdate.Size = new System.Drawing.Size(818, 141);
            this.txtUpdate.TabIndex = 3;
            this.txtUpdate.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Campos do MySQL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(404, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Insert (Campos)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(404, 506);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Update";
            // 
            // Txt_Parametros
            // 
            this.txtParamentros.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParamentros.ForeColor = System.Drawing.Color.Maroon;
            this.txtParamentros.Location = new System.Drawing.Point(403, 46);
            this.txtParamentros.Name = "Txt_Parametros";
            this.txtParamentros.ReadOnly = true;
            this.txtParamentros.Size = new System.Drawing.Size(818, 150);
            this.txtParamentros.TabIndex = 7;
            this.txtParamentros.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(404, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Parâmetros";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Propriedades";
            // 
            // Txt_Propriedades
            // 
            this.txtPropriedades.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropriedades.ForeColor = System.Drawing.Color.Indigo;
            this.txtPropriedades.Location = new System.Drawing.Point(12, 375);
            this.txtPropriedades.Name = "Txt_Propriedades";
            this.txtPropriedades.ReadOnly = true;
            this.txtPropriedades.Size = new System.Drawing.Size(375, 290);
            this.txtPropriedades.TabIndex = 9;
            this.txtPropriedades.Text = "";
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Limpar.Location = new System.Drawing.Point(637, 684);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(250, 47);
            this.Btn_Limpar.TabIndex = 11;
            this.Btn_Limpar.Text = "Limpar";
            this.Btn_Limpar.UseVisualStyleBackColor = true;
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);
            // 
            // Txt_Insert_Values
            // 
            this.txtInsertValues.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsertValues.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtInsertValues.Location = new System.Drawing.Point(403, 375);
            this.txtInsertValues.Name = "Txt_Insert_Values";
            this.txtInsertValues.ReadOnly = true;
            this.txtInsertValues.Size = new System.Drawing.Size(818, 128);
            this.txtInsertValues.TabIndex = 12;
            this.txtInsertValues.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(404, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Insert (Values)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 743);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtInsertValues);
            this.Controls.Add(this.Btn_Limpar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPropriedades);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtParamentros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUpdate);
            this.Controls.Add(this.Btn_Gerar);
            this.Controls.Add(this.txtInsertCampos);
            this.Controls.Add(this.txtCampos);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MySQL Gerador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtCampos;
        private System.Windows.Forms.RichTextBox txtInsertCampos;
        private System.Windows.Forms.Button Btn_Gerar;
        private System.Windows.Forms.RichTextBox txtUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtParamentros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtPropriedades;
        private System.Windows.Forms.Button Btn_Limpar;
        private System.Windows.Forms.RichTextBox txtInsertValues;
        private System.Windows.Forms.Label label6;
    }
}

