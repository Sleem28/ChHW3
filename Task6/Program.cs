// Показать кубы чисел, заканчивающихся на четную цифру
Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()?? "");

Console.WriteLine();
for (int i = 1; i <= number; i++)
{
    int cubeNumber = (int)Math.Pow(i,3);
    if(cubeNumber%10%2 == 0) Console.WriteLine(cubeNumber);
}
