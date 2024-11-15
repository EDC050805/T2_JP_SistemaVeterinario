using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_JP_SistemaVeterinario
{
    internal class Validaciones
    {
        //Coloco "static" para no tener la necesidad de crear un objeto en la clase en donde se use
        //Método para corroborar si el número ingresado es entero
        static public void Entero(string dato, ref bool flag)
        {
            int dato2;

            try
            {
                dato2 = int.Parse(dato);
                flag = true;
            }
            catch
            {
                flag = false;
            }
        }

        //Método para comprobar si el número ingresado cumple con algunas condiciones del programa
        static public void EnteroSegunOpcion(int opcion, int dato, ref bool flag)
        {
            switch (opcion)
            {
                case 1: //Validación de peso (debe ser entre 1 y 40 kg)

                    if (dato >= 1 && dato <= 40) flag = true; //El dato está en el rango
                    else flag = false;

                    break;

                case 2: //Validación de la edad de la mascota

                    if (dato >= 1 && dato <= 15) flag = true; //El dato está en el rango
                    else flag = false;

                    break;
            }
        }
        static public void Cadena(int opcion, string dato, ref bool flag)
        {
            switch (opcion)
            {
                case 1:
                    if (dato.ToUpper() == "BULDOG" || dato.ToUpper() == "LABRADOR"
                        || dato.ToUpper() == "PASTOR" || dato.ToUpper() == "GOLDEN"
                        || dato.ToUpper() == "DACHSHUND" || dato.ToUpper() == "GALGO"
                        || dato.ToUpper() == "COOKER" || dato.ToUpper() == "SAN BERNARDO")
                        flag = true;
                    else flag = false;
                    break;
                case 2:
                    if (dato.ToUpper() == "MACHO" || dato.ToUpper() == "HEMBRA")
                        flag = true;
                    else flag = false;
                    break;
            }
        }
    }
}
