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
                //Usamos "PadRight()" para agregar espacios desde el comienzo de la variable hacia la derecha (si termina la cadena que muestra la variable entonces va
                //agregando espacios en blanco o lo que se especifica en el uso de "PadRight()"), empujando a la derecha a la variable siguiente a mostrar. El "PadLeft()" funciona
                //al revés, agregando espacios a la izquierda hasta terminar la cadena de la variable, empujándose a sí misma desde la cadena de la variable anterior
                Console.WriteLine(" |    " + actual.CodigoMascota.ToString().PadRight(7) + "|   " + actual.CodigoCliente.ToString().PadRight(6) + "|    " + actual.Cliente.PadRight(43) +
                    "|   " + actual.AliasMascota.PadRight(12) + "|     " + actual.Peso.ToString().PadRight(7) + "|  " + actual.Raza.PadRight(14) + "|  " + actual.Edad.ToString().PadRight(4) + "| " + actual.Sexo.PadRight(7) + "|");
                actual = actual.siguiente;
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("  -----------------------------------------------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        //Función para obtener la cantidad de elementos de la cola
        public int Count()
        {
            int count = 0;
            NodoVet actual = frente;
            while (actual != null)
            {
                count++;
                actual = actual.siguiente;
            }
            return count;
        }

        // Método para buscar una mascota por código
        public NodoVet BuscarPorCodigo(int codigo)
        {
            NodoVet actual = frente;
            while (actual != null)
            {
                if (actual.CodigoMascota == codigo)
                {
                    return actual;
                }
                actual = actual.siguiente;
            }
            return null;
        }

        // Método para eliminar una mascota por código
        public bool EliminarPorCodigo(int codigo)
        {
            NodoVet actual = frente;
            NodoVet anterior = null;

            while (actual != null)
            {
                if (actual.CodigoMascota == codigo)
                {
                    if (anterior == null) // La mascota está en el frente
                    {
                        frente = frente.siguiente;
                        if (frente == null) final = null; // Si era el único elemento
                    }
                    else
                    {
                        anterior.siguiente = actual.siguiente;
                        if (actual == final) final = anterior; // Si era el último
                    }
                    return true;
                }
                anterior = actual;
                actual = actual.siguiente;
            }
            return false; // No se encontró la mascota
        }

        //Función para actualizar los datos de una mascota según su código
        public NodoVet ModificarPorCodigo(int codigo, string cliente, string mascota, int peso, int edad, string raza, string sexo)
        {
            NodoVet actual = frente;
            while (actual != null)
            {
                if (actual.CodigoMascota == codigo)
                {
                    actual.Cliente = cliente;
                    actual.AliasMascota = mascota;
                    actual.Peso = peso;
                    actual.Edad = edad;
                    actual.Raza = raza;
                    actual.Sexo = sexo;
                    return actual;
                }
                actual = actual.siguiente;
            }
            return null;
        }

        //Método para desarrollar los cálculos que deben mostrarse en el reporte
        public void Calculos(ref double hembras, ref double machos, ref double mascotasentre6y15, ref double entre5a9, ref double entre10a12k)
        {
            NodoVet actual = frente;
            while (actual != null)
            {
                if (actual.Sexo.ToUpper() == "HEMBRA")
                    hembras++;

                if (actual.Sexo.ToUpper() == "MACHO")
                    machos++;

                if (actual.Edad >= 6 && actual.Edad <= 15)
                    mascotasentre6y15++;

                if (actual.Edad >= 5 && actual.Edad <= 9)
                    entre5a9++;


                if (actual.Peso >= 10 && actual.Edad <= 12)
                    entre10a12k++;

                actual = actual.siguiente;
            }
        }

        //Método para mostrar los nodos que tienen como raza "Pastor"
        public void mostrarRazaPastor()
        {
            NodoVet actual = frente;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("  -----------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(" |  CÓDIGO   | CÓDIGO  |                                               |    ALIAS      |            |                |      |        |");
            Console.WriteLine(" |  MASCOTA  | CLIENTE |                    CLIENTE                    |    MASCOTA    | PESO(1-40) |      RAZA      | EDAD |  SEXO  |");
            Console.WriteLine("  -----------------------------------------------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;

            while (actual != null)
            {
                if (actual.Raza.ToUpper() == "PASTOR")
                {
                    Console.WriteLine(" |    " + actual.CodigoMascota.ToString().PadRight(7) + "|   " + actual.CodigoCliente.ToString().PadRight(6) + "|    " + actual.Cliente.PadRight(43) + "|   " + actual.AliasMascota.PadRight(12) + "|     " + actual.Peso.ToString().PadRight(7) + "|  " + actual.Raza.PadRight(14) + "|  " + actual.Edad.ToString().PadRight(4) + "| " + actual.Sexo.PadRight(7) + "|");
                }
                actual = actual.siguiente;
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("  -----------------------------------------------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.ReadKey();
        }
    }
}
