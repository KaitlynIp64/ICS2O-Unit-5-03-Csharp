// Created by: Kaitlyn Ip
// Created on: April 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        int num17;
        int num13;
        int num5;
        Console.Write(" Figure out which movies the user is allowed to watch based on their age:");
        Console.ReadLine();
        Console.Write("Age groups: 17yrs old, 13yrs old, 5yrs old and 5yrs and younger");
        Console.ReadLine();
        Console.Write("Enter your age: ");
      
        num17 = Convert.ToInt32(Console.ReadLine());
        num13 = Convert.ToInt32(Console.ReadLine());
        num5 = Convert.ToInt32(Console.ReadLine());
        if (num17 == 17)
            Console.WriteLine("You can see an R-rated movie alone!");
        else if (num13 == 13) 
            Console.WriteLine("You can see a PG-13 rated movie alone!");
        else if (num5 == 5)
            Console.WriteLine("You can watch a G-rated movie alone");
        else {
            Console.WriteLine("You are too young to watch movies alone.");
        }
        Console.WriteLine("\nDone.");
    }
}