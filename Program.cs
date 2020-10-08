using System;
using Humanizer;


namespace NumeralExtenso
{
    class Program
    {
        static void Main(string[] args)
        {
            //Numero/Para/Letra//
            int calculo;
            string escrita;
    
            Console.Write("Conversor de Numeros para Letras: ");
            calculo = int.Parse(Console.ReadLine());
            escrita = calculo.ToWords();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(escrita);
            Console.ResetColor();
        }
    }
}