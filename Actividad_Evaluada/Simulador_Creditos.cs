using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_Evaluada
{
    public partial class Simulador_Creditos : Form
    {

        public Simulador_Creditos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMontoS_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCuotas_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMontoT_TextChanged(object sender, EventArgs e)
        {
             
    }

        private void txtVCuota_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //Validar el Monto ingresado
            string MontoSolicitado = txtMontoS.Text;
            MontoSolicitado = int.Parse(txtMontoS);
            if (MontoSolicitado < 500000 || MontoSolicitado <= 0)
            {
                MessageBox.Show("El monto ingresado debe ser igual o mayor a $500.000 pesos");
            }
            else
            {
                MessageBox.Show("El monto ingresado es válido");
            }

            //Validar el numero de cuotas
            string Cuotas = txtCuotas.Text;
            Cuotas = int.Parse(txtCuotas);
            if (Cuotas < 1 || Cuotas > 36)
            {
                MessageBox.Show("La cantidad de cuotas no es aceptada." + "\n" + "Debe escoger entre 1 y 36 cuotas");
            }
            else
            {
                MessageBox.Show("El número de cuotas es válido ");
            }

            //Intereses aplicados al monto solicitado
            int interes;
            int MontoTotal;
            if(Cuotas >=1 && Cuotas <=12)
            {
                interes = (MontoSolicitado * 10) / 100;
                MontoTotal = MontoSolicitado + interes;
                txtMontoT.Enabled = false;        //Para que no se pueda cambiar el texto de la caja
                txtMontoT.AppendText(MontoTotal);
            }
            else if(Cuotas >12 && Cuotas <=24)
            {
                interes = (MontoSolicitado * 20) / 100;
                MontoTotal = MontoSolicitado + interes;
                txtMontoT.Enabled = false;        //Para que no se pueda cambiar el texto de la caja
                txtMontoT.AppendText(MontoTotal);
            }
            else
            {
                interes = (MontoSolicitado * 35) / 100;
                MontoTotal = MontoSolicitado + interes;
                txtMontoT.Enabled = false;        //Para que no se pueda cambiar el texto de la caja
                txtMontoT.AppendText(MontoTotal);
            }
             

            //Calcular valor por cuota
            int valorCuota;
            valorCuota = MontoTotal / Cuotas;
            txtVCuota.Enabled = false;           //Para que no se pueda cambiar el texto de la caja
            txtVCuota.AppendText(valorCuota);









        }
    }
}
