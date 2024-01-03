using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ATENDIMENTO.Exercicios
{
    internal class ArrayInteiros
    {   
        public void MeusInteiros() 
        { 
            int[] arrayInt = new int[4];
                arrayInt[0] = 12;
                arrayInt[1] = 20;
                arrayInt[2] = 16;
                arrayInt[3] = 23;
            //mostrar o tamanho do array 
            Console.WriteLine($"Tamanho total do meu array é {arrayInt.Length}");

            //contador para poder calalular a media 
            int cont = 0;

            //for para andar pelo array 
            for (int i = 0; i < arrayInt.Length; i++)
            {
                int valor = arrayInt[i];
                Console.WriteLine($"valor dentro do indice {i} é {valor} ");
                cont += valor;
            }
            //calculo da média 
            var media = cont / arrayInt.Length;
            Console.WriteLine($"A média dos indices do array é {media}");

         

        }
    }
}


/*
 * 1- Primeiro faço a classe
 * 2- Depois faço um metodo
 * 3- Declaro o meu array e quantas casas eu quero que ele tenha 
 * 4- Faço um FOR para passar por ele 
 * 5- Mostro os indices comum cw 
 * 6- Calculo a média 
 * 
 
 */