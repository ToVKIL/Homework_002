// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("enter the number of the day of the week");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 1)
{
    Console.Write("Fatal");
}
else if (num > 7)
{
    Console.Write("Fatal");
}
else
{
    Console.Write(num);
}

if (num == 6)
{
    Console.Write(" -> Yes");
}
else if (num == 7)
{
    Console.Write(" -> Yes");
}
else
{
    Console.Write(" -> No");
}