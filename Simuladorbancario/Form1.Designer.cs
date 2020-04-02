namespace Simuladorbancario
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DATOSCLIENTES = new System.Windows.Forms.Panel();
            this.cedula = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.txtmes = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.txtcdt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtcorriente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.botonretirar1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textahorros = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.DATOSCLIENTES.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Simuladorbancario.Properties.Resources.simulador_bancario;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(594, 138);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DATOSCLIENTES
            // 
            this.DATOSCLIENTES.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DATOSCLIENTES.Controls.Add(this.cedula);
            this.DATOSCLIENTES.Controls.Add(this.nombre);
            this.DATOSCLIENTES.Controls.Add(this.label3);
            this.DATOSCLIENTES.Controls.Add(this.label2);
            this.DATOSCLIENTES.Controls.Add(this.label1);
            this.DATOSCLIENTES.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DATOSCLIENTES.Location = new System.Drawing.Point(12, 143);
            this.DATOSCLIENTES.Name = "DATOSCLIENTES";
            this.DATOSCLIENTES.Size = new System.Drawing.Size(569, 53);
            this.DATOSCLIENTES.TabIndex = 1;
            this.DATOSCLIENTES.Tag = "";
            this.DATOSCLIENTES.Paint += new System.Windows.Forms.PaintEventHandler(this.DATOSCLIENTES_Paint);
            // 
            // cedula
            // 
            this.cedula.Enabled = false;
            this.cedula.Location = new System.Drawing.Point(358, 22);
            this.cedula.Name = "cedula";
            this.cedula.Size = new System.Drawing.Size(174, 20);
            this.cedula.TabIndex = 4;
            // 
            // nombre
            // 
            this.nombre.Enabled = false;
            this.nombre.Location = new System.Drawing.Point(80, 22);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(174, 20);
            this.nombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cedula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos Cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txttotal);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.txtmes);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Location = new System.Drawing.Point(12, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 268);
            this.panel1.TabIndex = 5;
            this.panel1.Tag = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(276, 234);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Total";
            // 
            // txttotal
            // 
            this.txttotal.Enabled = false;
            this.txttotal.Location = new System.Drawing.Point(307, 231);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(225, 20);
            this.txttotal.TabIndex = 11;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(307, 202);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(225, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Avanzar Mes";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtmes
            // 
            this.txtmes.Enabled = false;
            this.txtmes.Location = new System.Drawing.Point(111, 206);
            this.txtmes.Name = "txtmes";
            this.txtmes.Size = new System.Drawing.Size(174, 20);
            this.txtmes.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 209);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Mes";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.button7);
            this.panel4.Controls.Add(this.txtcdt);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel4.Location = new System.Drawing.Point(7, 144);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(547, 53);
            this.panel4.TabIndex = 7;
            this.panel4.Tag = "";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(415, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(109, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "Cerrar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "CDT";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(299, 18);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(109, 23);
            this.button7.TabIndex = 8;
            this.button7.Text = "Abrir";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // txtcdt
            // 
            this.txtcdt.Enabled = false;
            this.txtcdt.Location = new System.Drawing.Point(103, 22);
            this.txtcdt.Name = "txtcdt";
            this.txtcdt.Size = new System.Drawing.Size(174, 20);
            this.txtcdt.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Saldo CDT";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.txtcorriente);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel3.Location = new System.Drawing.Point(7, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(547, 53);
            this.panel3.TabIndex = 6;
            this.panel3.Tag = "";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(415, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Retirar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(299, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Consignar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtcorriente
            // 
            this.txtcorriente.Enabled = false;
            this.txtcorriente.Location = new System.Drawing.Point(103, 22);
            this.txtcorriente.Name = "txtcorriente";
            this.txtcorriente.Size = new System.Drawing.Size(174, 20);
            this.txtcorriente.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Saldo Corriente";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Cuenta Corriente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Informacion Bancaria";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.botonretirar1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textahorros);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel2.Location = new System.Drawing.Point(20, 229);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(547, 53);
            this.panel2.TabIndex = 5;
            this.panel2.Tag = "";
            // 
            // botonretirar1
            // 
            this.botonretirar1.Location = new System.Drawing.Point(415, 19);
            this.botonretirar1.Name = "botonretirar1";
            this.botonretirar1.Size = new System.Drawing.Size(109, 23);
            this.botonretirar1.TabIndex = 5;
            this.botonretirar1.Text = "Retirar";
            this.botonretirar1.UseVisualStyleBackColor = true;
            this.botonretirar1.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(299, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Consignar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textahorros
            // 
            this.textahorros.Enabled = false;
            this.textahorros.Location = new System.Drawing.Point(103, 22);
            this.textahorros.Name = "textahorros";
            this.textahorros.Size = new System.Drawing.Size(174, 20);
            this.textahorros.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Saldo Ahorros";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cuenta de Ahorros";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.button8);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.button9);
            this.panel5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel5.Location = new System.Drawing.Point(16, 477);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(565, 53);
            this.panel5.TabIndex = 10;
            this.panel5.Tag = "";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(287, 18);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(236, 23);
            this.button8.TabIndex = 9;
            this.button8.Text = "Opcion 2";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Opciones";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(26, 19);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(224, 23);
            this.button9.TabIndex = 8;
            this.button9.Text = "Opcion 1";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 537);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DATOSCLIENTES);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Simulador Bancario";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.DATOSCLIENTES.ResumeLayout(false);
            this.DATOSCLIENTES.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel DATOSCLIENTES;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cedula;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button botonretirar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textahorros;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtcorriente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtmes;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox txtcdt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button9;
    }
}

