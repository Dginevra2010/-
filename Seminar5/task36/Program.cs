// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


{
Random random = new Random();

// Задаем размерность массива
int length = 10;
int[] numbers = new int[length];

// Заполняем массив случайными числами
for (int i = 0; i < length; i++)
{
numbers[i] = random.Next(1, 100);
}

// Находим сумму элементов на нечетных позициях
int sum = 0;
for (int i = 1; i < length; i += 2)
{
sum += numbers[i];
}

Console.WriteLine("Сгенерированный массив:");
for (int i = 0; i < length; i++)
{
Console.Write(numbers[i] + " ");
}

Console.WriteLine("\nСумма элементов на нечетных позициях: " + sum);

Console.ReadLine();
}
