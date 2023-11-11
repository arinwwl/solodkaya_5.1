Console.WriteLine("Введите массив символов из 16 элементов: ");
string input = Console.ReadLine();
char[] charArray = input.ToCharArray();
int max = 0;
int j = 0;
foreach (char c in charArray)
{

    if (Char.IsDigit(c))
    {
        j = j * 10 + (c - '0');
    }
    else
    {
        if (j > max)
        {
            max = j;
        }
        j = 0;
    }
}

if (j > max)
{
    max = j;
}

Console.WriteLine("Наибольшее целое число без учета знака: " + max);