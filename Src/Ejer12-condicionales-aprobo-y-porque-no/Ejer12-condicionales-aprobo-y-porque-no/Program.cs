double nota, inasistencias;
Console.WriteLine("Digite la nota del estudiante: ");
nota = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite las inasistencias del estudiante: ");
inasistencias = Convert.ToDouble(Console.ReadLine());

if (nota >= 4.0 && inasistencias <= 3)
{
    Console.WriteLine($"El estudiante con nota: {nota} y inasistencias totales como: {inasistencias} (Aprobo)");
}
else if (nota < 4.0)
{
    Console.WriteLine($"El estudiante con nota: {nota} y inasistencias totales como: {inasistencias} (No aprobo por nota)");
}
else
{
    Console.WriteLine($"El estudiante con nota: {nota} y inasistencias totales como: {inasistencias} (No aprobo por inasistencias)");
}