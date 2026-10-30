double costofabricacion, precioventa,unidadesvendidas, gananciatotal, rentabilidad;
Console.WriteLine("Digite cuanto gasto en la fabricacion: ");
costofabricacion =Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digita el valor al que lo vas a vender: ");
precioventa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Cuantas unidades vendio: ");
unidadesvendidas = Convert.ToDouble(Console.ReadLine());
gananciatotal = (precioventa- costofabricacion) * unidadesvendidas;
//Console.WriteLine(gananciatotal);
rentabilidad = (gananciatotal / costofabricacion)*0.100;
//Console.WriteLine(rentabilidad+"%");
Console.WriteLine("La ganancia total es de: "+gananciatotal+" y su rentabilidad es del: "+rentabilidad+"%");




