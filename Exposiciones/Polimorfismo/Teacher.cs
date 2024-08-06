using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Teacher: Person
    {
        public override void Hablar()
        {
            Console.WriteLine("El profesor esta dando una clase.");
        }
    }
}
