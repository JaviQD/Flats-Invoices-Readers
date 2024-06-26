using System.Data;
using WindForm_Reader.src.Services;

namespace WindForm_Reader.src.Views
{
    public partial class Principal : Form
    {
        Return _return = new Return();

        public bool CargueOK { get; set; } = false;

        public Principal()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e) => this.Dispose();

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var Registrar = new RegistrarFactura(this);
            Registrar.ShowDialog();
        }

        private void MenuItemGuardar_Click(object sender, EventArgs e)
        {
            if (DataGridFactura.Rows.Count is 1 &&
                 DataGridFactura.Rows[0].IsNewRow)
            {
                MessageBox.Show("No hay facturas para GUARDAR",
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            SaveFileDialog _SaveFile = new SaveFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
                Title = "Guardar Facturas"
            };

            if (_SaveFile.ShowDialog() is DialogResult.OK)
            {
                try
                {
                    using (StreamWriter _writer = new StreamWriter(_SaveFile.FileName))
                    {
                        foreach (DataGridViewRow row in DataGridFactura.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                string factura = string.Join(";", row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value?.ToString() ?? ""));
                                _writer.WriteLine(factura);
                            }
                        }
                    }

                    MessageBox.Show("Facturas guardadas exitosamente.",
                                   "Éxito",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al guardar las facturas: {ex.Message}",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    throw;
                }
            }
        }

        public void AgregarToDataGrid(string FacturaPlana)
        {
            DataGridFactura.Rows.Add(FacturaPlana);
            DataGridFactura.Refresh();
        }

        private void btnLimpiarNoPagas_Click(object sender, EventArgs e)
        {
            if (DataGridFactura.Rows.Count is 1 &&
                DataGridFactura.Rows[0].IsNewRow)
            {
                MessageBox.Show("No hay facturas NO PAGAS para limpiar.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            var filas_A_Eliminar = new List<DataGridViewRow>();

            foreach (DataGridViewRow row in DataGridFactura.Rows)
            {
                if (!row.IsNewRow)
                {
                    // Obtener la fila completa como un string
                    string factura = string.Join(";", row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value?.ToString() ?? ""));

                    string[] position = factura.Split(';');

                    if (_return.SetPosition(position))
                    {
                        if (_return._Modelo.Pagadas.Equals("NO"))
                        {
                            filas_A_Eliminar.Add(row);
                        }
                    }
                }
            }

            foreach (var row in filas_A_Eliminar)
            {
                DataGridFactura.Rows.Remove(row);
            }
        }

        private void btnLimpiarPagas_Click(object sender, EventArgs e)
        {
            if (DataGridFactura.Rows.Count is 1 &&
                DataGridFactura.Rows[0].IsNewRow)
            {
                MessageBox.Show("No hay facturas PAGAS para limpiar.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            var filas_A_Eliminar = new List<DataGridViewRow>();

            foreach (DataGridViewRow row in DataGridFactura.Rows)
            {
                if (!row.IsNewRow)
                {
                    // Obtener la fila completa como un string
                    string factura = string.Join(";", row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value?.ToString() ?? ""));

                    string[] position = factura.Split(';');

                    if (_return.SetPosition(position))
                    {
                        if (_return._Modelo.Pagadas.Equals("SI"))
                        {
                            filas_A_Eliminar.Add(row);
                        }
                    }
                }
            }

            foreach (var row in filas_A_Eliminar)
            {
                DataGridFactura.Rows.Remove(row);
            }
        }

        private void MenuItemCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog _OpenFile = new OpenFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
                Title = "Abrir archivo con facturas planas"
            };

            if (_OpenFile.ShowDialog() is DialogResult.OK)
            {
                try
                {
                    string[] lines = File.ReadAllLines(_OpenFile.FileName);

                    foreach (string line in lines)
                    {
                        if (_return.IsCargue_OK(line)) 
                        {
                            AgregarFacturaDesdeTexto(line);  
                            CargueOK = true;
                        } 
                    }

                    if (CargueOK) MessageBox.Show("Archivo cargado exitosamente.",
                                                  "Éxito",
                                                  MessageBoxButtons.OK,
                                                  MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al cargar el archivo: {ex.Message}", 
                                    "Error", 
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Error);

                    throw;
                }
            }
        }

        private void AgregarFacturaDesdeTexto(string facturaTexto) => DataGridFactura.Rows.Add(facturaTexto);

    }
}
