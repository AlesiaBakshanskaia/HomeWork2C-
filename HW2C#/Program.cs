﻿//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Решаем с помощью "/" и "%", со строками не работаем

/*Console.WriteLine("Введите трехзначное число");
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
}*/


//Задача 13: //Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Решаем с помощью "/" и "%", со строками не работаем (Максимальное число 100000)

int num = new Random().Next(0, 100001);
int Number = 0;
if ((num / 100) > 0){
    if ((num > 99) && (num < 1000 )){
        Number = num % 10; 
    }
    if ((num > 999) && (num < 10000 )){
        int a = num % 100; 
        Number = a /10;
    }
    if ((num > 9999) && (num < 100000 )){
        int b = num % 1000; 
        Number = b /100;
    }
    Console.WriteLine($"Третья цифра слева  числа {num} {Number} ");
}
else
{
   Console.WriteLine($"У числа {num} нет третьей цифры"); 
}