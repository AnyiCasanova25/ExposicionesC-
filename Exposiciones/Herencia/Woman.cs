using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Herencia
{
    public class Woman : People
    {
        public string IdWoman { get; set; }


        public Woman(int idPeople, string nombre, string apellido, int edad) : base(idPeople, nombre, apellido, edad)
        {
            IdWoman = "Mujer";
        }

        public override void MostrarPeople()
        {
            Console.WriteLine($"Id: {IdWoman}");
            base.MostrarPeople();
            Console.WriteLine($"Las {Nombre} son coquetas");
        }

    }
}
