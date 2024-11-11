using System;

class Program {
  public static void Main (string[] args) {

    Console.Write("Digite a sua idade: ");
int idade = int.Parse(Console.ReadLine());

    if(idade > 0){
    
  if (idade >= 70) {
    Console.WriteLine("Você  tem 70 ou mais anos e seu voto é opcional.");
  }
      else if (idade >= 18) {
        Console.WriteLine ("Você é uma pessoa maior de idade e seu voto é obrigatório.");
      }
      else if (idade >= 16) {
      Console.WriteLine ("Seu voto ainda é opçãonal.");
    
    }
      else {
        Console.WriteLine ("Você ainda não pode votar, pois é muito jovem.");
    }
      
      }
    else 
      {
      Console.WriteLine("Digite um número válido, não tem como ter uma idade negativa.");
      }}}
