using WindForm_Reader.src.Models;

namespace WindForm_Reader.src.Services
{
    public class Return : IReturn
    {
        public enum PrimerSemestre { Enero, Febrero, Marzo, Abril, Mayo, Junio };
        public enum SegundoSemestre { Julio, Agosto, Septiembre, Octubre, Noviembre, Diciembre };
        private double TotalPagado { get; set; } = 0;
        private double TotalNoPagado { get; set; } = 0;

        public Invoice _Modelo = new Invoice();

        public List<string> FacturasPagadas_Enero(List<string> Facturas)
        {
            List<string> PagadasEnero = new List<string>();

            foreach (string item in Facturas)
            {
                string[] Position = item.Split(';');

                if (SetPosition(Position))
                {
                    if (_Modelo.Mes.Equals("Enero"))
                    {
                        PagadasEnero.Add(item);
                    }
                }
            }

            return PagadasEnero;
        }

        public double TotalFacturas_Pagadas(List<string> Facturas)
        {
            foreach (string item in Facturas)
            { 
                string[] Position = item.Split(';');

                if (SetPosition(Position)) 
                {
                    if (_Modelo.Pagadas.Equals("SI"))
                    {
                        TotalPagado += double.Parse(_Modelo.TotalConImpuestos);
                    }
                }
            }

            return TotalPagado;
        }

        public double TotalFacturas_NO_Pagadas(List<string> Facturas)
        {
            foreach (string item in Facturas)
            {
                string[] Position = item.Split(';');

                if (SetPosition(Position))
                {
                    if (_Modelo.Pagadas.Equals("NO"))
                    {
                        TotalNoPagado += double.Parse(_Modelo.TotalConImpuestos);
                    }
                }
            }

            return TotalNoPagado;
        }

        public List<string> Facturas_Pagadas_PrimerSemestre(List<string> Facturas)
        {
            List<string> _PrimerSemestre = new List<string>();

            foreach (string item in Facturas)
            {
                string[] Position = item.Split(';');

                if (SetPosition(Position))
                {
                    if (_Modelo.Pagadas.Equals("SI") && 
                        Enum.TryParse(_Modelo.Mes, out PrimerSemestre mes))
                    {
                        _PrimerSemestre.Add(item);
                    }
                }
            }

            return _PrimerSemestre;
        }

        public List<string> Facturas_Pagadas_SegundoSemestre(List<string> Facturas)
        {
            List<string> _SegundoSemestre = new List<string>();

            foreach (string item in Facturas)
            {
                string[] Position = item.Split(';');

                if (SetPosition(Position))
                {
                    if (_Modelo.Pagadas.Equals("SI") &&
                        Enum.TryParse(_Modelo.Mes, out SegundoSemestre mes))
                    {
                        _SegundoSemestre.Add(item);
                    }
                }
            }

            return _SegundoSemestre;
        }

        public bool SetPosition(string[] Position)
        {
            if (Position.Length is 6)
            {
                _Modelo.NumeroFactura = Position[0];
                _Modelo.MontoTotal = Position[1];
                _Modelo.Impuestos = Position[2];
                _Modelo.TotalConImpuestos = Position[3];
                _Modelo.Mes = Position[4];
                _Modelo.Pagadas = Position[5];

                return true;
            }

            return false;
        }

