// Показать последнюю цифру трёхзначного числа

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int result = 0;
if (number>99 && number<1000)
{
    result = number % 10;
    Console.WriteLine("Последняя цифра числа {0} - {1}", number, result);
}
else
    Console.WriteLine("Вы ввели не трехзначное число");
