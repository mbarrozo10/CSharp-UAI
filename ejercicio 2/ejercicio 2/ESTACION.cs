using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace ejercicio_2
{
    public class ESTACION
    {
        public List<SURTIDOR> surtidores = new List<SURTIDOR>();

        public float CalcularRecaudacionTotal()
        {
            float total = 0;
            foreach (var surtidor in surtidores)
            {
                total += surtidor.Total;
            }

            return total;
        }

        public float CalcularRecaudacionSurtidor(SURTIDOR surtidor)
        {
            float recaudado = 0;
            foreach (var s in surtidores)
            {
                if (s == surtidor)
                {
                    recaudado = s.Total;
                }
            }

            return recaudado;
        }

        public SURTIDOR MaxRecaudado()
        {
            SURTIDOR temp = new SURTIDOR();
            surtidores.OrderByDescending(s => s.Total);
            temp = surtidores[0];
            return temp;
        }

        public SURTIDOR MinRecaudado()
        {
            List<SURTIDOR> surtidoresTemp = new List<SURTIDOR>();
            if (surtidores.OrderByDescending(s => s.Total) != null)
            {
                surtidoresTemp = surtidores.OrderByDescending(s => s.Total).ToList();
            }

            return surtidoresTemp.Last();
        }

        public SURTIDOR MaxVentas()
        {
            List<SURTIDOR> surtidoresTemp = new List<SURTIDOR>();
            if (surtidores.OrderByDescending(s => s.CantVentas) != null)
            {
                surtidoresTemp = surtidores.OrderByDescending(s => s.CantVentas).ToList();
            }
            return surtidoresTemp[0];
        }

        public string ObtenerPorcentaje(NAFTA N)
        {
            float totalVentas = 0;
            float cantNafta = 0;
            foreach (var surtidor in surtidores)
            {
                totalVentas += surtidor.CantVentas;
                if (surtidor.Nafta.Nombre == N.Nombre)
                {
                    cantNafta = surtidor.CantVentas;
                }
            }
            if (totalVentas == 0)
            {
                totalVentas = 1;
            }

            return "La nafta " + N.Nombre + " vendio " + ((cantNafta / totalVentas) * 100).ToString() + "%";
        }

        public string ObtenerPorcentajeRecaudado(NAFTA N)
        {
            float totalVentas = 0;
            float ventasNafta = 0;
            foreach (var surtidor in surtidores)
            {
                totalVentas += surtidor.Total;
                if (surtidor.Nafta.Nombre == N.Nombre)
                {
                    ventasNafta = surtidor.Total;
                }
            }
            if (totalVentas == 0)
            {
                totalVentas = 1;
            }

            return "La nafta " + N.Nombre + " recaudo " + ((ventasNafta / totalVentas) * 100).ToString() +"%";
        }


        public SURTIDOR ObtenerMaxRecargas()
        {
            if (surtidores.Count < 3)
            {
                return new SURTIDOR();
            }
            List<SURTIDOR> surtidoresTemp = new List<SURTIDOR>();
            if (surtidores.OrderByDescending(s => s.CantidadRecargas) != null)
            {
                surtidoresTemp = surtidores.OrderByDescending(s => s.CantidadRecargas).ToList();
            }
            return surtidoresTemp[0];
        }

        public string ObtenerPorcentajeCantSurtidor(SURTIDOR s)
        {
            if (s == null)
            {
                return "No iniciado";
            }

            float totalVentas = 0;
            foreach (var surtidor in surtidores)
            {
                totalVentas += surtidor.CantVentas;
            }

            return "El surtidor seleccionado vendio " + ((s.CantVentas / totalVentas) * 100).ToString() + "%";
        }

        public string ObtenerPorcentajeRecaudadoSurtidor(SURTIDOR s)
        {
            if (s == null)
            {
                return "No iniciado";
            }
            float totalVentas = 0;
            foreach (var surtidor in surtidores)
            {
                totalVentas += surtidor.Total;
            }

            return "El surtidor seleccionado vendio " + ((s.Total / totalVentas) * 100).ToString() + "%";
        }
    
    }
}