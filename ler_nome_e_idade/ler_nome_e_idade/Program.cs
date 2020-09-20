//ler o nome e idade de duas pessoas e calcular a média entre elas

using System;
using System.Globalization;

namespace ler_nome_e_idade
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variaveis
            string nome1, nome2;
            int idade1, idade2;
            double media;

            //usar vetor para nao ler o nome em linha e sim um abaixo do outro
            string[] vet;
            vet = Console.ReadLine().Split(' ');  //separa o espaço
            nome1 = vet[0];
            idade1 = int.Parse(vet[1]); //converte para inteiro
            vet = Console.ReadLine().Split(' ');  //separa o espaço
            nome2 = vet[0];
            idade2 = int.Parse(vet[1]);

            //calculo da média
            media =(double) (idade1 + idade2) / 2.0; 

            //mostrar na tela
            Console.WriteLine("A idade media de" + nome1 + " e " + nome2 + " é de " 
                + media.ToString("F1",CultureInfo.InvariantCulture) + " anos ");

            Console.ReadLine();

        }
    }
}
