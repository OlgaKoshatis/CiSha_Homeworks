// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
using System;
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число : ");
            int number = int.Parse(Console.ReadLine());
            int remineder, sum = 0;
            int temp = number;
            while (number > 0)
            {
                remineder = number % 10;
                sum = (sum * 10) + remineder;
                number = number / 10; 
            }
            if (temp == sum)
            {
                Console.WriteLine($"число {temp} - Палиндром.");
            }
            else
            {
                Console.WriteLine($"число {temp} - не палиндром");
            }
            Console.ReadKey();
        }
    }
