Console.Clear();
Console.Write("Введите число: ");
string strNumber = Console.ReadLine();
int sum = SumNumbers(strNumber);
Console.WriteLine(sum);



int SumNumbers(string num)
{
    int number = Math.Abs(int.Parse(num));
    num = number.ToString();
    int len = num.Length;
    int result = 0;
    for (int i = 0; i < len; i++)
        result = result + (int)Char.GetNumericValue(num[i]);
    return result;
}