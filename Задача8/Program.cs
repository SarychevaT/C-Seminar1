﻿Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int counter = 2;

while (counter <= N)
{
    Console.Write(counter + " ");
    counter = counter + 2;
}

