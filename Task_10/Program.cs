// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Enter a three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

int num2 = num % 100;
int num3 = num2 / 10;

Console.Write(num + "->" + num3);