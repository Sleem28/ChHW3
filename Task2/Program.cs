// Найти кубы чисел от 1 до N
Console.Clear();
Console.Write("Найти кубы чисел от 1 до N.\n" + "Введите число N: ");
int number = int.Parse(Console.ReadLine() ?? "");

var intCubeValues = new Dictionary<int, int>(); // Сделал коллекцию для кубов, просьба не ругаться

for (int i = 0; i <= number; i++)
{
    intCubeValues.Add(i, (int)Math.Pow(i, 3));
}
Console.WriteLine("Кубы посчитаны!!!\n");

Console.WriteLine("Вы хотите посмотреть таблицу кубов? Если да, то нажмите 'y' и Enter. Если нет, нажмите любую клавишу и Enter.");
string printing = Console.ReadLine()?? "";

if(printing.Equals("y"))DictionaryPrint(intCubeValues);
else Console.WriteLine("Ну нет, так нет.");

//Функция вывода коллекции на экран
void DictionaryPrint(Dictionary<int,int> dictionary)
{
    if(dictionary.Count != number+1){Console.WriteLine("Размер словаря не равен введенному числу!!!"); return;}
    
    for (int i = 1; i <= number;i++)
    {
        Console.WriteLine($"Куб числа {i} равен {dictionary[i]}");
    }
}
