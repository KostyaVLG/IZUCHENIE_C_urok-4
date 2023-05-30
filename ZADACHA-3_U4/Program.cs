// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int size = 8;
int[] array = new int[size]; // Массив из 8 элементов: в массиве изначально 8 нулей

for (int i = 0; i < size; i++)
{
    // array[i] = new Random().Next(0, 2)
    array[i] = new Random().Next(99);
    // Console.Write(array[i] + " ");
}

Console.WriteLine($"{String.Join(", ",array)} -> [ {String.Join(", ",array)} ]");
