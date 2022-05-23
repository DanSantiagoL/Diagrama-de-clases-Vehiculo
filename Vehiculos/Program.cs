using System;
namespace Vehiculos
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("La clase Vehiculo: \n");
            Vehiculo Vehiculo = new Vehiculo();
            Console.WriteLine(Vehiculo.getInfoVehiculo());
            Console.WriteLine("\n\n------------------------------------------------------------------");

            Console.WriteLine("\nLa clase Terrestre: \n");
            Terrestre Terrestre = new Terrestre();
            Console.WriteLine(Terrestre.getInfoTerrestre());
            Console.WriteLine("\n\n------------------------------------------------------------------");

            Console.WriteLine("\nLa clase Moto: \n");
            Moto Moto = new Moto();
            Console.WriteLine(Moto.getInfoMoto());
            Console.WriteLine("\n\n------------------------------------------------------------------");

            Console.WriteLine("\nLa clase Scooter: \n");
            Scooter Scooter = new Scooter();
            Console.WriteLine(Scooter.getInfoScooter());
            Console.WriteLine("\n\n------------------------------------------------------------------");
        }
    }
}