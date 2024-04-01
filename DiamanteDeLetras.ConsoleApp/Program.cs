using System.ComponentModel.DataAnnotations.Schema;

namespace DiamanteDeLetras.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVXWYZ";

            Console.WriteLine("Digite uma letra do alfabeto: ");
            char entrada = Convert.ToChar(Console.ReadLine().ToUpper());
            char inicial = 'A';

            int numeroEntrada = Convert.ToInt32(entrada);
            int numeroInicial = Convert.ToInt32(inicial);

            int qtdeLinhas = numeroEntrada - numeroInicial;
            int qtdeEspacos = numeroEntrada - numeroInicial;

            int qtdeLetras = 1;
            //parte superior
           for (int linha = 0; linha < qtdeLinhas; linha++)
           {
                for (int espaco = 0; espaco < qtdeEspacos; espaco++)
                    Console.Write(" ");                

                Console.Write($"{alfabeto[linha]}");

                for (int espaco = 0; espaco < qtdeLetras - 2; espaco++)
                    Console.Write(" ");                

                if(linha!=0)
                    Console.Write($"{alfabeto[linha]}");               

                qtdeEspacos--;
                qtdeLetras += 2;

                Console.WriteLine();
           }
            //parte do meio
           Console.Write($"{alfabeto[qtdeLinhas]}");
           for (int linha = 0; linha < qtdeLinhas * 2 - 1; linha++)
                Console.Write(" ");
           
           Console.Write($"{alfabeto[qtdeLinhas]}");

           Console.WriteLine();
           //parte inferior
            qtdeEspacos = 1;
            qtdeLetras -= 2;

            for(int linha = qtdeLinhas - 1; linha >= 0; linha--)
            {
                for (int espaco = 0; espaco < qtdeEspacos; espaco++)
                    Console.Write(" ");                

                Console.Write($"{alfabeto[linha]}");

                for (int espaco = 0; espaco < qtdeLetras - 2; espaco++)
                    Console.Write(" ");
                

                if(linha != 0)
                    Console.Write($"{alfabeto[linha]}");                

                qtdeEspacos++;
                qtdeLetras -= 2;

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
