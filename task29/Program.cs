Console.Clear();
int[] array = CreateArray();
PrintArray(array);




int[] CreateArray()
{
    int[] arr = new int[8];
    Random rand = new Random();
    for (int i = 0; i < 8; i++)
    {
        arr[i] = rand.Next(0, 100);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    int count = arr.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        Console.Write(arr[i]);
        if (i == count - 1)            
            Console.WriteLine("]");
        else
            Console.Write(", ");
    }
    Console.WriteLine();
}