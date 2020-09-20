//Ler um valor N é mostrar na saida o mesmo N no formato horas:minutos:segundos


using System;

namespace conversao_de_tempo
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variveis 
            int N, horas, resto, minutos, segundos;

            //pedir ao usuario que digite N
            N = int.Parse(Console.ReadLine());

            //fazer os calculos
            horas = N / 3600;
            resto = N % 3600;
            minutos = resto / 60;
            segundos = resto % 60;


            Console.WriteLine(horas + " : " + minutos + " : " + segundos);

            Console.ReadLine();
        }
    }
}
