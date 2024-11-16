using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Datos
    {
        public double denominador{ get; set; }
        public double numerador { get; set; }
        public double resultado { get; set; }

        public double Dividir(double numerador, double denominador)
        {
            return resultado = numerador / denominador;
        }

        public double Multiplicar(double numerador, double denominador) 
        {
            return resultado = numerador * denominador;
        }

        public double Sumar(double numerador, double denominador) 
        {
            return resultado = numerador + denominador;         
        }

        public double Restar(double numerador, double denominador) 
        {
            return resultado = numerador - denominador;
        }
    }
}
