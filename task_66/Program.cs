// Задача 66: Задайте значение M и N. Напишите программу, 
// которая найдет сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.Write("Введите M: ");
int M = Convert.ToInt16(Console.ReadLine()!);
Console.Write("Введите N: ");
int N = Convert.ToInt16(Console.ReadLine()!);

Console.WriteLine($"N={M}, M={N}");

int sum = 0;
if (M>N)
for (int i = N; i <= M; i++)
    {
        sum += i;
    }
else
    for (int i = M; i <= N; i++)
    {
        sum += i;
    }

Console.Write($" {sum}");