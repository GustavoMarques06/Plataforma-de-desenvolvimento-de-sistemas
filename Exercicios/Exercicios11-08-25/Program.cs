namespace Exercicios11_08_25
{
    internal class Program
    {
        static void ParOuImpar(string[] args)
        {
            Console.WriteLine("Digite o primeiro numero: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o terceiro numero: ");
            int numero3 = Convert.ToInt32(Console.ReadLine());

            if (numero1 % 2 == 0 || numero2 % 2 == 0 || numero3 % 2 != 0)
            {
                Console.WriteLine("O primeiro numero é par \nO segundo é par \nO terceiro é impar");
            }
            else if (numero1 % 2 == 0 || numero2 % 2 != 0 || numero3 % 2 == 0)
            {
                Console.WriteLine("O primeiro numero é par \nO segundo é impar \nO terceiro é par");
            }
            else if (numero1 % 2 != 0 || numero2 % 2 == 0 || numero3 % 2 == 0)
            {
                Console.WriteLine("O primeiro numero é impar \nO segundo é par \nO terceiro é par");
            }
            else
            {
                Console.WriteLine("O primeiro numero é par \nO segundo é par \nO terceiro é par");
            }

        }

        static void FahrenheitParaCelsius(string[] args)
        {
            Console.WriteLine("Digite o valor em Fahrenheit: ");
            double Fahrenheit = Convert.ToDouble(Console.ReadLine());
            double Celsius = ((Fahrenheit - 32) * 5) / 9;
            Console.WriteLine("A temperatura em Celsius é de: " + Celsius);
        }


        static void EquacaoSegundoGrau(string[] args)
        {
            //Chamando as variaveis
            Console.WriteLine("Digite o valor de A: ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de C: ");
            double C = Convert.ToDouble(Console.ReadLine());

            double delta = Math.Pow(B, 2) - (4 * A * C);
            double x1, x2 = 0;

            x1 = ((-B) + Math.Sqrt(delta)) / (2 * A); //Formula de Bhaskara utilizando mais 
            x2 = ((-B) - Math.Sqrt(delta)) / (2 * A); // Utilizando o menos


            Console.WriteLine("O valor de X1: " + x1 + "\nO valor de X2: " + x2);
        }
    }
}
