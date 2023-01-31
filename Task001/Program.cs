/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

int SecondDigit(int number)
{
   int result = Math.Abs((number / 10) % 10);
    return result;
}

 if(Math.Abs(number) > 999 || Math.Abs(number) < 100) 
    {
        Console.WriteLine("Данное число не является трехзначным");
    }
else 
{
  int second = SecondDigit(number);
Console.WriteLine($"Вторая цифра числа {number}: {second}");  
}

