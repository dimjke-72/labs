// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

Console.WriteLine("Введите число от 10 до 99: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int digit1 = 0;
int digit2 = 0;
if (number>9 && number<100)
{
    digit1 = number / 10;
    digit2 = number % 10;
    if (digit1 == digit2)
    {
        Console.WriteLine("Цифры числа {0} - одинаковые", number);
    }
    else
    {
        if (digit1 > digit2)
        {
            Console.WriteLine("В числе {0} наибольшая цифра - {1}", number, digit1);
        }
        else
        {
            Console.WriteLine("В числе {0} наибольшая цифра - {1}", number, digit2);
        }
    }
}
else
    Console.WriteLine("Вы ввели число не из отрезка [10, 99]");

