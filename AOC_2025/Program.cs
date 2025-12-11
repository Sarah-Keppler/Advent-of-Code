// See https://aka.ms/new-console-template for more information
using AOC_2025.DayOne;

Console.WriteLine("Advent of Code 2025\n");

#region Day1

Console.WriteLine("--- Day 1: Secret Entrance ---\r\n");
SafeDial safeDial = new SafeDial("./DayOne/DayOne.txt");
Console.WriteLine($"What's the actual password to open the door? {safeDial.ThinkAndFindPassword()}");
safeDial = new SafeDial("./DayOne/DayOne.txt", true);
Console.WriteLine($"Using password method 0x434C49434B, what is the password to open the door? {safeDial.ThinkAndFindPassword()}\r\n");

#endregion

#region Day2

Console.WriteLine("--- Day 2: Gift Shop ---\r\n");
DayTwo dayTwo = new DayTwo("./DayTwo/DayTwo.txt");
Console.WriteLine($"What do you get if you add up all of the invalid IDs? {dayTwo.SumAllInvalidsIds()}");
Console.WriteLine($"What do you get if you add up all of the invalid IDs using these new rules? {dayTwo.SumAllInvalidsIds(true)}\r\n");

#endregion
