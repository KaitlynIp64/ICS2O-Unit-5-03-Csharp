// Created by: Kaitlyn Ip
// Created on: April 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        int userAge;

      Console.WriteLine("This program identifies which rated movies the user can watch alone.")
      Console.WriteLine("");
      Console.Write("Enter Age: ");
      userAge = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Write your age:");
        userAge = int.Parse(Console.ReadLine());
        if (userAge > 17)
        {
            Console.WriteLine("You are allowed to watch R rated movies alone.");
        }
        else if (userAge > 12)
        {
            Console.WriteLine("You are allowed to watch PG 13 rated movies alone.");
        }
        else if (userAge > 4)
        {
            Console.WriteLine("You are allowed to watch G and PG rated movies alone.");
        }
        else
        {
            Console.WriteLine("You are too young to watch any rated movies alone.");
        }
        Console.WriteLine("Done.");
    }
}