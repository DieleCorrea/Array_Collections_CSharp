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
        private int _proximaPosicao = 0;

        public ListaDeContasCorrentes( int tamanhoInicial = 5)
        {
            _itens = new ContaCorrente[tamanhoInicial];
            
        }
       //criar metodo para adicionar 
       public void Adicionar(ContaCorrente item)
        {
            Console.WriteLine($"Adicionando item na posição {_proximaPosicao}");
            VerificarCapacidade(_proximaPosicao + 1);
            _itens[_proximaPosicao] = item;   
            _proximaPosicao++;
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

        public void Remover ( ContaCorrente conta )
        {
            int indiceItem = -1;
            for(int i = 0; i < _proximaPosicao; i++)
            {
                ContaCorrente contaAtual = _itens[i];
                if(contaAtual == conta) 
                { 
                    indiceItem = i;
                    break;
                }
                
            }
            for (int i = indiceItem; i < _proximaPosicao - 1; i++)
            {
                _itens[i] = _itens[i + 1];
            }
            _proximaPosicao--;
            _itens[_proximaPosicao] = null;
        }
        

        public void ExibeLista()
        {
            for (int i = 0; i < _itens.Length; i++)
            {
                if (_itens[i] != null)
                {
                    var conta = _itens[i];
                    Console.WriteLine($" Indice[{i}] = " +
                        $"Conta:{conta.Conta} - " +
                        $"N° da Agência: {conta.Numero_agencia}");
                }
            }
        }

        public ContaCorrente RecuperarContaNoIndice(int indice)
        {
            if (indice < 0 || indice >= _proximaPosicao)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }
            return _itens[indice];
        }
        public int Tamanho { get { return _proximaPosicao; } }
        public ContaCorrente this[int indice]
        {
            get
            {
                return RecuperarContaNoIndice(indice);
            }
        }
    }
}
/*
 1- primeiro crio um metodo do tipo conta corrente pois é la que tem o sado
2-preciso instancial a conta corrente para criar um for que vai percorrer os valores desse */