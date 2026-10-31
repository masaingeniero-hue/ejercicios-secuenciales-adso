double velocidad1, velocidad2, distancia ,tiempofinal, distanciarecorrida1, distanciarecorrida2;
Console.WriteLine("Digite la velocidad de su primer coche en (Kilometros/Hora): ");
velocidad1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite la velocidad de su segundo coche en (Kilometros/Hora): ");
velocidad2 = Convert.ToDouble(Console.ReadLine()); 
Console.WriteLine("Digite a que distancia se encuentran el uno del otro en (Metros)");
distancia = Convert.ToDouble(Console.ReadLine());

tiempofinal = distancia / (velocidad1 + velocidad2);
distanciarecorrida1 = velocidad1 * tiempofinal;
distanciarecorrida2 = distancia - distanciarecorrida1;

/*Console.WriteLine(velocidad1);
Console.WriteLine(velocidad2);
Console.WriteLine(distancia);
Console.WriteLine(tiempofinal);*/

Console.WriteLine($"El tiempo de recorrido fue de: {tiempofinal} y la distancia recorrida del primer coche es de: {distanciarecorrida1} y del segundo coche es de: {distanciarecorrida2}");