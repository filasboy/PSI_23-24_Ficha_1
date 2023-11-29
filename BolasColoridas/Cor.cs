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

       
   }
  }