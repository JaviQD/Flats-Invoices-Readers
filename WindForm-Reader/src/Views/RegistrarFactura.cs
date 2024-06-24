using WindForm_Reader.src.Services;

namespace WindForm_Reader
{
    public partial class RegistrarFactura : Form
    {
        private string FlatInvoice = string.Empty;
        private enum EstadoCheck { SI, NO }

        public RegistrarFactura()
        {
            InitializeComponent();
        }

        private void btnRegistarFactura_Click(object sender, EventArgs e)
        {
            if (Is_All_OK(sender, e))
            {
                MessageBox.Show($"Registro exitoso, Factura -> {FlatInvoice}",
                                "Exitoso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);

                CleanAll();
                FlatInvoice = string.Empty;

            }
            else
            {
                MessageBox.Show($"Revisa que la informaciond de la factura este bien redactada",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                FlatInvoice = string.Empty;
            }
        }

        private bool Is_All_OK(object sender, EventArgs e)
        {
            #region Numerofactura

            if (!string.IsNullOrEmpty(textNumero.Text) && textNumero.Text.Length >= 4)
            {
                FlatInvoice += $"{textNumero.Text.ToUpper()};";
            }
            else
            {
                MessageBox.Show("El numero de la factura no puede ser null y debe contener al menos 4 caracteres",
                                "Información",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                FlatInvoice = string.Empty;
                return false;
            }

            #endregion

            #region MontoTotal

            if (!string.IsNullOrEmpty(textMontoTotal.Text) && int.Parse(textMontoTotal.Text) >= 0)
            {
                FlatInvoice += $"{textMontoTotal.Text};";
            }
            else
            {
                MessageBox.Show("El monto total debe ser un valor entero y mayor a 0",
                                "Información",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                FlatInvoice = string.Empty;
                return false;
            }

            #endregion

            #region Impuestos

            if (!string.IsNullOrEmpty(textImpuestos.Text) && int.Parse(textImpuestos.Text) >= 0)
            {
                FlatInvoice += $"{textImpuestos.Text};";
            }
            else
            {
                MessageBox.Show("El Impuesto debe ser un valor entero y mayor a 0",
                                "Información",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                FlatInvoice = string.Empty;
                return false;
            }

            #endregion

            #region TotalConImpuesto

            int TotalConImpuesto = int.Parse(textTotalConImpuestos.Text);
            int Impuestos = int.Parse(textImpuestos.Text);
            int MontoTotal = int.Parse(textMontoTotal.Text);

            if (TotalConImpuesto == (Impuestos + MontoTotal))
            {
                FlatInvoice += $"{textTotalConImpuestos.Text};";
            }
            else
            {
                MessageBox.Show("El total con impuestos no es igual a la suma de impuestos y el monto total.",
                                "Información",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                FlatInvoice = string.Empty;
                return false;
            }

            #endregion

            #region Mes

            if (ComboMes.SelectedIndex != -1)
            {
                string MesSeleccionado = ComboMes.SelectedItem.ToString();

                if (Enum.TryParse(MesSeleccionado, out Return.PrimerSemestre primer) ||
                    Enum.TryParse(MesSeleccionado, out Return.SegundoSemestre segundo))
                {
                    FlatInvoice += $"{MesSeleccionado};";
                }
            }
            else
            {
                MessageBox.Show("Selecciona un mes valido para registar la factura",
                                "Información",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                FlatInvoice = string.Empty;
                return false;
            }

            #endregion

            #region Pagado

            EstadoCheck Pagado = CheckPagado.Checked ? EstadoCheck.SI : EstadoCheck.NO;
            FlatInvoice += Pagado == EstadoCheck.SI ? "SI" : "NO";

            #endregion

            return true;
        }

        private void CleanAll()
        {
            // Limpiar todos los TextBox
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }

            // Limpiar el ComboBox
            ComboMes.SelectedIndex = -1;

            // Limpiar el CheckBox
            CheckPagado.Checked = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
