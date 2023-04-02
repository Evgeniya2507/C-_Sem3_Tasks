/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Palindrome();

int GetInt (string argument)
{
    int x;
    System.Console.WriteLine($"Введите число {argument}");

    while (!int.TryParse(Console.ReadLine(), out x))
    {
        System.Console.WriteLine("Это не число!");
    }
    return x;
}


void Palindrome()

{
    int p = GetInt("p");
    if (p / 10000 == p % 10 && p / 1000 % 10 == p % 100 / 10)
    {
        System.Console.WriteLine($"Число {p} является палиндромом");
    }
    else
    {
        System.Console.WriteLine($"Число {p} не является палиндромом");
    }
}