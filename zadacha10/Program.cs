// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100 | num > 999)
{
    Console.WriteLine("Ваше число не трехзначное");
    return;
}
else num = num / 10 % 10;
    Console.WriteLine(num);
