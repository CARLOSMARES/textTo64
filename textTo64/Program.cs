using System;

namespace textTo64
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecciona la Opcion Deseada:");
            Console.WriteLine("1.- Texto a Base 64");
            Console.WriteLine("2.- Base 64 a Texto");
            int opcion = int.Parse(Console.ReadLine());
            if(opcion == 1)
            {
                Console.WriteLine("Ingrese el Texto a Convertir: ");
                string valor = Console.ReadLine();
                byte[] myByte = System.Text.Encoding.UTF8.GetBytes(valor);
                string myBase64 = Convert.ToBase64String(myByte);
                Console.WriteLine(myBase64);
            }
            else if(opcion == 2)
            {
                Console.WriteLine("Ingrese el valor de base 64 a Convertir:");
                string valor = Console.ReadLine();
                byte[] myBase64ret = Convert.FromBase64String(valor);
                string myStr = System.Text.Encoding.UTF8.GetString(myBase64ret);
                Console.WriteLine(myStr);
            }
        }
    }
}
