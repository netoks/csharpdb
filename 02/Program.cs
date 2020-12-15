using System;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the marks obtained in Physic: ");
            var physic = int.Parse(Console.ReadLine());
            Console.Write("Input the marks obtained in Chemistry: ");
            var chemistry = int.Parse(Console.ReadLine());
            Console.Write("Input the marks obtained in Mathematics: ");
            var mathematics = int.Parse(Console.ReadLine());

            if ((mathematics >= 65 && physic >= 55 && chemistry >= 50 && (mathematics + physic + chemistry) >= 180) || (mathematics + physic) >= 140)
                {
                    Console.WriteLine("The candidate is eligible for admission.");
                } 
            else {
                    Console.WriteLine("The candidate is not eligible for admmision.");
                }
        }
    }
}
