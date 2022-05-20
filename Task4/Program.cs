// Возведите число А в натуральную степень B используя цикл
Console.Clear();
Console.WriteLine("Введите число А: ");
int number = int.Parse(Console.ReadLine()?? "");
Console.WriteLine("\n" + "Введите число В: ");
uint degree = uint.Parse(Console.ReadLine()?? "");

int result = number;

for (int i = 1; i < degree; i++)
{
    result *= number;
}

Console.WriteLine($"Число {number} в степени {degree} равно {result}");
