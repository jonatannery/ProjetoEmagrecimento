using System;
using System.Globalization;

namespace ProgramaEmagrecimento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Início do projeto

            //variaveis do projeto
            int idade=0;
            double peso, altura, IMC;
            string nome, sexo, categoria;
            bool validarIdade , validadeAltura, validadePeso;

            // O usuário esta tendo a infomação do inicio do programa.
            Console.WriteLine("Sistema de controle de IMC. ");


            Console.WriteLine("");

            Console.WriteLine("por favor, insira seus dados. \n");

           
            // Obtendo o nome do usuário

            Console.Write("Nome : ");
            nome = Console.ReadLine();

            //Obtendo o sexo do usuário            
            Console.Write("Sexo (M ou F): ");
            sexo = Console.ReadLine().ToUpper(); 

            //atribuindo o caractere para o sexo do usuário

            while (sexo != "M" && sexo != "F")
            {

                Console.WriteLine("informação invalida, insira o sexo novamente.");
                Console.Write("Sexo (M ou F): ");
                sexo = Console.ReadLine().ToUpper();
                
            }
            //atribuindo o sexo.
            if (sexo == "M")
            {
                sexo = "masculino";
            }
            else if (sexo == "F") ;
            {
                sexo = "feminino";
            }


            //Obetendo a idade do usuário           
            Console.Write("Idade : ");
            validarIdade = int.TryParse(Console.ReadLine(),out idade);

            while (validarIdade == false ||idade <=0)  // idade tem que ser valores positivos
            {
                Console.WriteLine("Não identificamos sua idade .Por favor insira a idade novamente:");
                Console.Write("Idade : ");
                validarIdade = int.TryParse(Console.ReadLine(),out idade);
            }


            //Obtendo a altura do usuário
            Console.Write("Altura : ");
            validadeAltura = double.TryParse(Console.ReadLine(),out altura);
            while (validadeAltura == false || altura <= 0)
            {
                //altura deve ter valores positivos
                Console.WriteLine("Não identificamos sua altura.Por favor insira a altura novamente: ");
                Console.Write("Altura : ");
                validadeAltura = double.TryParse(Console.ReadLine(), out altura);
            }

            //obtendo o peso do usuário
            Console.Write("Peso : ");
            validadePeso =double.TryParse(Console.ReadLine(),out peso);
            while(validadePeso == false || peso <= 0)
            {
                //peso deve ter valores positivos
                Console.WriteLine("Não identificamos seu peso. Por favor insira o peso novamente!");
                Console.Write("Peso : ");
                validadePeso = double.TryParse(Console.ReadLine(), out peso);

            }

            // saber  a categoria do usuário
            Console.Write("Categoria : ");
            int entrarCategoria = idade;
            categoria=Categoria(entrarCategoria);

            Console.WriteLine(categoria);

        }

        private static string Categoria(int idade)
        {
            if (idade <= 12)
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
            if (imc < 20)
            {
                Console.WriteLine("Abaixo do peso Ideal \t");

                Console.WriteLine(@"Riscos: Muitas complicações de saúde como doenças pulmonares 
                                   e cardiovasculares podem estar associadas ao baixo peso. \t");

                Console.WriteLine(@"Inclua carboidratos simples em sua dieta, além de proteínas -
                                    indispensáveis para ganho de massa magra. Procure um profissional .");
            }
            else if (imc >= 20 && imc <= 24)
            {
                Console.WriteLine("Peso normal \t");
                Console.WriteLine("Riscos: Seu peso está ideal para suas referências. \t");
                Console.WriteLine(@"Recomendação inicial: Mantenha uma dieta saudável e faça 
                                   seus exames periódicos.");
            }
            else if (imc >= 25 && imc <= 29)
            {
                Console.WriteLine("Excesso de peso \t");
                Console.WriteLine(@"Riscos: Aumento de peso apresenta risco moderado
                                    para outras doenças crônicas e cardiovasculares. \t ");


                Console.WriteLine(@"Recomendação inicial:Adote um tratamento baseado
                                    em dieta balanceada, exercício físico e medicação.
                                    A ajuda de um profissional pode ser interessante \t ");
            }
            else if (imc >= 30 && imc <= 35)
            {
                Console.WriteLine("Obesidade \t");

                Console.WriteLine(@"Riscos: Quem tem obesidade vai estar mais exposto a doenças 
                                    graves e ao risco de mortalidade. \t");

                Console.WriteLine(@"Recomendação inicial: Adote uma dieta alimentar rigorosa, 
                                    com o acompanhamento de um nutricionista e
                                    um médico especialista (endócrino).");
            }
            else
            {
                Console.WriteLine("Super obesidade \t);");

                Console.WriteLine(@"Riscos: O obeso mórbido vive menos
                                    tem alto risco de mortalidade geral por diversas causas.");

                Console.WriteLine(@"Recomendação inicial: Procure com urgência o acompanhamento 
                                    de um nutricionista para realizar reeducação alimentar, 
                                    um psicólogo e um médico especialista (endócrino).");

            }



        }



    }



}
