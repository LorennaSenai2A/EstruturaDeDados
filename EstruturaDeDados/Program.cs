internal class Program
{
    private static void Main(string[] args)
    {
        /* Console.WriteLine("Minha primeira branch!");
         Console.WriteLine("Trabalhando com Git\\Github");
         Console.WriteLine("Mais uma tentativa de trabalho Git"); */

        //Trabalhando com lista (list)
        //Criando uma lista
        List<string> frutas = new List<string>();

        //Adicionando itens na lista
        frutas.Add("Morango");
        frutas.Add("Manga");
        frutas.Add("Goiaba");
        frutas.Add("Uva");

        //Imprimir os itens da lista
        /*Console.WriteLine("Minha lista de frutas:");
        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }*/

        //Impressão da lista em uma única linha
        frutas.ForEach(Console.WriteLine);

        Console.WriteLine(); // Pula linha em branco

        //Imprimir elemento na posição específica
        Console.WriteLine("Fruta na indice 2: " + frutas[2]);

        //Inserindo um elemento na posiç~so específica
        frutas.Insert(1, "Maracuja");

        //Imprimindo a lista novamente
        Console.WriteLine(); //pula linha em branco

        Console.WriteLine("Minha lista de frutas:");
        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }
        //alterando um elemento no indice especifico
        frutas.Insert(4, "Pera");

        Console.WriteLine(); //Pula linha em branco
        Console.WriteLine("Minha Lista de Frutas:");
        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }

        //Remover elementos da lista do indice especifico
        frutas.RemoveAt(3);
        //Remover elementos pelo valor do conteúdo
        frutas.Remove("Morango");

        //imprimir a lista novamente
        Console.WriteLine();
        Console.WriteLine("Minha lista de frutas:");
        frutas.ForEach(Console.WriteLine);

        // Apagar todos os elementos da lista 
        frutas.Clear();

        //Trabalhando com dicionario (dictionary)
        //Criando um dicionario de dados
        Dictionary<int, string> carros = new Dictionary<int, string>();
        //Adicionar dados a um dicionário
        carros.Add(5, "Corsa");
        carros.Add(10, "Fusca");
        carros.Add(2, "Ford Ka");

        Console.WriteLine();
        Console.WriteLine("==========================");
        Console.WriteLine();

        Console.WriteLine("Meu dicionario de carros:");
        //Imprimir um dicionario de dados
        foreach (var carro in carros)
        {
            Console.WriteLine($"{carro.Key} - {carro.Value}");
        }
    }
}