using System;

class Program {
  public static void Main (string[] args) {
    
//Um município deseja saber a porcentagem de votos de três candidatos, além da porcentagem de votos brancos e nulos. Monte um programa que receba como entrada o número de votos de cada um dos três candidatos e também os votos nulos e brancos. Ao final, o programa deve apresentar o total de votos e a porcentagem, em relação a todos os eleitores que votaram, de votos de cada candidato, votos nulos e votos em branco.

    Console.Write("Digite o números de votos do candidato A: ");
    float candidatoA = float.Parse(Console.ReadLine());

    Console.Write("Digite o números de votos do candidato B: ");
    float candidatoB = float.Parse(Console.ReadLine());

    Console.Write("Digite o números de votos do candidato C: ");
    float candidatoC = float.Parse(Console.ReadLine());

    Console.Write("Digite o números de votos do em branco: ");
    float brancos = float.Parse(Console.ReadLine());

    Console.Write("Digite o números de votos nulos: ");
    float nulos = float.Parse(Console.ReadLine());

    float total = candidatoA + candidatoB + candidatoC + brancos + nulos;

    Console.WriteLine();

    Console.WriteLine("Total de votos: " + total);

    Console.WriteLine();
    
    Console.WriteLine("Porcentagem de votos do candidato A: " + (candidatoA / total) * 100 + "%");
    Console.WriteLine("Porcentagem de votos do candidato B: " + (candidatoB / total) * 100 + "%");
    Console.WriteLine("Porcentagem de votos do candidato C: " + (candidatoC / total) * 100 + "%");
    Console.WriteLine("Porcentagem de votos em branco: " + (brancos / total) * 100 + "%");
    Console.WriteLine("Porcentagem de votos nulos: " + (nulos / total) * 100 + "%");
  

    }
  }
  