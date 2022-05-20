// Показать кубы чисел, заканчивающихся на четную цифру
// Это решение, если куб числа четное число
/*  
Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()?? "");

Console.WriteLine();
for (int i = 1; i <= number; i++)
{
    int cubeNumber = (int)Math.Pow(i,3);
    if(cubeNumber%10%2 == 0) Console.WriteLine(cubeNumber);
}
*/
// Это решение. Если введеное число четное, то показать его куб
Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()?? "");

Console.WriteLine();
if(number%2 == 0) Console.WriteLine($"Куб четного числа {number} равен {Math.Pow(number,3)}");
else Console.WriteLine("Введенное число не четное.");