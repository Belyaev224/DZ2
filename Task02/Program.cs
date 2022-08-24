Console.WriteLine("Введите 3х значное число:");
int a = int.Parse(Console.ReadLine());

if (a > 99)
{
    Console.WriteLine(a + " -> " + a % 10);
}
else
{   
    Console.WriteLine(a + " ->" + " третьей цифры нет");
}
