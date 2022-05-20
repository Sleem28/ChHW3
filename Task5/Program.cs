//Подсчитать сумму цифр в числе
// Все как вы любите. Никаких string.length  и т.д.
Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()?? "");
int sumDigits = 0;

while(true)
{
    sumDigits += number%10;
    if(number < 10) break;
    number /= 10;
}

Console.WriteLine("Сумма цифр введенного числа равна " + sumDigits);