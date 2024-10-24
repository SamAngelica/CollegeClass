using System;

class Program
{
    public static void Main(string[] args)
    {
        string nome, senha;

        Console.WriteLine("Digite o usuário");
        nome = Console.ReadLine();

        Console.WriteLine("Digite a senha");
        senha = Console.ReadLine();

        if (nome == "Samara" && senha == "12345")
        {
            Console.WriteLine("Acesso liberado");
        }
        else
        {
            Console.WriteLine("Acesso negado");
        }
    }
}
