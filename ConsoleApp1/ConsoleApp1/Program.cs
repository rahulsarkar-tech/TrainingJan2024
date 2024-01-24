using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var aObject = new { Name = "ABCS", Age = 25, Address = "PUNE" };
            //aObject.Name = "XYZ";
            Console.WriteLine(aObject.Name + " " + aObject.Address + " " + aObject.Age);

            dynamic dObject = new ExpandoObject();
            dObject.Name = "ABSC";
            dObject.Age = 25;
            dObject.Salary = 12000;
            dObject.Address = "Mumbai";
            Console.WriteLine(dObject.Salary + " " + dObject.Address);

            dObject.Print = (Action)(() =>
                {
                    Console.WriteLine("Inside Dynamic Object");
                });

            dObject.Print();

            dObject.IsValid = (Func<bool>) (() => 
                {
                    if (string.IsNullOrWhiteSpace(dObject.Name))
                        return false;
                    return true; 
                });

            Console.WriteLine(dObject.IsValid());
        }
    }
}
