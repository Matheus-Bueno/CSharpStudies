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
                Console.WriteLine("Escolha o exercicio desejado de Microsoft Learn ");
                string escolha = Console.ReadLine() ?? string.Empty;
                if (escolha == "1")
                    Console.WriteLine();                    
                break;

            case "2":
                Console.WriteLine("Escolha o exercicio desejado de Cody Tech ");
                string escolhaLoop = Console.ReadLine() ?? string.Empty;
                if (escolhaLoop == "1")
                    
                    Console.WriteLine();
                break;

            case "3":
                Console.WriteLine("Escolha o exercicio desejado de Udemy ");
                string escolhaloop = Console.ReadLine() ?? string.Empty;
                
                if (escolhaloop == "1") 
                    Console.WriteLine();
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }
}