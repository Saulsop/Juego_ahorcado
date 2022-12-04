using System;

namespace ahorcado
{
    class Program
    {
        static void Main(string[] args)
        {
 //ARROJA LA  PALABRA AL AZAR 
            string[] palabras = {"hola", "benito", "hakunamatata"};
        Random generador = new Random();
        int numeroAzar = generador.Next(0, palabras.Length);
        string palabraAdivinar = palabras[numeroAzar];

            //MUESTRA LOS GUIONES DE LA PALABRA ARROJADA
        string palabraMostrar = "";
        for (int i = 0; i < palabraAdivinar.Length; i++)
            if (palabraAdivinar[i] == ' ')
                palabraMostrar += " ";
            else
                palabraMostrar += "-";

           //Numero de vidas
        int fallosRestantes = 8;
        char letraActual;
        bool terminado = false;

                //Bucle
        do
        {
           //Se muestra la palabra oculta y las vidas
            Console.WriteLine("La palabra es : \n" + palabraMostrar);
            Console.WriteLine("Numeros de vidas " + fallosRestantes);

            //el usuario ingresa la letra
            Console.WriteLine("ingrese la letra: ");
            letraActual = Convert.ToChar(Console.ReadLine());

            //si esta mal la palabra pierde una vida
            if (!palabraAdivinar.Contains(letraActual))
            {
                fallosRestantes--;
                MostrarHorca(fallosRestantes);
            }

            //Si la palabra existe, el jugador no pierde vidas
            string siguienteMostrar = "";

           for (int a = 0; a < palabraAdivinar.Length ; a++)
                    {
                        if (letraActual == palabraAdivinar[a])
                        {
                            siguienteMostrar += letraActual;
                        }else
                        {
                            siguienteMostrar += palabraMostrar[a];
                        }
                    }
            palabraMostrar = siguienteMostrar;

            //Se comprueba si termino con las vidas completas o no
           if (! palabraMostrar.Contains("-"))
                    {
                        Console.WriteLine("Ahuevo, lo hiciste bien ({0})", palabraAdivinar);
                        terminado = true;
                    }
                    else
                    {
                        if (fallosRestantes == 0)
                        {
                            Console.WriteLine("Perdistes, la palabra es" + palabraAdivinar);
                            terminado = true;
                        }
                        Console.WriteLine();
                    }

                } while (!terminado);
    }

    static void MostrarHorca(int fallosRestantes)
    {
        switch (fallosRestantes)
        {
            case 7:
                Console.WriteLine("-");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("----");
                break;
            case 6:
                Console.WriteLine("-------");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("----");
                break;
            case 5:
                Console.WriteLine("-------");
                Console.WriteLine("|    |");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("----");
                break;
            case 4:
                Console.WriteLine("-------");
                Console.WriteLine("|    |");
                Console.WriteLine("|    O");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("----");
                break;
            case 3:
                Console.WriteLine("-------");
                Console.WriteLine("|    |");
                Console.WriteLine("|    O");
                Console.WriteLine("|   (|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("----");
                break;
            case 2:
                Console.WriteLine("-------");
                Console.WriteLine("|    |");
                Console.WriteLine("|    O");
                Console.WriteLine("|  ( | )");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("----");
                break;
            case 1:
                Console.WriteLine("-------");
                Console.WriteLine("|    |");
                Console.WriteLine("|    O");
                Console.WriteLine("|  ( | )");
                Console.WriteLine("|   | |");
                Console.WriteLine("|");
                Console.WriteLine("----");
                break;
            case 0:
                Console.WriteLine("-------");
                Console.WriteLine("|    |");
                Console.WriteLine("|    O");
                Console.WriteLine("|  ( | )");
                Console.WriteLine("|   | |");
                Console.WriteLine("|");
                Console.WriteLine("----");
                break;

      }              }
    }
}
