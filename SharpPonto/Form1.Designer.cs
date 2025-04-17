namespace SharpPonto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnRegistrar = new Button();
            btnExportar = new Button();
            btnExcluir = new Button();
            textData = new MaskedTextBox();
            textEntrada = new MaskedTextBox();
            textAlmoco = new MaskedTextBox();
            textRetorno = new MaskedTextBox();
            textSaida = new MaskedTextBox();
            btnInserir = new Button();
            lblPath = new Label();
            dataGridView1 = new DataGridView();
            gridData = new DataGridViewTextBoxColumn();
            gridEntrada = new DataGridViewTextBoxColumn();
            gridAlmoco = new DataGridViewTextBoxColumn();
            gridRetorno = new DataGridViewTextBoxColumn();
            gridSaida = new DataGridViewTextBoxColumn();
            gridManha = new DataGridViewTextBoxColumn();
            gridTarde = new DataGridViewTextBoxColumn();
            gridTotal = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnRegistrar.Location = new Point(12, 421);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(278, 62);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.TabStop = false;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += BtnRegistrar_Click;
            // 
            // btnExportar
            // 
            btnExportar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnExportar.Location = new Point(308, 421);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(278, 62);
            btnExportar.TabIndex = 7;
            btnExportar.TabStop = false;
            btnExportar.Text = "Exportar CSV";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += BtnExportar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnExcluir.Location = new Point(602, 421);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(278, 62);
            btnExcluir.TabIndex = 8;
            btnExcluir.TabStop = false;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += BtnExcluir_Click;
            // 
            // textData
            // 
            textData.Font = new Font("Segoe UI", 12F);
            textData.Location = new Point(12, 500);
            textData.Mask = "00/00/0000";
            textData.Name = "textData";
            textData.Size = new Size(136, 29);
            textData.TabIndex = 0;
            textData.TextAlign = HorizontalAlignment.Center;
            textData.ValidatingType = typeof(DateTime);
            // 
            // textEntrada
            // 
            textEntrada.Font = new Font("Segoe UI", 12F);
            textEntrada.Location = new Point(154, 500);
            textEntrada.Mask = "00:00";
            textEntrada.Name = "textEntrada";
            textEntrada.ResetOnPrompt = false;
            textEntrada.ResetOnSpace = false;
            textEntrada.Size = new Size(136, 29);
            textEntrada.TabIndex = 1;
            textEntrada.TextAlign = HorizontalAlignment.Center;
            textEntrada.ValidatingType = typeof(DateTime);
            // 
            // textAlmoco
            // 
            textAlmoco.Font = new Font("Segoe UI", 12F);
            textAlmoco.Location = new Point(296, 500);
            textAlmoco.Mask = "00:00";
            textAlmoco.Name = "textAlmoco";
            textAlmoco.ResetOnPrompt = false;
            textAlmoco.ResetOnSpace = false;
            textAlmoco.Size = new Size(136, 29);
            textAlmoco.TabIndex = 2;
            textAlmoco.TextAlign = HorizontalAlignment.Center;
            textAlmoco.ValidatingType = typeof(DateTime);
            // 
            // textRetorno
            // 
            textRetorno.Font = new Font("Segoe UI", 12F);
            textRetorno.Location = new Point(438, 500);
            textRetorno.Mask = "00:00";
            textRetorno.Name = "textRetorno";
            textRetorno.ResetOnPrompt = false;
            textRetorno.ResetOnSpace = false;
            textRetorno.Size = new Size(136, 29);
            textRetorno.TabIndex = 3;
            textRetorno.TextAlign = HorizontalAlignment.Center;
            textRetorno.ValidatingType = typeof(DateTime);
            // 
            // textSaida
            // 
            textSaida.Font = new Font("Segoe UI", 12F);
            textSaida.Location = new Point(580, 500);
            textSaida.Mask = "00:00";
            textSaida.Name = "textSaida";
            textSaida.ResetOnPrompt = false;
            textSaida.ResetOnSpace = false;
            textSaida.Size = new Size(136, 29);
            textSaida.TabIndex = 4;
            textSaida.TextAlign = HorizontalAlignment.Center;
            textSaida.ValidatingType = typeof(DateTime);
            // 
            // btnInserir
            // 
            btnInserir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnInserir.Location = new Point(722, 491);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(158, 44);
            btnInserir.TabIndex = 5;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += BtnInserir_Click;
            // 
            // lblPath
            // 
            lblPath.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPath.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPath.Location = new Point(12, 544);
            lblPath.Name = "lblPath";
            lblPath.Size = new Size(868, 20);
            lblPath.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle14;
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.SelectionForeColor = Color.Black;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.False;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { gridData, gridEntrada, gridAlmoco, gridRetorno, gridSaida, gridManha, gridTarde, gridTotal });
            dataGridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = SystemColors.Window;
            dataGridViewCellStyle24.Font = new Font("Segoe UI", 11.25F);
            dataGridViewCellStyle24.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle24.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle24;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = SystemColors.ButtonShadow;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle25.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = SystemColors.Control;
            dataGridViewCellStyle25.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle25.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle25;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 80;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle26.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle26;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(868, 397);
            dataGridView1.TabIndex = 9;
            dataGridView1.TabStop = false;
            // 
            // gridData
            // 
            gridData.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            gridData.DataPropertyName = "Data";
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle16.Font = new Font("Segoe UI", 11.25F);
            dataGridViewCellStyle16.Format = "d";
            dataGridViewCellStyle16.NullValue = null;
            gridData.DefaultCellStyle = dataGridViewCellStyle16;
            gridData.FillWeight = 40.60913F;
            gridData.Frozen = true;
            gridData.HeaderText = "Data";
            gridData.MaxInputLength = 10;
            gridData.MinimumWidth = 105;
            gridData.Name = "gridData";
            gridData.ReadOnly = true;
            gridData.SortMode = DataGridViewColumnSortMode.NotSortable;
            gridData.Width = 105;
            // 
            // gridEntrada
            // 
            gridEntrada.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            gridEntrada.DataPropertyName = "Entrada";
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle17.Font = new Font("Segoe UI", 11.25F);
            dataGridViewCellStyle17.Format = "t";
            dataGridViewCellStyle17.NullValue = null;
            gridEntrada.DefaultCellStyle = dataGridViewCellStyle17;
            gridEntrada.FillWeight = 183.871628F;
            gridEntrada.Frozen = true;
            gridEntrada.HeaderText = "Entrada";
            gridEntrada.MaxInputLength = 5;
            gridEntrada.MinimumWidth = 105;
            gridEntrada.Name = "gridEntrada";
            gridEntrada.ReadOnly = true;
            gridEntrada.SortMode = DataGridViewColumnSortMode.NotSortable;
            gridEntrada.Width = 105;
            // 
            // gridAlmoco
            // 
            gridAlmoco.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            gridAlmoco.DataPropertyName = "Almoco";
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle18.Font = new Font("Segoe UI", 11.25F);
            dataGridViewCellStyle18.Format = "t";
            dataGridViewCellStyle18.NullValue = null;
            gridAlmoco.DefaultCellStyle = dataGridViewCellStyle18;
            gridAlmoco.FillWeight = 159.814377F;
            gridAlmoco.Frozen = true;
            gridAlmoco.HeaderText = "Almoço";
            gridAlmoco.MaxInputLength = 5;
            gridAlmoco.MinimumWidth = 105;
            gridAlmoco.Name = "gridAlmoco";
            gridAlmoco.ReadOnly = true;
            gridAlmoco.SortMode = DataGridViewColumnSortMode.NotSortable;
            gridAlmoco.Width = 105;
            // 
            // gridRetorno
            // 
            gridRetorno.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            gridRetorno.DataPropertyName = "Retorno";
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle19.Font = new Font("Segoe UI", 11.25F);
            dataGridViewCellStyle19.Format = "t";
            dataGridViewCellStyle19.NullValue = null;
            gridRetorno.DefaultCellStyle = dataGridViewCellStyle19;
            gridRetorno.FillWeight = 11.7430735F;
            gridRetorno.Frozen = true;
            gridRetorno.HeaderText = "Retorno";
            gridRetorno.MaxInputLength = 5;
            gridRetorno.MinimumWidth = 105;
            gridRetorno.Name = "gridRetorno";
            gridRetorno.ReadOnly = true;
            gridRetorno.SortMode = DataGridViewColumnSortMode.NotSortable;
            gridRetorno.Width = 105;
            // 
            // gridSaida
            // 
            gridSaida.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            gridSaida.DataPropertyName = "Saida";
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle20.Font = new Font("Segoe UI", 11.25F);
            dataGridViewCellStyle20.Format = "t";
            dataGridViewCellStyle20.NullValue = null;
            gridSaida.DefaultCellStyle = dataGridViewCellStyle20;
            gridSaida.FillWeight = 158.092163F;
            gridSaida.Frozen = true;
            gridSaida.HeaderText = "Saída";
            gridSaida.MaxInputLength = 5;
            gridSaida.MinimumWidth = 105;
            gridSaida.Name = "gridSaida";
            gridSaida.ReadOnly = true;
            gridSaida.SortMode = DataGridViewColumnSortMode.NotSortable;
            gridSaida.Width = 105;
            // 
            // gridManha
            // 
            gridManha.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            gridManha.DataPropertyName = "Manha";
            dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle21.Font = new Font("Segoe UI", 11.25F);
            dataGridViewCellStyle21.Format = "t";
            dataGridViewCellStyle21.NullValue = null;
            gridManha.DefaultCellStyle = dataGridViewCellStyle21;
            gridManha.FillWeight = 120.6781F;
            gridManha.Frozen = true;
            gridManha.HeaderText = "Manhã";
            gridManha.MaxInputLength = 5;
            gridManha.MinimumWidth = 105;
            gridManha.Name = "gridManha";
            gridManha.ReadOnly = true;
            gridManha.SortMode = DataGridViewColumnSortMode.NotSortable;
            gridManha.Width = 105;
            // 
            // gridTarde
            // 
            gridTarde.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            gridTarde.DataPropertyName = "Tarde";
            dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle22.Font = new Font("Segoe UI", 11.25F);
            dataGridViewCellStyle22.Format = "t";
            dataGridViewCellStyle22.NullValue = null;
            gridTarde.DefaultCellStyle = dataGridViewCellStyle22;
            gridTarde.FillWeight = 3.86393428F;
            gridTarde.Frozen = true;
            gridTarde.HeaderText = "Tarde";
            gridTarde.MaxInputLength = 5;
            gridTarde.MinimumWidth = 105;
            gridTarde.Name = "gridTarde";
            gridTarde.ReadOnly = true;
            gridTarde.SortMode = DataGridViewColumnSortMode.NotSortable;
            gridTarde.Width = 105;
            // 
            // gridTotal
            // 
            gridTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridTotal.DataPropertyName = "TotalDia";
            dataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle23.Font = new Font("Segoe UI", 11.25F);
            dataGridViewCellStyle23.Format = "t";
            dataGridViewCellStyle23.NullValue = null;
            gridTotal.DefaultCellStyle = dataGridViewCellStyle23;
            gridTotal.FillWeight = 121.327545F;
            gridTotal.HeaderText = "Total de Horas";
            gridTotal.MaxInputLength = 5;
            gridTotal.MinimumWidth = 130;
            gridTotal.Name = "gridTotal";
            gridTotal.ReadOnly = true;
            gridTotal.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 569);
            Controls.Add(lblPath);
            Controls.Add(btnInserir);
            Controls.Add(textSaida);
            Controls.Add(textRetorno);
            Controls.Add(textAlmoco);
            Controls.Add(textEntrada);
            Controls.Add(textData);
            Controls.Add(btnExcluir);
            Controls.Add(btnExportar);
            Controls.Add(btnRegistrar);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SharpPonto";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnRegistrar;
        private Button btnExportar;
        private Button btnExcluir;
        private MaskedTextBox textData;
        private MaskedTextBox textEntrada;
        private MaskedTextBox textAlmoco;
        private MaskedTextBox textRetorno;
        private MaskedTextBox textSaida;
        private Button btnInserir;
        private Label lblPath;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn gridData;
        private DataGridViewTextBoxColumn gridEntrada;
        private DataGridViewTextBoxColumn gridAlmoco;
        private DataGridViewTextBoxColumn gridRetorno;
        private DataGridViewTextBoxColumn gridSaida;
        private DataGridViewTextBoxColumn gridManha;
        private DataGridViewTextBoxColumn gridTarde;
        private DataGridViewTextBoxColumn gridTotal;
    }
}
