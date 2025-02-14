using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese su edad: ");
        int edad;

        // Verificamos si la entrada es un número válido
        if (int.TryParse(Console.ReadLine(), out edad))
        {
            if (edad < 12)
            {
                Console.WriteLine("Categoría: Niño");
            }
            else if (edad >= 12 && edad <= 17)
            {
                Console.WriteLine("Categoría: Adolescente");
            }
            else if (edad >= 18 && edad < 60)
            {
                Console.WriteLine("Categoría: Adulto");
            }
            else // edad 60 o más
            {
                Console.WriteLine("Categoría: Adulto mayor");
            }
        }
        else
        {
            Console.WriteLine("Por favor, ingrese un número válido.");
        }
    }
}

