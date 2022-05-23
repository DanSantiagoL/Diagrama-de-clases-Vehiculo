using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vehiculos
{
    internal class Moto : Terrestre
    {
        private int cilindraje;
        private string transmisión;
        private int tamañoNeumatico;

        public Moto()
        {
            this.cilindraje = 200;
            this.transmisión = "Cadena";
            this.tamañoNeumatico = 120;
        }
        public void setInfoMoto(int cilindraje, string transmisión, int tamañoNeumatico)
        {
            this.cilindraje = cilindraje;
            this.transmisión = transmisión;
            this.tamañoNeumatico = tamañoNeumatico;
        }

        public string getInfoMoto()
        {
            return "Las caracteristicas de la moto son: \nEl cilindraje: " + cilindraje + "\nLa transmisión: " + transmisión + "\nEl tamaño del neumatico es: " + tamañoNeumatico; 
        }
    }
    }