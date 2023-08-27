// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.WriteLine("Введите натуральное число от ");
int number_M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число до ");
int number_N = Convert.ToInt32(Console.ReadLine());
if(number_M<0 || number_N<0){
    Console.WriteLine("Вы ввели ненатуральное число");
    return;
}
NaturalNumbersRange(number_M, number_N);


void NaturalNumbersRange(int m, int n)
{
    //if (n == 0 || m == 0) return;
    if (m > n)
    {
        Console.Write($"{m} ");
        NaturalNumbersRange(m - 1, n);
    }
    else if (m < n)
    {
        Console.Write($"{m} ");
        NaturalNumbersRange(m + 1, n);
    }
    else Console.Write($"{m} ");
        //NaturalNumbersRange(m, n);
    
}

       
    
