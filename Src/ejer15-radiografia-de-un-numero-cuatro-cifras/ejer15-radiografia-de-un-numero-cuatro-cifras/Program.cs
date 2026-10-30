int numeroentero, unidades, centenas, decenas,millares;
Console.WriteLine("Digite el numero de dos cifras a invertir: ");
numeroentero = Convert.ToInt32(Console.ReadLine());
unidades = numeroentero % 10;
decenas = (numeroentero / 10) % 10;
centenas = (numeroentero / 100) % 10;
millares = numeroentero / 1000;

Console.WriteLine("EL numero divido en millares, centenas, decenas y unidades: " +millares+", "+centenas+", "+decenas+", "+unidades);