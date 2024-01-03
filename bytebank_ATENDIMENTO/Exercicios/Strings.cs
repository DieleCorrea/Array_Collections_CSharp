using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ATENDIMENTO.Exercicios
{
    internal class Strings
    {   private static string[] amigos = new string[5];
        public static void testeArrayString()
        {
            

            Console.WriteLine("Por favor, difgite o nome de seus amigos: ");
            Console.WriteLine($"Numero maximo de amigos que pode digitar é {amigos.Length}");

            for (int i = 0; i < amigos.Length; i++)
            {
                amigos[i] =  Console.ReadLine();
                    
            }
            Console.Clear();
            Console.WriteLine("Deseja visualizar seus amigos?\n Dgite SIM ou NÃO ");
            string opcao = Console.ReadLine();
            switch (opcao.ToLower())
            {
                case "sim":
                    mostarAmigos();
                    break;
                case "nao":
                    Console.WriteLine("Ok fechando console");
                    Environment.Exit(0);
                    break;
                 default: Console.WriteLine("Opção invalida.tente novamente"); break;
            }

        }

        public static void mostarAmigos() {
            foreach (string item in amigos)
            {
                Console.WriteLine(item);
            }
        }
    }
}
