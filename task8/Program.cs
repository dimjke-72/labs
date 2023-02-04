// Удалить вторую цифру трёхзначного числа

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int result = 0;
int digit1 = 0;
int digit2 = 0;
int digit3 = 0;
int copy = number;
if (number>99 && number<1000)
{
    digit3 = copy % 10;
    copy = copy / 10;
    digit2 = copy % 10;
    digit1 = copy / 10;
    result = digit1 * 10 + digit3;
    Console.WriteLine("Было число {0}, стало - {1}", number, result);
}
else
    Console.WriteLine("Вы ввели не трехзначное число");

