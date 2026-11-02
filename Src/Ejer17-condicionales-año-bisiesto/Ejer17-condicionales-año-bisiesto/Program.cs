double ano;
Console.WriteLine("Digite el año:");
ano = Convert.ToDouble(Console.ReadLine());

/*si colocas 2024 entonces:
 *ano%100=24 por lo cual debe ser != 0
 *ano%%4=0 por lo cual es == 0
 *ano%400=0 por lo cual es == 0*/

if (ano%100!=0 && ano%4==0 || ano%400==0)
{
    Console.WriteLine("el año es bisiesto");
}
else
{
    Console.WriteLine("el año no es bisiesto");
}