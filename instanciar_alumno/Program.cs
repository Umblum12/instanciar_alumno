using System;

namespace instanciar_alumno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alumno Alumno;
            Alumno = new Alumno();
            Console.WriteLine(Alumno.dormir());

            Alumno Alumno1 = new Alumno();
            Alumno1.nombre = "Martha Valdez";
            Alumno1.edad = 50;
            Console.WriteLine(Alumno1.dormir());

            Alumno Alumno2 = new Alumno();
            Alumno2.nombre = "Pedro López";
            Alumno2.edad = 45;
            Console.WriteLine(Alumno2.dormir());
            Console.ReadKey(true);
        }
    }

    class Alumno
    {
        public string nombre = "Juan Martínez";
        public int edad = 22;

        public string dormir()
        {
            return nombre + " " + edad;
        }
    }
}
