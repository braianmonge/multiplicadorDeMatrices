using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplicadorDeMatricesPruebaPiloto
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("PRODUCTO O MULTIPLICACION DE MATRICES");
            //MATRIZZ [1] 
            Console.WriteLine("[Matriz[1] A]");//Muestra al usuario llenar la matriz 1 
            Console.Write("Inserte el Nº de Filas: ");
            int f1 = int.Parse(Console.ReadLine());//Captura numero de Filas de matriz 1 
            Console.Write("Inserte el Nº de Columnas: ");
            int c1 = int.Parse(Console.ReadLine());//Captura numero de Columnas de matriz 1 
                                                   //MATRIZZ [2] 
            Console.WriteLine("\n [Matriz[2] B]");//Muestra al usuario llenar la matriz 2 
            Console.Write("Inserte el Nº de Filas: ");//Muestra al usuario llenar el numero de Filas 
            int f2 = int.Parse(Console.ReadLine());//Captura numero de Filas de matriz 2 
            Console.Write("Inserte el Nº de Columnas: ");
            int c2 = int.Parse(Console.ReadLine());//Captura numero de Columnas de matriz 2 
                                                   //DECLARACION DE LAS MATRICES 1 Y 2 
                                                   //Las filas y columnas se suman +1 para empezar desde posicion 1 
            int[,] Matriz1 = new int[f1 + 1, c1 + 1];
            int[,] Matriz2 = new int[f2 + 1, c2 + 1]; //Matriz 2 
            int[,] Multiplicacion = new int[f1 + 1, c2 + 1];//Matriz para la multiplicacion 
                                                            //CONDICIONES 
                                                            //Si la columna de la matriz 1 es igual al numero de filasde la matriz 2 
            if (c1 == f2)
            {
                //Empezando a llenar la Matriz 1 
                Console.WriteLine(" \n Datos [Matriz 1]: ");
                for (int i = 1; i <= f1; i++)
                {
                    for (int j = 1; j <= c1; j++)
                    {
                        Console.Write("Ingresa Dato (Fila: {0} - Columna: {1}): ", i, j);
                        Matriz1[i, j] = int.Parse(Console.ReadLine());
                    }
                } //Empezando a llenar las Matriz 2 
                Console.WriteLine("Datos [Matriz 2]: ");
                for (int i = 1; i <= f2; i++)
                {
                    for (int j = 1; j <= c2; j++)
                    {
                        Console.Write("Ingresa Dato (Fila: {0} - Columna: {1}): ", i, j);
                        Matriz2[i, j] = int.Parse(Console.ReadLine());
                    }

                } //Multiplicando las 2 matrices 
                for (int i = 1; i <= f1; i++)
                {
                    for (int j = 1; j <= c2; j++)
                    {
                        Multiplicacion[i, j] = 0;
                        for (int z = 1; z <= c1; z++)
                        {
                            Multiplicacion[i, j] = Matriz1[i, z] * Matriz2[z, j] + Multiplicacion[i, j];
                        }
                    }
                }
                Console.WriteLine("Multiplicacion de 2 Matrices");
                for (int i = 1; i <= f1; i++)
                {
                    for (int j = 1; j <= c2; j++)
                    {
                        Console.Write("{0} ", Multiplicacion[i, j]); //Muestra el resultado total 

                    }
                    Console.WriteLine(); //Si la columna de la matriz 1 no es igual al numero de filasde la matriz 2 no se puede multiplicar 
                }
            }
            else
            {
                Console.WriteLine("Error: No se puede multiplicar las matrices" + " Columnas: {0}! = Filas: {1}", c1, f2);
            }
            Console.Read();
        }



    }
}

