using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Cat
{
    // Auto-implemented properties
    private readonly int mAge=10;
    public int Age {
        get;
      
        //set
        //{
        //    if (value > 0)
        //        mAge = value;
        //}
    }
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
        Cat sameCat = new Cat("Fluffy") {  };
        Console.WriteLine($"{sameCat.Name} {sameCat.Age}");
    }
}


