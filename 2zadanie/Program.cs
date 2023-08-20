Console.WriteLine("Введите число: ");
string str_num = Console.ReadLine();
int num = int.Parse(str_num);
int Length(int num)
{
    int rez = 0;
    while (num > 0)
    {
        num /= 10;
        rez++;
    }
    return rez;
}
int leng = Length(num);
int Summ(int num, int leng)
{
    int summ = 0;
    for (int i=0; i <= leng; i++)
    {
        summ += num % 10;
        num /= 10;
    }
    return summ;
}
Console.WriteLine($"Сумма цифр числа {num} равна {Summ(num,leng)}");