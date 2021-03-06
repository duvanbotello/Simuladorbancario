﻿using Simuladorbancario.Mundo;
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
        CDT inversion = new CDT();
        public Form1()
        {
            InitializeComponent();
            nombre.Text = "Duvan Botello";
            cedula.Text = "1090499082";
            txtmes.Text = "1";
          
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
                txtcorriente.Text = Convert.ToString(corriente.darSaldo());
                
            }
            else
            {
                MessageBox.Show("No tienes saldo a favor...");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String inversion1 = Microsoft.VisualBasic.Interaction.InputBox("Introduzca el monto de dinero a Invertir", "Invertir CDT");
            String InteresMensual = Microsoft.VisualBasic.Interaction.InputBox("Introduzca el interes mensual", "Invertir CDT");
            if (inversion1 != null && InteresMensual != null)
            {
                inversion.invertir(Convert.ToDouble(inversion1), Convert.ToDouble(InteresMensual), Int32.Parse(s: txtmes.Text));
                txtcdt.Text = Convert.ToString(inversion.calcularValorPresente(Int32.Parse(txtmes.Text))) + " [" + Convert.ToString(inversion.darInteresMensual()) + "%]";
                txttotal.Text = Convert.ToString(corriente.darSaldo() + inversion.calcularValorPresente(Int32.Parse(txtmes.Text)) + ahorros.darSaldo());
            }
            else
            {
                MessageBox.Show("Ingrese valores");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int mes = Int32.Parse(txtmes.Text);
            int nuevomes = mes + 1;
            txtmes.Text = Convert.ToString(nuevomes);
            ahorros.actualizarSaldoPorPasoMes();
            txttotal.Text = Convert.ToString(corriente.darSaldo() + inversion.calcularValorPresente(Int32.Parse(txtmes.Text)) + ahorros.darSaldo());
            textahorros.Text = Convert.ToString(ahorros.darSaldo()) + " [" + Convert.ToString(ahorros.darInteresMensual()) + "%]";
        }

        private void button6_Click(object sender, EventArgs e)
        {
          
            double valorCierreCDT = inversion.cerrar(Int32.Parse(txtmes.Text));
            corriente.consignarMonto(valorCierreCDT);
            txtcdt.Text = Convert.ToString(inversion.calcularValorPresente(0)) + " [" + Convert.ToString(inversion.darInteresMensual()) + "%]";
            txtcorriente.Text = Convert.ToString(corriente.darSaldo());

        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Respuesta 1");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Respuesta 2");
        }
    }
}

