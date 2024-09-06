class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Selecione uma categoria:");
        Console.WriteLine("1 - MicrosoftLearn");
        Console.WriteLine("2 - Cody Tech");
        Console.WriteLine("3 - Udemy");

        string categoria = Console.ReadLine() ?? string.Empty;
        

        switch(categoria)
        {
            case "1":
                string escolha = Console.ReadLine() ?? string.Empty ;
                if (escolha == "1")
                    Console.WriteLine();                    
                break;

            case "2":
                string escolhaLoop = Console.ReadLine() ?? string.Empty ;
                if (escolhaLoop == "1")
                    
                    Console.WriteLine();
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }
}