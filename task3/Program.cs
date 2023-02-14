// Написать программу копирования массива
void FillArr(int[] arr)
{
    Console.Write("Оригинальный массив: ");
    for(int i  = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0,100);
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine("");
}
void CopyArr(int[] arr)
{
    int[] newarr = new int[arr.Length];
    Console.Write("Копия массива: ");
    for(int i = 0; i < arr.Length; i++)
    {
        newarr[i] = arr[i];
        Console.Write($"{newarr[i]} ");
    }
    Console.WriteLine("");
}

Console.WriteLine("Введите длину массива");
int arrlength = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int[arrlength];
FillArr(array);
CopyArr(array);