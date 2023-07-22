/* Задача 27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Пример:
452 -> 11
82 -> 10
9012 -> 12

*/

Console.Write("Введите число: ");
string numbers = Console.ReadLine();

int SumNumbersInNumber(int num)
{
    int sum = 0;
    while (num != 0)
    {
        sum = sum + (num % 10);
        num = num / 10;
    }
    return sum;
}

void ExceptionHandling(string enterA)
{
    bool yesInt = int.TryParse(enterA, out int result);

    if (yesInt && result >= 0) // Непонятно, что делать с отрицательными числами и 0 =(
    {
        int sumResult = SumNumbersInNumber(result);
        Console.WriteLine("Сумма цифр числа {0} = {1}",
                          result, sumResult);
    }
    else
    {
        Console.WriteLine("{0} -> Некорректный ввод!", numbers);
    }
}

ExceptionHandling(numbers);