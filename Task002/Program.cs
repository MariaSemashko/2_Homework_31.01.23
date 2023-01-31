/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
*/

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int ThirdDigit(int number)
{
    int result = Math.Abs(number % 10); //Ввожу модуль, чтобы программа работала с отрицательными числами
    return result; 
}

if(Math.Abs(number) < 100) 
    {
        Console.WriteLine("Третьей цифры нет");
    }
else 
{
    while (Math.Abs(number) >= 999) //Ввожу цикл while, чтобы программа работала с четырехзначными и более числами
    {
        number = number / 10;
    }
    int third = ThirdDigit(number);
    Console.WriteLine($"Третья цифра: {third}");  
}

