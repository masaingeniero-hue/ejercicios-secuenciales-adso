double nota1, nota2, nota3, promedio;
Console.WriteLine("Digite la nota 1:");
nota1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite la nota 2:");
nota2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite la nota 3:");
nota3 = Convert.ToDouble(Console.ReadLine());

promedio = nota1 * 0.25 + nota2 * 0.35 + nota3 * 0.40;

Console.WriteLine($"Su nota promedio es de {promedio}");