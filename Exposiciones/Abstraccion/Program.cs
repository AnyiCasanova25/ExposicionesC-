using Abstraccion;

class Program

{
    static void Main()
    {
        Animal myDog = new Dog();
        Animal myCat = new Cat();

        myDog.HacerSonido();
        myDog.dormir();

        myCat.HacerSonido();
        myCat.dormir();
    }
}