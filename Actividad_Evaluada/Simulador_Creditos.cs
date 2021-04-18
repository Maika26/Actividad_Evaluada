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
            if (txtMontoS.Text < 500000 && txtMontoS.Text <= 0)
            {
                MessageBox.Show("El monto ingresado debe ser igual o mayor a $500.000 pesos");
            }
            else
            {
                MessageBox.Show("El monto ingresado es válido");
            }

            //Validar el numero de cuotas
            if (txtCuotas.Text < 1 && txtCuotas.Text > 36)
            {
                MessageBox.Show("La cantidad de cuotas no es aceptada." + "\n" + "Debe escoger entre 1 y 36 cuotas");
            }
            else
            {
                MessageBox.Show("El número de cuotas es válido ");
            }



        }
    }
}
