﻿//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

using System;
Console.WriteLine("Введите по очереди два числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
if (a > b){
    Console.WriteLine("Большее число " + a);
}
else{
    Console.WriteLine("Большее число " + b);
}