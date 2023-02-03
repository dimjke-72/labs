// По двум заданным числам проверять является ли первое квадратом второго

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine() ?? "0");
if (num2 * num2 == num1)
     Console.WriteLine("Число " + num1 + " является квадратом числа " + num2);
else
    Console.WriteLine("Число {0} не является квадратом числа {1}", num1, num2);
