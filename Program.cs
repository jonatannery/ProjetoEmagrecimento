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
            int idade = 0;
            double peso, altura;
            string nome, sexo, categoria;
            bool validarIdade, validadeAltura, validadePeso;

            // O usuário esta tendo a infomação do inicio do programa.
            Console.WriteLine("                 |     Sistema de controle de IMC.      |                        \n" );
            Console.WriteLine("");

            Console.WriteLine("||-----------------------------------//-------------------------------------------|| \n");


            Console.WriteLine("por favor, insira seus dados. \n");


            // Obtendo o nome do usuário.

            Console.Write("Nome : ");
            nome = Console.ReadLine();

            //Obtendo o sexo do usuário.       
            Console.Write("Sexo (M ou F): ");
            sexo = Console.ReadLine().ToUpper(); //ToUpper vai deixar a primeira letra da palavra maiuscula .

            //atribuindo o caractere para o sexo do usuário "m" para masculino e "f " para feminino com uma condição
            //caso o usuário digite palavras que nao seja "m" ou "f".
            while (sexo != "M" && sexo != "F")
            {
                //se o usuário digitar palavras diferente do que é pedido ,aparecerá essa informação
                Console.WriteLine("informação invalida, insira o sexo novamente.");

                // repetindo para o usuario digitar novamente ,caso seja diferente do que é pedido.
                Console.Write("Sexo (M ou F): ");
                sexo = Console.ReadLine().ToUpper();

            }
            //atribuindo o sexo.
            if (sexo == "M")
            {
                sexo = "masculino";
            }
            else if (sexo == "F") 
            {
                sexo = "feminino";
            }


            //Obtendo a idade do usuário           
            Console.Write("Idade : ");
            validarIdade = int.TryParse(Console.ReadLine(), out idade);

            //validando somente números positivos.
            while (validarIdade == false || idade <= 0)  // idade tem que ser valores positivos
            {
                Console.WriteLine("Não identificamos sua idade .Por favor insira a idade novamente:");
                Console.Write("Idade : ");
                validarIdade = int.TryParse(Console.ReadLine(), out idade);
            }


            //Obtendo a altura do usuário
           
            Console.Write("Altura : ");
            validadeAltura = double.TryParse(Console.ReadLine(), out altura);
            while (validadeAltura == false || altura <= 0)
            {
                //altura deve ter valores positivos
                //validando somente números positivos.
                Console.WriteLine("Não identificamos sua altura.Por favor insira a altura novamente: ");
                Console.Write("Altura : ");
                validadeAltura = double.TryParse(Console.ReadLine(), out altura);
            }


            //obtendo o peso do usuário
            Console.Write("Peso : ");
            validadePeso = double.TryParse(Console.ReadLine(), out peso);
            while (validadePeso == false || peso <= 0)
            {
                //peso deve ter valores positivos
                //validando somente números positivos.
                Console.WriteLine("Não identificamos seu peso. Por favor insira o peso novamente! \t");
                Console.Write("Peso : ");
                validadePeso = double.TryParse(Console.ReadLine(), out peso);

            }

            // saber  a categoria do usuário.

            /* foi criado uma variavel int "auxCategoria" recebendo a "idade" ,
            a variavel "auxCategoria" foi colocada dentro da função
            "Categoria:aonde mostra a categoria do usuário " e a variavel "Categoria" recebeu
            a função "Categoria(auxCategoria).*/
            Console.Write("Categoria : ");
            int auxCategoria = idade;
            categoria = Categoria(auxCategoria);
            Console.WriteLine(categoria);




            
            Console.WriteLine("\n ||-----------------------------------//-------------------------------------------|| \n");
            Console.WriteLine("\n                    --  DIAGNÓSTICO PRÉVIO --             \n");
            Console.WriteLine($"Nome: {nome}\n" +
                              $"Sexo: {sexo} \n" +
                              $"Idade:{idade} anos\n" +
                              $"Altura: {altura} metros\n" +
                              $"Peso: {peso} kg\n" +
                              $"Categoria: {categoria}\n\n");
            

            double auxImc = Imc(altura, peso);
            // foi criado o método "Imc" obtendo a fórmula para calcular o IMC do usuário.
            Console.WriteLine($"IMC desejável: entre 20 e 24 .\n\n"+
                              $"Resultado IMC: {auxImc} ");
            Classificacao(auxImc); /*foi criado o metodo " Classificação" para visualizar a classificação do usuario 
                                              com os dados de "riscos" e " recomendações iniciais "*/
            





















        }
        // condição pra obter a categoria do usuário
        //foi criado um método para saber a categoria do usuário 
        static string Categoria(int idade)
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

        //Foi criado um método para saber a classificação do usuario
        //A classificação é baseada no índice de massa corporal(IMC).
        static void Classificacao(double imc)
        {
            if (imc < 20)
            {
                Console.WriteLine("Abaixo do peso Ideal ");

                Console.WriteLine("Riscos: Muitas complicações de saúde como doenças pulmonares " +
                                  " e cardiovasculares podem estar associadas ao baixo peso. \n");

                Console.WriteLine("Recomendação inicial:Inclua carboidratos simples em sua dieta," +
                                  " além de proteínas - indispensáveis para ganho de massa magra." +
                                  " Procure um profissional.\n");
            }
            else if (imc >= 20 && imc <= 24)
            {
                Console.WriteLine("Peso normal ");
                Console.WriteLine("Riscos: Seu peso está ideal para suas referências. \n");
                Console.WriteLine("Recomendação inicial: Mantenha uma dieta saudável e faça seus" +
                                  " exames periódicos.\n");
            }
            else if (imc >= 25 && imc <= 29)
            {
                Console.WriteLine("Excesso de peso ");
                Console.WriteLine("Riscos: Aumento de peso apresenta risco moderado" +
                    " para outras doenças crônicas" +
                    " e cardiovasculares. \n ");


                Console.WriteLine("Recomendação inicial:Adote um tratamento baseado em " +
                    "dieta balanceada,exercício físico e medicação." +
                    " A ajuda de um profissional pode ser interessante .\n");
            }
            else if (imc >= 30 && imc <= 35)
            {
                Console.WriteLine("Obesidade \n");

                Console.WriteLine("Riscos: Quem tem obesidade vai estar mais" +
                                  " exposto a doenças graves e ao" +
                                  " risco de mortalidade. \n");

                Console.WriteLine("Recomendação inicial: Adote uma dieta " +
                                  "alimentar rigorosa, com o acompanhamento" +
                                  " de um nutricionista e um médico especialista (endócrino).");
            }
            else
            {
                Console.WriteLine("Super obesidade \n");

                Console.WriteLine("Riscos: O obeso mórbido vive menos tem" +
                                  " alto risco de mortalidade geral por " +
                                  "diversas causas.\n");

                Console.WriteLine($"Recomendação inicial: Procure com urgência o  acompanhamento de um nutricionista" +
                                 $" para realizar reeducação alimentar, um psicólogo e um médico especialista (endócrino).\n");

            }

            

        }

        static double Imc(double altura, double peso)
        {
            double imc = peso / Math.Pow(altura, 2);
            return imc;
        }

    }



}
