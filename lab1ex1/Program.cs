using System;

namespace lab1ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Scrieti un program care citind de la tastaura cele trei dimensiuni ale unui
            paralelipiped dreptunghic, va afisa volumul lui */

            Console.WriteLine("We will calculate the volume of a parallelepiped.");
            Console.WriteLine("Type in the widht");

            int width = int.Parse(Console.ReadLine());

            Console.WriteLine("Type in the height");

            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Type in the lenght");

            int lenght = int.Parse(Console.ReadLine());

            int pVolume = width * height * lenght;
            Console.WriteLine("The area of our parallelipiped is " + pVolume);
        }
    }
}
