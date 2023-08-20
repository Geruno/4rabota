Console.WriteLine("Введите первое число: ");
string str_num_1 = Console.ReadLine();
int num_1 = int.Parse(str_num_1);
Console.WriteLine("Введите второе число: ");
string str_num_2 = Console.ReadLine();
int num_2 = int.Parse(str_num_2);
int Vozvedenie(int num_1, int num_2)
{
    int rez = 1;
    for(int i=1; i<=num_2; i++)
    {
        rez = rez * num_1;
    }
    return rez;
}
int vozved = Vozvedenie(num_1, num_2);
Console.WriteLine($"{vozved}");