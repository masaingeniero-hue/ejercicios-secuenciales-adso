int numero1;
Console.WriteLine("Digite su numero:");
numero1 = Convert.ToInt32(Console.ReadLine());


if (numero1>0)
{
    Console.WriteLine($"Su numero {numero1} es positivo");
} else if (numero1==0)
{
    Console.WriteLine($"Su numero {numero1} es cero");
}
else
{
    Console.WriteLine($"Su numero {numero1} es negativo");
}