using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class People
    {
        public int IdPeople { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int   Edad { get; set; }

        public People(int idPeople, string nombre, string apellido, int edad)
        {
            IdPeople = idPeople;
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
        }

        public virtual void MostrarPeople()
        {
            Console.WriteLine($"Id: {IdPeople}");
            Console.WriteLine($"Nombre:{Nombre}");
            Console.WriteLine($"Apellido: {Apellido}");
            Console.WriteLine($"Edad:{Edad}");
        }
    }
}
