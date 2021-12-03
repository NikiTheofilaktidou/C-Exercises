using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.SetAge(21);
            s1.ShowAge();
            s1.GoToClasses();

            Teacher t1 = new Teacher();
            t1.SetAge(30);
            //t1.ShowAge();
            t1.Explain();
        }
    }
    class Student
    {
        private int age;

        public void GoToClasses()
        {
            Console.WriteLine("I'm going to class.");
        }
        public void SetAge(int n)
        {
            age = n;
        }
        public void ShowAge()
        {
            Console.WriteLine($"My age is: {age} years old");
        }
    }
    class Teacher
    {
        private int age;
        private string subject;


        public void Explain()
        {
            Console.WriteLine("Explanation begins");
        }
        public void SetAge(int n)
        {
            age = n;
        }
        public void ShowAge()
        {
            Console.WriteLine($"My age is: {age} years old");
        }
    }
}
