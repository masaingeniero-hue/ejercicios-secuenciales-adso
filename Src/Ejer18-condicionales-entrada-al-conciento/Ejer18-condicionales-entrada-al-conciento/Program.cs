int edad;
string respuesta;

Console.WriteLine("Digite su edad:");
edad = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite su repuesta (S/N):");
respuesta = Console.ReadLine();

if (edad >= 18 && respuesta=="S")
{
    Console.WriteLine("Entras");
}else if (edad<18)
{
    Console.WriteLine("menor");
}
else
{
    Console.WriteLine("sin boleta");
}