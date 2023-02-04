// Найти третью цифру числа или сообщить, что её нет

// !!задача выполнена при условии, что ищу в числе третью цифру слева

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int result = 0;
int copy = number;
while (copy > 1000)
{
    copy = copy / 10;
    result = copy % 10;
}
if (result == 0)
    Console.WriteLine("В числе нет третьей цифры");
else
    Console.WriteLine("Третья цифра числа {0} - {1}", number, result);