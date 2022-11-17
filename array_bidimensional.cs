using System;
//using System.IO;

namespace arrayBidimensional_temperatura28días
{
    class Program
    {
        static void Main (string[] args)
        {
        Console.Clear();

            decimal[,] arreglo_numerico = new decimal[4,7]; 
            decimal numero=0;
            decimal suma=0;
            decimal promedio=0;

            Console.Write("Ingresar la temperatura diaria durante una semana, para calcular el promedio");

            for (int i = 0; i < 4; i++)
            {
                for (int c = 0 ; c < 7 ; c++)
                {
                    Console.Write("\nPor favor, ingrese la temperatura para el día {0} de la semana {1}: " , c+1 , i+1);
                    numero = Convert.ToDecimal (Console.ReadLine());
                    arreglo_numerico[i,c] = numero;
                }
            }

            Console.Clear();
            Console.WriteLine("\nLa temperatura registrada cada día fue de: "); 

            for (int i = 0; i < 4; i++)
            {
                for (int c = 0 ; c < 7 ; c++)
                {
                    Console.Write("["+arreglo_numerico[i,c]+"] ");
                    suma = suma+arreglo_numerico[i,c]; 
                }
                Console.Write("\n");
            }

            promedio = suma/28;
            Console.Write("\nEl promedio de las temperaturas registradas es de: {0}", promedio);
    
            Console.WriteLine("\n¡Gracias por utilizar el programa!"); 
            Console.WriteLine("\n(Por favor, presione una tecla para finalizar)");
            Console.ReadKey();
        } 
    }
}

