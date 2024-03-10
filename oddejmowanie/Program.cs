/*for (int a = 10; a >= -99; a--)
{
    for (int b = 10; a <= b;)
    {
        Console.Write(b + ",");
        b = b - 1;
    }
    Console.WriteLine();
}*/
int b = 10;
int a = 10;
while ( a >= -99 )
{
    a--;
    while ( a <= b)
    {
        Console.Write(b + ",");
        b --;
    }
    Console.WriteLine();
}