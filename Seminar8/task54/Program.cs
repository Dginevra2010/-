// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2



{
int[,] matrix = {
{ 1, 4, 7, 2 },
{ 5, 9, 2, 3 },
{ 8, 4, 2, 4 }
};

int rows = matrix.GetLength(0);
int columns = matrix.GetLength(1);

for (int i = 0; i < rows; i++)
{
SortRowDescending(matrix, i, columns);
}

Console.WriteLine("Упорядоченный по убыванию двумерный массив:");

for (int i = 0; i < rows; i++)
{
for (int j = 0; j < columns; j++)
{
Console.Write(matrix[i, j] + " ");
}
Console.WriteLine();
}
}

static void SortRowDescending(int[,] matrix, int row, int columns)
{
for (int i = 0; i < columns - 1; i++)
{
for (int j = 0; j < columns - i - 1; j++)
{
if (matrix[row, j] < matrix[row, j + 1])
{
int temp = matrix[row, j];
matrix[row, j] = matrix[row, j + 1];
matrix[row, j + 1] = temp;
}
}
}
}

