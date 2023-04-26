// на входе целое или вещественное число, надо удалить вторую цифру слева этого числа.

// 145 -> 15
// 1 -> нет
// 567,123 -> 57,123
Console.WriteLine("Введите число");
double num = Convert.ToDouble(Console.ReadLine());
int i = Convert.ToInt32(num);
double raz = num - i;
if (num < 10)
{
    Console.WriteLine("второй цифры нет");
    return;
}
int count = 0;
int i2 = Convert.ToInt32(i);
while (i2 > 0)
{
    count++;
    i2 = i2 / 10;
}
int res = i / Convert.ToInt32(Math.Pow(10, count - 1)) * Convert.ToInt32(Math.Pow(10, count - 2)) + i % (Convert.ToInt32(Math.Pow(10, count - 2)));
// это то что я не мог понять на семинаре, пересмотрел и понял)
num = res + raz;
Console.WriteLine(num);
//возможно есть лишние переменные, но все работает 
// но почемуто когда я отделяю остаток у дабла он добавляет лишние цифры,не знаю как пофиксить
