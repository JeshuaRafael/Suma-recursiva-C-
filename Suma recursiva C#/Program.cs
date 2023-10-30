using System;

class Program
{
    static int SumaRecursiva(int n)
    {
        if (n <= 9)
            return n;
        else
            return SumaRecursiva(n / 10) + n % 10;
    }

    static void Main(string[] args)
    {
        Console.Write("Ingresa un número entero: ");
        int numero = int.Parse(Console.ReadLine());

        int resultado = SumaRecursiva(numero);
        Console.WriteLine($"La suma de los dígitos de {numero} es: {resultado}");
    }
}
