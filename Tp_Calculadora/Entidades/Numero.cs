using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double _numero;

        /// <summary>
        /// constructor que setea el numero a 0
        /// </summary>
        public Numero()
        {
            this._numero = 0;
        }

        /// <summary>
        /// constructor que toma como parametro un double y lo setea el numero de instancia
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero)
        {
            this._numero = numero;
        }

        /// <summary>
        /// constructor que toma un string y lo pasa por el SetNumero para validarlo y convertirlo en double
        /// </summary>
        /// <param name="strNumero"></param>
        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }

        /// <summary>
        /// 
        /// </summary>
        public string SetNumero
        {
              set { this._numero=ValidarNumero(value); }
        }
        public double GetNumero
        {
            get { return this._numero; }
        }


        /// <summary>
        /// Recibe un String que se debe pasar a decimal,valida que el string recibido se pueda parsear a double con el 
        /// metodo "Validar numero", si es que se puede devuelve el numero double, y despues lo convierte en binario.
        /// Si el metodo "Validar numero" Recibe algo que no se puede parsear, o recibe un 0 o negativo este metodo devuelve 
        /// "Valor invalido",(si el numero que recibe es 0 tambien devuelve valor invalido)
        /// </summary>
        /// <param name="Binario"></param>
        /// <returns></returns>
        public string BinarioDecimal(string Binario)
        {
            double calculo;
         //   int Calculo;
            int flagBin=0;
            string retorno = "";

            calculo=ValidarNumero(Binario);
            Binario = "";
            
            if (calculo <= 0)
            {
                retorno = "Valor inválido";
            }

            while (calculo > 0)
            {
                if (calculo % 2 == 0)
                {
                    Binario="0"+Binario;
                }
                else
                {
                    Binario="1"+Binario;
                }

                calculo = (int)(calculo / 2);
                flagBin=1;
            }

            if (flagBin == 1)
            {
                return Binario.ToString();
            }
            else
            {
                return retorno;
            }
        }

        public string DecimalBinario(double Numero)
        {
           return DecimalBinario(Numero.ToString());
        }

        /// <summary>
        /// valida que solo sea "1" y "0" y transforma a decimal
        /// </summary>
        /// <param name="Numero"></param>
        /// <returns></returns>
        public string DecimalBinario(string Numero)
        {
            double aux = 0;
            int x = 1;
            string numdec = "";
            for (int i = Numero.Length - 1; i >= 0; i--)
            {
                numdec += Numero[i];
                    if(Numero[i].ToString() == ("2") || Numero[i].ToString() == ("3") || Numero[i].ToString() == ("4") || Numero[i].ToString() == ("5") || Numero[i].ToString() == ("6") || Numero[i].ToString() == ("7") || Numero[i].ToString() == ("8") || Numero[i].ToString() == ("9"))
                    {
                    //preguntar profe !=
                    return "Valor invalido";
                    }
            }

            for (int i = 0; i < numdec.Length; i++)
            {
                x = Convert.ToInt32(numdec[i]);
                if (x == 49)
                    aux += Math.Pow(2, i);
            }
            return aux.ToString();

             // return (Convert.ToDecimal(ValidarNumero(Numero)).ToString());
        }

        public static double operator -(Numero n1, Numero n2)
        {
            return n1._numero - n2._numero;
        }

        public static double operator +(Numero n1, Numero n2)
        {
            return n1._numero + n2._numero;
        }

        public static double operator /(Numero n1, Numero n2)
        {
            return n1._numero / n2._numero;
        }

        public static double operator *(Numero n1, Numero n2)
        {
            return n1._numero * n2._numero;
        }
        /// <summary>
        /// Convierte un string en double, si nos se puede parsear devuelve 0.
        /// </summary>
        /// <param name="strNumero">String que se debe parsear</param>
        /// <returns>Retorna el numero parseado o 0 si no se pudo parsear.</returns>
        public static double ValidarNumero(string strNumero)
        {
            double resu;

            double.TryParse(strNumero, out resu);
           
            return resu;
        }
    }
}
