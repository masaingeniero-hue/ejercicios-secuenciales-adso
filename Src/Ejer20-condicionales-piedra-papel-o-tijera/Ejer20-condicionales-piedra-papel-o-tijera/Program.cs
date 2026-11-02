using System.ComponentModel.Design;
using System.Xml.Schema;

int numero1, numero2;
Console.WriteLine("Jugador 1 Digite que va jugar (1)Piedra, (2)Papel, (3)Tijera");
numero1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Jugador 2 Digite que va jugar (1)Piedra, (2)Papel, (3)Tijera");
numero2 = Convert.ToInt32(Console.ReadLine());
if (numero1 > 3 || numero1 < 1 || numero2 > 3 || numero2 < 1)
{
    Console.WriteLine("Invalido");
}
else if (numero1 == numero2)
{
    Console.WriteLine("Empate");
}else if ( (numero1==1 && numero2==3) || (numero1==2 && numero2==1) || (numero1==3 && numero2==2))
{
    Console.WriteLine($"Gana ({numero1})");
}
else
{
    Console.WriteLine($"Gana ({numero2})");
}