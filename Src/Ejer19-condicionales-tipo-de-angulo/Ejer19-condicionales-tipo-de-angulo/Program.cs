int angulo;
Console.WriteLine("Digite su angulo en un rango de (0 y 180)");
angulo = Convert.ToInt32(Console.ReadLine());

if (angulo<0 || angulo>180)
{
    Console.WriteLine("VALOR DE ANGULO INCORRECTO");
} else if (angulo==90)
{
    Console.WriteLine("Angulo Recto");
}else if (angulo<90)
{
    Console.WriteLine("Angulo Agudo");
}
else
{
    Console.WriteLine("Angulo Obtuso");
}