namespace CSharpStudies.Exercicios.Cody_Tech
{
    public class Operators
    {
        public static void Executar()
        {
            //Your task is to fill in the right values so that variable d in line 10 will hold true
            //int a = ?;
            //int b = ?;
            //int c = ?;

            int a = 15;
            int b = 5;
            int c = 5;


            bool d = ((a - b) > c) && (b == c);
            Console.WriteLine("d = " + d);
        }
    }
}
