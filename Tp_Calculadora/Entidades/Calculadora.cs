using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {

        /// <summary>
        /// valida el operador que recibe por parametro, si no es ninguno de los 3 devuelve +
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static string ValidarOporador(string operador)
        {
            string retorno;

            switch (operador)
            {
                case "-":
                    {
                        retorno = "-";
                        break;
                    }
                case "/":
                    {
                        retorno = "/";
                        break;
                    }
                case "*":
                    {
                        retorno = "*";
                        break;
                    }
                default:
                    {
                        retorno = "+";
                        break;
                    }
            }
            return retorno;
        }

        /// <summary>
        /// recibe 2 numeros y el operador, valida el operador y dependiendo de ese operador recibido, realiza el calculo devolviendo el resultado
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        public static double Operar(Numero num1,Numero num2, string operador)
        {
            double retorno=0;
            string miOperador;

            miOperador=ValidarOporador(operador);

            if (miOperador == "+")
            {
                retorno = num1 + num2;
            }

            if (miOperador == "-")
            {
                retorno = num1 - num2;
            }

            if (miOperador == "/")
            {
                retorno = num1 / num2;
            }

            if (miOperador == "*")
            {
                retorno = num1 * num2;
            }

           return retorno;
        }

    }
}
