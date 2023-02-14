// Написать программу масштабирования фигуры
void ScalingFigure(string strcoords, double mult)
{
    char[] separators = new char[] { ' ', ',', '(', ')' };
    string[] subs = strcoords.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    double[] doublecoords = new double[subs.Length];
    for(int i = 0; i < subs.Length; i++)
    {
        doublecoords[i] = Convert.ToDouble(subs[i]);
        doublecoords[i] = doublecoords[i] * mult;
    }
    Console.WriteLine("");
    Console.Write($"Новые координаты фигуры: ");
    for(int i = 0; i < doublecoords.Length; i++)
    {
        Console.Write($"({doublecoords[i]},{doublecoords[i+1]}) ");
        i++;
    }
}
Console.WriteLine("Введите координаты фигуры одной строкой");
string coords1 = Console.ReadLine () ?? "0";
Console.WriteLine("Введите коэффициент масштабирования");
double mult1 = double.Parse(Console.ReadLine() ?? "0");
ScalingFigure(coords1, mult1);