using System;
using System.Collections;
using System.ComponentModel.Design;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
    
        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("O que você deseja fazer?:");
            Console.WriteLine("1- soma");
            Console.WriteLine("2- subtração");
            Console.WriteLine("3- divisão");
            Console.WriteLine("4- multiplicação");
            Console.WriteLine("5- sair");

            Console.WriteLine("--------------");

            Console.WriteLine("Escolha uma opção:");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
                
            }
        }

        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro número:");
            float v1= float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            float v2= float.Parse(Console.ReadLine());

            float resultado = v1 + v2;
            Console.WriteLine("");
            Console.WriteLine($"O resultado da soma é {resultado}.");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro número:");
            float v1= float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            float v2= float.Parse(Console.ReadLine());

            float resultado = v1 - v2;
            Console.WriteLine("");
            Console.WriteLine($"O resultado da subtracao é {resultado}.");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro número:");
            float v1= float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            float v2= float.Parse(Console.ReadLine());

            float resultado = v1 / v2;
            Console.WriteLine("");
            Console.WriteLine($"O resultado da divisão é {resultado}.");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            
            Console.WriteLine("Digite o primeiro número:");
            float v1= float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            float v2= float.Parse(Console.ReadLine());

            float resultado = v1 * v2;
            Console.WriteLine("");
            Console.WriteLine($"O resultado da multiplicação é {resultado}.");
            Console.ReadKey();
            Menu();
        }
    }

}
