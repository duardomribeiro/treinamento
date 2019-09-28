using System;

namespace exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello World! 1");
            Console.WriteLine("Hello World! 2");

            string nome = "Eduardo";
            bool inativo;
            int numero;
            long numero_1;
            decimal valor = 10_000_00;
            DateTime hoje = DateTime.Now; //Data Atual
            DateTime data_manual = new DateTime(2019, 09, 28); //Data Manual
            string hoje_formatada = hoje.ToString("dd/MM/yyyy");
            string hoje_formatada_2 = hoje.ToString("T");
            char tipo;
            _ = new int[5];
            string[] array_string = new string[5];
            array_string[0] = "A";
            array_string[1] = "B";
            array_string[2] = "C";
            array_string[3] = "D";
            array_string[4] = "E";

            Console.WriteLine(">>" + hoje_formatada);
            Console.WriteLine($">> {hoje_formatada}<<");
            Console.WriteLine($">> {valor.ToString()}<<");
            Console.WriteLine($">> {nome}<<");

            Console.WriteLine("Digite SIM ou NÃO");
            string variavel_usuario = Console.ReadLine();

            if (variavel_usuario.ToUpper() == "SIM")
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NOT!");
            }
            */

            Exemplos exemplo = new Exemplos();

            Console.WriteLine("**************************VARIAS OPERAÇÕES!****************************");
            Console.WriteLine("");

            exemplo.FatorialNUmeroQuatro();//4 via metodo

            Console.WriteLine("***********************************************************************");
            Console.WriteLine("");
            Console.ReadKey();

            Console.WriteLine($"Fatorial cinco: 5 x 4 x 3 x 2 x 1 = {exemplo.FatorialNumeroCinco()}");//5 via funcao

            Console.WriteLine("***********************************************************************");
            Console.WriteLine("");

            exemplo.FatorialViaUsuario();//fatorial via usuario

            Console.WriteLine("***********************************************************************");
            Console.WriteLine("");

            exemplo.QualEMaior();

            Console.WriteLine("***********************************************************************");
            Console.WriteLine("");

            exemplo.ParOuImpar();

            Console.WriteLine("***********************************************************************");
            Console.WriteLine("");

            exemplo.Calculadora();

            Console.WriteLine("***********************************************************************");
            Console.WriteLine("");

            exemplo.Tabuada();

            Console.WriteLine("***********************************************************************");
            Console.WriteLine("");

            exemplo.CauculaGraus();

            Console.WriteLine("***********************************************************************");
            Console.WriteLine("");

            Console.WriteLine("FIM");
        }
    }
}
