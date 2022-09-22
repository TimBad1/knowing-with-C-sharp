Console.Clear();

Console.Write("Введите первое число ");
int firstNumber = int.Parse(Console.ReadLine());

Console.Write("Введите второе число ");
int secondNumber = int.Parse(Console.ReadLine());

if (firstNumber == Convert.ToInt32(Math.Pow(secondNumber, 2)))
{
    Console.Write($"Первое число {firstNumber} является квадратом {secondNumber}");
} else {
    Console.Write($"Первое число {firstNumber} не является квадратом {secondNumber}");
}
