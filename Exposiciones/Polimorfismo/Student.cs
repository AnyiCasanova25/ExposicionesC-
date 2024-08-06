using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Student: Person
    {
        public override void Hablar()
        {
            Console.WriteLine("El estudiante esta hablando sobre sus estudios.");
        }
    }
}
