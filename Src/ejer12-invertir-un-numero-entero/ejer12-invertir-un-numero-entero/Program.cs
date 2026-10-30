int numeroentero, digito, invertido;
Console.WriteLine("Digite el numero de dos cifras a invertir: ");
numeroentero = Convert.ToInt32(Console.ReadLine());
digito = numeroentero % 10;
invertido = digito;
numeroentero = numeroentero / 10;
digito = numeroentero % 10;
invertido = (invertido * 10) + digito;
Console.WriteLine("EL valor invertido es: "+invertido);