using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_JP_SistemaVeterinario
{
    class Veterinaria
    {
        //Inicializamos la cola y la pila para obtener las operaciones que realiza
        private Cola colaMascotas = new Cola();
      
        private Arbol arbolito = new Arbol();

        private int contador = 0; 
        static public Random rnd = new Random(); 

        public void AgregarMascota()
        {
            bool flag = false; //Variable para validar datos
            string cliente = null, aliasMascota = null, raza = null, sexo = null;
            int codigoMascota = rnd.Next(121, 901); //Valores aleatorios de 121 a 900
            int codigoCliente = rnd.Next(10, 901); //Valores aleatorios de 10 a 900

            Console.Write("\n\t\t\t\t\t Introduzca el nombre del dueño:\n\t\t\t\t\t -> ");
            cliente = Console.ReadLine();
            //Intentamos volverlo a entero y si se puede quiere decir que no es una cadena. Si no se puede entonces es válido
            //El "Try Catch" intenta hacer un proceso y si no se cumple entonces se ejecuta lo que está dentro del "catch". Es la mejor opción para controlar excepciones.
            try
            {
                int cliente1 = int.Parse(cliente);
                Console.WriteLine("\n\t\t\t\t\t¡Error! Ingrese un nombre válido (en caracteres)...");
                Console.ReadKey();
                Console.Clear();
                return;
            }
            catch
            {
                Console.WriteLine("");
            }

            Console.Write("\n\t\t\t\t\t Introduzca el alias de la mascota:\n\t\t\t\t\t -> ");
            aliasMascota = Console.ReadLine();
            try
            {
                int aliasMascota1 = int.Parse(aliasMascota);
                Console.WriteLine("\n\t\t\t\t\t¡Error! Ingrese un nombre válido (en caracteres)...");
                Console.ReadKey();
                Console.Clear();
                return;
            }
            catch
            {
                Console.WriteLine("");
            }

            Console.Write("\n\t\t\t\t\t Introduzca el peso de la mascota (entre 1 y 40 kg):\n\t\t\t\t\t -> ");
            string peso1 = Console.ReadLine();
            Validaciones.Entero(peso1, ref flag); //Validamos si la variable ingresada es entera

            if (flag == false) //Si no es entera salimos de la función
            {
                Console.WriteLine("\n\t\t\t\t\t¡Error! Ingrese un número entero...");
                Console.ReadKey();
                Console.Clear();
                return;
            }

            int peso = int.Parse(peso1); //Si es entero convertimos a entero la variable "peso1"

            //Se usa "ref" en los parámetros de la función para que se modifique el valor de la variable declarada en la función en donde es llamada. Si no se pone eso, entonces,
            //simplemente se creará otra variable nueva en la función en donde se pretende entrar y no se cambiará el valor de la variable original
            Validaciones.EnteroSegunOpcion(1, peso, ref flag); //Validamos si la variable ingresada está dentro del rango

            if (flag == false)
            {
                Console.WriteLine("\n\t\t\t\t\t¡Error! Ingrese un peso dentro del rango (1-40 kg)...");
                Console.ReadKey();
                Console.Clear();
                return;
            }

            Console.WriteLine("");

            Console.Write("\n\t\t\t\t\t Introduzca la edad de la mascota (entre 1 y 15 años):\n\t\t\t\t\t -> ");
            string edad1 = Console.ReadLine();
            Validaciones.Entero(edad1, ref flag); //Validamos si la variable ingresada es entera

            if (flag == false) //Si no es entera salimos de la función
            {
                Console.WriteLine("\n\t\t\t\t\t¡Error! Ingrese un número entero...");
                Console.ReadKey();
                Console.Clear();
                return;
            }

            int edad = int.Parse(edad1); //Si es entera convertimos a entero la variable "edad1"

            Validaciones.EnteroSegunOpcion(2, edad, ref flag); //Validamos si la variable ingresada está dentro del rango

            if (flag == false)
            {
                Console.WriteLine("\n\t\t\t\t\t¡Error! Ingrese una edad dentro del rango (1-15 años)...");
                Console.ReadKey();
                Console.Clear();
                return;
            }
            Console.WriteLine("");
            //Menú para las razas de los perros
            Console.WriteLine("\n\t\t\t\t\t Según el siguiente menú...");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan; //Para cambiar el color de la letra. Y "Console.BackgroundColor = ConsoleColor.Cyan" es para cambiar el color de fondo de la consola
            Console.WriteLine("\n\t\t\t\t\t       ------------ ");
            Console.WriteLine("\t\t\t\t\t      |   BULDOG   |");
            Console.WriteLine("\t\t\t\t\t       ------------ ");
            Console.WriteLine("\t\t\t\t\t      |  LABRADOR  |");
            Console.WriteLine("\t\t\t\t\t       ------------ ");
            Console.WriteLine("\t\t\t\t\t      |   PASTOR   |");
            Console.WriteLine("\t\t\t\t\t       ------------ ");
            Console.WriteLine("\t\t\t\t\t      |   GOLDEN   |");
            Console.WriteLine("\t\t\t\t\t       ------------ ");
            Console.WriteLine("\t\t\t\t\t      |  DACHSHUND |");
            Console.WriteLine("\t\t\t\t\t       ------------ ");
            Console.WriteLine("\t\t\t\t\t      |    GALGO   |");
            Console.WriteLine("\t\t\t\t\t       ------------ ");
            Console.WriteLine("\t\t\t\t\t      |   COOKER   |");
            Console.WriteLine("\t\t\t\t\t       ------------ ");
            Console.WriteLine("\t\t\t\t\t      |SAN BERNARDO|");
            Console.WriteLine("\t\t\t\t\t       ------------ ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\t\t\t\t\t Introduzca la raza:\n\t\t\t\t\t -> ");
            raza = Console.ReadLine();
            //Verificamos si es una cadena
            try
            {
                int raza1 = int.Parse(raza);
                Console.WriteLine("\n\t\t\t\t\t¡Error! Ingrese un nombre válido (en caracteres)...");
                Console.ReadKey();
                Console.Clear();
                return;
            }
            catch
            {
                Console.WriteLine("");
            }
            Validaciones.Cadena(1, raza, ref flag); //Validamos si la variable ingresada está dentro del rango
            if (flag == false)
            {
                Console.WriteLine("\n\t\t\t\t\t¡Error! Ingrese una raza dentro del cuadro...");
                Console.ReadKey();
                Console.Clear();
                return;
            }

            Console.WriteLine("\n\t\t\t\t\t Introduzca el sexo de la mascota");
            Console.Write("\t\t\t\t\t (Macho o Hembra): \n\t\t\t\t\t -> ");
            sexo = Console.ReadLine();
            try
            {
                int sexo1 = int.Parse(sexo);
                Console.WriteLine("\n\t\t\t\t\t¡Error! Ingrese un nombre válido (en caracteres)...");
                Console.ReadKey();
                Console.Clear();
                return;
            }
            catch
            {
                Console.WriteLine("");
            }
            Validaciones.Cadena(2, sexo, ref flag); //Validamos si la variable ingresada está dentro del rango
            if (flag == false)
            {
                Console.WriteLine("\n\t\t\t\t\t¡Error! Ingrese un sexo válido (hembra o macho)...");
                Console.ReadKey();
                Console.Clear();
                return;
            }
            //Mandamos el nodo para que se agregue a la cola
            NodoVet nuevaMascota = new NodoVet(codigoMascota, codigoCliente, cliente, aliasMascota, peso, edad, raza, sexo);
            colaMascotas.queue(nuevaMascota);
            Console.WriteLine("\n\t\t\t\t\t ¡Mascota agregada exitosamente!");
        }
        public void AgregarMascotaAArbol()
        {
            bool flag = false; //Variable para validar datos
            string cliente = null, aliasMascota = null, raza = null, sexo = null;
            int codigoMascota = rnd.Next(121, 901); //Valores aleatorios de 121 a 900
            int codigoCliente = rnd.Next(10, 901); //Valores aleatorios de 10 a 900
            Console.WriteLine("\n\t\t\t\t\t Codigo de la nueva mascota:\n\t\t\t\t\t -> " + codigoMascota);
            Console.Write("\n\t\t\t\t\t Introduzca el nombre del dueño:\n\t\t\t\t\t -> ");
            cliente = Console.ReadLine();
            //Intentamos volverlo a entero y si se puede quiere decir que no es una cadena. Si no se puede entonces es válido
            //El "Try Catch" intenta hacer un proceso y si no se cumple entonces se ejecuta lo que está dentro del "catch". Es la mejor opción para controlar excepciones.
            try
            {
                int cliente1 = int.Parse(cliente);
                Console.WriteLine("\n\t\t\t\t\t¡Error! Ingrese un nombre válido (en caracteres)...");
                Console.ReadKey();
                Console.Clear();
                return;
            }
            catch
            {
                Console.WriteLine("");
            }

            Console.Write("\n\t\t\t\t\t Introduzca el alias de la mascota:\n\t\t\t\t\t -> ");
            aliasMascota = Console.ReadLine();
            try
            {
                int aliasMascota1 = int.Parse(aliasMascota);
                Console.WriteLine("\n\t\t\t\t\t¡Error! Ingrese un nombre válido (en caracteres)...");
                Console.ReadKey();
                Console.Clear();
                return;
            }
            catch
            {
                Console.WriteLine("");
            }

            Console.Write("\n\t\t\t\t\t Introduzca el peso de la mascota (entre 1 y 40 kg):\n\t\t\t\t\t -> ");
            string peso1 = Console.ReadLine();
            Validaciones.Entero(peso1, ref flag); //Validamos si la variable ingresada es entera

            if (flag == false) //Si no es entera salimos de la función
            {
                Console.WriteLine("\n\t\t\t\t\t¡Error! Ingrese un número entero...");
                Console.ReadKey();
                Console.Clear();
                return;
            }

            int peso = int.Parse(peso1); //Si es entero convertimos a entero la variable "peso1"

            //Se usa "ref" en los parámetros de la función para que se modifique el valor de la variable declarada en la función en donde es llamada. Si no se pone eso, entonces,
            //simplemente se creará otra variable nueva en la función en donde se pretende entrar y no se cambiará el valor de la variable original
            Validaciones.EnteroSegunOpcion(1, peso, ref flag); //Validamos si la variable ingresada está dentro del rango

            if (flag == false)
            {
                Console.WriteLine("\n\t\t\t\t\t¡Error! Ingrese un peso dentro del rango (1-40 kg)...");
                Console.ReadKey();
                Console.Clear();
                return;
            }

            Console.WriteLine("");

            Console.Write("\n\t\t\t\t\t Introduzca la edad de la mascota (entre 1 y 15 años):\n\t\t\t\t\t -> ");
            string edad1 = Console.ReadLine();
            Validaciones.Entero(edad1, ref flag); //Validamos si la variable ingresada es entera

            if (flag == false) //Si no es entera salimos de la función
            {
                Console.WriteLine("\n\t\t\t\t\t¡Error! Ingrese un número entero...");
                Console.ReadKey();
                Console.Clear();
                return;
            }

            int edad = int.Parse(edad1); //Si es entera convertimos a entero la variable "edad1"

            Validaciones.EnteroSegunOpcion(2, edad, ref flag); //Validamos si la variable ingresada está dentro del rango

            if (flag == false)
            {
                Console.WriteLine("\n\t\t\t\t\t¡Error! Ingrese una edad dentro del rango (1-15 años)...");
                Console.ReadKey();
                Console.Clear();
                return;
            }
            Console.WriteLine("");
            //Menú para las razas de los perros
            Console.WriteLine("\n\t\t\t\t\t Según el siguiente menú...");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan; //Para cambiar el color de la letra. Y "Console.BackgroundColor = ConsoleColor.Cyan" es para cambiar el color de fondo de la consola
            Console.WriteLine("\n\t\t\t\t\t       ------------ ");
            Console.WriteLine("\t\t\t\t\t      |   BULDOG   |");
            Console.WriteLine("\t\t\t\t\t       ------------ ");
            Console.WriteLine("\t\t\t\t\t      |  LABRADOR  |");
            Console.WriteLine("\t\t\t\t\t       ------------ ");
            Console.WriteLine("\t\t\t\t\t      |   PASTOR   |");
            Console.WriteLine("\t\t\t\t\t       ------------ ");
            Console.WriteLine("\t\t\t\t\t      |   GOLDEN   |");
            Console.WriteLine("\t\t\t\t\t       ------------ ");
            Console.WriteLine("\t\t\t\t\t      |  DACHSHUND |");
            Console.WriteLine("\t\t\t\t\t       ------------ ");
            Console.WriteLine("\t\t\t\t\t      |    GALGO   |");
            Console.WriteLine("\t\t\t\t\t       ------------ ");
            Console.WriteLine("\t\t\t\t\t      |   COOKER   |");
            Console.WriteLine("\t\t\t\t\t       ------------ ");
            Console.WriteLine("\t\t\t\t\t      |SAN BERNARDO|");
            Console.WriteLine("\t\t\t\t\t       ------------ ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\t\t\t\t\t Introduzca la raza:\n\t\t\t\t\t -> ");
            raza = Console.ReadLine();
            //Verificamos si es una cadena
            try
            {
                int raza1 = int.Parse(raza);
                Console.WriteLine("\n\t\t\t\t\t¡Error! Ingrese un nombre válido (en caracteres)...");
                Console.ReadKey();
                Console.Clear();
                return;
            }
            catch
            {
                Console.WriteLine("");
            }
            Validaciones.Cadena(1, raza, ref flag); //Validamos si la variable ingresada está dentro del rango
            if (flag == false)
            {
                Console.WriteLine("\n\t\t\t\t\t¡Error! Ingrese una raza dentro del cuadro...");
                Console.ReadKey();
                Console.Clear();
                return;
            }

            Console.WriteLine("\n\t\t\t\t\t Introduzca el sexo de la mascota");
            Console.Write("\t\t\t\t\t (Macho o Hembra): \n\t\t\t\t\t -> ");
            sexo = Console.ReadLine();
            try
            {
                int sexo1 = int.Parse(sexo);
                Console.WriteLine("\n\t\t\t\t\t¡Error! Ingrese un nombre válido (en caracteres)...");
                Console.ReadKey();
                Console.Clear();
                return;
            }
            catch
            {
                Console.WriteLine("");
            }
            Validaciones.Cadena(2, sexo, ref flag); //Validamos si la variable ingresada está dentro del rango
            if (flag == false)
            {
                Console.WriteLine("\n\t\t\t\t\t¡Error! Ingrese un sexo válido (hembra o macho)...");
                Console.ReadKey();
                Console.Clear();
                return;
            }
            //Mandamos el nodo para que se agregue a la cola
            NodoVet nuevaMascota = new NodoVet(codigoMascota, codigoCliente, cliente, aliasMascota, peso, edad, raza, sexo);
            arbolito.AgregarMascota(nuevaMascota);
            Console.WriteLine("\n\t\t\t\t\t ¡Mascota agregada exitosamente!");
            Console.ReadLine();
        }
        //Función para mostrar mascotas
        public void MostrarMascotas()
        {
            colaMascotas.muestracola();
        }

        //Función para eliminar mascota por código
        public void EliminarMascotaPorCodigo()
        {
            Console.WriteLine(" Eliminando mascota...");
            colaMascotas.muestracola();
            Console.Write("\n    Introduzca el código de la mascota a eliminar: \n    -> ");
            int codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            bool eliminada = colaMascotas.EliminarPorCodigo(codigo);

            if (eliminada)
            {
                Console.WriteLine("\n\t\t\t\t\t ¡Mascota con código " + codigo + " eliminada exitosamente!");
            }
            else
            {
                Console.WriteLine("\n\t\t\t\t\t ¡No se encontró una mascota con ese código!");
            }
        }

        //Función para pasar de la cola a la pila
        public void PasarColaAArbol()
        {
            string rpt;
            
            while (colaMascotas.frente != null)
            {
                NodoVet mascota = colaMascotas.dequeue();
                arbolito.AgregarMascota(mascota);
            }
            do{
                Console.Clear();
                Console.WriteLine("\t\t\t\t\t Datos pasados exitosamente!");
                Console.WriteLine("\t\t\t\t\t  Arbol:");
                arbolito.muestraArbolRaicesYHojas(arbolito.arbolito, 0);
                Console.WriteLine("\t\t\t\t\t  \n¿Desea ingresar otra mascota?");
                Console.WriteLine("\t\t\t\t\t  \nIngrese 1 para confirmar, caso contrario ingrese cualquier otra cosa");
                rpt = Console.ReadLine();
                if(rpt == "1")
                {
                    AgregarMascotaAArbol();
                }
                else
                {
                    break;
                }
            } while (rpt == "1");
        }

        //Función para generar reporte
        public void GenerarReporte()
        {
            double hembras = 0, machos = 0, mascotasentre6y15 = 0, entre5a9 = 0, entre10a12k = 0, contador1 = colaMascotas.Count();

            Console.Write("\n\t\t\t\t\t Generando reporte de mascotas...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(" VETERINARIA RAMOS S.A.\n REGISTRO DE ANIMALES\n\n\n");
            Console.WriteLine("                                                               REPORTE DE ATENCIÓN DE ANIMALES");

            arbolito.MostrarArbolitoenOrden(arbolito.arbolito);

            Console.WriteLine("\n DATOS:\n\n  Total de mascotas en la cola: " + colaMascotas.Count());

            arbolito.CalculosArbolito(arbolito.arbolito, ref hembras, ref machos, ref mascotasentre6y15, ref entre5a9, ref entre10a12k);

            Console.WriteLine($"  Mascotas hembras: {hembras}");

            Console.WriteLine($"  Porcentaje de mascotas hembras respecto al total: {((hembras / contador1) * 100).ToString("0.00")}%");
            Console.WriteLine($"  Mascotas machos: {machos}");
            Console.WriteLine($"  Porcentaje de mascotas machos respecto al total: {((machos / contador1) * 100).ToString("0.00")}%");
            Console.WriteLine($"  Mascotas entre 6 y 15 años de edad: {mascotasentre6y15}");
            Console.WriteLine($"  Porcentaje de mascotas entre 5 a 9 años de edad con respecto al total: {((entre5a9 / contador1) * 100).ToString("0.00")}%");
            Console.WriteLine($"  Mascotas entre 10 a 12 kilos: {entre10a12k}");
            Console.WriteLine($"  Porcentaje de mascotas entre 10 a 12 kilos con respecto al total: {((entre10a12k / contador1) * 100).ToString("0.00")}%");
            Console.WriteLine("\n\n  Mascotas de la raza 'Pastor': \n");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("  -----------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(" |  CÓDIGO   | CÓDIGO  |                                               |    ALIAS      |            |                |      |        |");
            Console.WriteLine(" |  MASCOTA  | CLIENTE |                    CLIENTE                    |    MASCOTA    | PESO(1-40) |      RAZA      | EDAD |  SEXO  |");
            Console.WriteLine("  -----------------------------------------------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            arbolito.MostrarRazaCooker(arbolito.arbolito);
        }

        //Función para buscar mascota según código
        public void BuscarMascotaPorCodigo()
        {
            Console.WriteLine(" Buscando mascotas...\n");
            colaMascotas.muestracola();
            Console.Write("\n   Introduzca el código de la mascota a buscar: \n   -> ");
            int codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            NodoVet mascota = colaMascotas.BuscarPorCodigo(codigo);

            if (mascota != null)
            {
                Console.WriteLine("   Mascota encontrada: " + mascota.AliasMascota + "   |   Código: " + mascota.CodigoMascota);
            }
            else
            {
                Console.WriteLine("   No se encontró una mascota con ese código...");
            }
        }

        //Función para modificar los datos de una mascota por medio de una cola
        public void ModificarMascotaPorCodigo()
        {
            Console.WriteLine(" Modificando mascotas...\n");
            colaMascotas.muestracola();
            Console.Write("\n   Introduzca el código de la mascota a modificar: \n   -> ");
            int codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("   Ingrese el nuevo dueño: \n   -> ");
            string cliente = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("   Ingrese el nuevo nombre de la mascota: \n   -> ");
            string mascota = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("   Ingrese el nuevo peso de la mascota: \n   -> ");
            int peso = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("   Ingrese la nueva edad de la mascota: \n   -> ");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("   Ingrese la nueva raza de la mascota: \n   -> ");
            string raza = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("   Ingrese el nuevo sexo de la mascota: \n   -> ");
            string sexo = Console.ReadLine();
            Console.WriteLine("");
            NodoVet mascotaActualizada = colaMascotas.ModificarPorCodigo(codigo, cliente, mascota, peso, edad, raza, sexo);
            Console.Clear();

            if (mascotaActualizada != null)
            {
                Console.WriteLine("   Mascota encontrada: " + mascotaActualizada.AliasMascota + "    |    Código: " + mascotaActualizada.CodigoMascota);
                Console.WriteLine("\n");
                colaMascotas.muestracola();
            }
            else
            {
                Console.WriteLine("   No se encontró una mascota con ese código...");
                Console.ReadKey();
            }
        }

        //Función para agregar datos por defecto
        public void insertarDatosPorDefecto()
        {
            Console.Clear();
            if (contador == 0)
            {
                //Generamos los arreglos para el nombre del cliente, para el alias de la mascota, para la raza y para el sexo de la mascota
                string[] cliente = { "ALVAREZ SALVADOR, RICARDO FRANCO", "ARANA SALAZAR, ALEXANDRO DEL PIERO", "ASENJO SACAYCO, LIZ ANGIE", "CABALLERO LYNCH, MIGUEL ANGEL",
                "CALAPUJA TANANTA, ELVIS LEVY", "CALONGOS ARRATEA, RICHARD", "CONISLLA DE LA CRUZ, HANZEL ADRIEL", "COTRINA RUIZ, FRANK ENRIQUE", "CUMPA DOMINGUEZ, DEYVI FRANK", "DE LA CRUZ TIRADO, CLEEFF DANIEL",
                "ESPINOZA GUEVARA, FABIAN JAVIER ALFREDO", "GAMARRA OSCANOA, DYLAN FABIAN", "GONZALES GRANADOS, SEBASTIAN EDDY", "HIDALGO ECHENIQUE, JOSE ENRIQUE SANTIAGO", "HUARANGA MEDINA, BRYCE JULIO",
                "HUARCAYA DIAZ, LUZ ADRIANA", "HURTADO CHAVEZ, JOSUE FELIPE", "LEDESMA LOZADA, RENATO ENRIQUE", "MAMANI TAVARA, JEFFERSON GABRIEL", "MAMANI URURI, RONALD GIAMPIERRE", "MARAVI DE LA CRUZ, LUIS DAVID",
                "MEZA CHAVEZ, PEDRO JHOSEP", "MEZA RIOS, JOSE MARIA JUNIOR", "PERALTA ISLA, GEREMI STEVE", "PICON JARA, MIGUEL ANGEL", "POLANCO CARDENAS, GERALD JEFFERSON", "QUEREVALU RAMOS, MICHAEL MATIAS",
                "RIVERA CULLANCO, GERALDIN ANABEL", "SAMBRANO LUNA, KARINA LIZETH", "SANCHEZ URPEQUE, JOSE LUIS", "TORRES PERUANO, FRANCISCO JESUS", "VACA VELA, EFRAIN RICARDO", "VALDIVIA APAZA, GIAN CARLO",
                "VILCA NOLASCO, EDUARDO ARTURO", "VILLACORTA COSTA, JULIO CESAR", "YAGILA PRADO, CARLOS AARON", "YACTAYO TRUJILLO, PAUL MARTIN", "YAURI CONDEZO, GONZALO PATRICK", "CHUQUILLANQUI APAZA, JOSHEP GERSOM",
                "MENDOZA OZORIO, DIEGO ALEXIS", "ALCAZAR REQUENA, JOSUHE EMANUEL MITCHELL", "ANTAY PILLPA, JOSE LUIS", "AVILA ALFARO, KATHERINE ANGELA", "CASTILLO UMAN, EDWIN RONALDO", "GERNA GARAY, GIAN POL",
                "CHANCA SERRANO, EDDY DANIEL", "CHAPOÑAN ALVINO, JOSEPH ANTHONY", "CHAVEZ CRISOSTOMO, CARLOS ENRIQUE SAMUEL", "CHAVEZ GARCIA, HANSEL FRANCO", "GARCIA CHAUCA, DIEGO RODRIGO"};
                string[] aliasM = { "RUFO", "VALENTINA", "NIÑO", "SULTAN", "TICAR", "PIBE", "MELI", "HACHICO", "LAICA", "ROBIN", "MILCA", "SCOOBY DOO", "PONGO", "VAGABUNDO",
                    "LORE", "PITUFO", "LICO", "VALENTINA" };
                string[] raza = { "BULDOG", "PASTOR", "LABRADOR", "GOLDEN", "DACHSHUND", "GALGO", "COOKER", "SAN BERNARDO" };
                string[] sexo = new string[2] {"MACHO", "HEMBRA"}; //Otra forma de inicializar un arreglo colocandole valores


                Console.WriteLine("\n\n\t\t\t\t\t  Insertando datos...");
                for (int i = 0; i < cliente.Length; i++)
                {
                    //Se colocan las variables aleatorias dentro del "for" para que me pueda dar distintos valores declarándose más de una vez
                    int codigoMascota = rnd.Next(121, 901); //Valores aleatorios de 121 a 900
                    int codigoCliente = rnd.Next(10, 901); //Valores aleatorios de 10 a 900
                    int aliazM1 = rnd.Next(0, 18);
                    int peso = rnd.Next(1, 41); //Valores aleatorios de 1 a 40
                    int edad = rnd.Next(1, 16); //Valores aleatorios de 1 a 15
                    int raza1 = rnd.Next(0, 8);
                    int sexo1 = rnd.Next(0, 2);
                    NodoVet DatosDefecto = new NodoVet(codigoMascota, codigoCliente, cliente[i], aliasM[aliazM1], peso, edad, raza[raza1], sexo[sexo1]);
                    colaMascotas.queue(DatosDefecto);
                }
                Console.ReadKey();
                Console.WriteLine(" Datos insertados: \n");
                colaMascotas.muestracola();
                contador += 1;
            }
            else
            {
                Console.WriteLine("\n\n\t\t\t\t\tYa se han agregado los valores predeterminados...\n");
                Console.ReadKey();
            }
        }

        public void MostrarArbolInOrden()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("  -----------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(" |  CÓDIGO   | CÓDIGO  |                                               |    ALIAS      |            |                |      |        |");
            Console.WriteLine(" |  MASCOTA  | CLIENTE |                    CLIENTE                    |    MASCOTA    | PESO(1-40) |      RAZA      | EDAD |  SEXO  |");
            Console.WriteLine("  -----------------------------------------------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            arbolito.MostrarArbolitoenOrden(arbolito.arbolito);
        }
    }
}
