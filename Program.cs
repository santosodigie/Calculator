﻿// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, Welcome to my Calculator App!");

bool exit = false;

while (!exit)
{
    Console.WriteLine("Console App in C#");
    Console.WriteLine("___________________________________________");
    Console.WriteLine("Please select an optiom: ");
    Console.WriteLine("1 - Addition");
    Console.WriteLine("2 - Subtraction");
    Console.WriteLine("3 - Multiplication");
    Console.WriteLine("4 - Division");
    Console.WriteLine("5 - Exit");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            PerformOperation("Addition");
            break;
        case "2":
            PerformOperation("Subtraction");
            break;
        case "3":
            PerformOperation("Multiplication");
            break;
        case "4":
            PerformOperation("Division");
            break;
        case "5":
            exit = true;
            break;
        default:
            Console.WriteLine("Invalid Option. Please select a valid option.");
            break;
    }
}

static void PerformOperation(string operation)
{
    Console.WriteLine($"Congrats you chose {operation}");

    double num1 = GetValidNumber("Enter the first numnber: ");
    double num2 = GetValidNumber("Enter the second numnber: ");

    double result = 0;

    switch (operation)
    {
        case "Addition":
            result = num1 + num2;
            break;
        case "Subtraction":
            result = num1 - num2;
            break;
        case "Multiplication":
            result = num1 * num2;
            break;
        case "Division":
            result = num1 / num2;
            break;
    }

    Console.WriteLine($"The result of {operation} is {result}");
}

static double GetValidNumber(string prompt)
{
    double number;
    Console.Write(prompt);
    while (!double.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
        Console.Write(prompt);
    }

    return number;
}
