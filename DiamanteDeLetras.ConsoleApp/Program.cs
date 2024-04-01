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
            ExibirParteSuperior(alfabeto, qtdeLinhas, ref qtdeEspacos, ref qtdeLetras);
            //parte do meio
            ExibirParteMeio(alfabeto, qtdeLinhas);
            //parte inferior
            ExibirParteInferior(alfabeto, qtdeLinhas, ref qtdeLetras);

            Console.ReadLine();
        }

        private static int ExibirParteInferior(string alfabeto, int qtdeLinhas, ref int qtdeLetras)
        {
            int qtdeEspacos = 1;
            qtdeLetras -= 2;

            for (int linha = qtdeLinhas - 1; linha >= 0; linha--)
            {
                for (int espaco = 0; espaco < qtdeEspacos; espaco++)
                    Console.Write(" ");

                Console.Write($"{alfabeto[linha]}");

                for (int espaco = 0; espaco < qtdeLetras - 2; espaco++)
                    Console.Write(" ");


                if (linha != 0)
                    Console.Write($"{alfabeto[linha]}");

                qtdeEspacos++;
                qtdeLetras -= 2;

                Console.WriteLine();
            }

            return qtdeEspacos;
        }

        private static void ExibirParteMeio(string alfabeto, int qtdeLinhas)
        {
            Console.Write($"{alfabeto[qtdeLinhas]}");
            for (int linha = 0; linha < qtdeLinhas * 2 - 1; linha++)
                Console.Write(" ");

            Console.Write($"{alfabeto[qtdeLinhas]}");

            Console.WriteLine();
        }

        private static void ExibirParteSuperior(string alfabeto, int qtdeLinhas, ref int qtdeEspacos, ref int qtdeLetras)
        {
            for (int linha = 0; linha < qtdeLinhas; linha++)
            {
                for (int espaco = 0; espaco < qtdeEspacos; espaco++)
                    Console.Write(" ");

                Console.Write($"{alfabeto[linha]}");

                for (int espaco = 0; espaco < qtdeLetras - 2; espaco++)
                    Console.Write(" ");

                if (linha != 0)
                    Console.Write($"{alfabeto[linha]}");

                qtdeEspacos--;
                qtdeLetras += 2;

                Console.WriteLine();
            }
        }
    }
}
