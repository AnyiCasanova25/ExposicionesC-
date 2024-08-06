using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion
{
    abstract class Animal
    {

        public abstract void HacerSonido();

        public void dormir()
        {
            Console.WriteLine("Durmiendo.....");
        }
    }
}
