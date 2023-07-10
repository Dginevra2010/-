// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


{
int[,] array = new int[4, 4];
int value = 1;
int size = 4;
int rowStart = 0;
int rowEnd = size - 1;
int colStart = 0;
int colEnd = size - 1;

while (value <= size * size)
{
// Заполнение верхней строки
for (int i = colStart; i <= colEnd; i++)
{
array[rowStart, i] = value++;
}
rowStart++;

// Заполнение последнего столбца
for (int i = rowStart; i <= rowEnd; i++)
{
array[i, colEnd] = value++;
}
colEnd--;

// Заполнение нижней строки
for (int i = colEnd; i >= colStart; i--)
{
array[rowEnd, i] = value++;
}
rowEnd--;

// Заполнение первого столбца
for (int i = rowEnd; i >= rowStart; i--)
{
array[i, colStart] = value++;
}
colStart++;
}

// Вывод массива
for (int i = 0; i < size; i++)
{
for (int j = 0; j < size; j++)
{
Console.Write($"{array[i, j]:D2} ");
}
Console.WriteLine();
}
}

