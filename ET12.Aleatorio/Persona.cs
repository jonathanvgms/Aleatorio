using System;

namespace ET12.Aleatorio
{
    public class Persona
    {
        /// <summary>
        /// Genera un nombre de pila en español
        /// </summary>
        /// <returns></returns>
        public static string CrearNombre()
        {
            string[] nombres = { "Daniel", "Hector", "Juan", "David", "Marta", "Cecilia", "Manuel", "Gorge", "Gabriela", "Alan", "Ivan", "Axel", "Monica", "Paula", "Maria", "Fernando", "Luis", "Sebastian", "Carlos", "Graciela" };
            return nombres[new Random().Next(20)];
        }

        /// <summary>
        /// Genera un apellido en español
        /// </summary>
        /// <returns></returns>
        public static string CrearApellido()
        {
            string[] apellidos = { "Gonzalez", "Rodriguez", "Lopez", "Fernandez", "Garcia", "Perez", "Martinez", "Gomez", "Diaz", "Sanchez", "Alvarez", "Romero", "Sosa", "Ruiz", "Torres", "Suarez", "Castro", "Gimenez", "Vazquez", "Acosta" };
            return apellidos[new Random().Next(20)];
        }


        /// <summary>
        /// Genera un número de DNI de 8 cifras
        /// </summary>
        /// <returns></returns>
        public static int CrearDNI()
        {
            return new Random().Next(10000000, 99999999);
        }

        /// <summary>
        /// Genera una edad entre 1 y 80 años
        /// </summary>
        /// <returns></returns>
        public static int CrearEdad()
        {
            return new Random().Next(1, 80);
        }
    }
}
