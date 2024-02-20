using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Util;
using bytebank_ATENDIMENTO.Exercicios;

//Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

//new ByteBankAtendimento().AtendimentoCliente();
//classe array disponivel na biblioteca de classes do .net 

ArrayInteiros arrayInteiros = new ArrayInteiros();
Array amostra = Array.CreateInstance(typeof(double), 5);

amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(10, 3);
amostra.SetValue(6.9, 4);

void testaMediana(Array array)
{
    if (array == null || array.Length == 0)
    {
        Console.WriteLine("Array para calculo de mediana está vazio ou nulo.");
    }
    double[] numerosOrdenados = (double[])array.Clone();
    Array.Sort(numerosOrdenados);

    int tamanho = numerosOrdenados.Length;
    int meio = tamanho / 2;
    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] :
        numerosOrdenados[meio] + (numerosOrdenados[meio - 1]) / 2;
    Console.WriteLine($"Com base na amostra a mediana = {mediana}");
}

void TestaArrayInt()
{
    int[] idades = new int[5];
    idades[0] = 30;
    idades[1] = 40;
    idades[2] = 17;
    idades[3] = 21;
    idades[4] = 18;

    Console.WriteLine($"Tamanho do Array{idades.Length}");
    int acumulador = 0;
    for (int i = 0; i < idades.Length; i++)
    {
        int idade = idades[i];
        Console.WriteLine($"indice [{i}] = {idade}");
        acumulador += idade;
    }
    int media = acumulador / idades.Length;
    Console.WriteLine($"Media de idades = {media}");
}

void TestaBuscarPalavra()
{
    string[] arrayDePalavras = new string[5];
    for (int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.Write($"Digite {i + 1}° palavra:  ");
        arrayDePalavras[i] = Console.ReadLine();
    }
    Console.WriteLine($"Digite a palavra a ser encontrada");
    var busca = Console.ReadLine();
    foreach (var palavra in arrayDePalavras)
    {
        if (palavra.Equals(busca))
        {
            Console.WriteLine($"Palavra encontrada é: {busca}");

        }

    }
}

void TestaArrayDeContasCorrentes()
{

    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
    listaDeContas.Adicionar(new ContaCorrente(874, "5679787-A"));
    listaDeContas.Adicionar(new ContaCorrente(874, "4456668-B"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    var contaDoAndre = new ContaCorrente(963, "123456-X");
    listaDeContas.Adicionar(contaDoAndre);
    //listaDeContas.ExibeLista();
    //Console.WriteLine("============");
    //listaDeContas.Remover(contaDoAndre);
    //listaDeContas.ExibeLista();
    for (int i = 0; i < listaDeContas.Tamanho; i++)
    {
        ContaCorrente conta = listaDeContas[i];
        Console.WriteLine($"Indice [{i}] = {conta.Conta}/{conta.Numero_agencia}");

    }
}

//chamar o metodo
//TestaArrayInt();
//TestaBuscarPalavra();
//testaMediana(amostra);
TestaArrayDeContasCorrentes();
//arrayInteiros.MeusInteiros();
//Strings.testeArrayString();