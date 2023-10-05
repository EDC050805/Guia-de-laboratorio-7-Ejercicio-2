// See https://aka.ms/new-console-template for more information

Console.WriteLine("\tPrograma para hallar todos los números divisibles ");
Console.WriteLine("\t\t      entre 3 del 1 al 1000\n");
Console.WriteLine("Ingrese su nombre y apellido: ");
string nombre =  Console.ReadLine()!;
int numero, contador;
numero = contador = 1;

while (numero >= 1 && numero <= 1000)
{

    if (numero % 3 == 0)
    {    
        Console.WriteLine("Divisor de {0} " + contador + ": {1}", nombre, numero);
        contador++;
    }
    numero++;
}