using System;
using System.Collections.Generic;
using System.Text;

namespace UD08
{
    class Television : Electrodomestico
    {
        public const int RESPÑUCION_DEF = 20;

        public int resolucion { get; set; }
        bool sintonizador { get; set; }

        public double precioFinal()
        {
            double plus = precioFinal();

            if (resolucion > 40)
            {
                plus += precioBase * 0.3;
            }
            if (sintonizador)
            {
                plus += 50;
            }

            return plus;
        }
        public Television()
        {
            this.resolucion = RESPÑUCION_DEF;
            this.sintonizador = false;
            this.precioBase = PRECIO_DEF;
            this.color = COLOR_DEF;
            this.consumoEnergetico = CONSU_DEF;
            this.peso = PESO_DEF;
        }
        public Television(double precioBase, double Peso)
        {
            this.precioBase = precioBase;
            this.peso = peso;
            this.resolucion = RESPÑUCION_DEF;
            this.sintonizador = false;
            this.color = COLOR_DEF;
            this.consumoEnergetico = CONSU_DEF;

        }
        public Television(double precioBase, double peso, char consumoEnergetico, String color, int resolucion, bool sintonizadorTDT)
        {
            this.resolucion = resolucion;
            this.sintonizador = sintonizador;
            this.precioBase = precioBase;
            this.color = color;
            this.consumoEnergetico = consumoEnergetico;
            this.peso = peso;
        }
    }
}
