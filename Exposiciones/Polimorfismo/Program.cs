using Polimorfismo;

class Program
{
    static void Main()
    {
        Person student = new Student();
        Person teacher = new Teacher();

        student.Hablar();
        teacher.Hablar();

        student.Hablar("Hola,Buenos Dias..");
        teacher.Hablar("Buenos Dias..", 2);
    }
}