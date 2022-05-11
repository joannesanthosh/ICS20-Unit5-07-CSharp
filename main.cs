// Created by: Joanne Santhosh
// Created on: May 2022
//
// This program adds up numbers using loops

using System;

class Program
{
    public static void Main(string[] args)
    {
      
        int number;
        var total = 0;
        
         // input
        Console.WriteLine("This program adds up numbers using loops");
        Console.WriteLine("");
        Console.Write("Enter a positive integer: ");
        number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");   
        
        // Process
        for (var counter = 1; counter <= number; counter++) {
        total += counter;
        }
        Console.WriteLine ("The answer is: " + total);
    }  
}