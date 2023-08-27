// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
// int FactorialRec(int n)
// {
// if (n == 1) return 1;
// else return n * FactorialRec(n - 1);
// }

// Console.WriteLine(FactorialRec(10)); // 3628800
Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());
int sum = SumNaturalNambers(number);
Console.WriteLine(sum);

int SumNaturalNambers(int n)
{
    if (n == 0) return 0;

    return n % 10 + SumNaturalNambers(n / 10);

}

