using WindForm_Reader.src.Services;
using WindForm_Reader.src.Views;

namespace WindForm_Reader
{
    public partial class RegistrarFactura : Form
    {
        private string FlatInvoice = string.Empty;
        private Principal _Principal;
        Return _return = new Return();
        private enum EstadoCheck { SI, NO }

        public RegistrarFactura(Principal principal)
        {
            InitializeComponent();
            CenterToScreen();
            _Principal = principal;
        }

        private void btnRegistarFactura_Click(object sender, EventArgs e)
        {

            if (AlreadyExist_NumeroFactura(textNumero.Text))
            {
                MessageBox.Show($"La factura '{textNumero.Text}' ya fue registrada previamente",
                                "Duplicado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                return;
            }

            if (Is_All_OK(sender, e))
            {
                MessageBox.Show($"Registro exitoso, Factura -> {FlatInvoice}",
                                "Agregada",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);

                _Principal.AgregarToDataGrid(FlatInvoice);

                var Pregunta = MessageBox.Show("¿Deseas registrar otra factura?", 
                                               "Confirmar", 
                                               MessageBoxButtons.YesNo, 
                                               MessageBoxIcon.Question);
                if (Pregunta is DialogResult.Yes)
                {
                    CleanAll();
                    FlatInvoice = string.Empty;
                }
                else this.Dispose();
            }
            else FlatInvoice = string.Empty;
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

            if (_return.TotalCuadrado(
                                        int.Parse(textTotalConImpuestos.Text),
                                        int.Parse(textImpuestos.Text),
                                        int.Parse(textMontoTotal.Text)))
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
                if (_return.Exist_Mes(ComboMes.SelectedItem.ToString()))
                {
                    FlatInvoice += $"{ComboMes.SelectedItem.ToString()};";
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

        private bool AlreadyExist_NumeroFactura(string NumeroFactura)
        {
            foreach (DataGridViewRow row in _Principal.DataGridFactura.Rows)
            {
                if (!row.IsNewRow)
                {
                    // Obtener la fila completa como un string
                    string factura = string.Join(";", row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value?.ToString() ?? ""));

                    string[] position = factura.Split(';');

                    if (_return.SetPosition(position))
                    {
                        if (_return._Modelo.NumeroFactura.Equals(NumeroFactura))
                        {
                            return true;
                        }
                    }
                }
            }

            return false;       
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
