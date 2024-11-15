﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_JP_SistemaVeterinario
{
    internal class Arbol
    {
        public NodoVet arbolito;

        public Arbol()
        {
            arbolito = null;
        }
        public void AgregarMascota(NodoVet q)
        {
            string valorRaiz;
            NodoVet t = arbolito;

            if (arbolito == null)
            {
                arbolito = q;
            }
            else
            {
                while (t != null)
                {
                    valorRaiz = t.CodigoMascota.ToString();
                    if (q.CodigoMascota.ToString().CompareTo(valorRaiz) == -1)
                    {
                        if (t.izquierda != null)
                        {
                            t = t.izquierda;
                        }
                        else
                        {
                            t.izquierda = q;
                            return;
                        }
                    }
                    else
                    {
                        if (t.derecha != null)
                        {
                            t = t.derecha;
                        }
                        else
                        {
                            t.derecha = q;
                            return;
                        }
                    }
                }
            }
        }

        public void mostrarArbolito()
        {

        }
        public void eliminaNodoABB(ref NodoVet arbol, int dato)
        {
            NodoVet p1, p2; //p1 y p2 son enlaces de trabajo
            //Preguntar si el arbol no tiene nodos
            if (arbol == null) return; //Salir 
            //En el arbol si hay nodos
            //Si el dato a eliminar es menor al dato del nodo del arbol,
            //eliminar el nodo del arbol por la izquierda
            if (dato < arbol.CodigoMascota) eliminaNodoABB(ref arbol.izquierda, dato);
            //Eliminar el nodo del arbol por la derecha
            else if (dato > arbol.CodigoMascota) eliminaNodoABB(ref arbol.derecha, dato);
            else if (arbol.izquierda == arbol.derecha)
                //Arbol no tiene hijos
                arbol = null; //arbol apunta a null
            else if (arbol.izquierda == null)
            {
                //El arbol no tiene hijo por la izquierda
                p1 = arbol; //p1 apunta al nodo del arbol (guardar el enlace del nodo del arbol a eliminar)
                arbol = arbol.derecha; //Mover el enlace del arbol por la derecha
                p1 = null; //Eliminar el nodo
            }
            else if (arbol.derecha == null)
            {
                //El arbol no tiene hijo pór la derecha
                p1 = arbol; //p1 apunta al nodo del arbol (guardar el enlace del nodo del arbol a eliminar)
                arbol = arbol.izquierda; //Mover el enlace del arbol por la izquierda
                p1 = null; //Eliminar el nodo
            }
            else
            {
                //El arbol solo tiene dos hijos
                p1 = arbol.derecha; //p1 apunta al hijo derecho del arbol (guardar el puntero) 
                p2 = arbol.derecha; //p2 apunta al hijo derecho del arbol (para avanzar)
                //Recorrer el arbol por la izquierda 
                while (p2.izquierda != null) //Buscar el menor de los mayores
                    p2 = p2.izquierda;//Avanzar hacia el sgte hijo del arbol por la izquierda

                //Hijo izquierdo de menor de mayor = Hijo izquierdo de eliminado
                p2.izquierda = arbol.izquierda;
                arbol = null;//eliminar nodo del arbol
                arbol = p1; //El padre apunta al derecho de eliminado	
            }
        }
        public void BuscaryActualizar(int codigomascota, int opcion, int nuevocodigoM, int nuevocodigoC, string nuevoC, string nuevoAliasM, int nuevoP, int nuevoE, string nuevoR)
        {
            int valorRaiz;
            NodoVet t = arbolito;

            if (arbolito == null)
            {
                Console.WriteLine("Arbol vacio ... ");
            }
            else
            {
                while (t != null)
                {
                    valorRaiz = t.CodigoMascota;
                    if (codigomascota.CompareTo(valorRaiz) == 0)
                    {
                        Console.WriteLine("------------------------------------");
                        Console.WriteLine("\tMascota encontrado");
                        Console.WriteLine("------------------------------------");
                        Console.WriteLine("Código mascota: " + t.CodigoMascota);
                        Console.WriteLine("Código cliente: " + t.CodigoCliente);
                        Console.WriteLine("Cliente       : " + t.Cliente);
                        Console.WriteLine("Alias mascota : " + t.AliasMascota);
                        Console.WriteLine("Peso          : " + t.Peso);
                        Console.WriteLine("Edad          : " + t.Edad);
                        Console.WriteLine("Raza          : " + t.Raza);
                        Console.WriteLine("------------------------------------");
                    }

                    if (codigomascota.CompareTo(valorRaiz) == -1)
                    {
                        if (t.izquierda != null)
                        {
                            t = t.izquierda;
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        if (t.derecha != null)
                        {
                            t = t.derecha;
                        }
                        else
                        {
                            return;
                        }
                    }
                    if (opcion == 1)
                    {
                        t.CodigoMascota = nuevocodigoM;
                        t.CodigoCliente = nuevocodigoC;
                        t.Cliente = nuevoC;
                        t.AliasMascota = nuevoAliasM;
                        t.Peso = nuevoP;
                        t.Edad = nuevoE;
                        t.Raza = nuevoR;
                    }
                }
            }
        }
    }
}
