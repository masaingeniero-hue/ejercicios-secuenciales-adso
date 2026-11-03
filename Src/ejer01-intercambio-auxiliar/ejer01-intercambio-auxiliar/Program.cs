int a, b, c;
Console.WriteLine("Digite el valor de A");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite el valor de B");
b = Convert.ToInt32(Console.ReadLine());

c = a;
a = b;
b = c;

Console.WriteLine($"el valor original de A ahora es {a}");
Console.WriteLine($"el valor original de B y ahora es {b}");