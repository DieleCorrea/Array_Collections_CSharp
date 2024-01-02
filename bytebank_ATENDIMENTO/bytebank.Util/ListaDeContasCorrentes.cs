using bytebank.Modelos.Conta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ATENDIMENTO.bytebank.Util
{
    public class ListaDeContasCorrentes
    {
        private ContaCorrente[] _itens = null;
        private int _proximoItem = 0;

        public ListaDeContasCorrentes( int tamanhoInicial = 5)
        {
            _itens = new ContaCorrente[tamanhoInicial];
            
        }
       //criar metodo para adicionar 
       public void Adicionar(ContaCorrente item)
        {
            Console.WriteLine($"Adicionando item na posição {_proximoItem}");
            _itens[_proximoItem] = item;   
            _proximoItem++;
        }

        //verificar a capacidade do array para ele não quebrar 
        private void VerificarCapacidade(int tamanhoNecessario)
        {
            if(_itens.Length >= tamanhoNecessario)
            {
                return;
            }
            Console.WriteLine($"Aumentando a capacidade");
        }
    }
}
