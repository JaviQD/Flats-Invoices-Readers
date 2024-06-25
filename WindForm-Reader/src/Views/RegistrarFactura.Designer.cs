namespace WindForm_Reader
{
    partial class RegistrarFactura
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
            btnRegistarFactura = new Button();
            etiNumero = new Label();
            etiMontoTotal = new Label();
            etiImpuestos = new Label();
            etiTotalConImpuestos = new Label();
            ComboMes = new ComboBox();
            CheckPagado = new CheckBox();
            etiMes = new Label();
            etiTitulo = new Label();
            textNumero = new TextBox();
            textMontoTotal = new TextBox();
            textImpuestos = new TextBox();
            textTotalConImpuestos = new TextBox();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // btnRegistarFactura
            // 
            btnRegistarFactura.Cursor = Cursors.Hand;
            btnRegistarFactura.Font = new Font("Algerian", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRegistarFactura.Location = new Point(152, 513);
            btnRegistarFactura.Name = "btnRegistarFactura";
            btnRegistarFactura.Size = new Size(253, 34);
            btnRegistarFactura.TabIndex = 0;
            btnRegistarFactura.Text = "Registrar Factura";
            btnRegistarFactura.UseVisualStyleBackColor = true;
            btnRegistarFactura.Click += btnRegistarFactura_Click;
            // 
            // etiNumero
            // 
            etiNumero.AutoSize = true;
            etiNumero.Font = new Font("Algerian", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            etiNumero.Location = new Point(52, 137);
            etiNumero.Name = "etiNumero";
            etiNumero.Size = new Size(241, 22);
            etiNumero.TabIndex = 1;
            etiNumero.Text = "Numero de la factura";
            // 
            // etiMontoTotal
            // 
            etiMontoTotal.AutoSize = true;
            etiMontoTotal.Font = new Font("Algerian", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            etiMontoTotal.Location = new Point(52, 198);
            etiMontoTotal.Name = "etiMontoTotal";
            etiMontoTotal.Size = new Size(140, 22);
            etiMontoTotal.TabIndex = 2;
            etiMontoTotal.Text = "Monto Total";
            // 
            // etiImpuestos
            // 
            etiImpuestos.AutoSize = true;
            etiImpuestos.Font = new Font("Algerian", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            etiImpuestos.Location = new Point(52, 262);
            etiImpuestos.Name = "etiImpuestos";
            etiImpuestos.Size = new Size(113, 22);
            etiImpuestos.TabIndex = 3;
            etiImpuestos.Text = "Impuestos";
            // 
            // etiTotalConImpuestos
            // 
            etiTotalConImpuestos.AutoSize = true;
            etiTotalConImpuestos.Font = new Font("Algerian", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            etiTotalConImpuestos.Location = new Point(52, 331);
            etiTotalConImpuestos.Name = "etiTotalConImpuestos";
            etiTotalConImpuestos.Size = new Size(221, 22);
            etiTotalConImpuestos.TabIndex = 4;
            etiTotalConImpuestos.Text = "Total con Impuestos";
            // 
            // ComboMes
            // 
            ComboMes.BackColor = SystemColors.GradientInactiveCaption;
            ComboMes.FormattingEnabled = true;
            ComboMes.Items.AddRange(new object[] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" });
            ComboMes.Location = new Point(334, 392);
            ComboMes.Name = "ComboMes";
            ComboMes.Size = new Size(144, 33);
            ComboMes.TabIndex = 5;
            // 
            // CheckPagado
            // 
            CheckPagado.AutoSize = true;
            CheckPagado.Font = new Font("Algerian", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            CheckPagado.Location = new Point(52, 463);
            CheckPagado.Name = "CheckPagado";
            CheckPagado.Size = new Size(214, 26);
            CheckPagado.TabIndex = 6;
            CheckPagado.Text = "Factura Pagada";
            CheckPagado.UseVisualStyleBackColor = true;
            // 
            // etiMes
            // 
            etiMes.AutoSize = true;
            etiMes.Font = new Font("Algerian", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            etiMes.Location = new Point(52, 403);
            etiMes.Name = "etiMes";
            etiMes.Size = new Size(48, 22);
            etiMes.TabIndex = 7;
            etiMes.Text = "Mes";
            // 
            // etiTitulo
            // 
            etiTitulo.AutoSize = true;
            etiTitulo.Font = new Font("Showcard Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            etiTitulo.Location = new Point(52, 29);
            etiTitulo.Name = "etiTitulo";
            etiTitulo.Size = new Size(415, 35);
            etiTitulo.TabIndex = 8;
            etiTitulo.Text = "REGISTRADOR DE FACTURAS";
            // 
            // textNumero
            // 
            textNumero.BackColor = SystemColors.GradientInactiveCaption;
            textNumero.BorderStyle = BorderStyle.FixedSingle;
            textNumero.Location = new Point(334, 132);
            textNumero.Name = "textNumero";
            textNumero.Size = new Size(133, 31);
            textNumero.TabIndex = 9;
            // 
            // textMontoTotal
            // 
            textMontoTotal.BackColor = SystemColors.GradientInactiveCaption;
            textMontoTotal.BorderStyle = BorderStyle.FixedSingle;
            textMontoTotal.Location = new Point(334, 189);
            textMontoTotal.Name = "textMontoTotal";
            textMontoTotal.Size = new Size(133, 31);
            textMontoTotal.TabIndex = 10;
            // 
            // textImpuestos
            // 
            textImpuestos.BackColor = SystemColors.GradientInactiveCaption;
            textImpuestos.BorderStyle = BorderStyle.FixedSingle;
            textImpuestos.Location = new Point(334, 253);
            textImpuestos.Name = "textImpuestos";
            textImpuestos.Size = new Size(133, 31);
            textImpuestos.TabIndex = 11;
            // 
            // textTotalConImpuestos
            // 
            textTotalConImpuestos.BackColor = SystemColors.GradientInactiveCaption;
            textTotalConImpuestos.BorderStyle = BorderStyle.FixedSingle;
            textTotalConImpuestos.Location = new Point(334, 331);
            textTotalConImpuestos.Name = "textTotalConImpuestos";
            textTotalConImpuestos.Size = new Size(133, 31);
            textTotalConImpuestos.TabIndex = 12;
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Font = new Font("Algerian", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(152, 567);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(253, 34);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "CANCELAR REGISTRO";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // RegistrarFactura
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 632);
            Controls.Add(btnCancelar);
            Controls.Add(textTotalConImpuestos);
            Controls.Add(textImpuestos);
            Controls.Add(textMontoTotal);
            Controls.Add(textNumero);
            Controls.Add(etiTitulo);
            Controls.Add(etiMes);
            Controls.Add(CheckPagado);
            Controls.Add(ComboMes);
            Controls.Add(etiTotalConImpuestos);
            Controls.Add(etiImpuestos);
            Controls.Add(etiMontoTotal);
            Controls.Add(etiNumero);
            Controls.Add(btnRegistarFactura);
            Name = "RegistrarFactura";
            Text = "Registrador";
            ResumeLayout(false);
            PerformLayout();
        }

        public Button btnRegistarFactura;
        public Label etiNumero;
        public Label etiMontoTotal;
        public Label etiImpuestos;
        public Label etiTotalConImpuestos;
        public ComboBox ComboMes;
        public CheckBox CheckPagado;
        public Label etiMes;
        public Label etiTitulo;
        public TextBox textNumero;
        public TextBox textMontoTotal;
        public TextBox textImpuestos;
        public TextBox textTotalConImpuestos;
        public Button btnCancelar;

        #endregion
    }
}
