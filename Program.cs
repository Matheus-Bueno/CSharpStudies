using CSharpStudies.Exercicios.Cody_Tech;
using CSharpStudies.Exercicios.Udemy;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Selecione uma categoria:");
        Console.WriteLine("1 - Cody Tech");
        Console.WriteLine("2 - MicrosoftLearn");
        Console.WriteLine("3 - Udemy");

        // o ?? serve para Verificar se o valor é nulo, caso for é atribuido o valor a sua direita
        string categoria = Console.ReadLine() ?? string.Empty;
        
        switch(categoria)
        {
            case "1":
                Console.WriteLine("Escolha o exercicio desejado de Cody Tech ");
                Console.WriteLine("1 - Variáveis");
                Console.WriteLine("2 - Operadores");
                Console.WriteLine("3 - Condicionais");
                string escolha = Console.ReadLine() ?? string.Empty;
                if (escolha == "1")
                    Variables.Executar();
                
                if (escolha == "2")
                    Operators.Executar();

                if (escolha == "3")
                    Condicionais.Executar();
                break;
            case "2":
                Console.WriteLine("Escolha o exercicio desejado de Microsoft Learn ");
                string escolhaLoop = Console.ReadLine() ?? string.Empty;
                if (escolhaLoop == "1")
                    Console.WriteLine("Em construção XD");
                break;

            case "3":
                Console.WriteLine("Escolha o exercicio desejado de Udemy ");
                Console.WriteLine("1 - Estrutura Sequencial");
                Console.WriteLine("2 - Formatação de Strings");
                string escolhaloop = Console.ReadLine() ?? string.Empty;

                if (escolhaloop == "1") 
                    EstruturasSequenciais.Executar();
                
                if (escolhaloop == "2") 
                    FormatacaoStrings.Executar();
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }
}