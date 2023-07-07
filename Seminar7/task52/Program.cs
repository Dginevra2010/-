// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,7; 5,7; 3,7; 3.


int[,] matrix = {
{ 1, 4, 7, 2 },
{ 5, 9, 2, 3 },
{ 8, 4, 2, 4 }
};

int rows = matrix.GetLength(0);
int columns = matrix.GetLength(1);

double[] columnAverages = new double[columns];

for (int j = 0; j < columns; j++)
{
int sum = 0;
for (int i = 0; i < rows; i++)
{
sum += matrix[i, j];
}
columnAverages[j] = (double)sum / rows;
}

Console.WriteLine("Средние арифметические в каждом столбце:");
for (int j = 0; j < columns; j++)
{
Console.WriteLine($"Столбец {j + 1}: {columnAverages[j]}");
}

