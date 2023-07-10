// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 6 16
// 9 6


{
int[,] matrix1 = {
{ 2, 4 },
{ 3, 2 }
};

int[,] matrix2 = {
{ 3, 4 },
{ 3, 3 }
};

int rows1 = matrix1.GetLength(0);
int columns1 = matrix1.GetLength(1);
int rows2 = matrix2.GetLength(0);
int columns2 = matrix2.GetLength(1);

if (columns1 != rows2)
{
Console.WriteLine("Невозможно выполнить умножение матриц. Количество столбцов первой матрицы должно быть равно количеству строк второй матрицы.");
return;
}

int[,] result = new int[rows1, columns2];

for (int i = 0; i < rows1; i++)
{
for (int j = 0; j < columns2; j++)
{
int sum = 0;
for (int k = 0; k < columns1; k++)
{
sum += matrix1[i, k] * matrix2[k, j];
}
result[i, j] = sum;
}
}

Console.WriteLine("Результирующая матрица:");

for (int i = 0; i < rows1; i++)
{
for (int j = 0; j < columns2; j++)
{
Console.Write(result[i, j] + " ");
}
Console.WriteLine();
}
}
