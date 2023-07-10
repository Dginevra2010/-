// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


{
int[,] matrix = {
{ 1, 4, 7, 2 },
{ 5, 9, 2, 3 },
{ 8, 4, 2, 4 },
{ 5, 2, 6, 7 }
};

int rows = matrix.GetLength(0);
int columns = matrix.GetLength(1);

int minSumRow = 0;
int minSum = int.MaxValue;

for (int i = 0; i < rows; i++)
{
int sum = 0;
for (int j = 0; j < columns; j++)
{
sum += matrix[i, j];
}

if (sum < minSum)
{
minSum = sum;
minSumRow = i;
}
}

Console.WriteLine("Строка с наименьшей суммой элементов: " + (minSumRow + 1));
}

