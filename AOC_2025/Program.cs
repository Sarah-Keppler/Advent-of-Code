// See https://aka.ms/new-console-template for more information
using AOC_2025.DayOne;

Console.WriteLine("Advent of Code 2025\n");

#region Day1

Console.WriteLine("--- Day 1: Secret Entrance ---\r\n");
SafeDial safeDial = new SafeDial("./DayOne/DayOne.txt");
Console.WriteLine($"What's the actual password to open the door? {safeDial.ThinkAndFindPassword()}");

#endregion
