﻿//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Решаем с помощью "/" и "%", со строками не работаем

Console.WriteLine("Введите трехзначное число");
int num = int.Parse(Console.ReadLine()!);

if ((num > 99) && (num < 1000) || (num < -99) && (num > -1000)){
    int a = num % 100;
    int b = a / 10;
        if (b < 0)
        b = b*(-1);
    Console.WriteLine($"Вторая цифра введенного вами числа {b}");
}
else {
    Console.WriteLine("Вы ввели не трехзначное число");
}

