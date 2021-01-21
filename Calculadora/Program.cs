using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            double num3 = 0;
            double num4 = 0;
            double num5 = 0;


            Console.WriteLine("Calculadora");
            Console.WriteLine("---------------------------------\n");

            // pedindo para digitar os numeros
            Console.WriteLine("Digite o Primeiro Valor");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o Segundo Valor");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o Terceiro Valor");
            num3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o Quarto Valor");
            num4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o Quinto Valor");
            num5 = Convert.ToDouble(Console.ReadLine());


            //Escolha a Operação
            Console.WriteLine("Escolha a Operação a ser Utilizada: ");
            Console.WriteLine("\ta - Soma");
            Console.WriteLine("\tb - Subtração");
            Console.WriteLine("\tc - Multiplicação");
            Console.WriteLine("\td - Dividir");
            Console.WriteLine("Sua Escolha? ");




            //escolha das opçoes

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Seu Resultado: {num1} + {num2} + {num3} + {num4} + {num5} = " + (num1
                    + num2
                    + num3
                    + num4
                    + num5));
                    break;

                case "b":
                    Console.WriteLine($"Seu Resultado: {num1} - {num2} - {num3} - {num4} - {num5} = " + (num1
                    - num2
                    - num3
                    - num4
                    - num5));
                    break;

                case "c":
                    Console.WriteLine($"Seu Resultado: {num1} * {num2} * {num3} * {num4} * {num5} = " + (num1
                    * num2
                    * num3
                    * num4
                    * num5));
                    break;

                case "d":
                    Console.WriteLine($"Seu Resultado: {num1} / {num2} / {num3} / {num4} / {num5} = " + (num1
                    / num2
                    / num3
                    / num4
                    / num5));
                    break;

            }

            Console.WriteLine("Aperte algo para fechar a calculadora");
            Console.ReadKey();



        }


    }
}
