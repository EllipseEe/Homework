﻿// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("Введите первое число: ");
// int n1 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите второе число: ");
// int n2 = int.Parse(Console.ReadLine()!);

// if (n1 > n2){
//     int max = n1;
//     int min = n2;
//     Console.WriteLine($"Максисмальное число : {max}");
//     Console.WriteLine($"Минимальное число : {min}");
//     }
// else {
//     int max = n2;
//     int min = n1;
//     Console.WriteLine($"Максисмальное число : {max}");
//     Console.WriteLine($"Минимальное число : {min}");
// }


// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Write("Введите первое число: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите второе число: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Write("Введите третье число: ");
// int c = int.Parse(Console.ReadLine()!);
// int max = a;
// if (max < b){
//     max = b;
//     if (max < c){
//         max = c;
//     }
// }
// Console.WriteLine(max);



// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.Write("Введите число ");
// int a = int.Parse(Console.ReadLine()!);

// if (a %2 == 0){
//     Console.WriteLine("Да");
// }
// else {
//     Console.WriteLine("нет");
// }

// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.Write("Введите число : ");
// int a = int.Parse(Console.ReadLine()!);
// int x = 1;
// while (x <= a){
//     if (x%2 == 0)
//     {
//         Console.Write($"{x}," );
//     }
// x++;
// }