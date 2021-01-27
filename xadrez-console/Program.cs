using System;
using tabuleiro;

namespace xadrez_console
{
    public class Program
    {
        static void Main(string[] args)
        {
            Posicao P;

            Tabuleiro tab = new Tabuleiro(8, 8);

            Tela.ImprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}
