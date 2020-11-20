using System;

namespace Funcoes_Calculadora_Adicao_Subtracao
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite uma operação");
            string operacao = Console.ReadLine();

            System.Console.WriteLine("primeiro numero");
            float num1= float.Parse(Console.ReadLine());

            System.Console.WriteLine("segundo numero");
            float num2= float.Parse(Console.ReadLine());

            //( ) = argumentos
            switch (operacao)
            {
                case "Soma":
                    Somar(num1, num2);
                    Console.WriteLine(Somar);
                    break;

                case "Subtrair":
                    Subtrair(num1, num2);
                    Console.WriteLine(Subtrair);
                    break;

                default:
                    break;
            }
        }

        static void Somar(float a, float b){
            Console.WriteLine(a+b);
            }

            
        static void Subtrair(float a, float b){
            Console.WriteLine(a-b);
            }
    }
}
