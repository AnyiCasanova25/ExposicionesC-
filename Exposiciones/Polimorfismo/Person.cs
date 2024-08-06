using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    abstract class Person
    {
        public virtual void Hablar()
        {
            Console.WriteLine("La persona esta hablando");
        }

        public void Hablar(string mensaje)
        {
            Console.WriteLine("Mensaje: " + mensaje);
        }

        public void Hablar(string mensaje, int veces)
        {
            for (int i = 0; i < veces; i++) 
            {
                Hablar(mensaje);
            }
        }
    }
}
