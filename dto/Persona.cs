using System;
using System.Collections.Generic;
using System.Text;

namespace UD08
{
    class Persona
    {
        public const char SEXO_DEF = 'H';
        public const int PESO_INFERIOR = -1;
        public const int PESO_IDEAL = 0;
        public const int SOBRE_PESO = 1;

        //Atributos
        public string nombre { get; set; }
        public int edad { get; set; }
        public string DNI { get; set; }
        public char sexo { get; set; }
        public double peso { get; set; }
        public double altura { get; set; }

        public Persona()
        {
            this.sexo = SEXO_DEF;
        }

        public Persona(string nombre, int edad, char sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
        }
        public Persona(String nombre, int edad, char sexo, double peso, double altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.peso = peso;
            this.altura = altura;
            generarDni();
            this.sexo = sexo;
            comprobarSexo();
        }
        private void comprobarSexo()
        {
            if (sexo != 'H' && sexo != 'M')
            {
                this.sexo = SEXO_DEF;
            }
        }
        private void generarDni()
        {
            Random rnd = new Random();
            const int divisor = 23;

            int numDNI = rnd.Next(10000000, 100000000);
            int res = numDNI - (numDNI / divisor * divisor);

            char letraDNI = generaLetraDNI(res);

            DNI = numDNI.ToString() + letraDNI;
        }
        private char generaLetraDNI(int res)
        {
            char[] letras = {'T', 'R', 'W', 'A', 'G', 'M', 'Y',
            'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z',
            'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E'};

            return letras[res];
        }
        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }
        public void setEdad(int edad)
        {
            this.edad = edad;
        }

        public void setSexo(char sexo)
        {
            this.sexo = sexo;
        }
        public void setPeso(double peso)
        {
            this.peso = peso;
        }
        public void setAltura(double altura)
        {
            this.altura = altura;
        }
        public int calcularIMC()
        {
            double pesoActual = peso / (Math.Pow(altura, 2));
            if (pesoActual >= 20 && pesoActual <= 25)
            {
                return PESO_IDEAL;
            }
            else if (pesoActual < 20)
            {
                return PESO_INFERIOR;
            }
            else
            {
                return SOBRE_PESO;
            }
        }
        public bool esMayorDeEdad()
        {
            bool mayor = false;
            if (edad >= 18)
            {
                mayor = true;
            }
            return mayor;
        }
        public String toString()
        {
            String sexo;
            if (this.sexo == 'H')
            {
                sexo = "hombre";
            }
            else
            {
                sexo = "mujer";
            }
            return "Informacion de la persona:\n"
                    + "Nombre: " + nombre + "\n"
                    + "Sexo: " + sexo + "\n"
                    + "Edad: " + edad + " años\n"
                    + "DNI: " + DNI + "\n"
                    + "Peso: " + peso + " kg\n"
                    + "Altura: " + altura + " metros\n";
        }
    }
}
