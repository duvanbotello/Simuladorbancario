using Simuladorbancario.Mundo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simuladorbancario
{
    public partial class Form1 : Form
    {
        CuentaAhorros ahorros;
        CuentaCorriente corriente;
        public Form1()
        {
            InitializeComponent();
            nombre.Text = "Duvan Botello";
            cedula.Text = "1090499082";
        }


        


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            String saldo = Microsoft.VisualBasic.Interaction.InputBox("Introduzca el monto de dinero a consignar", "Consignar");
            if (saldo != null)
            {
                ahorros = new CuentaAhorros(Convert.ToDouble(saldo));
                textahorros.Text = Convert.ToString(ahorros.darSaldo()) + " [" + Convert.ToString(ahorros.darInteresMensual())+ "%]";
            }
            else
            {
                MessageBox.Show("Ingrese Saldo");
            }


            
        }

        private void DATOSCLIENTES_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(ahorros.darSaldo() != 0){
                String retiro = Microsoft.VisualBasic.Interaction.InputBox("Introduzca el monto de dinero a retirar", "retirar");
                ahorros.retirarMonto(Convert.ToDouble(retiro));
                textahorros.Text = Convert.ToString(ahorros.darSaldo()) + " [" + Convert.ToString(ahorros.darInteresMensual()) + "%]";
            }
            else
            {
                MessageBox.Show("No tienes saldo a favor...");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String saldo = Microsoft.VisualBasic.Interaction.InputBox("Introduzca el monto de dinero a consignar", "Consignar");
            if (saldo != null)
            {
                corriente = new CuentaCorriente(Convert.ToDouble(saldo));
                txtcorriente.Text = Convert.ToString(corriente.darSaldo());
            }
            else
            {
                MessageBox.Show("Ingrese Saldo");
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (corriente.darSaldo() != 0)
            {
                String retiro = Microsoft.VisualBasic.Interaction.InputBox("Introduzca el monto de dinero a retirar", "retirar");
                corriente.retirarMonto(Convert.ToDouble(retiro));
                txtcorriente.Text = Convert.ToString(ahorros.darSaldo());
            }
            else
            {
                MessageBox.Show("No tienes saldo a favor...");
            }
        }
    }
}

