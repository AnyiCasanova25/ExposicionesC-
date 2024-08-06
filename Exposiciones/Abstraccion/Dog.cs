using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion
{
    class Dog:Animal
    {
        public override void HacerSonido()
        {
            Console.WriteLine("Woof!..");
        }
    }
}
