using System;
using System.Collections.Generic;
using System.Text;

namespace UD08
{
    class Password
    {
        public const int LONG_DEF = 8;
        public int longitud { get; set; }
        public string contraseña { get; set; }

        public int getLongitud()
        {
            return longitud;
        }
        public void setLongitud(int longitud)
        {
            this.longitud = longitud;
        }
        public String getContraseña()
        {
            return contraseña;
        }

        public Password()
        {
            this.longitud = LONG_DEF;
        }
        public Password(int longitud)
        {
            this.longitud = longitud;
            contraseña = generaPassword();
        }

        public String generaPassword()
        {
            String password = "";
            for (int i = 0; i < longitud; i++)
            {
                Random rnd = new Random();
                int eleccion = rnd.Next(1,3);

                if (eleccion == 1)
                {
                    char minusculas = (char)rnd.Next(97, 122);
                    password += minusculas;
                }
                else
                {
                    if (eleccion == 2)
                    {
                        char mayusculas = (char)rnd.Next(65, 90);
                        password += mayusculas;
                    }
                    else
                    {
                        char numeros = (char)rnd.Next(48, 59);
                        password += numeros;
                    }
                }
            }
            return password;
        }
        public bool esFuerte()
        {
            char[] Contraseña = new char[contraseña.Length];
            for (int i = 0; i < contraseña.Length; i++)
            {
                Contraseña[i] = Convert.ToChar(contraseña.Substring(i, 1));
            }
            int cuentanumeros = 0;
            int cuentaminusculas = 0;
            int cuentamayusculas = 0;

            for (int i = 0; (i < contraseña.Length); i++)
            {
                if ((int)Contraseña[i] >= 97 && (int)Contraseña[i] <= 122)
                {
                    cuentaminusculas += 1;
                }
                else
                {
                    if ((int)Contraseña[i] >= 65 && (int)Contraseña[i] <= 90)
                    {
                        cuentamayusculas += 1;
                    }
                    else
                    {
                        cuentanumeros++;
                    }
                }
            }

            if (cuentanumeros >= 5 && cuentaminusculas >= 1 && cuentamayusculas >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
