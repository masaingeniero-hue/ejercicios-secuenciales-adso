int a, b;
Console.WriteLine("Digite el valor de A");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite el valor de b");
b = Convert.ToInt32(Console.ReadLine());

a = a + b;
b = a - b;
a = a - b;

Console.WriteLine($"El valor original de A ahora es {a}");
Console.WriteLine($"El valor original de B ahora es {b}");