// принимает на вход три числа и выдаёт максимальное из этих чисел. Вариант 2

Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());
int max = firstNumber;

if(firstNumber < secondNumber)
{
    max=secondNumber;
}
if(max < thirdNumber)
{
    Console.WriteLine(thirdNumber);
}
else 
{
    Console.WriteLine(max);
}

