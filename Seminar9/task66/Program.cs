﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


{
int M = 4;
int N = 8;
int sum = SumNaturalNumbers(M, N);
Console.WriteLine(sum);
}

static int SumNaturalNumbers(int m, int n)
{
if (m > n)
return 0;

return m + SumNaturalNumbers(m + 1, n);
}
