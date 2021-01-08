using System;
using System.Collections.Generic;
using System.Text;

namespace UD08
{
    class Cuenta
    {
        private string _titular;
        private double _cantidad;

        public string titular
        {
            get { return _titular; }
            set { _titular = value; }
        }
        public double cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        // Constructores
        public Cuenta(string ptitular)
        {
            this.titular = ptitular;
            cantidad = 0;
        }

        public Cuenta(string ptitular, double pcantidad)
        {
            this.cantidad = cantidad; 
            if (cantidad < 0)
            {
                this.cantidad = 0;
            }
            else
            {
                this.cantidad = cantidad;
            }
        }

        //Metodos
        public String getTitular()
        {
            return titular;
        }

        public void setTitular(String titular)
        {
            this.titular = titular;
        }

        public double getCantidad()
        {
            return cantidad;
        }

        public void setCantidad(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public void ingresar(double cantidad)
        {
            if (cantidad > 0)
            {
                this.cantidad += cantidad;
            }
        }
        public void retirar(double cantidad)
        {
            if (this.cantidad - cantidad < 0)
            {
                this.cantidad = 0;
            }
            else
            {
                this.cantidad -= cantidad;
            }
        }
        public String toString()
        {
            return "El titular " + titular + " tiene " + cantidad + " euros en su cuenta";
        }
    }
}
