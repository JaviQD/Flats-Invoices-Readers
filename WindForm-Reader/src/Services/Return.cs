using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindForm_Reader.src.Models;

namespace WindForm_Reader.src.Services
{
    public class Return
    {
        public enum PrimerSemestre { Enero, Febrero, Marzo, Abril, Mayo, Junio };
        public enum SegundoSemestre { Julio, Agosto, Septiembre, Octubre, Noviembre, Diciembre };
        private double TotalPagado { get; set; } = 0;
        public double TotalNoPagado { get; set; } = 0;

        public Invoice _Modelo = new Invoice();

        public void FacturasPagadasEnero()
        {
            //Hacemos un ciclo para que cada item del arreglo de factura sea pasado a mi nueva _Modelo
            Console.WriteLine();
            Console.Write("RESPUESTA =>> ");
            foreach (string item in GetFacturas())
            {
                //Divido la factura en subcadenas usando el dilimitador ;
                string[] Position = item.Split(';');

                if (SetPosition(Position))
                {
                    if (_Modelo.Mes.Equals("Enero"))
                    {
                        Console.Write($"'{_Modelo.NumeroFactura}', ");
                    }
                }
                else
                {
                    Console.WriteLine("La estrutura de el plano esta incompleta o supera los limites");
                }
            }
        }

        public void TotalPagadas()
        {
            //Hacemos un ciclo para que cada item del arreglo de factura sea pasado a mi nueva _Modelo
            Console.WriteLine();
            Console.Write("RESPUESTA =>> ");
            foreach (string item in GetFacturas())
            {
                //Divido la factura en subcadenas usando el dilimitador ;
                string[] Position = item.Split(';');

                if (SetPosition(Position))
                {
                    if (_Modelo.Pagadas.Equals("SI"))
                    {
                        TotalPagado += double.Parse(_Modelo.TotalConImpuestos);
                    }
                }
                else
                {
                    Console.WriteLine("La estrutura de el plano esta incompleta o supera los limites");
                }
            }

            Console.Write(TotalPagado);
        }

        public void TotalNoPagadas()
        {
            //Hacemos un ciclo para que cada item del arreglo de factura sea pasado a mi nueva _Modelo
            Console.WriteLine();
            Console.Write("RESPUESTA =>> ");
            foreach (string item in GetFacturas())
            {
                //Divido la factura en subcadenas usando el dilimitador ;
                string[] Position = item.Split(';');

                if (SetPosition(Position))
                {
                    if (_Modelo.Pagadas.Equals("NO"))
                    {
                        TotalNoPagado += double.Parse(_Modelo.TotalConImpuestos);
                    }
                }
                else
                {
                    Console.WriteLine("La estrutura de el plano esta incompleta o supera los limites");
                }
            }

            Console.Write(TotalNoPagado);
        }

        public void FacturasPrimerSemestre()
        {
            //Hacemos un ciclo para que cada item del arreglo de factura sea pasado a mi nueva _Modelo
            Console.WriteLine();
            Console.WriteLine("RESPUESTA =>> ");
            foreach (string item in GetFacturas())
            {
                //Divido la factura en subcadenas usando el dilimitador ;
                string[] Position = item.Split(';');

                if (SetPosition(Position))
                {
                    if (_Modelo.Pagadas.Equals("SI") && Enum.TryParse(_Modelo.Mes, out PrimerSemestre mes))
                    {
                        Console.WriteLine($"Factura '{_Modelo.NumeroFactura}' del mes '{_Modelo.Mes}'");
                    }
                }
                else
                {
                    Console.WriteLine("La estrutura de el plano esta incompleta o supera los limites");
                }
            }
        }

