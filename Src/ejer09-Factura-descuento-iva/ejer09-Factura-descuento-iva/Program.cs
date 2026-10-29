double subtotal, descuento, iva, total;
Console.WriteLine("Digite el subtotal de su factura: ");
subtotal = Convert.ToDouble(Console.ReadLine());
descuento = subtotal * 0.10;
iva = descuento * 0.19;
total = subtotal - descuento + iva;
Console.WriteLine("El descuento de tu factura es: "+descuento+" el iva es: "+iva+" y tu total es: "+total);