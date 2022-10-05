using System;

namespace trianguloPascal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pisos = 0;
            int[] arreglo = new int[1];

            Console.WriteLine("Ingrese el numero de pisos: ");
            pisos = Convert.ToInt16(Console.ReadLine());

            for (int i= 1; i <= pisos; i++)
            {
                int[] pascal = new int[i];
                for(int j=pisos; j<i; j--)
                {
                    Console.WriteLine(" ");
                }

                for (int k=0; k<1; k++)
                {
                    if (k==0 || k == (i - 1))
                    {
                        pascal[k] = 1;
                    }
                    else
                    {
                        pascal[k] = arreglo[k] + arreglo[k - 1];
                    }
                    Console.WriteLine("[" + pascal[k] + "]");
                }
                arreglo = pascal;
                Console.WriteLine(" ");
            }
            Console.ReadLine();
        }
    }
}
