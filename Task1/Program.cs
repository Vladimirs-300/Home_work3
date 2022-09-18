// Задача 1
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Не использовать строки!

// 14212 -> нет
// 12821 -> да
// 23432 -> да

int ReverseNumber(int number)
{
    int result = 0;
    while (number > 0)
    {
        result = result * 10 + number % 10;
        number = number / 10;
    }
    return result;
}
bool IsPalindrome(int number)
{
    int reverse = ReverseNumber(number);
    return reverse == number;
}
int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(System.Console.ReadLine());
}
int number = Prompt("Введите 5ти зачное число -> ");
System.Console.WriteLine("Ответ -> ");
if (IsPalindrome(number))
{
    System.Console.WriteLine($"Введите число - {number} - является палиндромом");
}
else
{
    System.Console.WriteLine($"Число {number} не является палиндромом");
}
System.Console.WriteLine();