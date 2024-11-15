using System;
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
        public void muestraArbol(NodoVet arb, int cont)
        {
            NodoVet Tope;
            if (arb == null)
            {
                return;
            }
            else
            {
                muestraArbol(arb.derecha, cont + 1);
                for (int i = 0; i < cont; i++)
                {
                    Console.Write("\t\t\t\t\t   ");

                }
                Console.WriteLine(arb.CodigoMascota);
                muestraArbol(arb.izquierda, cont + 1);
            }
        }
       
    }
}
