using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
         static void Main(string[] args) 
         {
             Person firstPerson = new Person();
             Person secondPerson = new Person();
            firstPerson.Name = "Гошо";
            firstPerson.Age = 46;
            secondPerson.Name = "Иван";
            secondPerson.Age = 34;
            
             if(firstPerson.Age<secondPerson.Age2)
                 firstPerson.IntroduceYourself();
             else
                 secondPerson.IntroduceYourself();

         }

        }
    }

