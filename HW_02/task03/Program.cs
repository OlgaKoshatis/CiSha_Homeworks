//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите номер дня недели ");
int day_num = Convert.ToInt32(Console.ReadLine());

if (day_num >= 1 && day_num <=7) 
{
	if (day_num >= 6) {
		Console.Write("Это выходной");
	} else {
		Console.Write("Это не выходной");
	}
} else {
	Console.Write("В неделе 7 дней, введите корректную цифру ");
}