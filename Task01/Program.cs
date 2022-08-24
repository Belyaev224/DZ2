int num = new Random().Next(100, 999);

int a1 = num % 100; // убирает первую цифру
int a2 = a1 / 10;   // убирает последнюю цифру

Console.WriteLine(num + " -> " + a2);
