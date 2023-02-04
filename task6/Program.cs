// Показать вторую цифру трёхзначного числа

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int result = 0;
int copy = number;
if (copy>99 && copy<1000)
{
    copy = copy / 10;
    result = copy % 10;
    Console.WriteLine("Вторая цифра числа {0} - {1}", number, result);
}
else
    Console.WriteLine("Вы ввели не трехзначное число");
