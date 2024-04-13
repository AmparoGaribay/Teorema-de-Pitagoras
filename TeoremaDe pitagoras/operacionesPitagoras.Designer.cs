namespace TeoremaDe_pitagoras
{
    partial class operacionesPitagoras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(operacionesPitagoras));
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.cmBoxCalculo = new System.Windows.Forms.ComboBox();
            this.txtCaOpuesto = new System.Windows.Forms.TextBox();
            this.txtCaAdyacente = new System.Windows.Forms.TextBox();
            this.txtHipotenusa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.imagFig = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timerlab = new System.Windows.Forms.Label();
            this.Imprime = new System.Drawing.Printing.PrintDocument();
            this.dateTime = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imagFig)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(464, 226);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 31);
            this.btnImprimir.TabIndex = 0;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(36, 7);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // cmBoxCalculo
            // 
            this.cmBoxCalculo.ForeColor = System.Drawing.Color.SpringGreen;
            this.cmBoxCalculo.FormattingEnabled = true;
            this.cmBoxCalculo.Location = new System.Drawing.Point(105, 9);
            this.cmBoxCalculo.Name = "cmBoxCalculo";
            this.cmBoxCalculo.Size = new System.Drawing.Size(179, 21);
            this.cmBoxCalculo.TabIndex = 2;
            this.cmBoxCalculo.SelectedIndexChanged += new System.EventHandler(this.cmBoxCalculo_SelectedIndexChanged);
            // 
            // txtCaOpuesto
            // 
            this.txtCaOpuesto.ForeColor = System.Drawing.Color.SpringGreen;
            this.txtCaOpuesto.Location = new System.Drawing.Point(155, 17);
            this.txtCaOpuesto.Name = "txtCaOpuesto";
            this.txtCaOpuesto.Size = new System.Drawing.Size(100, 20);
            this.txtCaOpuesto.TabIndex = 3;
            // 
            // txtCaAdyacente
            // 
            this.txtCaAdyacente.ForeColor = System.Drawing.Color.SpringGreen;
            this.txtCaAdyacente.Location = new System.Drawing.Point(155, 44);
            this.txtCaAdyacente.Name = "txtCaAdyacente";
            this.txtCaAdyacente.Size = new System.Drawing.Size(100, 20);
            this.txtCaAdyacente.TabIndex = 4;
            // 
            // txtHipotenusa
            // 
            this.txtHipotenusa.ForeColor = System.Drawing.Color.SpringGreen;
            this.txtHipotenusa.Location = new System.Drawing.Point(155, 70);
            this.txtHipotenusa.Name = "txtHipotenusa";
            this.txtHipotenusa.Size = new System.Drawing.Size(100, 20);
            this.txtHipotenusa.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tipo de Calculo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(39, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cateto Opuesto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.SeaGreen;
            this.label3.Location = new System.Drawing.Point(39, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cateto Adyacente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.SeaGreen;
            this.label4.Location = new System.Drawing.Point(39, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hipotenusa";
            // 
            // imagFig
            // 
            this.imagFig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagFig.Image = ((System.Drawing.Image)(resources.GetObject("imagFig.Image")));
            this.imagFig.Location = new System.Drawing.Point(64, 35);
            this.imagFig.Name = "imagFig";
            this.imagFig.Size = new System.Drawing.Size(308, 222);
            this.imagFig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagFig.TabIndex = 10;
            this.imagFig.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtCaOpuesto);
            this.panel1.Controls.Add(this.txtCaAdyacente);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtHipotenusa);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(435, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 105);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmBoxCalculo);
            this.panel2.Location = new System.Drawing.Point(435, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 38);
            this.panel2.TabIndex = 12;
            // 
            // timerlab
            // 
            this.timerlab.AutoSize = true;
            this.timerlab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timerlab.Font = new System.Drawing.Font("Perpetua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerlab.ForeColor = System.Drawing.Color.SeaGreen;
            this.timerlab.Location = new System.Drawing.Point(545, 0);
            this.timerlab.Name = "timerlab";
            this.timerlab.Size = new System.Drawing.Size(33, 15);
            this.timerlab.TabIndex = 13;
            this.timerlab.Text = "label5";
            // 
            // Imprime
            // 
            this.Imprime.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.Imprime_PrintPage);
            // 
            // dateTime
            // 
            this.dateTime.Tick += new System.EventHandler(this.dateTime_Tick);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnCalcular);
            this.panel3.Location = new System.Drawing.Point(591, 226);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(140, 38);
            this.panel3.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Opuesto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "adyacente";
            // 
            // operacionesPitagoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(787, 297);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.timerlab);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.imagFig);
            this.Name = "operacionesPitagoras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Teorema de Pitagoras";
            ((System.ComponentModel.ISupportInitialize)(this.imagFig)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ComboBox cmBoxCalculo;
        private System.Windows.Forms.TextBox txtCaOpuesto;
        private System.Windows.Forms.TextBox txtCaAdyacente;
        private System.Windows.Forms.TextBox txtHipotenusa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox imagFig;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label timerlab;
        private System.Drawing.Printing.PrintDocument Imprime;
        private System.Windows.Forms.Timer dateTime;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}