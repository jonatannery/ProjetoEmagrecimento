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
            sexo = sexo.ToUpper();
            while(sexo != "masculino" && sexo != "feminino")
            {
                Console.WriteLine("informação invalida, insira o sexo novamente.");
            }
            

            //Obetendo a idade do usuário           
            Console.Write("\nIdade : ");
            idade = int.Parse(Console.ReadLine());
             


            //Obtendo a altura do usuário
            Console.Write("\nAltura : ");
            altura = double.Parse(Console.ReadLine());

            //Obtendo o peso do usuário
            Console.Write("\nPeso: ");
            peso=double.Parse(Console.ReadLine());





            /*Console.WriteLine($"Nome:{nome}\n"+
                              $"idade:{idade}\n"+
                              $"sexo:{altura}\n");
*/

        }

        private static string Categoria (int idade)
        {
            if (idade < 12)
            { 
                return "Infantil"; 
            }
            else if (idade >= 12 && idade <= 20)
            {
                return "Juvenil";
            }
            else if (idade >= 21 && idade <= 65)
            {
                return "Adulto"; 
            }
            else  
            { 
                return "Idoso"; 
            }

        }
        private void Classificacao(double imc)
        {
            if(imc < 20)
            {
                Console.WriteLine("Abaixo do peso Ideal");
            }
            else if (imc >= 20 && imc <= 24)
            { 
                Console.WriteLine("Peso normal"); 
            }
            else if (imc >= 25 && imc <=29)
            {
                Console.WriteLine("Excesso de peso");
            }
            else if(imc >=30 && imc <= 35)
            {
                Console.WriteLine("Obesidade");
            }
            else
            {
                Console.WriteLine("Super obesidade"); 
            }

        }
  
    
    }



}
