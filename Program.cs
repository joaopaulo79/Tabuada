using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroDigitado; 
            int tabuada = 0;
            bool realInt;
            
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n--------- Tabuada ---------\n");
            Console.ResetColor();

            Console.WriteLine(" * Insira um número inteiro\n   e receba a sua tabuada.\n");

            Console.Write("Digite um número inteiro: ");
            realInt = Int32.TryParse(Console.ReadLine(), out numeroDigitado);

            if (realInt)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"\nTabuada do {numeroDigitado}:\n");
                Console.ResetColor();

                while (tabuada < 11)
                {
                    int multiplicacao = tabuada * numeroDigitado;
                    Console.WriteLine($"{numeroDigitado} × {tabuada} = {multiplicacao}");
                    tabuada += 1;
                }

                Console.WriteLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n* Insira apenas números inteiros!\n");
                Console.ResetColor();
            }
        }
    }
}
