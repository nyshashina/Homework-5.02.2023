// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
void IntersectionPoint(double k1, double k2, double b1, double b2)
{
    double coordX = (b2 - b1) / (k1 - k2);
    double coordY = k1 * coordX + b1;
    Console.WriteLine($"Точка пересечения этих прямых задана координатами ({coordX},{coordY})");
}

Console.WriteLine("Введите угловой коэффициент первой прямой");
double numberk1 = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите угловой коэффициент второй прямой");
double numberk2 = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите точку пересечения первой прямой с осью y");
double numberb1 = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите точку пересечения второй прямой с осью y");
double numberb2 = double.Parse(Console.ReadLine() ?? "0");

IntersectionPoint(numberk1, numberk2, numberb1, numberb2);