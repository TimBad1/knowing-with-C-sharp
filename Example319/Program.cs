Console.Clear();
Console.Write("Введите число ");
int N = int.Parse(Console.ReadLine());

if (N < 10000 || N > 99999) {
    Console.WriteLine("Вы ввели не пятизначное число");
    return;
}

string str = N.ToString();

for ( int i = 0 ; i < (str.Length / 2) ; i++) {
    if (str[i] != str[str.Length - 1 - i]) {
        Console.WriteLine("Число не палиндром");
        return;
    }
}

Console.WriteLine("Число является палиндромом");
