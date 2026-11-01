int numero1,resultadocapicua,primernumero;
Console.WriteLine("Digite un numero de dos cifras: ");
numero1 = Convert.ToInt32(Console.ReadLine());
resultadocapicua = numero1 % 10;
primernumero = numero1 / 10;

/*Console.WriteLine(primernumero);
Console.WriteLine(resultadocapicua);*/

if (resultadocapicua==primernumero)
{
    Console.WriteLine($"Su numero {numero1} separadado tal como {resultadocapicua} y {primernumero} es capicua");
}
else
{
    Console.WriteLine($"Su numero {numero1} separadado tal como {resultadocapicua} y {primernumero} no es capicua");
}

