using System.Xml.XPath;

double valor, resultado=0, total;
Console.WriteLine("Digite el valor de su factura: ");
valor = Convert.ToInt32(Console.ReadLine());

if (valor >= 200000)
{
    resultado = 0.15 * valor;
    Console.WriteLine($"Su valor de: {valor} aplica un descuento del 15% por lo tanto su descuento es de: {resultado}");
} else if (valor >=100000)
{
    resultado = 0.10 * valor;
    Console.WriteLine($"Su valor de: {valor} aplica un descuento del 10% por lo tanto su descuento es de: {resultado}");
} else if (valor >=50000)
{
    resultado = 0.05 * valor;
    Console.WriteLine($"Su valor de: {valor} aplica un descuento del 5% por lo tanto su descuento es de: {resultado}");
}
else
{
    Console.WriteLine($"Su valor de: {valor} por lo cual no aplica un descuento");
}
total = valor - resultado;
Console.WriteLine($"El total de su factura es de: {total}");