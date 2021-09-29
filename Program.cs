using System;
using System.Collections.Generic;

namespace teacher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOMEE TO THE SYSTEM");
            List<teacher1> teacher = new List<teacher1>();
            teacher1 t1 = new teacher1();
            Console.WriteLine("enter teacher name");
            t1.tname = Console.ReadLine();
            Console.WriteLine("enter teacher class");
            t1.classname = Console.ReadLine();
            Console.WriteLine("enter teacher section");
            t1.sectionname = Console.ReadLine();
            Console.WriteLine("enter teacher id");
            t1.id = Convert.ToInt32(Console.ReadLine());
            teacher.Add(t1);
            Console.WriteLine($"{t1.id}, {t1.tname} , {t1.sectionname} , {t1.classname}");
        



        }
    }
}