        public void FacturasSegundoSemestre()
        {
            //Hacemos un ciclo para que cada item del arreglo de factura sea pasado a mi nueva _Modelo
            Console.WriteLine();
            Console.WriteLine("RESPUESTA =>> ");
            foreach (string item in GetFacturas())
            {
                //Divido la factura en subcadenas usando el dilimitador ;
                string[] Position = item.Split(';');

                if (SetPosition(Position))
                {
                    if (_Modelo.Pagadas.Equals("SI") && Enum.TryParse(_Modelo.Mes, out SegundoSemestre mes))
                    {
                        Console.WriteLine($"Factura '{_Modelo.NumeroFactura}' del mes '{_Modelo.Mes}'");
                    }
                }
                else
                {
                    Console.WriteLine("La estrutura de el plano esta incompleta o supera los limites");
                }
            }
        }

        public void PrintResult()
        {
            Console.WriteLine();
            Console.Write("PREGUNTA #1. Cuáles son las facturas que fueron pagadas en el mes de Enero. ");
            FacturasPagadasEnero();
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("PREGUNTA #2. Cuál es el total de Facturas pagadas. ");
            TotalPagadas();
            Console.WriteLine();

            Console.WriteLine();
            Console.Write($"PREGUNTA #3. Cuál es el total de Facturas NO pagadas. ");
            TotalNoPagadas();
            Console.WriteLine();

            Console.WriteLine();
            Console.Write($"PREGUNTA #4. Cuáles fueron las facturas pagadas en el primer semestre => \n(enero,febrero,marzo,abril,mayo,junio). ");
            FacturasPrimerSemestre();
            Console.WriteLine();

            Console.Write($"PREGUNTA #5. Cuáles fueron las facturas pagadas en el segundo semestre => \n(julio,agosto,septiembre,octubre,noviembre,diciembre). ");
            FacturasSegundoSemestre();
            Console.WriteLine();
        }

        private string[] GetFacturas() => new string[]
        {
            "FA001;10000;1900;11900;Enero;SI",
            "FA002;20500;3895;24395;Julio;SI",
            "FA003;120000;22800;142800;Diciembre;SI",
            "FA004;458000;87020;545020;Diciembre;SI",
            "FA005;26000;4940;30940;Diciembre;SI",
            "FA006;35000;6650;41650;Diciembre;SI",
            "FA007;456900;86811;543711;Diciembre;SI",
            "FA008;78000;14820;92820;Julio;SI",
            "FA009;97000;18430;115430;Julio;SI",
            "FA010;108900;20691;129591;Julio;SI",
            "FA011;2963790;563120,1;3526910,1;Enero;NO",
            "FA012;1622811;308334,09;1931145,09;Enero;NO",
            "FA013;1962394;372854,86;2335248,86;Enero;SI",
            "FA014;2950942;560678,98;3511620,98;Agosto;SI",
            "FA015;3572660;678805,4;4251465,4;Agosto;SI",
            "FA016;3464394;658234,86;4122628,86;Agosto;SI",
            "FA017;3948860;750283,4;4699143,4;Febrero;SI",
            "FA018;2816262;535089,78;3351351,78;Agosto;SI",
            "FA019;1750681;332629,39;2083310,39;Agosto;NO",
            "FA020;1867059;354741,21;2221800,21;Agosto;NO",
            "FA021;2788905;529891,95;3318796,95;Febrero;SI",
            "FA022;3038502;577315,38;3615817,38;Septiembre;SI",
            "FA023;752476;142970,44;895446,44;Noviembre;SI",
            "FA024;2081316;395450,04;2476766,04;Noviembre;SI",
            "FA025;1331836;253048,84;1584884,84;Noviembre;NO",
            "FA026;4286809;814493,71;5101302,71;Noviembre;NO",
            "FA027;3744576;711469,44;4456045,44;Noviembre;SI",
            "FA028;1381975;262575,25;1644550,25;Noviembre;SI",
            "FA029;3034673;576587,87;3611260,87;Febrero;SI",
            "FA030;658350;125086,5;783436,5;Febrero;SI"
        };

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
    }
}
