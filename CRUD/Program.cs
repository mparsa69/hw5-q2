// See https://aka.ms/new-console-template for more information
using CRUD;
using System;
using System.Collections.Generic;
bool flag = true;
string name, family,newName,newFamily;
PersonRepository pr = new PersonRepository();
while(flag == true)
{
    Console.WriteLine("Would You Like To Continue? y / n");
    var ans=Console.ReadKey().Key;
    if(ans == ConsoleKey.Y)
    {
        Console.WriteLine();
        Console.WriteLine("Choose Operation   I-Insert G-GetAll F-Find D-Delete U-Update C-Compare Two Person");
        var operaton = Console.ReadKey().Key;
        Console.WriteLine();
        if (operaton == ConsoleKey.I)
        {
            Console.WriteLine("Enter Your Name:");
            name = Console.ReadLine();

            Console.WriteLine("Enter Your Family:");
            family = Console.ReadLine();

            Person p = new Person();
            p.Name = name;
            p.Family = family;
            pr.InsertPerson(p);
            //DataSource._person.Add(p);
        }
        else if (operaton == ConsoleKey.G)
        {
            var items = pr.GetAll();
            foreach(var item in items)
            {
                Console.WriteLine($"{item.Name} {item.Family}");
            }
        }
        else if (operaton == ConsoleKey.F)
        {

            Console.WriteLine("Enter Your Name To Find:");
            name = Console.ReadLine();
            pr.FindPerson(name);
        }
        else if (operaton == ConsoleKey.D)
        {
            Console.WriteLine("Enter Your Name To Delete:");
            name = Console.ReadLine();
            pr.DeletePerson(name);
        }
        else if (operaton == ConsoleKey.U)
        {
            Console.WriteLine("Enter Your Name To Update:");
            name = Console.ReadLine();

            Console.WriteLine("Enter Your New Name ");
            newName = Console.ReadLine();
            Console.WriteLine("Enter Your New Family ");
            newFamily = Console.ReadLine();
            pr.UpdatePerson(name, newName, newFamily);
        }

        else if (operaton == ConsoleKey.C)
        {

            if (DataSource._person.Count > 1)
            {
                if (DataSource._person[0].Equals(DataSource._person[1]))
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    Console.WriteLine("Not OK");
                }
            }
            else
            {
                Console.WriteLine("Enter atleast two person");
            }
        }
    }
    else if (ans == ConsoleKey.N)
    {
        Console.WriteLine("\t");
        flag = false;
    }
    else
    {
        Console.WriteLine("Enter Valid Answer!!!");
        flag = false;
    }
}



