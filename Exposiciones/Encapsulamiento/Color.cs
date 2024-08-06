using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
    public class Color
    {
        private string nombre { get; set; }

        //Constructor
        public Color(string nombre)
        {
            this.nombre = nombre;
        }

        public void mostrarInfo()
        {
            Console.WriteLine($"Color: {nombre}");
        }
    }
}
