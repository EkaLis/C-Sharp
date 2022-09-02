// принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

Console.WriteLine("Введите число");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number % 2 == 0)
{
    Console.WriteLine("Четное число");
}
else
{
        Console.WriteLine("Нечетное число");
}


