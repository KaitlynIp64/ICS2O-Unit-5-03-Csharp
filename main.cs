// Created by: Kaitlyn Ip
// Created on: April 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {

    int age;

    Console.WriteLine("This program determines which rated movies they are allowed to watch alone.");
    Console.WriteLine("");
    Console.WriteLine("Enter age: ");
    age = Convert.ToInt32(Console.ReadLine());

    if (age >= 17)
        Console.WriteLine("You are allowed to watch an R-rated movie alone.");
    else if (age >= 13)
        Console.WriteLine("You are allowed to watch a PG-13 rated movie alone.");
    else if (age >= 5)
        Console.WriteLine("You are allowed to watch a G-rated movie alone.");
    else 
        Console.WriteLine("You are too young to watch movies alone.");

    Console.WriteLine("/nDone.");
  }
} 