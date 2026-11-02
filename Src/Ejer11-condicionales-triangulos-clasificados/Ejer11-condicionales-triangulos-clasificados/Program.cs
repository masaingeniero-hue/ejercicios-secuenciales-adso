int numero1,numero2,numero3;
Console.WriteLine("Digite su primer numero:");
numero1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite su segundo numero:");
numero2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite su tercer numero:");
numero3 = Convert.ToInt32(Console.ReadLine());
if (numero1==numero2 && numero1==numero3)
{
    Console.WriteLine($"Su Triangulo de lados {numero1},{numero2},{numero3} es (Equilatero)");
}else if (numero1 == numero2 && numero1!=numero3)
{
    Console.WriteLine($"Su Triangulo de lados {numero1},{numero2},{numero3} es (Isosceles)");
}
else
{
    Console.WriteLine($"Su Triangulo de lados {numero1},{numero2},{numero3} es (Escaleno)");
}