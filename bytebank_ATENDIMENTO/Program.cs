using bytebank_ATENDIMENTO.bytebank.Atendimento;
Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");
//new ByteBankAtendimento().AtendimentoCliente();

//chamar o metodo
//TestaArrayInt();
TestaBuscarPalavra();

void TestaArrayInt() {
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
        Console.Write($"Digite {i+1}° palavra:  ");
        arrayDePalavras[i] = Console.ReadLine();
    }
    Console.WriteLine($"Digite a palavra a ser encontrada");
    var busca = Console.ReadLine();
    foreach(var palavra in arrayDePalavras)
    {
        if (palavra.Equals(busca))
        {
            Console.WriteLine($"Palavra encontrada é: {busca}");
            
        }
       
    }
}