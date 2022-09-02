using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jokenpo
{
    class Program
    {
        static void Main(string[] args)
        {
            int opção, jogada;
            double Vitoriasjogador = 0, Vitoriascomputador = 0;
            do
            {

            Console.WriteLine("JOKENPO");
            Console.WriteLine("0- PEDRA");
            Console.WriteLine("1- PAPEL");
            Console.WriteLine("2- TESOURA");

            opção = Convert.ToInt32(Console.ReadLine());

            Random jokenpo = new Random();
            jogada = jokenpo.Next(2);

            //O-> PEDRA
            //1-> PAPEL
            //2-> TESOURA
            
                if (opção == 0 && jogada == 0)
            {
                Console.Clear();
                Console.WriteLine("O COMPUTADOR JOGOU PEDRA");
                Console.WriteLine("EMPATE!");
            }
            else if (opção == 0 && jogada == 1)
            {

                Console.Clear();
                Console.WriteLine("O COMPUTADOR JOGOU PAPEL");
                Console.WriteLine("COMPUTADOR VENCEU!");
                Vitoriascomputador = Vitoriascomputador + 1;
            }
            else if (opção == 0 && jogada == 2)
            {

                Console.Clear();
                Console.WriteLine("O COMPUTADOR JOGOU TESOURA");
                Console.WriteLine("JOGADOR VENCEU!");
                Vitoriasjogador = Vitoriasjogador + 1;
            }
            else if (opção == 1 && jogada == 0)
            {
                Console.Clear();
                Console.WriteLine("O COMPUTADOR JOGOU PEDRA");
                Console.WriteLine("JOGADOR VENCEU!");
                Vitoriasjogador = Vitoriasjogador + 1;
            }
            else if (opção == 1 && jogada == 1)
            {
                Console.Clear();
                Console.WriteLine("O COMPUTADOR JOGOU PAPEL");
                Console.WriteLine("EMPATE!");
            }
            else if (opção == 1 && jogada == 2)
            {
                Console.Clear();
                Console.WriteLine("O COMPUTADOR JOGOU TESOURA");
                Console.WriteLine("COMPUTADOR VENCEU!");
                Vitoriascomputador = Vitoriascomputador + 1;
            }
            else if (opção == 2 && jogada == 0)
            {
                Console.Clear();
                Console.WriteLine("O COMPUTADOR JOGOU PEDRA");
                Console.WriteLine("COMPUTADOR VENCEU!");
                Vitoriascomputador = Vitoriascomputador + 1;
            }
            else if (opção == 2 && jogada == 1)
            {
                Console.Clear();
                Console.WriteLine("O COMPUTADOR JOGOU PAPEL");
                Console.WriteLine("JOGADOR VENCEU!");
                Vitoriasjogador = Vitoriasjogador + 1;
            }
            else if (opção == 2 && jogada == 2)
            {
                Console.Clear();
                Console.WriteLine("O COMPUTADOR JOGOU TESOURA");
                Console.WriteLine("EMPATE!");
            }
            
            }while(Vitoriasjogador + Vitoriascomputador != 3 );
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("O jogador fez: " + Vitoriasjogador + " pontos");
            Console.WriteLine("O Computador fez: " + Vitoriascomputador + " pontos");
           
            Console.ReadKey();

            if ( Vitoriasjogador > Vitoriascomputador )
            {

                Console.WriteLine("jogador venceu!");
            }
            else
            {
                Console.WriteLine("Computador venceu!");
            }
            Console.ReadKey();

        }
        }
    }
