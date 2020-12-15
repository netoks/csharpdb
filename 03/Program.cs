using System;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[10];
            int sum = 0;
            decimal avg;

            Console.WriteLine("Enter 10 numbers!");

            for (int i = 0; i < 10; i++) {
                Console.Write("Enter number " + i + ": ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // calculating sum. can be created as separate method
            foreach (var element in numbers) {
                sum = sum + element;
            }

            //calculating average. can be created as separate method
            avg = Decimal.Divide(sum, 10);

            Console.WriteLine("The sum of 10 numbers is: " + sum);
            Console.WriteLine("The average is: " + avg);
        }
    }
}
