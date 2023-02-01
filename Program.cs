// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

System.Console.Write("Введите число A: ");
int num1 = Convert.ToInt32(Console.ReadLine()!);
System.Console.Write("Введите число B: ");
int num2 = Convert.ToInt32(Console.ReadLine()!);
GetDegree (num1,num2);

void GetDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine($"Число {num1} в степени {num2} = {result}");
}

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

System.Console.Write("Введите число: ");
int num11 = Convert.ToInt32(Console.ReadLine()!);
System.Console.WriteLine($"Сумма цифр в числе {num11} равна {GetSumNumbers (num11)}");

int GetSumNumbers (int a)
{
    int sum = 0;
    while (a != 0)
    {
        sum += a % 10;
        a /= 10;
    }
    return sum;
}
    

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)

int[] Array = GetArray(8);
System.Console.WriteLine($"[{String.Join(",",Array)}]");

int[] GetArray (int size)
{
    int [] Array = new int [size];
    for (int i = 0; i < size; i++)
    {
        Array [i] = new Random().Next(1000);
    }
    return Array;
}