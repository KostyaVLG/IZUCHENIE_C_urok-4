// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число А: ");
int number1 = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Введите число В: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int count = number1;

for (int i=1; i < number2; i++)
{
count=count*number1;
}

Console.WriteLine("A в степени B равно: " + count);