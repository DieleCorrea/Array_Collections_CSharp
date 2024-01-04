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
            VerificarCapacidade(_proximoItem + 1);
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
            Console.WriteLine($"Aumentando a capacidade da lista");
            //instancio a classe para criar novo array caso passe do tamanho, esse array não tem tamanho fixo 
            ContaCorrente[] novoArray = new ContaCorrente[tamanhoNecessario];

            //crio esse for para o novo array receber cada item novo do array antigo:
            for (int i = 0; i < _itens.Length; i++)
            {
                novoArray[i] = _itens[i];//enquanto i for menor que o tamanho de itens, continuaremos rodando esse loop. Os índices serão definidos por i e, a cada iteração, novoArray receberá um novo elemento de _itens. Esse processo é semelhante a uma clonagem.
            }
            _itens = novoArray;
        }

        //DESAFIO: CRIAR UM METODO QUE RETORNORNE A CONTA CORRENTE COM O MAIOR SALDO DA LISTA 
        //public void MaiorSaldo()
        //{

        //}
       
        public ContaCorrente SaldoMaior()
        {
            ContaCorrente conta = null;// crio um obj de conta conrrente onde vai trazer os saldos 
            double maiorValor = 0;//Essa variavel é usada para ver o meior saldo 

            /*Preciso de um for para percorrer o array que vai ver qual o maior*/
            for (int i = 0; i < _itens.Length; i++)
            {
                //verifca se os valores do elemneto atual não é nulo
                if (_itens[i] != null)
                {
                    //vejo se o saldo do elemnto atual é maior que o registrado ate o momento 
                    if(maiorValor < _itens[i].Saldo)
                    {
                        maiorValor = _itens[i].Saldo;
                        conta = _itens[i];

                    }

                }
            }
            return conta;
        }
    }
}
/*
 1- primeiro crio um metodo do tipo conta corrente pois é la que tem o sado
2-preciso instancial a conta corrente para criar um for que vai percorrer os valores desse */