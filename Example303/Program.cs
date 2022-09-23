Console.Clear();

Console.WriteLine("Введите положение первой точки");
Console.Write("х = ");
double xa = double.Parse(Console.ReadLine());
Console.Write("y = ");
double ya = double.Parse(Console.ReadLine());

Console.WriteLine("Введите положение второй точки");
Console.Write("х = ");
double xb = double.Parse(Console.ReadLine());
Console.Write("y = ");
double yb = double.Parse(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2));

Console.WriteLine($"расстояние между точками {distance:f2}");
Console.WriteLine($"расстояние между точками {Math.Round(distance, 2)}");
Console.WriteLine($"расстояние между точками {distance.ToString("0.00")}");