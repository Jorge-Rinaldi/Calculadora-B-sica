using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Sumar_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();

            datos.numerador = int.Parse(txt_Numerador.Text);
            datos.denominador = int.Parse(txt_Denominador.Text);

            try
            {
                if (datos.numerador != null & datos.denominador != null) 
                {
                    datos.resultado = datos.Sumar(datos.numerador, datos.denominador);

                    txt_Resultado.Text = datos.resultado.ToString();
                }
                
            }
            catch (Exception Ex)
            {
                throw Ex;
            }            
            

        }

        private void btn_Restar_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();

            datos.numerador = int.Parse(txt_Numerador.Text);
            datos.denominador = int.Parse(txt_Denominador.Text) ;

            try
            {
                if (datos.numerador != null & datos.denominador != null)
                {
                    datos.resultado = datos.Restar(datos.numerador, datos.denominador);

                    txt_Resultado.Text= datos.resultado.ToString();
                }
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }

        private void btn_Multiplicar_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();

            datos.numerador = int.Parse(txt_Numerador.Text);
            datos.denominador = int.Parse(txt_Denominador.Text);

            try
            {
                if (datos.numerador != null & datos.denominador != null)
                {
                    datos.resultado = datos.Multiplicar(datos.numerador, datos.denominador);

                    txt_Resultado.Text = datos.resultado.ToString();
                }
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }

        private void btn_Dividir_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();

            datos.numerador = int.Parse(txt_Numerador.Text);
            datos.denominador = int.Parse(txt_Denominador.Text);

            try
            {
                if (datos.numerador != null & datos.denominador != null)
                {
                    datos.resultado = datos.Dividir(datos.numerador, datos.denominador);

                    txt_Resultado.Text = datos.resultado.ToString();
                }
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
    }
}
