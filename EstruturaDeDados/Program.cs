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
        Console.WriteLine("Minha lista de frutas:");
        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }

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

        // Apagar todos os elementos da lista 
        frutas.Clear();

    }
}