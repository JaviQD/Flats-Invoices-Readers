namespace WindForm_Reader.src.Services
{
    public interface IReturn
    {

        IEnumerable<string> FacturasPagadas_Enero(List<string> Facturas);

        double TotalFacturas_Pagadas(List<string> Facturas);

        double TotalFacturas_NO_Pagadas(List<string> Facturas);

        IEnumerable<string> Facturas_Pagadas_PrimerSemestre(List<string> Facturas);

        IEnumerable<string> Facturas_Pagadas_SegundoSemestre(List<string> Facturas);

        bool SetPosition(string[] Position);

        bool IsCargue_OK(string LineaFactura);

        bool Exist_Mes(string Mes);

        bool TotalCuadrado(int TotalConImpuesto, int Impuesto, int MontoTotal);

        void Remove_From_List(DataGridView DataGrid, List<DataGridViewRow> Lista, string Pago);

        void Pregunta1(List<string> Facturas);
        void Pregunta2(List<string> Facturas);
        void Pregunta3(List<string> Facturas);
        void Pregunta4(List<string> Facturas);
        void Pregunta5(List<string> Facturas);
    }
}
