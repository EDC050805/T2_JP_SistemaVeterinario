//Librerías (colecciones de código desarrollado previamente que los programadores pueden utilizar para desarrollar software de manera más ágil) a usar en el proyecto
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Todo lo que se muestra en pantalla es una solución (ejecutador de proyecto), que tienen proyectos en su interior, que a su vez incluyen clases
//y dentro de ellas funciones, las que permiten hacer distintas operaciones o crear distintos objetos
//Los "namespace" son contenedores que contienen (valga la redundancia) identificadores en su interior como funciones, clases y objetos únicos. Se les podría llamar "proyectos"
namespace T2_JP_SistemaVeterinario
{
    //Las clases son lugares que contienen funciones y atributos que permiten crear objetos y realizar distintas operaciones
    class Program
    {
     
        //    Console.WriteLine("\n\t\t\t\t\t |5| Eliminar por código");
        //    Console.WriteLine("\n\t\t\t\t\t |5| Buscar mascota por código y actualizar");
 
        //    Console.WriteLine("\n\t\t\t\t\t |7| Altura del árbol");
  
        static void Main(string[] args)
        {
            Veterinaria vet = new Veterinaria();

            int opcion;
            Menus.Presentacion();
            Console.ForegroundColor = ConsoleColor.Yellow;
            do
            {
                Console.Clear();
                Console.WriteLine("");
                opcion = Menus.MenuPrincipal();

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Menus.Encabezado(" Agregando mascota");
                        vet.AgregarMascota();
                        Console.ReadLine();
                        break;

                    case 2:
                        Console.Clear();
                        vet.insertarDatosPorDefecto();
                       
                        break;
                    case 3:
                        Console.Clear();
                        vet.MostrarMascotas();
                
                        break;
                    case 4:
                        Console.Clear();
                        vet.PasarColaAArbol();
                     
                        break;

                    case 5:
                        Console.Clear();
                        Menus.Encabezado(" Pasando a pila");
                        vet.BuscarMascotaPorCodigo();
                        break;

                    case 6:

                        vet.MostrarArbolInOrden();
                        Console.ReadLine();
                  

                        Console.Clear();
                     
                        break;

                    case 7:
                        Console.Clear();
                        vet.insertarDatosPorDefecto();
                        break;

                    case 8:
                        Console.Clear();
                        vet.GenerarReporte();
                        break;

                    case 9:
                        Console.WriteLine("\n\t\t\t\t\t ¡Hasta luego!\n");
                        return; // Termina el programa

                    default:
                        Console.WriteLine("\n\t\t\t\t\t Opción no válida, intenta de nuevo.");
                        break;
                }

                if (opcion == 2 || opcion == 6 || opcion == 4 || opcion == 8 || opcion == 7) Console.Write("\n  Presione cualquier tecla para regresar...");
                else Console.Write("\n\t\t\t\t\t Presione cualquier tecla para regresar...");
                Console.ReadKey();
                Console.Clear();
            }
            while (opcion != 9);
        }
    }
}
