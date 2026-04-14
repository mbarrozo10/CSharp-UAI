using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejercicio_2
{
    public class NAFTA
    {
        private string nombre= "vacio";
        private float precio= 0;


        public NAFTA()
        {
            nombre = "vacio";
            precio = 0;
        }
        public NAFTA(string nombre, float precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public float Precio { get => precio; set => precio = value; }


        public override string ToString()
        {
            return nombre + "-" + precio;
        }
    }
}