// Exercicio Vetor -> Criar um codigo a partir do passado pelo professor (uso de Vetor), so que em vez de escrever as informacoes pelo codigo, o codigo ira receber os dados.

using System;

class Program
{
    static void Main(string[] args)

    {

        double[] notasT1 = new double[30];

        for (int i = 0; i < 30; i++)
        {
            string nome = " ";
            Console.Write("Nome do Aluno: ");
            nome = Console.ReadLine();
            
            Console.Write("Nota do aluno: ");
            int.Parse(Console.ReadLine());
        }
    }
}