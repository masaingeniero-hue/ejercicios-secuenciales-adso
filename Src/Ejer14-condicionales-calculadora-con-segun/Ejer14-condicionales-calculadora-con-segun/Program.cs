using System.ComponentModel.Design;

double numero1, numero2, resultado;
string simbolo;
Console.WriteLine("Digite el primer numero:");
numero1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite el simbolo (+),(-),(*),(/):");
simbolo = Console.ReadLine();
Console.WriteLine("Digite el segundo numero:");
numero2 = Convert.ToDouble(Console.ReadLine());

if (simbolo == "+")
{
    resultado = numero1 + numero2;
    Console.WriteLine($"Elegiste la suma y su total es de: {resultado}");
}
else if (simbolo == "-")
{
    resultado = numero1 - numero2;
    Console.WriteLine($"Elegiste la resta y su total es de: {resultado}");
}
else if (simbolo == "*")
{
    resultado = numero1 * numero2;
    Console.WriteLine($"Elegiste la multiplicacion y su total es de: {resultado}");
}
else if (simbolo == "/")
{
    if (numero2 != 0)
    {
        resultado = numero1 / numero2;
        Console.WriteLine($"Elegiste la division y su total es de: {resultado}");
    }
    else
    {
        Console.WriteLine("Imposible dividir por cero(0)");
    }
 } 