using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dados2025
{
    class Dado
    {
        int valor;
        static Random random = new Random();

        public Dado()
        {
            valor = 0;
        }

        public void Tirar()
        {
            valor = random.Next(1, 7);
        }

        public int RetornarValor()
        {
            return valor;
        }

        public void Imprimir()
        {
            string[] dado = new string[7];

            dado[1] = "┌─────┐\n" +
                      "│     │\n" +
                      "│  *  │\n" +
                      "│     │\n" +
                      "└─────┘\n";
            dado[2] = "┌─────┐\n" +
                      "│ *   │\n" +
                      "│     │\n" +
                      "│   * │\n" +
                      "└─────┘\n";
            dado[3] = "┌─────┐\n" +
                      "│ *   │\n" +
                      "│  *  │\n" +
                      "│   * │\n" +
                      "└─────┘\n";
            dado[4] = "┌─────┐\n" +
                      "│ * * │\n" +
                      "│     │\n" +
                      "│ * * │\n" +
                      "└─────┘\n";
            dado[5] = "┌─────┐\n" +
                      "│ * * │\n" +
                      "│  *  │\n" +
                      "│ * * │\n" +
                      "└─────┘\n";
            dado[6] = "┌─────┐\n" +
                      "│ * * │\n" +
                      "│ * * │\n" +
                      "│ * * │\n" +
                      "└─────┘\n";
            Console.WriteLine(dado[valor]);
        }
    }

    class JuegoDeDados
    {
        public void Jugar()
        {
            Dado dado1 = new Dado();
            Dado dado2 = new Dado();
            Dado dado3 = new Dado();

            dado1.Tirar();
            dado1.Imprimir();
            Thread.Sleep(200);

            dado2.Tirar();
            dado2.Imprimir();
            Thread.Sleep(200);

            dado3.Tirar();
            dado3.Imprimir();
            Thread.Sleep(200);

            if (dado1.RetornarValor() == dado2.RetornarValor() && dado1.RetornarValor() == dado3.RetornarValor())
            {
                Console.WriteLine("┌───────────────┐");
                Console.WriteLine("│ USTED GANO!!! │");
                Console.WriteLine("└───────────────┘");
            }
            else
            {
                Console.WriteLine("┌──────────────────┐");
                Console.WriteLine("│ USTED PERDIO !!! │");
                Console.WriteLine("└──────────────────┘");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo tecla;
            JuegoDeDados juegoDeDados = new JuegoDeDados();
            do
            {
                Console.Clear();
                Console.WriteLine("                JUEGO DE DADOS");
                Console.WriteLine("─────────────────────────────────────────────────");
                Console.WriteLine("");
                juegoDeDados.Jugar();
                Console.WriteLine("Presione cualquier tecla para volver a jugar, o 'S' para salir...");
                tecla = Console.ReadKey();
            } while (tecla.Key != ConsoleKey.S);
        }
    }
}