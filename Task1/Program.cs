/* Задача 25 Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
Прмер:
3, 5 -> 243 (3⁵)
2, 4 -> 16

*/

Console.Write("Введите число А: ");
string a = Console.ReadLine()!;

Console.Write("Введите число B: ");
string b = Console.ReadLine()!;

int degreeResult;

int RaiseToADegree(int number, int degreeOfNumber)
{
    int degree = 1;
    for (int i = 0; i < degreeOfNumber; i++)
    {
        degree *= number;
    }
    return degree;
}

bool LetterInNumbers(string let)
{
    int n = let.Length;

    for (int i = 0; i < n; i++)
    {
        if (!Char.IsDigit(let[i]) || int.Parse(let) == 0)
        {
            return false;
        }
    }
    return true;
}

if (LetterInNumbers(a) && LetterInNumbers(b))
{
    int aInt = int.Parse(a);
    int bInt = int.Parse(b);
    degreeResult = RaiseToADegree(aInt, bInt);
    Console.WriteLine("{0} в степени {1} = {2}", aInt, bInt, degreeResult);
}
else Console.WriteLine("{0}, {1} -> Некорректный ввод!\nВедите цисла от 1 или равные 1", a, b);