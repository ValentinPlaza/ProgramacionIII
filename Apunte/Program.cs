using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apunte
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            float b;
            char c='z';
            bool f;

            a = 10;
            a = (10 + 15) / 2 * 3 - 7 % 2;

            a += 10;
            a++;

            Console.WriteLine("Ingrese un numero: "); // Mostrar por pantalla
            a = int.Parse(Console.ReadLine()); //Le asigno a la variable a el valor que ingrese el usuario y con Parse convierto el string de readline en int
            a += 10;

            Console.WriteLine("El valor es " + a); // Concatenacion
            Console.ReadLine();

            if(a > 10)
            {
                Console.WriteLine("El valor es mayor a 10");
            }
            else if ((a == 5 && c=='a') || c=='z')
            {
                Console.WriteLine("El valor es igual a 5");
            }
            else
            {
                Console.WriteLine("El valor es menor a 10 pero no es 5");
            }

            if (a == 10)
                Console.WriteLine("es 10"); // se puede no usar llaves si ocupas una sola linea de codigo
            else
                Console.WriteLine("no es 10");

            switch (c)
            {
                case 'a':
                    Console.WriteLine("la variable tiene a");
                    break;
                case 'b':
                    Console.WriteLine("La variable tiene b");
                    break;
                default:
                    Console.WriteLine("kcy");
                    break;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hola mundo" + i);
            }

            //while (a!=0)
            //{

            //}

            //foreach (var item in collection)
            //{

            //}

            holamundo();

            int resultado = sumar(3, 6);
            int r = 10;
            restar(ref r, 9);
            Console.WriteLine("El resultado de la funcion restar es: ");
            Console.WriteLine(r);
            Console.ReadLine();

        }//aca termina el main

        static void holamundo()
        {
            Console.WriteLine("Hola mundo");
        }

        static int sumar(int a, int b)
        {
            return a + b;
        }

        static int restar(ref int j, int b) // Ref hace que reciba por referencia el valor, es decir, que modifica el valor en el origen de la memoria y no en al duplicada.
        {
            return j = j - b;
        }
    }
}
