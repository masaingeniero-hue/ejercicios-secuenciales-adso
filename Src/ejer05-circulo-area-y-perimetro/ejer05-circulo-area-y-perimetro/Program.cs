double Radio, Perimetro, area;
Console.WriteLine("Digite el Radio de su circulo: ");
Radio = Convert.ToDouble(Console.ReadLine());
Perimetro = 2 * 3.1415 * Radio;
area = 3.1415 * Math.Pow(Radio, 2);
Console.WriteLine("El Perimetro de su circulo es: " + Perimetro + " y el area de su circulo es: " + area);