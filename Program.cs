// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет

Console.WriteLine("Введите число от 1 до 7 :");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void WorkHoliday(int dayNumber)
{
    if ( dayNumber > 0 && dayNumber < 8 )
     
         
        if ( dayNumber == 6 || dayNumber == 7 )
        {
            Console.WriteLine("Этот день выходной");

        }
        else
        {
            Console.WriteLine("Этот день рабочий");
        }
}
WorkHoliday(dayNumber);


