using System;

namespace Calculadora_Simples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Perguntar a operação
            Console.WriteLine("Qual a operação deseja realizar?");
            Console.WriteLine("Soma, Subtraçao, Multiplicaçao, Divisao");
            string operação = Console.ReadLine();

            // Pedir o 1º número
            Console.WriteLine("Digite o 1º número:");
            float num1 = float.Parse(Console.ReadLine());

            // Pedir o 2º número
            Console.WriteLine("Digite o 2º número:");
            float num2 = float.Parse(Console.ReadLine());

            // Fazer o cálculo
            float resultado = 0;

            if(operação == "Soma"){
                resultado = num1 + num2;
            }
            else if(operação == "Subtraçao"){
                resultado = num1 - num2;
            }
            else if(operação == "Multiplicaçao"){
                resultado = num1 * num2;
            }
            else if(operação == "Divisao"){
                resultado = num1 / num2;
            }
            else{
                Console.WriteLine("Operação inválida");
            }

            switch(operação){

                case "Soma":
                resultado = num1 + num2;
                break;

                case "Subtraçao":
                resultado = num1 - num2;
                break;

                case "Multiplicaçao":
                resultado = num1 * num2;
                break;

                case "Divisao":
                resultado = num1 / num2;
                break;

                default:
                    Console.WriteLine("Operação inválida");
                    break;
            }

            // Mostrar o resultado

            // Concatenação
            // Console.WriteLine("Cálculo : "+ num1 +" com "+ num2 +" = " + resultado);

            // Interpolação 
            Console.WriteLine($"Cálculo : {num1} com {num2} = {resultado}");
        }
    }
}
