using Herencia;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Man Hombre = new Man(123, "Santiagos", "Ramirez", 18);
            Woman Mujer = new Woman(124, "Maydy", "Conde", 18);

            Hombre.MostrarPeople();
            Console.WriteLine();
            Mujer.MostrarPeople();
        }
    }
}