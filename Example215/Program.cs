Console.Clear();

Console.Write("Порядковый номер дня недели ");
int day = Math.Abs(int.Parse(Console.ReadLine()));

if (day > 7) {
    Console.WriteLine("Нет дня недели с таким номером");
    return;
}

if (day > 5) {
    Console.WriteLine("Выходной");
    return;
}

Console.WriteLine("Рабочий");
