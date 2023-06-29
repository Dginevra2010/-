// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2



{
Random random = new Random();

int length = 10;
int[] numbers = new int[length];

for (int i = 0; i < length; i++)
{
numbers[i] = random.Next(100, 1000);
}

int countEven = 0;
for (int i = 0; i < length; i++)
{
if (numbers[i] % 2 == 0)
{
countEven++;
}
}

Console.WriteLine("Сгенерированный массив:");
for (int i = 0; i < length; i++)
{
Console.Write(numbers[i] + " ");
}

Console.WriteLine("\nКоличество четных чисел: " + countEven);

Console.ReadLine();
}
