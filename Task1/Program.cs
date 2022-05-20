// Показать таблицу квадратов чисел от 1 до N
Console.Write("\n" + "Введите число, для построения таблицы квадратов: ");
int number = int.Parse(Console.ReadLine()?? "");
Console.WriteLine($"\n" + $"Таблица квадратов от 1 до {number}:\n");

for (int i = 0; i <= number; i++)
{
    Console.WriteLine($"Квадрат числа {i} равен {i*i}");
}