        public bool IsCargue_OK(string LineaFactura)
        {
            string[] position = LineaFactura.Split(';');

            if (SetPosition(position))
            {
                #region NumeroFactura

                if (_Modelo.NumeroFactura.Length < 4)
                {
                    MessageBox.Show($"El NUMERO de una de las factura a cargar no cumple la longitud maxima",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return false;
                }

                #endregion

                #region MontoTotal

                if (int.Parse(_Modelo.MontoTotal) <= 0)
                {
                    MessageBox.Show($"El MONTO TOTAL de unas de las factura a cargar no puede ser menor o igual a 0",
                                   "Error",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                    return false;
                }

                #endregion

                #region Impuestos

                if (int.Parse(_Modelo.Impuestos) <= 0)
                {
                    MessageBox.Show($"El IMPUESTO de unas de las factura a cargar no puede ser menor o igual a 0",
                                   "Error",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                    return false;
                }

                #endregion

                #region TotalConImpuestos

                if (!TotalCuadrado(
                                    int.Parse(_Modelo.TotalConImpuestos), 
                                    int.Parse(_Modelo.MontoTotal), 
                                    int.Parse(_Modelo.Impuestos)))
                {
                    MessageBox.Show($"El TOTAL CON IMPUESTO de unas de las factura '{_Modelo.NumeroFactura}' a cargar no concuerda con la suma de IMPUESTOS y MONTO TOTAL",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return false;
                }

                #endregion

                #region Mes

                if (!Exist_Mes(_Modelo.Mes))
                {
                    MessageBox.Show($"El MES de unas de las factura a cargar no se encuentra en los meses permitidos",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return false;
                }

                #endregion

                #region Pagadas

                if (!_Modelo.Pagadas.Equals("SI") &&
                    !_Modelo.Pagadas.Equals("NO"))
                {
                    MessageBox.Show($"El PAGO de unas de las factura a cargar no se encuentra en los valores permitidos",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return false;
                }

                #endregion
            }
            else
            {
                MessageBox.Show($"El archivo cargado no cumple con los requerimientos para facturas planas",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public bool Exist_Mes(string Mes)
        {
            return Enum.TryParse(Mes, out Return.PrimerSemestre primer) || Enum.TryParse(Mes, out Return.SegundoSemestre segundo);
        }

        public bool TotalCuadrado(int TotalConImpuesto, int Impuesto, int MontoTotal)
        {
            return TotalConImpuesto == (Impuesto + MontoTotal);
        }

        public void Remove_From_List(DataGridView DataGrid, List<DataGridViewRow> Lista, string Pago)
        {
            if (Pago is not "SI" && Pago is not "NO")
            {
                MessageBox.Show("Pago no soportado",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            foreach (DataGridViewRow row in DataGrid.Rows)
            {
                if (!row.IsNewRow)
                {
                    // Obtener la fila completa como un string
                    string factura = string.Join(";", row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value?.ToString() ?? ""));

                    string[] position = factura.Split(';');

                    if (SetPosition(position))
                    {
                        if (_Modelo.Pagadas.Equals(Pago))
                        {
                            Lista.Add(row);
                        }
                    }
                }
            }

            Lista.ForEach(row => DataGrid.Rows.Remove(row));
        }

        public void Pregunta1(List<string> Facturas)
        {
            List<string> PagadasEnero = FacturasPagadas_Enero(Facturas);

            if (PagadasEnero.Any())
            {
                string facturasTexto = string.Join("\n", PagadasEnero);
                MessageBox.Show($"Facturas pagadas en enero:\n{facturasTexto}",
                                "Facturas Pagadas",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else MessageBox.Show("No hay facturas pagadas en enero.",
                                 "Facturas Pagadas",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
        }

        public void Pregunta2(List<string> Facturas)
        {
            TotalPagado = TotalFacturas_Pagadas(Facturas);

            if (TotalPagado is > 0)
            {
                MessageBox.Show($"Total de Facturas pagadas: ${TotalPagado}",
                                "Total Facturas Pagadas",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                TotalPagado = 0;
            }
            else MessageBox.Show("El total de Facturas pagadas es: 0",
                                 "Total Facturas Pagadas",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
        }

        public void Pregunta3(List<string> Facturas)
        {
            TotalNoPagado = TotalFacturas_NO_Pagadas(Facturas);

            if (TotalNoPagado is > 0)
            {
                MessageBox.Show($"Total de Facturas NO pagadas: ${TotalNoPagado}",
                                "Total Facturas Pagadas",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                TotalNoPagado = 0;
            }
            else MessageBox.Show("El total de Facturas No pagasdas es: 0",
                                 "Total Facturas NO Pagadas",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
        }

        public void Pregunta4(List<string> Facturas)
        {
            List<string> PrimerSemestre = Facturas_Pagadas_PrimerSemestre(Facturas);

            if (PrimerSemestre.Any())
            {
                string facturasTexto = string.Join("\n", PrimerSemestre);
                MessageBox.Show($"Facturas pagadas en primer semestre:\n{facturasTexto}",
                                "Facturas Pagadas",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else MessageBox.Show("No hay facturas pagadas en primer semestre.",
                                 "Facturas Pagadas",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
        }

        public void Pregunta5(List<string> Facturas)
        {
            List<string> SegundoSemestre = Facturas_Pagadas_SegundoSemestre(Facturas);

            if (SegundoSemestre.Any())
            {
                string facturasTexto = string.Join("\n", SegundoSemestre);
                MessageBox.Show($"Facturas pagadas en segundo semestre:\n{facturasTexto}",
                                "Facturas Pagadas",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else MessageBox.Show("No hay facturas pagadas en segundo semestre.",
                                 "Facturas Pagadas",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
        }  
    }
}
