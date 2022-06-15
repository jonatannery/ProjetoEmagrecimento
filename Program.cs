using System;

namespace ProgramaEmagrecimento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Início do projeto

            //variaveis do projeto
            int idade;
            double peso, altura, IMC;
            string nome  , sexo, categoria;
            
            // O usuário esta tendo a infomação do inicio do programa.
            Console.WriteLine("Estamos dando o início ao   para o programa de " +
                "emagrecimento");

            Console.WriteLine("");

            Console.WriteLine("por favor, insira seus dados.");

            Console.WriteLine("");
            // Obtendo o nome do usuário
             
            Console.Write("\nNome : ");
            nome = Console.ReadLine();
            
            //Obtendo o sexo do usuário            
            Console.Write("\nSexo : " );
            sexo = Console.ReadLine();

            //Obetendo a idade do usuário           
            Console.Write("\nIdade : ");
            idade = int.Parse(Console.ReadLine());

            //Obtendo a altura do usuário
            Console.Write("\nAltura : ");
            altura = double.Parse(Console.ReadLine());

            //Obtendo o peso do usuário
            Console.Write("\nPeso: ");
            peso=double.Parse(Console.ReadLine());

            Console.WriteLine($"Nome:{nome}\n"+
                              $"idade:{idade}\n"+
                              $"sexo:{altura}\n");


        }
    }
}
