int hora;
Console.WriteLine("Digite la hora en formato de 24h (0 a 23)");
hora = Convert.ToInt32(Console.ReadLine());

if (hora > 24 || hora < 0)
{
    Console.WriteLine("¡Hora invalida!");
}
else if (hora <= 5)
{
    Console.WriteLine("Buenas noches, Madrugada");
}
else if (hora <= 12)
{
    Console.WriteLine("Buenas dias");
}
else if (hora <= 18)
{
    Console.WriteLine("Buenas tardes");
}
else
{
    Console.WriteLine("Buenas noches");
}