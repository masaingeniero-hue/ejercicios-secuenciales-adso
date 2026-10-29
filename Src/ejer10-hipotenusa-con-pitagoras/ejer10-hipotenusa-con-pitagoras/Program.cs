double catetoAdyacente, catetoOpuesto, hipotenusa;
Console.WriteLine("Digite el catetoAdyacente: ");
catetoAdyacente = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite el catetoOpuesto: ");
catetoOpuesto = Convert.ToDouble(Console.ReadLine());
hipotenusa = Math.Sqrt(Math.Pow(catetoAdyacente, 2) + Math.Pow(catetoOpuesto, 2));
Console.WriteLine("La hipotenusa para su catetoAdyacente: "+catetoAdyacente+" y su catetoOpuesto: "+catetoOpuesto+" es: "+hipotenusa);