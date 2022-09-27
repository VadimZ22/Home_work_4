
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
Console.Write("Введите степень числа: ");
int exponent = int.Parse(Console.ReadLine()!);

int result = Power(number, exponent);
Console.WriteLine(result);




int Power(int num, int exp)
{
    int res = 1;
    for (int i = 0; i < exp; i++)
        res *= num;
    return res;
}


