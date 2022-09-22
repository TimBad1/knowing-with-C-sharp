Console.Clear();

Console.Write("Введите число ");
int N = int.Parse(Console.ReadLine());

int number = Math.Abs(N);

for (int i = number * (-1); i <= number; i++) {
    Console.Write($"{i} ");
}
Console.WriteLine("");