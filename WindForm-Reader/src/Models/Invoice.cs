namespace WindForm_Reader.src.Models
{
    public class Invoice
    {
        public string NumeroFactura { get; set; }
        public string MontoTotal { get; set; }
        public string Impuestos { get; set; }
        public string TotalConImpuestos { get; set; }
        public string Mes { get; set; }
        public string Pagadas { get; set; }
    }
}
