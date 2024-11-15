using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_JP_SistemaVeterinario
{
    //Clase para contruir la pila y usar sus operaciones
    class Pila
    {
        public NodoVet cima; //Atributo para guardar el último elemento de la pila

        //Constructor
        public Pila()
        {
            cima = null;
        }

        //Método para agregar valores a la pila
        public void push(NodoVet mascota)
        {
            NodoVet nuevaMascota = new NodoVet(mascota.CodigoMascota, mascota.CodigoCliente,
                mascota.Cliente, mascota.AliasMascota, mascota.Peso, mascota.Edad, mascota.Raza,
                mascota.Sexo);

            if (cima == null)
            {
                cima = nuevaMascota;
            }
            else
            {
                nuevaMascota.siguiente = cima;
                cima = nuevaMascota;
            }
            Console.WriteLine("Elemento de código " + mascota.CodigoMascota + " apilado.");
        }

        //Método para eliminar valores a la pila
        public int pop()
        {
            int val = -999;
            if (cima == null)
            {
                Console.WriteLine("Pila está vacía.");
            }
            else
            {
                val = cima.CodigoMascota;
                cima = cima.siguiente;
            }
            return val;
        }

        //Método para mostrar los valores de la pila
        public void MostrarMascotas()
        {
            if (cima == null)
            {
                Console.WriteLine("La pila está vacía.");
                return;
            }
            Console.WriteLine("\n\nElementos en la pila:");
            NodoVet actual = cima;
            while (actual != null)
            {
                Console.WriteLine("\n NOMBRE DE LA MASCOTA: " + actual.AliasMascota + " \n" +
                    " CÓDIGO: " + actual.CodigoMascota + " \n" + " DUEÑO: " + actual.Cliente +
                    " \n" + " RAZA: " + actual.Raza + " \n" + " EDAD: " + actual.Edad + " \n" +
                    " SEXO: " + actual.Sexo + " \n");
                Console.WriteLine("-------------------------------------");

                actual = actual.siguiente;
            }
        }
    }
}
