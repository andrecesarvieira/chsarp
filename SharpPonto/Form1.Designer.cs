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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { gridData, gridEntrada, gridAlmoco, gridRetorno, gridSaida, gridManha, gridTarde, gridTotal });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 11.25F);
            dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = SystemColors.ButtonShadow;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 80;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle13;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(868, 397);
            dataGridView1.TabIndex = 9;
            dataGridView1.TabStop = false;
            // 
            // gridData
            // 
            gridData.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            gridData.DataPropertyName = "Data";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11.25F);
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            gridData.DefaultCellStyle = dataGridViewCellStyle3;
            gridData.FillWeight = 40.60913F;
            gridData.Frozen = true;
            gridData.HeaderText = "Data";
            gridData.MaxInputLength = 10;
            gridData.MinimumWidth = 104;
            gridData.Name = "gridData";
            gridData.ReadOnly = true;
            gridData.SortMode = DataGridViewColumnSortMode.NotSortable;
            gridData.Width = 104;
            // 
            // gridEntrada
            // 
            gridEntrada.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            gridEntrada.DataPropertyName = "Entrada";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11.25F);
            dataGridViewCellStyle4.Format = "t";
            dataGridViewCellStyle4.NullValue = null;
            gridEntrada.DefaultCellStyle = dataGridViewCellStyle4;
            gridEntrada.FillWeight = 183.871628F;
            gridEntrada.Frozen = true;
            gridEntrada.HeaderText = "Entrada";
            gridEntrada.MaxInputLength = 5;
            gridEntrada.MinimumWidth = 102;
            gridEntrada.Name = "gridEntrada";
            gridEntrada.ReadOnly = true;
            gridEntrada.SortMode = DataGridViewColumnSortMode.NotSortable;
            gridEntrada.Width = 102;
            // 
            // gridAlmoco
            // 
            gridAlmoco.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            gridAlmoco.DataPropertyName = "Almoco";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11.25F);
            dataGridViewCellStyle5.Format = "t";
            dataGridViewCellStyle5.NullValue = null;
            gridAlmoco.DefaultCellStyle = dataGridViewCellStyle5;
            gridAlmoco.FillWeight = 159.814377F;
            gridAlmoco.Frozen = true;
            gridAlmoco.HeaderText = "Almoço";
            gridAlmoco.MaxInputLength = 5;
            gridAlmoco.MinimumWidth = 102;
            gridAlmoco.Name = "gridAlmoco";
            gridAlmoco.ReadOnly = true;
            gridAlmoco.SortMode = DataGridViewColumnSortMode.NotSortable;
            gridAlmoco.Width = 102;
            // 
            // gridRetorno
            // 
            gridRetorno.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            gridRetorno.DataPropertyName = "Retorno";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11.25F);
            dataGridViewCellStyle6.Format = "t";
            dataGridViewCellStyle6.NullValue = null;
            gridRetorno.DefaultCellStyle = dataGridViewCellStyle6;
            gridRetorno.FillWeight = 11.7430735F;
            gridRetorno.Frozen = true;
            gridRetorno.HeaderText = "Retorno";
            gridRetorno.MaxInputLength = 5;
            gridRetorno.MinimumWidth = 102;
            gridRetorno.Name = "gridRetorno";
            gridRetorno.ReadOnly = true;
            gridRetorno.SortMode = DataGridViewColumnSortMode.NotSortable;
            gridRetorno.Width = 102;
            // 
            // gridSaida
            // 
            gridSaida.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            gridSaida.DataPropertyName = "Saida";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 11.25F);
            dataGridViewCellStyle7.Format = "t";
            dataGridViewCellStyle7.NullValue = null;
            gridSaida.DefaultCellStyle = dataGridViewCellStyle7;
            gridSaida.FillWeight = 158.092163F;
            gridSaida.Frozen = true;
            gridSaida.HeaderText = "Saída";
            gridSaida.MaxInputLength = 5;
            gridSaida.MinimumWidth = 102;
            gridSaida.Name = "gridSaida";
            gridSaida.ReadOnly = true;
            gridSaida.SortMode = DataGridViewColumnSortMode.NotSortable;
            gridSaida.Width = 102;
            // 
            // gridManha
            // 
            gridManha.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            gridManha.DataPropertyName = "Manha";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 11.25F);
            dataGridViewCellStyle8.Format = "t";
            dataGridViewCellStyle8.NullValue = null;
            gridManha.DefaultCellStyle = dataGridViewCellStyle8;
            gridManha.FillWeight = 120.6781F;
            gridManha.Frozen = true;
            gridManha.HeaderText = "Manhã";
            gridManha.MaxInputLength = 5;
            gridManha.MinimumWidth = 102;
            gridManha.Name = "gridManha";
            gridManha.ReadOnly = true;
            gridManha.SortMode = DataGridViewColumnSortMode.NotSortable;
            gridManha.Width = 102;
            // 
            // gridTarde
            // 
            gridTarde.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            gridTarde.DataPropertyName = "Tarde";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 11.25F);
            dataGridViewCellStyle9.Format = "t";
            dataGridViewCellStyle9.NullValue = null;
            gridTarde.DefaultCellStyle = dataGridViewCellStyle9;
            gridTarde.FillWeight = 3.86393428F;
            gridTarde.Frozen = true;
            gridTarde.HeaderText = "Tarde";
            gridTarde.MaxInputLength = 5;
            gridTarde.MinimumWidth = 102;
            gridTarde.Name = "gridTarde";
            gridTarde.ReadOnly = true;
            gridTarde.SortMode = DataGridViewColumnSortMode.NotSortable;
            gridTarde.Width = 102;
            // 
            // gridTotal
            // 
            gridTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridTotal.DataPropertyName = "TotalDia";
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 11.25F);
            dataGridViewCellStyle10.Format = "t";
            dataGridViewCellStyle10.NullValue = null;
            gridTotal.DefaultCellStyle = dataGridViewCellStyle10;
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
