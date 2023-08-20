int[] random_array = new int[8];
Console.Write("[");
for (int i = 0; i < 8; i++)
{
    random_array[i] = new Random().Next(1,99);
    if (i<7)
    Console.Write($"{random_array[i]},");
    else
    Console.Write($"{random_array[i]}");
}
Console.Write("]");