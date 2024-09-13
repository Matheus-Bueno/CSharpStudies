namespace CSharpStudies.Exercicios.Udemy
{
    public class EstruturasSequenciais
    {
        public static void Executar()
        {    
            //Exercício 01
            //Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma mensagem explicativa.
            
            /*Console.WriteLine("Informe um numero inteiro");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe outro numero inteiro");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"A soma dos numeros é: {n1+n2}");*/

            //Exercício 02
            //Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro casas decimais.
            //Fórmula da área: area = π . raio2. Considere o valor de π = 3.14159

            /*Console.WriteLine("Informe o valor do raio do circulo ");
            double raio = Convert.ToDouble(Console.ReadLine());

            double result = (raio * raio) * 3.14159;

            Console.WriteLine($"A={result:f4}"); */

            //Exercício 03
            //Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
            //de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).
            
            /*Console.WriteLine("Digite um numero Inteiro");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite um numero Inteiro");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite um numero Inteiro");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite um numero Inteiro");
            int d = Convert.ToInt32(Console.ReadLine());

            int diferenca =(a*b- c*d) ;
            Console.WriteLine(diferenca);*/

            //Exercício 04
            //Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casasdecimais.

            /*Console.WriteLine("Informe o Numero do Funcionario");
            int numFunc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o Numero de horas Trabalhadas");
            int horas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o Valor da hora");
            double valorHora = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine($"Numero = {numFunc}");
            Console.WriteLine($"Salário = R$ {horas * valorHora:F2}");*/
        }
    }
}