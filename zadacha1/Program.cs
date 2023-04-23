// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int number1 = 12, number2 = 22;
int max = number1;
if (number1 < number2) max = number2;
{
    Console.WriteLine(max);
}