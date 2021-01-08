using System;
using System.Collections.Generic;
using System.Text;

namespace UD08
{
    class Electrodomestico
    {
        public const string COLOR_DEF = "blanco";
        public const char CONSU_DEF = 'F';
        public const double PRECIO_DEF =    100;
        public const double PESO_DEF = 5;

        public double precioBase { get; set; }
        public string color { get; set; }
        public char consumoEnergetico { get; set;}
        public double peso { get; set; }

        private void comprobarColor(String color)
        {
            string[] colores = { "blanco", "negro", "rojo", "azul", "gris" };
            bool encontrado = false;

            for (int i = 0; i < colores.Length && !encontrado; i++)
            {
                if (colores[i].Equals(color))
                {
                    encontrado = true;
                }
            }
            if (encontrado)
            {
                this.color = color;
            }
            else
            {
                this.color = COLOR_DEF;
            }
        }
        public void comprobarConsumoEnergetico(char consumoEnergetico)
        {
            if (consumoEnergetico >= 65 && consumoEnergetico <= 70)
            {
                this.consumoEnergetico = consumoEnergetico;
            }
            else
            {
                this.consumoEnergetico = CONSU_DEF;
            }
        }
        public double getPrecioBase()
        {
            return precioBase;
        }
        public String getColor()
        {
            return color;
        }
        public char getConsumoEnergetico()
        {
            return consumoEnergetico;
        }
        public double getPeso()
        {
            return peso;
        }
        public double precioFinal()
        {
            double plus = 0;
            switch (consumoEnergetico)
            {
                case 'A':
                    plus += 100;
                    break;
                case 'B':
                    plus += 80;
                    break;
                case 'C':
                    plus += 60;
                    break;
                case 'D':
                    plus += 50;
                    break;
                case 'E':
                    plus += 30;
                    break;
                case 'F':
                    plus += 10;
                    break;
            }

            if (peso >= 0 && peso < 19)
            {
                plus += 10;
            }
            else if (peso >= 20 && peso < 49)
            {
                plus += 50;
            }
            else if (peso >= 50 && peso <= 79)
            {
                plus += 80;
            }
            else if (peso >= 80)
            {
                plus += 100;
            }

            return precioBase + plus;
        }

        public Electrodomestico()
        {
            this.precioBase = PRECIO_DEF;
            this.color = COLOR_DEF;
            this.consumoEnergetico = CONSU_DEF;
            this.peso = PESO_DEF;
        }

        public Electrodomestico(double precioBase, double peso)
        {
            this.precioBase = precioBase;
            this.peso = peso;
            this.color = COLOR_DEF;
            this.consumoEnergetico = CONSU_DEF;
        }

        public Electrodomestico(double precioBase, double peso, char consumoEnergetico, String color)
        {
            this.precioBase = precioBase;
            this.peso = peso;
            comprobarConsumoEnergetico(consumoEnergetico);
            comprobarColor(color);
        }
    }
}
