double numero1, numero2, resultado;
Console.WriteLine("Digite su primer numero:");
numero1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite su segundo numero:");
numero2 = Convert.ToDouble(Console.ReadLine());

if (numero1>numero2)
{
    Console.WriteLine($"El numero {numero1} es mayor al numero {numero2}");
} else if (numero1==numero2)
{
    Console.WriteLine($"Los numeros {numero1} y {numero2} son iguales");
}
else
{
    Console.WriteLine($"Su numero {numero1} es menor que {numero2}");
}
