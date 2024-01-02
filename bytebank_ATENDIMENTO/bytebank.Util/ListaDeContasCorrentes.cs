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

        public ListaDeContasCorrentes( int tamanhoInicial)
        {
            _itens = new ContaCorrente[tamanhoInicial];
            
        }
       //criar metodo para adicionar 
       public void Adicionar(ContaCorrente item)
        {
            _itens[_proximoItem] = item;   
            _proximoItem++;
        }
    }
}
