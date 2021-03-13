using System;

namespace Repaso3
{
    class MainClass
    {
        //Chequear si una palabra es un Palíndromo

        public static void Main(string[] args)
        {
            bool esPalindromo(string palabra)
            {
                if (palabra == "") return false;
                string reverso = "";
                for(int i = palabra.Length-1; i > -1; i--)
                {
                    reverso += palabra[i];
                }
                if (reverso == palabra)
                {
                    return true;
                }
                else { return false; }
            }



            string palabraIngresada = "";
            do
            {
                Console.WriteLine("Ingresar una palabra");
                palabraIngresada = Console.ReadLine();
                if (palabraIngresada == "") Console.WriteLine("Algo, no vacío");
            } while (palabraIngresada == "");


            if (esPalindromo(palabraIngresada))
            {
                Console.WriteLine(palabraIngresada + "-> es un palíndromo");
            } else
            {
                Console.WriteLine(palabraIngresada + "-> no es un palíndromo");
            }

            //test
            Console.WriteLine(esPalindromo("neuquen"));
            Console.WriteLine(esPalindromo("chubut"));
            Console.WriteLine(esPalindromo("salta"));
            Console.WriteLine(esPalindromo("salas"));
            Console.WriteLine(esPalindromo("alla"));

        }
    }
}
