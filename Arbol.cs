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
        public void muestraArbolRaicesYHojas(NodoVet arb, int cont)
        {
            NodoVet Tope;
            if (arb == null)
            {
                return;
            }
            else
            {
                muestraArbolRaicesYHojas(arb.derecha, cont + 1);
                for (int i = 0; i < cont; i++)
                {
                    Console.Write("   ");

                }
                Console.WriteLine(arb.CodigoMascota);
                muestraArbolRaicesYHojas(arb.izquierda, cont + 1);
            }
        }
        public void MostrarArbolitoenOrden(NodoVet arb)
        {
            if (arb == null)
            {
                return;
            }
            else
            {
                MostrarArbolitoenOrden(arb.izquierda);
                Console.WriteLine(" |    " + arb.CodigoMascota.ToString().PadRight(7) + "|   " + arb.CodigoCliente.ToString().PadRight(6) + "|    " + arb.Cliente.PadRight(43) +
                    "|   " + arb.AliasMascota.PadRight(12) + "|     " + arb.Peso.ToString().PadRight(7) + "|  " + arb.Raza.PadRight(14) + "|  " + arb.Edad.ToString().PadRight(4) + "| " + arb.Sexo.PadRight(7) + "|");
                MostrarArbolitoenOrden(arb.derecha);
            }
        }
        public void CalculosArbolito(NodoVet arb, ref double hembras, ref double machos, ref double mascotasentre6y15, ref double entre5a9, ref double entre10a12k, ref double TotalMascotas)
        {
            if (arb == null)
            {
                return;
            }
            else
            {
                CalculosArbolito(arb.izquierda, ref hembras, ref machos, ref mascotasentre6y15, ref entre5a9, ref entre10a12k, ref TotalMascotas);

                TotalMascotas++;
                if (arb.Sexo.ToUpper() == "HEMBRA")
                {
                    hembras++;
                }
                if (arb.Sexo.ToUpper() == "MACHO")
                {
                    machos++;
                }

                if (arb.Edad >= 6 && arb.Edad <= 15)
                {
                    mascotasentre6y15++;
                }

                if (arb.Edad >= 5 && arb.Edad <= 9)
                {
                    entre5a9++;
                }

                if (arb.Peso >= 10 && arb.Edad <= 12)
                {
                    entre10a12k++;
                }

                CalculosArbolito(arb.derecha, ref hembras, ref machos, ref mascotasentre6y15, ref entre5a9, ref entre10a12k, ref TotalMascotas);
            }
        }
        public void MostrarRazaCooker(NodoVet arb)
        {
            if (arb == null)
            {
                return;
            }
            else
            {
                MostrarRazaCooker(arb.izquierda);
                if (arb.Raza.ToUpper() == "COOKER")
                {
                    Console.WriteLine(" |    " + arb.CodigoMascota.ToString().PadRight(7) + "|   " + arb.CodigoCliente.ToString().PadRight(6) + "|    " + arb.Cliente.PadRight(43) + "|   " + arb.AliasMascota.PadRight(12) + "|     " + arb.Peso.ToString().PadRight(7) + "|  " + arb.Raza.PadRight(14) + "|  " + arb.Edad.ToString().PadRight(4) + "| " + arb.Sexo.PadRight(7) + "|");
                }

                MostrarRazaCooker(arb.derecha);
            }
        }
        public void eliminaNodoABB(ref NodoVet arbol, int dato)
        {
            NodoVet p1, p2; //p1 y p2 son enlaces de trabajo
            if (arbol == null) return; //Salir 
            if (dato < arbol.CodigoMascota) eliminaNodoABB(ref arbol.izquierda, dato);
            else if (dato > arbol.CodigoMascota) eliminaNodoABB(ref arbol.derecha, dato);
            else if (arbol.izquierda == arbol.derecha)
                arbol = null; //arbol apunta a null
            else if (arbol.izquierda == null)
            {
                p1 = arbol; //p1 apunta al nodo del arbol (guardar el enlace del nodo del arbol a eliminar)
                arbol = arbol.derecha; //Mover el enlace del arbol por la derecha
                p1 = null; //Eliminar el nodo
            }
            else if (arbol.derecha == null)
            {
                p1 = arbol; //p1 apunta al nodo del arbol (guardar el enlace del nodo del arbol a eliminar)
                arbol = arbol.izquierda; //Mover el enlace del arbol por la izquierda
                p1 = null; //Eliminar el nodo
            }
            else
            {
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
        public int Altura(NodoVet arbolito)
        {
            int AltIzq, AltDer; 
            if (arbolito == null) return -1;
         
            else
            {
              
                AltIzq = Altura(arbolito.izquierda);
               
                AltDer = Altura(arbolito.derecha);
                if (AltIzq > AltDer) return AltIzq + 1; 
                else return AltDer + 1; 
            }
        }
    }
}
