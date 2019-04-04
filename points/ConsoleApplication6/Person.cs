using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class Person
    {
        private int age;
    private string name;

    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Person()
    {
        name = "No name";
        age = 1;
    }

    public Person( int age)
    {
        name = "No name";
        this.age = age;
    }

    public Person( int age, string name)
    {
        this.name = name;
        this.age = age;
    }

    public override string ToString()
    {
        return name +"-"+age;
    }

    }
}
