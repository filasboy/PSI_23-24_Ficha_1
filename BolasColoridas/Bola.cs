using System;

namespace BolasColoridas
{
  class Bola
  {
      // Estado da bola
      private string cor;
      private double raio;
      private int vezesAtirada;

      // Construtor padrão
      public Bola(string cor, double raio)
      {
          this.cor = cor;
          this.raio = raio;
          this.vezesAtirada = 0;
      }

      // Método para furar a bola
      public void Pop()
      {
          this.raio = 0;
          Console.WriteLine("A bola foi furada!");
      }

      // Método para atirar a bola
      public void Atirar()
      {
          if (this.raio > 0)
          {
              this.vezesAtirada++;
              Console.WriteLine("Bola atirada! Número de vezes atirada: " + this.vezesAtirada);
          }
          else
          {
              Console.WriteLine("A bola está furada e não pode ser atirada.");
          }
      }

      // Método para obter o número de vezes que a bola foi atirada
      public int GetVezesAtirada()
      {
          return this.vezesAtirada;
      }
    // metado
    public double getraio()
    {
    return raio;
    }
  }
  }