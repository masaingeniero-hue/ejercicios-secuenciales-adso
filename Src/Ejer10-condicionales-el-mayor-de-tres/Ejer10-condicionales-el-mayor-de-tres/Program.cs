int numero1, numero2, numero3;
Console.WriteLine("Digite su primer numero:");
numero1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite su segundo numero:");
numero2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite su tercer numero:");
numero3 = Convert.ToInt32(Console.ReadLine());
if (numero1 == numero2 && numero1 == numero3)
{
    Console.WriteLine($"Su numero: {numero1} es igual a: {numero2} y {numero3}");
}
else if (numero1 >= numero2 && numero1 >= numero3)
{
    Console.WriteLine($"Su numero: {numero1} es mayor a: {numero2} y {numero3}");
}
else if (numero2 >= numero1 && numero2 >= numero3)
{
    Console.WriteLine($"Su numero: {numero2} es mayor a: {numero1} y {numero3}");
}
else
{
    Console.WriteLine($"Su numero: {numero3} es mayor a: {numero1} y {numero2}");
}