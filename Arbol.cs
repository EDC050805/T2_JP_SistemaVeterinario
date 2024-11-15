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
        public void CalculosArbolito(NodoVet arb, ref double hembras, ref double machos, ref double mascotasentre6y15, ref double entre5a9, ref double entre10a12k)
        {
            if (arb == null)
            {
                return;
            }
            else
            {
                MostrarArbolitoenOrden(arb.izquierda);
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

                MostrarArbolitoenOrden(arb.derecha);
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
                MostrarArbolitoenOrden(arb.izquierda);
                if (arb.Raza.ToUpper() == "COOKER")
                {
                    Console.WriteLine(" |    " + arb.CodigoMascota.ToString().PadRight(7) + "|   " + arb.CodigoCliente.ToString().PadRight(6) + "|    " + arb.Cliente.PadRight(43) + "|   " + arb.AliasMascota.PadRight(12) + "|     " + arb.Peso.ToString().PadRight(7) + "|  " + arb.Raza.PadRight(14) + "|  " + arb.Edad.ToString().PadRight(4) + "| " + arb.Sexo.PadRight(7) + "|");
                }

                MostrarArbolitoenOrden(arb.derecha);
            }
        }
    }
}
