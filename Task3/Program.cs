/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

CubeNamber();

int GetInt (string argument)
{
    int x;
    System.Console.Write($"Введите число {argument}: ");

    while (!int.TryParse(Console.ReadLine(), out x))
    {
        System.Console.WriteLine("Это не число!");
    }
    return x;
}

void CubeNamber()
{
    int N = GetInt("N");
    for (int n = 1; n <= N; n++)
    {
        double result = Math.Pow(n, 3);
        System.Console.Write(result + " ");
    }
}
