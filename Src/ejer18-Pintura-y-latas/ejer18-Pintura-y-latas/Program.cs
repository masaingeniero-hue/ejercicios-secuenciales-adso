using System.Security.Cryptography;

double metroscuadrados, rendimiento, litrosporlata, rendimientoporlata, latasusasdas, litrossueltos;
Console.WriteLine("Digite la cantidad de metros cuadrados a pintar: ");
metroscuadrados = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite el valor de rendimiento (metrocuadrado/litro)");
rendimiento = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite la cantidad de litros por lata de pintura: ");
litrosporlata = Convert.ToDouble(Console.ReadLine());
rendimientoporlata = metroscuadrados / rendimiento;
latasusasdas = rendimientoporlata / litrosporlata;
litrossueltos = latasusasdas % 2;
/*Console.WriteLine(metroscuadrados);
Console.WriteLine(rendimiento);
Console.WriteLine(litrosporlata);
Console.WriteLine(rendimientoporlata);
Console.WriteLine(latasusasdas);
Console.WriteLine(litrossueltos);*/
Console.WriteLine($"Los metros cuadrados a pintar son: {metroscuadrados}, el rendimiento es de: {rendimiento}(metroscuadrados/litro). La cantidad de litros por lata de pintura son: {litrosporlata}. Entonces usaste: {latasusasdas} latas de pintura y te sobraron {litrossueltos}.");