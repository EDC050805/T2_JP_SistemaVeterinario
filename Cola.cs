using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_JP_SistemaVeterinario
{
    //Clase para construir la cola y operar con ellas
    class Cola
    {
        //Definimos sus atributos
        public NodoVet frente; //Nodo inicial (primer nodo que se ingresó)
        public NodoVet final; //Nodo final (último nodo que se ingresó)

        //Constructor
        public Cola()
        {
            //"this" se usa para utilizar un atributo de la clase presente en otra función
            this.frente = null;
            this.final = null;
        }

        //Función para agregar elementos a la cola
        public void queue(NodoVet mascota)
        {
            if (final == null)
            {
                frente = final = mascota;
            }
            else
            {
                final.siguiente = mascota;
                final = mascota;
            }
        }

        //Función para quitar elementos a la cola
        public NodoVet dequeue()
        {
            if (frente == null)
            {
                Console.WriteLine("Cola vacía...");
                return null;
            }

            NodoVet mascota = frente;
            frente = frente.siguiente;

            if (frente == null)
            {
                final = null;
            }

            return mascota;
        }

        //Función para mostrar los elementos de la cola
        public void muestracola()
        {
            if (frente == null)
            {
                Console.WriteLine("\n\t\t\t\t\t La cola está vacía...");
                Console.ReadKey();
                return;
            }
            Console.WriteLine(" Elementos en la cola:\n");
            NodoVet actual = frente;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("  -----------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(" |  CÓDIGO   | CÓDIGO  |                                               |    ALIAS      |            |                |      |        |");
            Console.WriteLine(" |  MASCOTA  | CLIENTE |                    CLIENTE                    |    MASCOTA    | PESO(1-40) |      RAZA      | EDAD |  SEXO  |");
            Console.WriteLine("  -----------------------------------------------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            while (actual != null)
            {
                Console.WriteLine(" |    " + actual.CodigoMascota.ToString().PadRight(7) + "|   " + actual.CodigoCliente.ToString().PadRight(6) + "|    " + actual.Cliente.PadRight(43) +
                    "|   " + actual.AliasMascota.PadRight(12) + "|     " + actual.Peso.ToString().PadRight(7) + "|  " + actual.Raza.PadRight(14) + "|  " + actual.Edad.ToString().PadRight(4) + "| " + actual.Sexo.PadRight(7) + "|");
                actual = actual.siguiente;
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("  -----------------------------------------------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

   
    }
}
