using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            var lettersList = new string[3];

            for (int i = 0; i < 3; i++) {
                Console.Write("Enter letter: ");
                lettersList[i] = Console.ReadLine();
            }

            for (int i = 2; i >= 0; i--) {
                Console.Write(lettersList[i] + " ");
            }
        }
    }
}
