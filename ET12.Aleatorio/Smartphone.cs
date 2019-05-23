using System;

namespace ET12.Aleatorio
{
    public class Smartphone
    {
        public static string CrearMarca()
        {
            string[] cadenas = { "LG", "Samsung", "Xiaomi", "Huawei", "Motorola", "Apple", "Nokia", "Sony" };
            return cadenas[new Random().Next(cadenas.Length - 1)];
        }

        public static string CrearModelo()
        {
            string[] cadenas = { "s7", "s8", "G1", "G2", "s9", "s10", "iPhone", "G3" };
            return cadenas[new Random().Next(cadenas.Length - 1)];
        }

        public static string CrearSistemaOperativo()
        {
            string[] cadenas = { "Android", "iOS", "Windows Phone" };
            return cadenas[new Random().Next(cadenas.Length - 1)];
        }

        public static string CrearSistemaOperativoVersionNombre()
        {
            string[] cadenas = { "Cupcake", "Donut", "Eclair", "Froyo", "Gingerbread", "Honeycomb", "Ice Cream Sandwich", "Jelly Bean", "Kitkat", "Lolipop", "Marshmallow", "Nougat", "Oreo", "Pie" };
            return cadenas[new Random().Next(cadenas.Length - 1)];
        }

        public static string CrearSistemaOperativoVersionNumero()
        {
            string[] cadenas = { "1.5", "1.6", "2.0", "2.2", "2.3", "3.0", "4.0", "4.1", "4.4", "5.0", "6.0", "7.0", "8.0", "9.0" };
            return cadenas[new Random().Next(cadenas.Length - 1)];
        }
    }
}
