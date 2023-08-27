// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


Console.WriteLine("Введите натуральное число A ");
int number_A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число B ");
int number_B = Convert.ToInt32(Console.ReadLine());
// if(number_M<0 || number_N<0){
//     Console.WriteLine("Вы ввели ненатуральное число");
//     return;
// }
int res = ExponentiationNaturalNambers(number_A, number_B);
Console.WriteLine(res);

int ExponentiationNaturalNambers(int a, int b)
{
    if ( b == 0) return 1;

    return a * ExponentiationNaturalNambers(a, b-1);

}
