int numeroentero, unidades, centenas, decenas,invertido;
Console.WriteLine("Digite el numero de dos cifras a invertir: ");
numeroentero = Convert.ToInt32(Console.ReadLine());
unidades = numeroentero % 10;
decenas = (numeroentero / 10) % 10;
centenas = numeroentero / 100;
    invertido = (unidades * 100) + (decenas * 10) + centenas;
Console.WriteLine("EL valor invertido es: " + invertido);