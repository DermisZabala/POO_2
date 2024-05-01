using System;
using System.Diagnostics;

namespace POO3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de dólares que deseas cambiar: ");
            double CantidadDolares = Convert.ToDouble(Console.ReadLine());

            Cambio DolarAPesos = new Cambio(CantidadDolares);

            Console.WriteLine(DolarAPesos.getCambio());
        }        
    }
    class Cambio 
    {
        private double dolares;
        private double pesos;
        public Cambio(double dolares) 
        {
            pesos = 58.51;
            this.dolares = dolares;
        }

        public string getCambio()
        {
            double cambioPesos = dolares * pesos;

            double  CambioPesos = Math.Round(cambioPesos, 2);

            return dolares + " dólares = " + CambioPesos + " pesos dominicanos";
        }
    }
}
