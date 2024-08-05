using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Man : People
    {
        public string IdMan { get; set; }

        public Man(int idPeople, string nombre, string apellido, int edad) : base(idPeople, nombre, apellido, edad)
        {
            IdMan = "Hombre";
        }

        public override void MostrarPeople()
        {
            Console.WriteLine($"Id: {IdMan}");
            base.MostrarPeople();
            Console.WriteLine($"Los {Nombre} mienten");
        }
    }
}
