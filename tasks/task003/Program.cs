﻿//task 19

Console.Clear();
Console.Write("Введите число: ");
string? number = Console.ReadLine();

  if (number[0]==number[4] && number[1]==number[3])
    Console.WriteLine($"Ваше число: {number}, палиндром");

  else Console.WriteLine($"Ваше число: {number}, не палиндром");