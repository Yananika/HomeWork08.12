double FindDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt(Math.Pow((x2 - x1), 2)+Math.Pow((y2 - y1), 2)+Math.Pow((z2 - z1), 2));
    return result;
} 
int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int x1 = EnterData("Введите координаты X1: ");
int y1 = EnterData("Введите координаты Y1: ");
int z1 = EnterData("Введите координаты Z1: ");
int x2 = EnterData("Введите координаты X2: ");
int y2 = EnterData("Введите координаты Y2: ");
int z2 = EnterData("Введите координаты Z2: ");
double result = FindDistance(x1, x2, y1, y2, z1, z2);
Console.Write($"Расстояние между точками равно {result}");
