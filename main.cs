// Created by: Zaida Hammel
// Created on: April 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args) {
        int userInteger;
        Console.WriteLine("Write any number (positive or negative):");
        userInteger = int.Parse(Console.ReadLine());
        if (userInteger > -1) {
            userInteger = Convert.ToInt32(Console.Read());
            Console.WriteLine("The integer you input is positive.");
            Console.ReadLine();
        } else {
            Console.WriteLine("The integer you input is a negative.");
        }
    }
}