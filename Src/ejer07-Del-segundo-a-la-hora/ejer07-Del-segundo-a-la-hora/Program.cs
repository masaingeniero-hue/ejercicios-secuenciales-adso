double segundos,minutos,horas,segundos1;
Console.WriteLine("Digite los segundos a convertir: ");
segundos = Convert.ToDouble(Console.ReadLine());
horas = segundos / 3600;
minutos = (segundos % 3600) / 60;
segundos1 = (segundos % 60);
Console.WriteLine("La cantidad de sus segundos: "+segundos+" total es: "+horas+" horas "+minutos+" minutos "+segundos1+" segundos ");