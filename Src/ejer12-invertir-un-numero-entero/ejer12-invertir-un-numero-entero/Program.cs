int numeroentero, unidades,decenas, invertido;
Console.WriteLine("Digite el numero de dos cifras a invertir: ");
numeroentero = Convert.ToInt32(Console.ReadLine());
unidades = numeroentero % 10;
decenas = (numeroentero / 10) % 10;
invertido = (unidades*10)+decenas;
Console.WriteLine("EL valor invertido es: "+invertido);