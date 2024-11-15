using System;

class Program {
  public static void Main (string[] args) {
    
//Elabore um programa que receba a nota de um aluno e diga se o mesmo foi aprovado ou reprovado. O aluno é aprovado com nova maior ou igual a 6,0 (seis).

    Console.Write("Digite sua nota: ");
    int nota = int.Parse(Console.ReadLine());

    if (nota >= 6){
      Console.WriteLine("Nota suficiente. Aprovado.");}

    else {
      Console.WriteLine("Nota insuficiente. Reprovado.");}
   
    }
  }