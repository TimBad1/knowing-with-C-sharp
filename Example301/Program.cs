Console.Clear();

Console.Write("Введите х ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите y ");
int y = int.Parse(Console.ReadLine());

if ( x == 0 ) {
    Console.WriteLine("У расположена на оси Х");
    return;
}


if ( y == 0 ) {
    Console.WriteLine("X расположена на оси Y");
    return;
}

if( x > 0 && y > 0 ) {
    Console.WriteLine("1 четверть");
    return;
}

if( x < 0 && y > 0 ) {
    Console.WriteLine("2 четверть");
    return;
}

if( x < 0 && y < 0) {
    Console.WriteLine("3 четверть");
    return;
}

if( x > 0 && y < 0) {
    Console.WriteLine("4 четверть");
    return;
}
