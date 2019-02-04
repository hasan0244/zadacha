using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
          string firstName = "Ivan";
string lastName = "Ivanov";
Console.WriteLine(@"Hello, ""{0}""!", firstName);
string fullName = ($"{firstName} {lastName}";
Console.WriteLine("Your full name is {0}.", fullName);



        }
    }
}
