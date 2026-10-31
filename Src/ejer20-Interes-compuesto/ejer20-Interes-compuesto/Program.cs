double capitalinicial, tasainteresmensual, numeromeses, capitalfinal, interesesganados;
Console.WriteLine("Digite la capital inicial: ");
capitalinicial = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite el porcentaje de interes mensual: ");
tasainteresmensual = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite numero de meses: ");
numeromeses = Convert.ToDouble(Console.ReadLine());

capitalfinal = capitalinicial * Math.Pow((1 + tasainteresmensual / 100), numeromeses);
interesesganados = capitalfinal - capitalinicial;

/*Console.WriteLine(capitalfinal);
Console.WriteLine(capitalinicial);
Console.WriteLine(tasainteresmensual);
Console.WriteLine(numeromeses);*/

Console.WriteLine($"La capital final fueron de: {capitalfinal} con interes ganados de: {interesesganados}");