using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vehiculos
{
    internal class Terrestre : Vehiculo
    {
        private string nombreTerrestre;
        private int ruedas;
        private int frenos;
        private int rines;

        public Terrestre()
            {
            this.nombreTerrestre = "Moto";
            this.ruedas = 2;
            this.frenos = 2;
            this.rines = 2;

            }
        public void setInfoTerrestre(string nombreTerrestre, int ruedas,int frenos, int rines)
        {
            this.nombreTerrestre = nombreTerrestre;
            this.ruedas = ruedas;
            this.frenos = frenos;
            this.rines = rines;
        }
        public string getInfoTerrestre()
        {
            return "Las caracteristicas del vehiculo terrestre son: \nNombre del Vehiculo: " + nombreTerrestre + 
             "\nNumero de ruedas: " + ruedas + "\nNumero de frenos: " + frenos + "\nNumero de rines: " + rines;
        }

        public void movilidadTerrestre()
        {
            Console.WriteLine("Moviendose via terrestre");
        }

    }
}