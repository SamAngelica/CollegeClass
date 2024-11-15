using System;

class Program {
  public static void Main (string[] args) {
    
//Escreva um programa para que sejam informados 5 (cinco) números inteiros. O programa deve informar o menor e o maior valor informado.
    
    Console.WriteLine("Digite 5 números inteiros, um por vez.");
    Console.WriteLine();
     Console.Write("Digite um número: ");
    int numero = int.Parse(Console.ReadLine());  

    int maior = numero;
    int menor = numero;

    int cont = 1;

    while(cont < 5){
      Console.Write("Digite um número: ");
      numero = int.Parse(Console.ReadLine());

      if(numero > maior){
        maior = numero;
      }
      else if (numero < menor){
        menor = numero;
      }
      cont++;
    }
    Console.WriteLine();
    Console.WriteLine("Menor número informado: " + menor);
    Console.WriteLine("Maior número informado: " + maior);
    
    
      
      }

    } 
  
