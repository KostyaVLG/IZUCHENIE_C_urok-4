
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Введите число");
int i = Convert.ToInt32(Console.ReadLine());
int res = 0; 

while (i > 0)  
{
int num = i % 10;
i = i / 10;
res = res + num;
}
Console.WriteLine("Cумма всех цифр числа равна: " + res);
