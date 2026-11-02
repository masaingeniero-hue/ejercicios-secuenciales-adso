int edad,resultado;
Console.WriteLine("Digite su edad:");
edad = Convert.ToInt32(Console.ReadLine());

if (edad <= 12 )
{
    Console.WriteLine("El valor de su boleta es de: $8.000");
} else if (edad > 12)
{
    if (edad <= 59)
    {
        Console.WriteLine("El valor de su boleta es de: $12.000");
    }
    else
    {
        Console.WriteLine("El valor de su boleta es de $9.000");
    }
}
