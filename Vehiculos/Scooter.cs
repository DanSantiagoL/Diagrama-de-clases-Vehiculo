using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vehiculos
{
    internal class Scooter : Moto
    {
        private bool portaEquipaje;

        public Scooter()
        {
            this.portaEquipaje = true;
        }
        public void setInfoScooter()
        {
            this.portaEquipaje = portaEquipaje;
        }
        public string getInfoScooter()
        {
            return "Las caracteristicas del Scooter son: \nPosee Portaequipaje: " + portaEquipaje;
        }
        public void facilManejo()
        {
            Console.WriteLine("El Scooter es de facil manejo");
        }
    }
}