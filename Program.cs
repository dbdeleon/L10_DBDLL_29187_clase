using System;

namespace L10_DBDLL_29187_clase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio LAB 10 - AL CUADRADO -");
            Console.WriteLine(alCuadrado(10));
            int segundoResutado = alCuadrado(5);
            Console.WriteLine(segundoResutado);
        }

        public static int alCuadrado(int numero)
        {
            int resultado = numero * numero;
            return resultado;
        }   



        
    }
}
