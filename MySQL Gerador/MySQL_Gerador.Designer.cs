
namespace MySQL_Gerador
{
    partial class Frm_MySQL_Gerador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MySQL_Gerador));
            this.Txt_Campos = new System.Windows.Forms.RichTextBox();
            this.Txt_Insert_Campos = new System.Windows.Forms.RichTextBox();
            this.Btn_Gerar = new System.Windows.Forms.Button();
            this.Txt_Update = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Parametros = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Propriedades = new System.Windows.Forms.RichTextBox();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.Txt_Insert_Values = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_Campos
            // 
            this.Txt_Campos.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Campos.Location = new System.Drawing.Point(15, 46);
            this.Txt_Campos.Name = "Txt_Campos";
            this.Txt_Campos.Size = new System.Drawing.Size(372, 303);
            this.Txt_Campos.TabIndex = 0;
            this.Txt_Campos.Text = "nome varchar;";
            // 
            // Txt_Insert_Campos
            // 
            this.Txt_Insert_Campos.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Insert_Campos.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Txt_Insert_Campos.Location = new System.Drawing.Point(403, 225);
            this.Txt_Insert_Campos.Name = "Txt_Insert_Campos";
            this.Txt_Insert_Campos.ReadOnly = true;
            this.Txt_Insert_Campos.Size = new System.Drawing.Size(818, 124);
            this.Txt_Insert_Campos.TabIndex = 1;
            this.Txt_Insert_Campos.Text = "";
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
            this.Txt_Update.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Update.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Txt_Update.Location = new System.Drawing.Point(403, 524);
            this.Txt_Update.Name = "Txt_Update";
            this.Txt_Update.ReadOnly = true;
            this.Txt_Update.Size = new System.Drawing.Size(818, 141);
            this.Txt_Update.TabIndex = 3;
            this.Txt_Update.Text = "";
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
            this.Txt_Parametros.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Parametros.ForeColor = System.Drawing.Color.Maroon;
            this.Txt_Parametros.Location = new System.Drawing.Point(403, 46);
            this.Txt_Parametros.Name = "Txt_Parametros";
            this.Txt_Parametros.ReadOnly = true;
            this.Txt_Parametros.Size = new System.Drawing.Size(818, 150);
            this.Txt_Parametros.TabIndex = 7;
            this.Txt_Parametros.Text = "";
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
            this.Txt_Propriedades.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Propriedades.ForeColor = System.Drawing.Color.Indigo;
            this.Txt_Propriedades.Location = new System.Drawing.Point(12, 375);
            this.Txt_Propriedades.Name = "Txt_Propriedades";
            this.Txt_Propriedades.ReadOnly = true;
            this.Txt_Propriedades.Size = new System.Drawing.Size(375, 290);
            this.Txt_Propriedades.TabIndex = 9;
            this.Txt_Propriedades.Text = "";
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
            this.Txt_Insert_Values.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Insert_Values.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Txt_Insert_Values.Location = new System.Drawing.Point(403, 375);
            this.Txt_Insert_Values.Name = "Txt_Insert_Values";
            this.Txt_Insert_Values.ReadOnly = true;
            this.Txt_Insert_Values.Size = new System.Drawing.Size(818, 128);
            this.Txt_Insert_Values.TabIndex = 12;
            this.Txt_Insert_Values.Text = "";
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
            // Frm_MySQL_Gerador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 743);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt_Insert_Values);
            this.Controls.Add(this.Btn_Limpar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_Propriedades);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_Parametros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Update);
            this.Controls.Add(this.Btn_Gerar);
            this.Controls.Add(this.Txt_Insert_Campos);
            this.Controls.Add(this.Txt_Campos);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_MySQL_Gerador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MySQL Gerador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Txt_Campos;
        private System.Windows.Forms.RichTextBox Txt_Insert_Campos;
        private System.Windows.Forms.Button Btn_Gerar;
        private System.Windows.Forms.RichTextBox Txt_Update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox Txt_Parametros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox Txt_Propriedades;
        private System.Windows.Forms.Button Btn_Limpar;
        private System.Windows.Forms.RichTextBox Txt_Insert_Values;
        private System.Windows.Forms.Label label6;
    }
}

