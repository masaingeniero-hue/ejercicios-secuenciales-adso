double numero, resultado;
Console.WriteLine("Digite su numero: ");
numero = Convert.ToDouble(Console.ReadLine());

resultado = numero % 2;

if (resultado==0)
{
    Console.WriteLine($"Su numero {numero} es par" );
}
else
{
    Console.WriteLine($"Su numero {numero} es impar");
}
