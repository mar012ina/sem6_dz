// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223 -> 4


Console.Write($"Введите количество чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
void InputNumb(int n)
{

    for (int i = 0; i < n; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count += 1;
    }
    return count;
}

InputNumb(n);

Console.WriteLine($"Введено чисел больше 0: {CountPositiveNumbers(array)} ");


// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Intersection(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    if(k1 == k2) Console.WriteLine("Прямые параллельны!");
    else Console.WriteLine($"Точка пересечения: ({x};{y})");
}

Console.Write("Введите b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

Intersection(b1, k1, b2, k2);