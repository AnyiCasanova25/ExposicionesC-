

using Encapsulamiento;

class Program
{
    static void Main()
    {
        Color colorAzul = new Color("Azul");
        Color colorVerde = new Color("Verde");
        Color colorMorado = new Color("Morado");

        colorAzul.mostrarInfo();
        colorVerde.mostrarInfo();
        colorMorado.mostrarInfo();
    }
}