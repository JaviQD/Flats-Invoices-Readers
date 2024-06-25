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
            menuStrip1.Size = new Size(714, 32);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // MenuAbrir
            // 
            MenuAbrir.DropDownItems.AddRange(new ToolStripItem[] { MenuItemRegistrar, MenuItemGuardar, MenuItemCargar });
            MenuAbrir.Font = new Font("Algerian", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            MenuAbrir.Name = "MenuAbrir";
            MenuAbrir.Size = new Size(71, 28);
            MenuAbrir.Text = "Abrir";
            // 
            // MenuItemRegistrar
            // 
            MenuItemRegistrar.Name = "MenuItemRegistrar";
            MenuItemRegistrar.Size = new Size(270, 34);
            MenuItemRegistrar.Text = "Registrar Factura";
            MenuItemRegistrar.Click += toolStripMenuItem2_Click;
            // 
            // MenuItemGuardar
            // 
            MenuItemGuardar.Name = "MenuItemGuardar";
            MenuItemGuardar.Size = new Size(270, 34);
            MenuItemGuardar.Text = "Guardar Facturas";
            MenuItemGuardar.Click += MenuItemGuardar_Click;
            // 
            // MenuItemCargar
            // 
            MenuItemCargar.Name = "MenuItemCargar";
            MenuItemCargar.Size = new Size(270, 34);
            MenuItemCargar.Text = "Cargar Facturas";
            MenuItemCargar.Click += MenuItemCargar_Click;
            // 
            // MenuMas
            // 
            MenuMas.DropDownItems.AddRange(new ToolStripItem[] { MenuItemSalir });
            MenuMas.Font = new Font("Algerian", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            MenuMas.Name = "MenuMas";
            MenuMas.Size = new Size(57, 28);
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
            etiTitulo.Location = new Point(71, 50);
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
            DataGridFactura.Location = new Point(38, 123);
            DataGridFactura.Name = "DataGridFactura";
            DataGridFactura.RowHeadersWidth = 62;
            DataGridFactura.Size = new Size(363, 449);
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
            btnLimpiarPagas.Location = new Point(421, 538);
            btnLimpiarPagas.Name = "btnLimpiarPagas";
            btnLimpiarPagas.Size = new Size(281, 34);
            btnLimpiarPagas.TabIndex = 11;
            btnLimpiarPagas.Text = "Limpiar Facturas Pagas";
            btnLimpiarPagas.UseVisualStyleBackColor = true;
            btnLimpiarPagas.Click += btnLimpiarPagas_Click;
            // 
            // btnLimpiarNoPagas
            // 
            btnLimpiarNoPagas.Cursor = Cursors.Hand;
            btnLimpiarNoPagas.Font = new Font("Algerian", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLimpiarNoPagas.Location = new Point(421, 464);
            btnLimpiarNoPagas.Name = "btnLimpiarNoPagas";
            btnLimpiarNoPagas.Size = new Size(281, 34);
            btnLimpiarNoPagas.TabIndex = 12;
            btnLimpiarNoPagas.Text = "Limpiar Facturas No Pagas";
            btnLimpiarNoPagas.UseVisualStyleBackColor = true;
            btnLimpiarNoPagas.Click += btnLimpiarNoPagas_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 609);
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
    }
}