Console.WriteLine("Введите день недели от 1 до 7:");
int a = int.Parse(Console.ReadLine());

if (a < 6)
{
    Console.WriteLine(a + " -> Это будни");
}
else if (a > 7)
{
    Console.WriteLine("Введите день недели от 1 до 7");
}
else
{
    Console.WriteLine(a + " -> Это выходной");
}