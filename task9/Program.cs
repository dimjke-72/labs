// Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.WriteLine("Введите число, которое хотите проверить на кратность: ");
int number1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число, кратность которому хотите проверить: ");
int number2 = int.Parse(Console.ReadLine() ?? "0");
int result = number1 % number2;
if (result == 0)
{
    Console.WriteLine("Число {0} кратно числу {1}", number1, number2);
}
else
    Console.WriteLine("Остаток от деления числа {0} на число {1} равен {2}", number1, number2, result);


