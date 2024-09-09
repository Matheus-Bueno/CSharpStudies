using System.Security.Cryptography.X509Certificates;

namespace CSharpStudies.Exercicios.Cody_Tech
{
    public class Condicionais
    {
        public static void Executar()
        {   
            //You are given a program that gets input from the user, and saves it in the variable num.
            //Your task is to add code that initializes a new variable x that will hold 5 if num is bigger than 5, else 0.
            Console.WriteLine("Digite um Número: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int x ;
            if (num > 5){
                x = 5;
            }
            else{
                x= 0;
            }
            
            Console.WriteLine("x = " + x);
        }

        public static void Executar2()
        {
            //You are given a program that gets three inputs from the user, op (char), n1 (int) and n2 (int).
            //Your task is to add code that initializes a new variable res (int) which will hold the following:
            //if op equals to '+', res will hold n1 + n2.
            //else if op equals to '-', res will hold n1 - n2. 
            //else if op equals to '*', res will hold n1 * n2.
            //else res will hold 0. 

        char op = Console.ReadLine()[0];
        int n1 = Convert.ToInt32(Console.ReadLine());;
        int n2 = Convert.ToInt32(Console.ReadLine());;
        // Don't change above this line
        
        // Write code here
        int res;
        if (op == '+'){
            res = n1 + n2;
        }
        else if(op == '-'){
            res = n1 - n2;
        }
        else if(op == '*'){
            res = n1 * n2;
        }
        else{
            res = 0;
        }
        // Don't change below this line
        Console.WriteLine(res);
        }
    }
}