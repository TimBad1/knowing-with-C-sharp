
int[] array = GetBinaryArr(8);

int[] GetBinaryArr(int length) {
    int[] arr = new int[length];
    for(int i = 0; i < length; i++) {
        arr[i] = new Random().Next(2);
    }

    return arr;
}

Console.WriteLine($"[{String.Join(",", array)}]");
