using System.Data;
using WindForm_Reader.src.Services;

namespace WindForm_Reader.src.Views
{
    public partial class Principal : Form
    {
        Return _return = new Return();

        private List<string> ListaFacuras = new List<string>();
        private List<string> FacturasDuplicadas = new List<string>();

        private bool CargueOK { get; set; } = false;
        private int Cargados {  get; set; }
        private string Codigo {  get; set; }

        public Principal()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e) => this.Dispose();

        private void toolStripMenuItem2_Click(object sender, EventArgs e) => new RegistrarFactura(this).ShowDialog();

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

            _return.Remove_From_List(DataGridFactura, new List<DataGridViewRow>(), "NO");
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

            _return.Remove_From_List(DataGridFactura, new List<DataGridViewRow>(), "SI");
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
                            if (IsNotCargue_Duplicated(line))
                            {
                                AgregarFacturaDesdeTexto(line);
                                CargueOK = true;
                                Cargados++;
                            }
                            else
                            {
                                FacturasDuplicadas.Add(line);
                            }
                        }
                    }

                    if (FacturasDuplicadas.Count >= 1)
                    {
                        string facturasTexto = string.Join("\n", FacturasDuplicadas);

                        MessageBox.Show($"Facturas Duplicadas no cargadas: {facturasTexto}\n",
                                         "Diplicado",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Warning);
                    }

                    if (CargueOK) MessageBox.Show($"Facturas cargadas exitosamente. {Cargados}",
                                                   "Cargue",
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

                Reset(1);
            }
        }

        private void AgregarFacturaDesdeTexto(string facturaTexto) => DataGridFactura.Rows.Add(facturaTexto);

        private void bntPregunta1_Click(object sender, EventArgs e)
        {
            DialogResult _Pregunta = MessageBox.Show("Cuáles son las facturas que fueron pagadas en el mes de Enero. \n\n" +
                                                     "Ver Respuesta?",
                                                     "Pregunta 1",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);
            if (_Pregunta is DialogResult.Yes)
            {
                foreach (DataGridViewRow row in DataGridFactura.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string factura = string.Join(";", row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value?.ToString() ?? ""));
                        ListaFacuras.Add(factura);
                    }
                }

                if (ListaFacuras.Count is 0)
                {
                    MessageBox.Show("No hay Facturas a leer para responder la pregunta 1",
                                    "Advertencia",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                _return.Pregunta1(ListaFacuras);

                Reset(2);
            }
        }

        private void bntPregunta2_Click(object sender, EventArgs e)
        {
            DialogResult _Pregunta = MessageBox.Show("Cuál es el total de Facturas pagadas. \n\n" +
                                                     "Ver Respuesta?",
                                                     "Pregunta 2",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);
            if (_Pregunta is DialogResult.Yes)
            {
                foreach (DataGridViewRow row in DataGridFactura.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string factura = string.Join(";", row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value?.ToString() ?? ""));
                        ListaFacuras.Add(factura);
                    }
                }

                if (ListaFacuras.Count is 0)
                {
                    MessageBox.Show("No hay Facturas a leer para responder la pregunta 2",
                                    "Advertencia",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                _return.Pregunta2(ListaFacuras);

                Reset(2);
            }
        }

        private void btnPregunta3_Click(object sender, EventArgs e)
        {
            DialogResult _Pregunta = MessageBox.Show("Cuál es el total de Facturas NO pagadas. \n\n" +
                                                     "Ver Respuesta?",
                                                     "Pregunta 3",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);
            if (_Pregunta is DialogResult.Yes)
            {
                foreach (DataGridViewRow row in DataGridFactura.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string factura = string.Join(";", row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value?.ToString() ?? ""));
                        ListaFacuras.Add(factura);
                    }
                }

                if (ListaFacuras.Count is 0)
                {
                    MessageBox.Show("No hay Facturas a leer para responder la pregunta 3",
                                    "Advertencia",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                _return.Pregunta3(ListaFacuras);

                Reset(2);
            }
        }

        private void btnPregunta4_Click(object sender, EventArgs e)
        {
            DialogResult _Pregunta = MessageBox.Show("Cuáles fueron las facturas pagadas en el primer semestre => \n(enero,febrero,marzo,abril,mayo,junio). \n\n" +
                                                     "Ver Respuesta?",
                                                     "Pregunta 4",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);
            if (_Pregunta is DialogResult.Yes)
            {
                foreach (DataGridViewRow row in DataGridFactura.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string factura = string.Join(";", row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value?.ToString() ?? ""));
                        ListaFacuras.Add(factura);
                    }
                }

                if (ListaFacuras.Count is 0)
                {
                    MessageBox.Show("No hay Facturas a leer para responder la pregunta 4",
                                    "Advertencia",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                _return.Pregunta4(ListaFacuras);

                Reset(2);
            }
        }

        private void btnPregunta5_Click(object sender, EventArgs e)
        {
            DialogResult _Pregunta = MessageBox.Show("Cuáles fueron las facturas pagadas en el segundo semestre => \n(julio,agosto,septiembre,octubre,noviembre,diciembre). \n\n" +
                                                     "Ver Respuesta?",
                                                     "Pregunta 5",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);
            if (_Pregunta is DialogResult.Yes)
            {
                foreach (DataGridViewRow row in DataGridFactura.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string factura = string.Join(";", row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value?.ToString() ?? ""));
                        ListaFacuras.Add(factura);
                    }
                }

                if (ListaFacuras.Count is 0)
                {
                    MessageBox.Show("No hay Facturas a leer para responder la pregunta 5",
                                    "Advertencia",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                _return.Pregunta5(ListaFacuras);

                Reset(2);
            }
        }

        private bool IsNotCargue_Duplicated(string line)
        {
            string[] FacturaRecibida = line.Split(';');
            if (_return.SetPosition(FacturaRecibida))
            {
                Codigo = _return._Modelo.NumeroFactura;
            }

            foreach (DataGridViewRow row in DataGridFactura.Rows)
            {
                if (!row.IsNewRow)
                {
                    string factura = string.Join(";", row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value?.ToString() ?? ""));

                    string[] position = factura.Split(';');

                    if (_return.SetPosition(position))
                    {
                        if(_return._Modelo.NumeroFactura == Codigo) return false;
                    }
                }
            }

            return true;
        }

        private void Reset(int hacer)
        {
            if (hacer is 1)
            {
                FacturasDuplicadas.Clear();
                Cargados = 0;
            }

            if(hacer is 2) ListaFacuras.Clear();
        }       
    }
}
