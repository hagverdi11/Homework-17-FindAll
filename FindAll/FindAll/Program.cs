using FindAll.Models;
using System;

namespace FindAll
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyList<int> nums = new MyList<int>();
            //nums.Add(1);
            //nums.Add(2);
            //nums.Add(3);
            //nums.Add(4);
            //nums.Add(5);
            //nums.Add(6);
            //nums.Add(7);
            //nums.Add(8);
            //nums.Add(9);
            //nums.Add(10);
            //nums.Add(11);


            MyList<string> names = new MyList<string>();
            names.Add("Orxan");
            names.Add("Eli");
            names.Add("Veli");
            names.Add("Eli");


            var result = names.Find(m => m == "Orxan");
            Console.WriteLine(result);

            var result1 = names.FindAll(m => m == "Eli");
            Console.WriteLine(result1);
        }
    }
}
