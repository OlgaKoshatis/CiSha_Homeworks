// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

while (num >= 100)
{
    num /= 10;
}
    var secDig = num % 10;

if (num < 10)
{
    Console.WriteLine("У числа нет второй цифры");
}

Console.WriteLine("Вторая цифра числа " + secDig);