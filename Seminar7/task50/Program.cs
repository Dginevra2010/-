// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет
// 1, 2 -> 2





{
double[,] matrix = GenerateRandomMatrix(4, 3); // Пример случайно сгенерированного 5x5 двумерного массива

Console.WriteLine("Введите позиции элемента в двумерном массиве:");
Console.Write("Строка: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Столбец: ");
int column = int.Parse(Console.ReadLine());

int rows = matrix.GetLength(0);
int columns = matrix.GetLength(1);

if (row >= 0 && row < rows && column >= 0 && column < columns)
{
double element = matrix[row, column];
Console.WriteLine($"Значение элемента [{row}, {column}]: {element}");
}
else
{
Console.WriteLine("Указанный элемент не существует в двумерном массиве.");
}
}

static double[,] GenerateRandomMatrix(int rows, int columns)
{
Random random = new Random();
double[,] matrix = new double[rows, columns];

for (int i = 0; i < rows; i++)
{
for (int j = 0; j < columns; j++)
{
matrix[i, j] = random.NextDouble();
}
}

return matrix;
}



