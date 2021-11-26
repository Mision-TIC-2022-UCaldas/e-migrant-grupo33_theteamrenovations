using System;

namespace Hackaton
{
    class Program
    {
        static void Main(string[] args)
        {
            float peso = 0;
            float estatura = 0;
            float IMC = 0;
            String Estado = "";

            Console.WriteLine("Ingrese el peso kilogramos");
            peso = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la estatura en metros:");
            estatura = float.Parse(Console.ReadLine());
            IMC = (peso / (estatura * estatura));

            //calcular rango de IMC			
            if (IMC < 16)
            {
                Estado = "Delgadez Severa";
            }

            if ((IMC >= 16) && (IMC < 16.99))
            {
                Estado = "Delgadez Moderada";
            }

            if ((IMC >= 17) && (IMC < 18.49))
            {
                Estado = "Delgadez Aceptable";
            }
            if ((IMC >= 18.5) && (IMC < 24.99))
            {
                Estado = "Peso Normal";
            }

            if ((IMC >= 30) && (IMC < 34.99))
            {
                Estado = "Obesidad Tipo 1";
            }


            if ((IMC >= 35) && (IMC < 39.99))
            {
                Estado = "Obesidad Tipo II";
            }


            if ((IMC >= 40) && (IMC < 49.99))
            {
                Estado = "Obesidad Tipo III o Morbida";
            }

            if (IMC >= 50)
            {
                Estado = "Obesidad tipo IV o extrema";
            }


            Console.WriteLine("Su IMC es: " + IMC);
            Console.WriteLine("Su estado es: " + Estado);

        }
    }
}
