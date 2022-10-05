using System;

namespace NetCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Tipos de variables */
            int year = 2022;
            int y = Convert.ToInt16("20");
            double doubles = 10.8;
            string saludo = "Hola Mundo";
            //string nombres = "Jesus Solis";
            decimal n = 2.07M;

            //Console.WriteLine("Jesus Solis Martinez! " + year);
            //Console.WriteLine(nombres + " Jesus Solis Martinez! {0} {1} {2} ", year, doubles, saludo);
            //Console.WriteLine("Variables: " + y + ", " + doubles + ", " + saludo + ", " + n);

            //float 7 digitos 32 bits
            //double 15-16 digitos 64 bits
            //decimal 28-29 digitos 128 bits

            //Console.WriteLine("");

            float flotante = 8.5F;
            bool verdadero = true;
            char letra = 'A';
            Decimal de = 28.4M;
            Boolean f = false;

            //Console.WriteLine("Otras: " + flotante + ", " + verdadero + ", " + letra + ", " + de + ", " + f);


            /* Operadores Aritmeticos */
            /* (+, -, *, /)  */

            int a = 10;
            int b = 5;
            var suma = a + b;
            var resta = a - b;
            var multi = a * b;
            var div = a / b;

            //Console.WriteLine("Suma: " + suma);
            //Console.WriteLine("Resta: " + resta);
            //Console.WriteLine("Multiplicación: " + multi);
            //Console.WriteLine("División: " + div);

            Console.WriteLine("================================");
            /* Operadores de Asignación */
            /* (=, +=, -=, *=, /=, %=)  */

            int v1 = 1;
            int v2 = 8;

            v1 += v2;

            v2 -= 5;

            //Console.WriteLine(v1 + " " + v2);

            v1 *= v2;

            //Console.WriteLine(v1);

            /* Operadores de Comparacion */
            /* (>, <, <=, >=) */

            var data = v1 > v2;
            //Console.WriteLine(data);

            /* Operadores de Igualdad */
            /* (!=, ==) */

            var data2 = v1 < v2;
            //Console.WriteLine(data2);

            /* Estructuras condicionales */
            /* (!=, ==, &&, ||) */
            int n1 = 10;
            int n2 = 40;

            if(n1 < n2)
            {
                //Console.WriteLine("Menor");
            }
            else
            {
                //Console.WriteLine("Mayor");
            }

            //Console.WriteLine("================================");

            string name;
            name = data2 ? "Jesus" : "Solis";

            //Console.WriteLine(name);

            //Console.WriteLine("================================");
            /* Arrays */

            string[] nombres = new string[3];
            nombres[0] = "Jesus";
            nombres[1] = "Solis";
            nombres[2] = "Martinez";

            string[] names = { "Solis", "Martinez", "Carmen" };

            //Console.WriteLine("Array: " + nombres.Length);

            //Console.WriteLine("Contenido Array: " + nombres[0] + "  " + names[2]);


            int[] ages = new int[2];

            ages[0] = 30;
            ages[1] = 45;

            int[] ages2 = { 2, 3 };

            //Console.WriteLine("Contenido Array Int: " + ages[0] + "  " + ages2[1]);

            double[,] doble= new double[2, 2] { { 6, 3.0 }, { 6.3,5.6} };

            //Console.WriteLine("Contenido Doble: " + doble[0,1] + "  " + doble[1,0]);

            double[,,] doble2 = new double[2, 2, 3] { { { 3.0, 6.9, 8.9 }, { 5.3, 6.1, 8.1 } }, { { 3.0, 6.9, 8.9 }, { 5.3, 6.1, 8.1 } } };

            //Console.WriteLine("Contenido Doble: " + doble2[0, 1, 2]);

            Console.WriteLine("================================");
            /* Ciclo For */
            for (int i=0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("================================");
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("================================");

            string[] nn = { "Jesus", "Solis", "Martinez" };

            for (int i=0; i < nn.Length; i++)
            {
                Console.WriteLine(nn[i]);
            }
        }
    }
}
