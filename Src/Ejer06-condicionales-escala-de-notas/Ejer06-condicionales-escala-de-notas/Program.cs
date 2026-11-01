double nota;

Console.WriteLine("Digite la definitiva del estudiante (5.0): ");
nota = Convert.ToDouble(Console.ReadLine());

if (nota >= 4.5)
{
    Console.WriteLine($"Tienes una nota de {nota}. Tienes (Desempeño alto)");
}
else if (nota>=4.0)
{
    Console.WriteLine($"Tines una nota de {nota} y estas (Aprobado)");
}
/*else if (nota >= 3.0)
{
    Console.WriteLine($"Tienes una nota de {nota} y estas (En riesgo)");
}*/
else
{
    Console.WriteLine($"Tienes una nota de {nota} y estas (No aprobado)");
}