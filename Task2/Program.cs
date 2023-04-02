/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Length3D();

int ReadInt (string argument)
{
    int x;
    System.Console.Write($"Введите число {argument}: ");

    while (!int.TryParse(Console.ReadLine(), out x))
    {
        System.Console.WriteLine("Это не число!");
    }
    return x;
}

double LineSigment()
{
    int xA = ReadInt("xA");
    int yA = ReadInt("yA");
    int zA = ReadInt("zA");
    int xB = ReadInt("xB");
    int yB = ReadInt("yB");
    int zB = ReadInt("zB");

    double result = Math.Round(Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA - zB, 2)), 2);
    return result;
}

void Length3D()
{
    double L = LineSigment();
    System.Console.WriteLine($"Расстояние между точками в 3D = {L}");
}
