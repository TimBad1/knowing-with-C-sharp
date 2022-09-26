Console.Clear();
Console.Write("Введите число ");
int N = int.Parse(Console.ReadLine());

if ( N < 10000 || N > 99999 ) {
    Console.WriteLine("Вы ввели не пятизначное число");
    return;
}

int first = (N / 10000);
int second = (N / 1000) % 10;
int fourth = (N / 10) % 10;
int fifth = N % 10;

Console.WriteLine($"first = {first}");
Console.WriteLine($"second = {second}");
Console.WriteLine($"fourth = {fourth}");
Console.WriteLine($"fifth = {fifth}");

if (( first == fifth) && (( second == fourth ))) {
    Console.WriteLine("Число палиндром");
} else {
    Console.WriteLine("Число не палиндром");
}

// string str = N.ToString();

// for ( int i = 0 ; i < (str.Length / 2) ; i++) {
//     if (str[i] != str[str.Length - 1 - i]) {
//         Console.WriteLine("Число не палиндром");
//         return;
//     }
// }


// Console.WriteLine("Число является палиндромом");
