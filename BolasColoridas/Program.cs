using System;

namespace BolasColoridas
{
    class Program
    {
        static void Main(string[] args)
        {
          Cor cor1 = new Cor(100, 150, 200, 128);
           Console.WriteLine($"Componentes da cor1: Red={cor1.Red}, Green={cor1.Green}, Blue={cor1.Blue}, Alpha={cor1.Alpha}");
           Console.WriteLine($"Grau de cinza da cor1: {cor1.GrauCinzento}");

           Cor cor2 = new Cor(50, 75, 100);
           Console.WriteLine($"Componentes da cor2: Red={cor2.Red}, Green={cor2.Green}, Blue={cor2.Blue}, Alpha={cor2.Alpha}");
           Console.WriteLine($"Grau de cinza da cor2: {cor2.GrauCinzento}");
          // Exemplo de uso da classe Bola
          Bola minhaBola = new Bola("vermelha", 10.0);

          minhaBola.Atirar(); // Bola atirada! Número de vezes atirada: 1
          minhaBola.Atirar(); // Bola atirada! Número de vezes atirada: 2

          minhaBola.Pop();    // A bola foi furada!

          minhaBola.Atirar(); // A bola está furada e não pode ser atirada.

          Console.WriteLine("Número total de vezes que a bola foi atirada: " + minhaBola.GetVezesAtirada());

           Console.WriteLine("o raio:"+
             minhaBola.getraio());
          





        }
    }
}
