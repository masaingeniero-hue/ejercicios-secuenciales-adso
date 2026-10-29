double c, f,k;
Console.WriteLine("Ingrese sus grados en Celsius: ");
c = Convert.ToDouble(Console.ReadLine());
f = (c * 9 / 5) + 32;
k = (c + 273.15);
Console.WriteLine("Sus grados de Celsius: "+c+" a Fahrenheit son: " +f+" y a kelvin son: "+k);