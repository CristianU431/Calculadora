using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Servicio
{
    /// <summary>
    /// Descripción breve de Calculadora
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Calculadora : System.Web.Services.WebService
    {

        [WebMethod(Description = "Suma de Numeros")]
        public double Suma(double nro1, double nro2)
        {
            double resultado;
            resultado = nro1 + nro2;
            return resultado;
        }

        [WebMethod(Description = "Resta de Numeros")]
        public double Resta(double nro1, double nro2)
        {
            double resultado;
            resultado = nro1 - nro2;
            return resultado;
        }

        [WebMethod(Description = "Multiplicacion de Numeros")]
        public double Multiplicacion(double nro1, double nro2)
        {
            double resultado;
            resultado = nro1 * nro2;
            return resultado;
        }

        public string MsgDiv()
        {
            return "No es podible dividir entre 0";
        }
        private double Dividir(double nro1, double nro2)
        {
            if (nro1 == 0)
                return nro1;
            else
                return nro1 / nro2;
        }

        [WebMethod(Description = "Division de Numeros")]
        public double Division(double nro1, double nro2)
        {
            return Dividir(nro1, nro2);
        }

        private double Fac(int n)
        {
            if (n == 0) return 1;
            else return n * Fac(n - 1);
        }

        [WebMethod(Description = "Factorial de un Numero")]
        public double Factorial(int n)
        {
            return Fac(n);
        }

        private double Pot(int nro1, int nro2)
        {
            if (nro2 == 0)
                return 1;
            else
                return nro1 * Pot(nro1, nro2 - 1);
        }
        [WebMethod(Description = "Potencia de un Numero")]
        public double Potencia(int nro1, int nro2)
        {
            return Pot(nro1, nro2);
        }

        private double Tang(int nro)
        {
            return Math.Tan(nro * Math.PI / 180.0);
        }
        [WebMethod(Description = "Tangente de un Numero")]
        public double Tangente(int nro)
        {
            return Tang(nro);
        }

        private double Cos(int nro)
        {
            return Math.Cos(nro * Math.PI / 180.0);
        }

        [WebMethod(Description = "Coseno de un Numero")]
        public double Coseno(int nro)
        {
            return Cos(nro);
        }

        private double Sen(int nro)
        {
            return Math.Sin(nro * Math.PI / 180.0);
        }

        [WebMethod(Description = "Seno de un Numero")]
        public double Seno(int nro)
        {
            return Sen(nro);
        }

        [WebMethod(Description = "Inverso de un Numero")]

        public double Inverso(double nro1)
        {
            return 1 / nro1;
        }

        [WebMethod(Description = "Porcentaje de un Numero")]

        public double Porcentaje(double nro1, double nro2)
        {
            double resultado;
            resultado = ((nro1/100) * nro2);
            return resultado;
        }

        private double Loga(int nro)
        {
            return Math.Log10(nro);
        }

        [WebMethod(Description = "Logaritmo de un Numero")]
        public double Logaritmo(int nro)
        {
            return Loga(nro);
        }

    }
}
