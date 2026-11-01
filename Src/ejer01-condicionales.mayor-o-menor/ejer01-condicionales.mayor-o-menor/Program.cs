double edad, resultadomayor, resultadomenor;
Console.WriteLine("Digite su edad: ");
edad = Convert.ToDouble(Console.ReadLine());
resultadomayor = edad - 18;
resultadomenor = 18 - edad;
if (edad>18)
{
    Console.WriteLine($"Eres mayor de edad y cumpliste los 18 hace: {resultadomayor} años.");
    
} else 
{
    Console.WriteLine($"Eres menor de edad y te faltan {resultadomenor} año para los cumplir los 18");
}