using System;

namespace BolasColoridas
{
   class Cor
   {
       private int _red;
       private int _green;
       private int _blue;
       private int _alpha;

       // Construtor que aceita todos os parâmetros
       public Cor(int red, int green, int blue, int alpha)
       {
           _red = red;
           _green = green;
           _blue = blue;
           _alpha = alpha;
       }

       // Construtor que aceita red, green, blue e define alpha como 255
       public Cor(int red, int green, int blue) : this(red, green, blue, 255)
       {
       }

       // Métodos getter e setter para red
       public int Red
       {
           get { return _red; }
           set { _red = value; }
       }

       // Métodos getter e setter para green
       public int Green
       {
           get { return _green; }
           set { _green = value; }
       }

       // Métodos getter e setter para blue
       public int Blue
       {
           get { return _blue; }
           set { _blue = value; }
       }

       // Métodos getter e setter para alpha
       public int Alpha
       {
           get { return _alpha; }
           set { _alpha = value; }
       }

       // Método getter para obter o grau de cinzento
       public int GrauCinzento
       {
           get { return (_red + _green + _blue) / 3; }
       }

       // Exemplo de uso:
       static void Main()
       {
           Cor cor1 = new Cor(100, 150, 200, 128);
           Console.WriteLine($"Componentes da cor1: Red={cor1.Red}, Green={cor1.Green}, Blue={cor1.Blue}, Alpha={cor1.Alpha}");
           Console.WriteLine($"Grau de cinza da cor1: {cor1.GrauCinzento}");

           Cor cor2 = new Cor(50, 75, 100);
           Console.WriteLine($"Componentes da cor2: Red={cor2.Red}, Green={cor2.Green}, Blue={cor2.Blue}, Alpha={cor2.Alpha}");
           Console.WriteLine($"Grau de cinza da cor2: {cor2.GrauCinzento}");
       }
   }
