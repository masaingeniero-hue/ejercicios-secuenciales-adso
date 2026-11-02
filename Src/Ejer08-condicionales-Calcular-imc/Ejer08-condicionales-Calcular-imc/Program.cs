double peso, altura, imc;
Console.WriteLine("Digite su peso:");
peso = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite su altura:");
altura = Convert.ToDouble(Console.ReadLine());
imc = peso / Math.Pow(altura, 2);

//Console.WriteLine(imc);
if (imc < 18.5)
{
    Console.WriteLine($"Su peso es de: {peso} y su altura de: {altura} por lo cual su IMC es de: {imc} y estas (Bajo peso)");
} else if (imc < 25)
{
    Console.WriteLine($"Su peso es de: {peso} y su altura de: {altura} por lo cual su IMC es de: {imc} y estas (Normal)");
}
else
{
    Console.WriteLine($"Su peso es de: {peso} y su altura de: {altura} por lo cual su IMC es de: {imc} y estas (Sobrepeso)");
}

