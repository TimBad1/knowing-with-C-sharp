Console.Clear();
Console.Write("Введите число ");
int N = int.Parse(Console.ReadLine());

for(int i=1;i<=N;i++){
    Console.Write($"{Math.Pow(i, 2)} ");
}
Console.WriteLine("");