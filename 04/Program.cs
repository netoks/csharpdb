using System;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Person 
    {
        private int _age; 

        public Person(int age) {
            SetAge(age);
        }

        public void SetAge(int age) {
            _age = age;
        }

        public void Greet() {

        }
    }

    class Student : Person 
    {
        public Student(int age) : base(age)
        {

        }
        public void Study() {
            Console.WriteLine("I'm studying");
        }
    }

    class Professor : Person 
    {
        public Professor(int age) : base(age) 
        {
            
        }

        public void Explain() {
            Console.WriteLine("I'm explaining");
        }
    }
}
