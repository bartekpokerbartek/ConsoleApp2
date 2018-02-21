using System;

namespace Interface
{
    public interface ISalary
    {
        void Increase();
    }

    struct Person : ISalary
    {
        public int age;

        public void Increase()
        {
            age++;
        }

        public override string ToString()
        {
            return age.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            ISalary salary = person; //boxing, temp copy, vtable lookup
            Console.WriteLine(person);
            salary.Increase();
            Console.WriteLine(person);
        }
    }
}
