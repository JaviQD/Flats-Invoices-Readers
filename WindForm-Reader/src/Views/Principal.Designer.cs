namespace WindForm_Reader.src.Views
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            menuStrip1 = new MenuStrip();
            MenuAbrir = new ToolStripMenuItem();
            MenuItemRegistrar = new ToolStripMenuItem();
            MenuItemGuardar = new ToolStripMenuItem();
            MenuItemCargar = new ToolStripMenuItem();
            MenuMas = new ToolStripMenuItem();
            MenuItemSalir = new ToolStripMenuItem();
            etiTitulo = new Label();
            DataGridFactura = new DataGridView();
            DataGridFacturas = new DataGridViewTextBoxColumn();
            btnLimpiarPagas = new Button();
            btnLimpiarNoPagas = new Button();
            bntPregunta1 = new Button();
            LabelPreguntas = new Label();
            bntPregunta2 = new Button();
            btnPregunta3 = new Button();
            btnPregunta4 = new Button();
            btnPregunta5 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridFactura).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { MenuAbrir, MenuMas });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(714, 26);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // MenuAbrir
            // 
            MenuAbrir.DropDownItems.AddRange(new ToolStripItem[] { MenuItemRegistrar, MenuItemGuardar, MenuItemCargar });
            MenuAbrir.Font = new Font("Algerian", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            MenuAbrir.Name = "MenuAbrir";
            MenuAbrir.Size = new Size(71, 22);
            MenuAbrir.Text = "Abrir";
            // 
            // MenuItemRegistrar
            // 
            MenuItemRegistrar.Name = "MenuItemRegistrar";
            MenuItemRegistrar.Size = new Size(267, 34);
            MenuItemRegistrar.Text = "Registrar Factura";
            MenuItemRegistrar.Click += toolStripMenuItem2_Click;
            // 
            // MenuItemGuardar
            // 
            MenuItemGuardar.Name = "MenuItemGuardar";
            MenuItemGuardar.Size = new Size(267, 34);
            MenuItemGuardar.Text = "Guardar Facturas";
            MenuItemGuardar.Click += MenuItemGuardar_Click;
            // 
            // MenuItemCargar
            // 
            MenuItemCargar.Name = "MenuItemCargar";
            MenuItemCargar.Size = new Size(267, 34);
            MenuItemCargar.Text = "Cargar Facturas";
            MenuItemCargar.Click += MenuItemCargar_Click;
            // 
            // MenuMas
            // 
            MenuMas.DropDownItems.AddRange(new ToolStripItem[] { MenuItemSalir });
            MenuMas.Font = new Font("Algerian", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            MenuMas.Name = "MenuMas";
            MenuMas.Size = new Size(57, 22);
            MenuMas.Text = "Mas";
            // 
            // MenuItemSalir
            // 
            MenuItemSalir.Name = "MenuItemSalir";
            MenuItemSalir.Size = new Size(151, 34);
            MenuItemSalir.Text = "Salir";
            MenuItemSalir.Click += toolStripMenuItem6_Click;
            // 
            // etiTitulo
            // 
            etiTitulo.AutoSize = true;
            etiTitulo.Font = new Font("Showcard Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            etiTitulo.Location = new Point(12, 50);
            etiTitulo.Name = "etiTitulo";
            etiTitulo.Size = new Size(273, 35);
            etiTitulo.TabIndex = 9;
            etiTitulo.Text = "FACTURAS PLANAS";
            // 
            // DataGridFactura
            // 
            DataGridFactura.AllowUserToOrderColumns = true;
            DataGridFactura.BackgroundColor = SystemColors.ActiveCaption;
            DataGridFactura.BorderStyle = BorderStyle.Fixed3D;
            DataGridFactura.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            DataGridFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridFactura.Columns.AddRange(new DataGridViewColumn[] { DataGridFacturas });
            DataGridFactura.Location = new Point(12, 123);
            DataGridFactura.Name = "DataGridFactura";
            DataGridFactura.RowHeadersWidth = 62;
            DataGridFactura.Size = new Size(499, 388);
            DataGridFactura.TabIndex = 10;
            // 
            // DataGridFacturas
            // 
            dataGridViewCellStyle1.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridFacturas.DefaultCellStyle = dataGridViewCellStyle1;
            DataGridFacturas.HeaderText = "Facturas Planas";
            DataGridFacturas.MinimumWidth = 8;
            DataGridFacturas.Name = "DataGridFacturas";
            DataGridFacturas.ReadOnly = true;
            DataGridFacturas.Width = 300;
            // 
            // btnLimpiarPagas
            // 
            btnLimpiarPagas.Cursor = Cursors.Hand;
            btnLimpiarPagas.Font = new Font("Algerian", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLimpiarPagas.Location = new Point(268, 537);
            btnLimpiarPagas.Name = "btnLimpiarPagas";
            btnLimpiarPagas.Size = new Size(250, 34);
            btnLimpiarPagas.TabIndex = 11;
            btnLimpiarPagas.Text = "Limpiar Facturas Pagas";
            btnLimpiarPagas.UseVisualStyleBackColor = true;
            btnLimpiarPagas.Click += btnLimpiarPagas_Click;
            // 
            // btnLimpiarNoPagas
            // 
            btnLimpiarNoPagas.Cursor = Cursors.Hand;
            btnLimpiarNoPagas.Font = new Font("Algerian", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLimpiarNoPagas.Location = new Point(12, 537);
            btnLimpiarNoPagas.Name = "btnLimpiarNoPagas";
            btnLimpiarNoPagas.Size = new Size(250, 34);
            btnLimpiarNoPagas.TabIndex = 12;
            btnLimpiarNoPagas.Text = "Limpiar Facturas No Pagas";
            btnLimpiarNoPagas.UseVisualStyleBackColor = true;
            btnLimpiarNoPagas.Click += btnLimpiarNoPagas_Click;
            // 
            // bntPregunta1
            // 
            bntPregunta1.Font = new Font("Algerian", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            bntPregunta1.Location = new Point(517, 123);
            bntPregunta1.Name = "bntPregunta1";
            bntPregunta1.Size = new Size(184, 34);
            bntPregunta1.TabIndex = 13;
            bntPregunta1.Text = "Pregunta 1";
            bntPregunta1.UseVisualStyleBackColor = true;
            bntPregunta1.Click += bntPregunta1_Click;
            // 
            // LabelPreguntas
            // 
            LabelPreguntas.AutoSize = true;
            LabelPreguntas.Font = new Font("Showcard Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelPreguntas.Location = new Point(517, 50);
            LabelPreguntas.Name = "LabelPreguntas";
            LabelPreguntas.Size = new Size(184, 35);
            LabelPreguntas.TabIndex = 14;
            LabelPreguntas.Text = "PREGUNTAS";
            // 
            // bntPregunta2
            // 
            bntPregunta2.Font = new Font("Algerian", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            bntPregunta2.Location = new Point(517, 203);
            bntPregunta2.Name = "bntPregunta2";
            bntPregunta2.Size = new Size(184, 34);
            bntPregunta2.TabIndex = 15;
            bntPregunta2.Text = "Pregunta 2";
            bntPregunta2.UseVisualStyleBackColor = true;
            bntPregunta2.Click += bntPregunta2_Click;
            // 
            // btnPregunta3
            // 
            btnPregunta3.Font = new Font("Algerian", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnPregunta3.Location = new Point(517, 291);
            btnPregunta3.Name = "btnPregunta3";
            btnPregunta3.Size = new Size(184, 34);
            btnPregunta3.TabIndex = 16;
            btnPregunta3.Text = "Pregunta 3";
            btnPregunta3.UseVisualStyleBackColor = true;
            btnPregunta3.Click += btnPregunta3_Click;
            // 
            // btnPregunta4
            // 
            btnPregunta4.Font = new Font("Algerian", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnPregunta4.Location = new Point(517, 384);
            btnPregunta4.Name = "btnPregunta4";
            btnPregunta4.Size = new Size(184, 34);
            btnPregunta4.TabIndex = 17;
            btnPregunta4.Text = "Pregunta 4";
            btnPregunta4.UseVisualStyleBackColor = true;
            btnPregunta4.Click += btnPregunta4_Click;
            // 
            // btnPregunta5
            // 
            btnPregunta5.Font = new Font("Algerian", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnPregunta5.Location = new Point(517, 477);
            btnPregunta5.Name = "btnPregunta5";
            btnPregunta5.Size = new Size(184, 34);
            btnPregunta5.TabIndex = 18;
            btnPregunta5.Text = "Pregunta 5";
            btnPregunta5.UseVisualStyleBackColor = true;
            btnPregunta5.Click += btnPregunta5_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 609);
            Controls.Add(btnPregunta5);
            Controls.Add(btnPregunta4);
            Controls.Add(btnPregunta3);
            Controls.Add(bntPregunta2);
            Controls.Add(LabelPreguntas);
            Controls.Add(bntPregunta1);
            Controls.Add(btnLimpiarNoPagas);
            Controls.Add(btnLimpiarPagas);
            Controls.Add(DataGridFactura);
            Controls.Add(etiTitulo);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Principal";
            Text = "Facturas Planas";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridFactura).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public MenuStrip menuStrip1;
        public ToolStripMenuItem MenuAbrir;
        public ToolStripMenuItem MenuItemRegistrar;
        public ToolStripMenuItem MenuMas;
        public ToolStripMenuItem MenuItemGuardar;
        public ToolStripMenuItem MenuItemCargar;
        public ToolStripMenuItem MenuItemSalir;
        public Label etiTitulo;
        public DataGridView DataGridFactura;
        private DataGridViewTextBoxColumn DataGridFacturas;
        private Button btnLimpiarPagas;
        private Button btnLimpiarNoPagas;
        private Button bntPregunta1;
        public Label LabelPreguntas;
        private Button bntPregunta2;
        private Button btnPregunta3;
        private Button btnPregunta4;
        private Button btnPregunta5;
    }
}