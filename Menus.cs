﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_JP_SistemaVeterinario
{
    public class Menus
    {
        //Se coloca "static" para no tener que crear el objeto cuando use las funciones de esta clase
        //Menú de presentación de la empresa
        static public void Presentacion()
        {
            Console.ForegroundColor = ConsoleColor.Cyan; //Cambiamos el color de letra a celeste
            Console.WriteLine("\n\t\t\t\t=============================================================");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\t\t||                                                         ||");
            Console.WriteLine("\t\t\t\t||                                                         ||");
            Console.WriteLine("\t\t\t\t||                     ████      ████                      ||");
            Console.WriteLine("\t\t\t\t||                   ████████  ████████                    ||");
            Console.WriteLine("\t\t\t\t||                   ████████  ████████                    ||");
            Console.WriteLine("\t\t\t\t||                   ████████  ████████                    ||");
            Console.WriteLine("\t\t\t\t||             ████    ████      ████    ████              ||");
            Console.WriteLine("\t\t\t\t||           ████████                  ████████            ||");
            Console.WriteLine("\t\t\t\t||           ████████                  ████████            ||");
            Console.WriteLine("\t\t\t\t||           ████████      ██████      ████████            ||");
            Console.WriteLine("\t\t\t\t||             ████      ██████████      ████              ||");
            Console.WriteLine("\t\t\t\t||                     ██████████████                      ||");
            Console.WriteLine("\t\t\t\t||                   ██████████████████                    ||");
            Console.WriteLine("\t\t\t\t||                 ██████████████████████                  ||");
            Console.WriteLine("\t\t\t\t||                 ██████████████████████                  ||");
            Console.WriteLine("\t\t\t\t||                 ██████████████████████                  ||");
            Console.WriteLine("\t\t\t\t||                   ██████████████████                    ||");
            Console.WriteLine("\t\t\t\t||                     ██████  ██████                      ||");
            Console.WriteLine("\t\t\t\t||                                                         ||");
            Console.WriteLine("\t\t\t\t||                                                         ||");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t\t\t\t=============================================================");
            Console.WriteLine("\t\t\t\t|-                 VETERINARIA RAMOS S.A.                  -|");
            Console.WriteLine("\t\t\t\t=============================================================");
            Console.WriteLine("\n\t\t\t\t\t\t\t----------------");
            Console.WriteLine("\t\t\t\t\t\t\t  ¡Bienvenido!  ");
            Console.WriteLine("\t\t\t\t\t\t\t----------------");
            Console.Write("\t\t\t\t\t\t\t    Entrar...   ");
            Console.ReadKey();
            Console.Clear();
        }

        //Menú principal
        static public int MenuPrincipal()
        {
            int opcion = 0;
            bool flag = false;
            //Generamos un contador de recursividad para que cada vez que llame a la misma función,
            //cuando la última llamada termine, se aumente en uno y no guarde el valor "opción" de la función anterior,
            //que sería un "string" (por eso se llamó a la misma función), que genera un error ya que no se
            //puede guardar una variable "string" en un "int". La recursividad como tal matienen un historial compuesto
            //por todas las veces que se ha entrado a la misma función y cuando termina su trabajo y cumple con la condición
            //puesta para llamar a la misma función, va cerrando una por una las veces que se ha ingresado a la misma función (va retrocediendo)
            int contDeRecursividad = 0;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\n\n\t\t\t\t\t========= Menú Veterinaria =========");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\t\t\t\t\t 1. Agregar Mascota");
            Console.WriteLine("\n\t\t\t\t\t 2. Mostrar Mascotas");
            Console.WriteLine("\n\t\t\t\t\t 3. Eliminar Mascota por Código");
            Console.WriteLine("\n\t\t\t\t\t 4. Modificar Mascota por Código");
            Console.WriteLine("\n\t\t\t\t\t 5. Buscar Mascota por Código");
            Console.WriteLine("\n\t\t\t\t\t 6. Pasar Mascotas de Cola a Pila");
            Console.WriteLine("\n\t\t\t\t\t 7. Insertar en la cola valores por defecto");
            Console.WriteLine("\n\t\t\t\t\t 8. Generar Reporte de Mascotas");
            Console.WriteLine("\n\t\t\t\t\t 9. Salir");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\t\t\t\t\t====================================");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\t\t\t\t\tElija una opción: ");
            string opcion1 = Console.ReadLine();
            //Validamos si la opción es entera mandando "flag" como referencia para que se modifique dentro de la función
            Validaciones.Entero(opcion1, ref flag);
            //Si no es, por recursividad volvemos al menú principal
            if (flag == false)
            {
                Console.WriteLine("\n\t\t\t\t\t¡Error! Ingrese un número entero...");
                Console.ReadKey();
                Console.Clear();
                opcion = MenuPrincipal();
                contDeRecursividad += 1;
            }
            //Si es la primera vez que se llama a la función, entonces se le agrega el
            //valor (que sería un entero ya que solo vuelve a llamar a la misma función cuando no es de este tipo de variable)
            if (contDeRecursividad == 0)
            {
                opcion = int.Parse(opcion1);
            }
            return opcion;
        }

        //Menú secundario
        static public void Encabezado(string encabezado)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\t\t\t\t\t===========================================");
            Console.WriteLine($"\n\t\t\t\t\t {encabezado}...");
            Console.WriteLine("\n\t\t\t\t\t===========================================");
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
    }
}