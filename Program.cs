// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("Введите певрое число: ");
// int A = int.Parse(Console.ReadLine()!);

// Console.Write("Введите Второе число: ");
// int B = int.Parse(Console.ReadLine()!);

// if (A>B)Console.Write("Первое число большее второго " );
// if (A<B)Console.Write("Первое число меньше второго " );


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
// Console.Write("Введите певрое число: ");
// int A = int.Parse(Console.ReadLine()!);
// Console.Write("Введите второе число: ");
// int B = int.Parse(Console.ReadLine()!);
// Console.Write("Введите третье число: ");
// int C = int.Parse(Console.ReadLine()!);
// if (A > B)
// {
//     if (A > C)
//     {
//         Console.WriteLine("Максимальное число: " + A);
//     }
//     else
//     {
//         Console.WriteLine("Максимальное число: " + C);
//     }
// }

// else if (B > C)
// {
//     Console.WriteLine("Максимальное число: " + B);
// }
// else
// {
//     Console.WriteLine("Максимальное число: " + C);
// }

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка(number%2==0)).

// 4->да
// - 3->нет
// 7->нет

// Console.Write("Введите певрое число: ");
// int A = int.Parse(Console.ReadLine()!);

// if (A % 2 == 0)
// {
//     Console.WriteLine("Число четное: ");
// }
// else
// {
//     Console.WriteLine("Число не четное: ");
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.Write("Введите число: ");
// int N = int.Parse(Console.ReadLine()!);

// int A = 2;

// while(A <= N)
// {
//     Console.Write($"{A} ");
//     A=A+2;
// }
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
for (int index = 2; index <= a; index += 2)
{
    System.Console.WriteLine(index + " ");
}