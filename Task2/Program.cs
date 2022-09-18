// Задача 2

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(System.Console.ReadLine());
}
int x1 = Prompt("x1 -> ");
int y1 = Prompt("y1 -> ");
int z1 = Prompt("z1 -> ");
int x2 = Prompt("x2 -> ");
int y2 = Prompt("y2 -> ");
int z2 = Prompt("z2 -> ");

double Decision(double x1, double x2,
                double y1, double y2,
                double z1, double z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
}
double segmentLength = Math.Round(Decision(x1, x2, y1, y2, z1, z2), 2);
Console.Write($"Длина отрезка  {segmentLength}");