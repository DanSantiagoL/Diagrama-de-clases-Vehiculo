using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vehiculos
{
    internal class Vehiculo
    {
        private string color;
        private string modelo;
        private double precio;
        private string uso;
        private int capacidad;
        private int serial;
        public Vehiculo()
        {
            this.color = "Verde";
            this.modelo = "Honda";
            this.precio = 3000;
            this.uso = "Personal";
            this.capacidad = 2;
            this.serial = 123456;

           
        }
        public void setInfoVehiculo(string color, string modelo, double precio, string uso, int capacidad, int serial)
        {
            this.color = color;
            this.modelo = modelo;
            this.precio = precio;
            this.uso = uso;
            this.capacidad = capacidad;
            this.serial = serial;
        }

        public string getInfoVehiculo()
        {
            return "Las caracteristicas del vehiculo son: \nEl color: " + color + "\nEl modelo:" + modelo + 
           "\nEl precio:" + precio + "\nDe uso: " + uso + "\nLa capacidad: " + capacidad + "\nEl serial: " + serial;
        }
        public void arrancar()
        {
            Console.WriteLine("Arrancando el vehiculo");
        }

        public void frenar()
        {
            Console.WriteLine("Frenando el vehiculo");
        }

        public void girar()
        {
            Console.WriteLine("Girando el vehiculo");
        }

    }
}