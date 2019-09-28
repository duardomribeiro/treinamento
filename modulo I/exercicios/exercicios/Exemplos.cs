using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios
{
    public class Exemplos
    {
        public void FatorialNUmeroQuatro()
        {
            int fatorial = 4 * 3 * 2 * 1;
            Console.WriteLine($"Fatorial quatro: 4 x 3 x 2 x 1 = {fatorial}");
        }
        public int FatorialNumeroCinco()
        {
            int fatorial = 5 * 4 * 3 * 2 * 1;
            return fatorial;
            Console.ReadKey();
        }
        public void FatorialViaUsuario()
        {
            Console.WriteLine("Informe o Fatorial.");
            int fatorial = Convert.ToInt32(Console.ReadLine());
            int i = 1;

            while (i == 0)
            {
                fatorial = (i * (fatorial - i));
                i = (i - 1);
            }

            Console.WriteLine($"Fatorial usuario: {Convert.ToString(fatorial)}");
        }

        public void QualEMaior()
        {
            Console.WriteLine("Qual é maior?");

            Console.WriteLine("Informe Primeiro Valor.");
            int v1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe Segundo Valor.");
            int v2 = Convert.ToInt32(Console.ReadLine());

            if (v1! > v2)
            {
                Console.WriteLine(Convert.ToString(v1) + " é Maior que " + Convert.ToString(v2));
            }
            else
            {
                Console.WriteLine(Convert.ToString(v2) + " é Maior que " + Convert.ToString(v1));
            }
        }

        public void ParOuImpar()
        {
            Console.WriteLine("Número é Par ou Impar?.");

            Console.WriteLine("Informe Valor.");
            decimal v1 = Convert.ToInt32(Console.ReadLine());

            if ((v1 % v1) == 1)
            {
                Console.WriteLine(Convert.ToString(v1) + " é Par.");
            }
            else
            {
                Console.WriteLine(Convert.ToString(v1) + " é Impar.");
            }
        }

        public void Calculadora()
        {
            Console.WriteLine("Calculadora");

            Console.WriteLine("Informe Primeiro Valor.");
            decimal v1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe Operação. (+ - x /)");
            string op = Console.ReadLine();

            Console.WriteLine("Informe Segundo Valor.");
            decimal v2 = Convert.ToInt32(Console.ReadLine());

            decimal resultado = 0;

            if ((op != "+") && (op != "-") && (op.ToUpper() != "x") && (op != "/"))
            {
                Console.WriteLine("Operador Inválido.");
            }
            else if (op == "+")
            {
                resultado = (v1 + v2);
            }
            else if (op == "-")
            {
                resultado = (v1 - v2);
            }
            else if (op.ToUpper() == "X")
            {
                resultado = (v1 * v2);
            }
            else if (op == "/")
            {
                resultado = (v1 / v2);
            }

            Console.WriteLine("Resultado é: " + Convert.ToString(resultado));
        }
        public void Tabuada()
        {
            Console.WriteLine("Tabuada");

            Console.WriteLine("Informe Valor.");
            decimal v1 = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(Convert.ToString(v1) + " X " + Convert.ToString(i) + " = " + Convert.ToString(v1*i));
            }
        }

        public void CauculaGraus()
        {
            Console.WriteLine("Celcius para Fahrenheit e vice versa.");

            Console.WriteLine("Converter em Celcius digite 'C', para Converter em Fahrenheit digite 'F'.");
            string g = Console.ReadLine();

            decimal v1;
            decimal resultado = 0;

            if (g == "C")
            {
                Console.WriteLine("Informe Graus em Fahrenheit");
                v1 = Convert.ToInt32(Console.ReadLine());

                resultado = (((v1 * 9) / 5) + 32);
                Console.WriteLine(Convert.ToString(resultado) + "º graus Celsius.");
            }
            else
            {
                Console.WriteLine("Informe Graus em Celsius");
                v1 = Convert.ToInt32(Console.ReadLine());

                resultado = (((v1 - 32) * 5) / 9);
                Console.WriteLine(Convert.ToString(resultado) + "º graus Fahrenheit.");
            }           

        }

    }
}
