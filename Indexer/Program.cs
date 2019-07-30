using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Cat
{
    // Auto-implemented properties.
    public int Age { get; set; }
    public string Name { get; set; }

    //public Cat()
    //{
    //}

    public Cat(string name)
    {
        this.Name = name;
    }
}

class Program
{
    static void Main(string[] args)
    {
        //Cat cat = new Cat { Age = 10, Name = "Fluffy" };
        Cat sameCat = new Cat("Fluffy") { Age = 10 };
        Console.WriteLine(sameCat);
    }
}


