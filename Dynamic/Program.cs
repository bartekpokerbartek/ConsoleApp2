using System;

namespace Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic d = new Employee();
            d.FirstName = "First";
            d.LastName = "Last";
            d.BirthDate = new DateTime(1986, 06, 02);

            Func<string, string, string> method = (a, b) => a + " " + b;

            d.GetData = method;
            Console.WriteLine(d.FirstName + " " + d.LastName + "..." + d.GetData("Aaa", "Bbb") + " - " + d.GetType());
        }
    }
}
