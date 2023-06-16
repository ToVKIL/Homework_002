// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int num2 = num % 10;

if (num2 > 0)
{
    Console.Write("The third digit: " + num2);
}
else{
    Console.Write("There is no third digit");
}