using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class Family
    {
        private List<Person> peoples = new List<Person>();
        public List<Person> Peoples
        {
            get { return peoples; }
        }
        public void AddMember(Person member)
        { peoples.Add(member); }
        public Person GetoldestMember()
        {peoples=peoples.OrderByDescending(x=>x.Age).ToList();
        return peoples.First();
        }
        public void Print()
        {
            foreach (var p in peoples.OrderBy(p => p.Name))
                System.Console.WriteLine(p);
        }
    }
}
