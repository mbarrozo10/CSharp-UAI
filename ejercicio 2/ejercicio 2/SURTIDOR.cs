using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejercicio_2
{
    public class SURTIDOR
    {
        private float capacidad = 100;
        private NAFTA nafta = new NAFTA();
        private int cantVentas;
        private float total;
        private int cantidadRecargas;
        public float Capacidad { get => capacidad; }
        public NAFTA Nafta { get => nafta; set => nafta = value; }
        public int CantVentas { get => cantVentas; set => cantVentas = value; }
        public float Total { get => total; set => total = value; }
        public int CantidadRecargas { get => cantidadRecargas; set => cantidadRecargas = value; }

        public void Vender(float cantidad)
        {
            if (capacidad >= cantidad)
            {
                this.capacidad -= cantidad;
                this.cantVentas++;
                this.total += cantidad * this.nafta.Precio;
            }
            else
            {
                Reponer();
            }

        }

        public void Reponer()
        {
            this.capacidad = 100;
            cantidadRecargas++;
        }

        public override string ToString()
        {
            return nafta.ToString();
        }
    }
}