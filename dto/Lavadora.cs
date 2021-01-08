using System;
using System.Collections.Generic;
using System.Text;

namespace UD08
{
    class Lavadora : Electrodomestico
    {
        public const int CARGA_DEF = 5;

        public int carga { get; set; }

        public int getCarga()
        {
            return carga;
        }
        public double precioFinal()
        {
            double plus = precioFinal();

            //añadimos el código necesario
            if (carga > 30)
            {
                plus += 50;
            }

            return plus;
        }

        public Lavadora()
        {
            this.carga = CARGA_DEF;
            this.precioBase = PRECIO_DEF;
            this.color = COLOR_DEF;
            this.consumoEnergetico = CONSU_DEF;
            this.peso = PESO_DEF;
        }
        public Lavadora(double precioBase, double peso)
        {
            this.precioBase = precioBase;
            this.peso = peso;
            this.carga = CARGA_DEF;
            this.color = COLOR_DEF;
            this.consumoEnergetico = CONSU_DEF;
        }

        public Lavadora(double precioBase, double peso, char consumoEnergetico, String color, int carga)
        {
            this.carga = carga;
            this.precioBase = precioBase;
            this.color = color;
            this.consumoEnergetico = consumoEnergetico;
            this.peso = peso;
        }
    }
}
