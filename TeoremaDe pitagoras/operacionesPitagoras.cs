using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeoremaDe_pitagoras
{
    public partial class operacionesPitagoras : Form
    {
       
        //resuelve el bug final despues de imprimir.y el de cuando los campos son vacios.
        public operacionesPitagoras()
        {
            InitializeComponent();
            cmBoxCalculo.Items.Add("Cateto Opuesto");
            cmBoxCalculo.Items.Add("Cateto Adyacente");
            cmBoxCalculo.Items.Add("Hipotenusa");
            dateTime.Start();
            btnImprimir.Enabled = false;
            
           
           
        }



        private void btnCalcular_Click(object sender, EventArgs e)
        {
        
           if ( cmBoxCalculo.SelectedIndex.Equals(0))//cateto opuesto b
            {
                double opuest;
                try {
                    opuest = Math.Sqrt(Math.Pow(double.Parse(txtHipotenusa.Text), 2) + Math.Pow(double.Parse(txtCaAdyacente.Text), 2));
                    txtCaOpuesto.Text = Convert.ToString(opuest);
                    txtCaOpuesto.Visible = true;
                    txtCaOpuesto.Enabled = false;
                    label2.Visible = true;

                    btnImprimir.Enabled = true;

                }catch (Exception ex){
                    MessageBox.Show("Valor incorrecto /n "+ ex, "Teorema de Pitagoras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
           else if (cmBoxCalculo.SelectedIndex.Equals(1))//cateto adyacente a
            {
                double adyacente;
                try {
                    adyacente = Math.Sqrt(Math.Pow(double.Parse(txtHipotenusa.Text), 2) + Math.Pow(double.Parse(txtCaOpuesto.Text), 2));
                    txtCaAdyacente.Text = Convert.ToString(adyacente);
                    txtCaAdyacente.Visible = true;
                    txtCaAdyacente.Enabled = false;
                    label3.Visible = true;
                    btnImprimir.Enabled = true;

                } catch (Exception ex)
                {
                    MessageBox.Show("Valor incorrecto /n " + ex, "Teorema de Pitagoras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (cmBoxCalculo.SelectedIndex.Equals(2))//hipotenusa
            {
                double hipotenusa;
                try { 
                    hipotenusa=Math.Sqrt(Math.Pow(double.Parse(txtCaAdyacente.Text),2)+Math.Pow(double.Parse(txtCaOpuesto.Text),2));
                    txtHipotenusa.Text = Convert.ToString(hipotenusa);
                    txtHipotenusa.Visible = true;
                    txtHipotenusa.Enabled = false;
                    label4.Visible = true;
                    btnImprimir.Enabled = true;

                } catch (Exception ex)
                {
                    MessageBox.Show("Valor incorrecto /n " + ex, "Teorema de Pitagoras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un tipo de operacion", "Teorema de Pitagoras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }//btncalcular

        private void cmBoxCalculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmBoxCalculo.SelectedItem.Equals("Cateto Opuesto"))
            {
                
                txtCaOpuesto.Visible = false;
                label2.Visible = false;

                txtCaAdyacente.Visible = true;
                label3.Visible = true;

                txtHipotenusa.Visible = true;
                label4.Visible = true;
            }
            else if (cmBoxCalculo.SelectedItem.Equals("Cateto Adyacente")){
                txtCaAdyacente.Visible = false;
                label3.Visible = false;

                txtCaOpuesto.Visible = true;
                label2.Visible = true;

                txtHipotenusa.Visible = true;
                label4.Visible = true;
            }
            else{

                txtHipotenusa.Visible = false;
                label4.Visible = false;

                txtCaOpuesto.Visible = true;
                label2.Visible = true;

                txtCaAdyacente.Visible = true;
                label3.Visible = true;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Imprime.Print();//imprimir 

            txtCaAdyacente.Text = "";
            txtCaOpuesto.Text = "";
            txtHipotenusa.Text = "";

        }

        private void dateTime_Tick(object sender, EventArgs e)
        {
            timerlab.Text = System.DateTime.Now.ToString();
        }

        private void Imprime_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            ///letras y otras cosas.
            Font tipoAria = new Font("Arial", 12);//normal cuerpotexto
            Font tipoAntig = new Font("Book Antiqua", 14, FontStyle.Bold);//normal titulo
            Font tipoAmazon = new Font("Amazone", 11, FontStyle.Italic);//cursiva
            Font tipoHora = new Font("Times New Roman", 8);
            Font tipoGatito = new Font("Bell MT", 12, FontStyle.Italic);
            Font tipoGatito2 = new Font("Bell MT", 12, FontStyle.Bold);

            //lapiz y figuras (Margenes)
            Pen delgado_negro = new Pen(Color.Black, 1);
            Pen grueso_negro = new Pen(Color.Black, 2);
            Pen delgado_verde = new Pen(Color.Green, 1);
            Pen delgado_azul = new Pen(Color.Blue, 1);

            e.Graphics.DrawRectangle(delgado_negro, 40, 10, 750, 60);//rectangulo de arriba
            e.Graphics.DrawString("Teorema de Pitagoras", tipoAntig, Brushes.Black, 350, 18);
            e.Graphics.DrawLine(delgado_negro, 750, 40, 75, 40);//largo y produndidad distancia margen1
            e.Graphics.DrawString("<<Nombre de Calculo>>", tipoAmazon, Brushes.Black, 350, 43);//ultimo caracter interlineado
           
            e.Graphics.DrawRectangle(delgado_negro, 40, 80, 750, 1065);//segundo rectangulo tercer 2valordistancia 4valor ancho

            ///imagenes
            String imag = Environment.CurrentDirectory + "\\trip.jpg";//path
            e.Graphics.DrawImage(Image.FromFile(imag), new Point(41, 86));

            e.Graphics.DrawRectangle(delgado_negro, 43, 83, 350, 325);//tercer rectangulo

            //leyendas

            e.Graphics.DrawString("Cateto Opuesto: ", tipoGatito2, Brushes.Black, 400, 200);
            e.Graphics.DrawString(txtCaOpuesto.Text, tipoGatito, Brushes.Black, 525, 200);//resp

            e.Graphics.DrawString("Cateto Adyacente: ", tipoGatito2, Brushes.Black, 400, 225);
            e.Graphics.DrawString(txtCaAdyacente.Text, tipoGatito, Brushes.Black, 535, 225);//resp

            e.Graphics.DrawString("Hipotenusa: ", tipoGatito2, Brushes.Black, 400, 250);
            e.Graphics.DrawString(txtHipotenusa.Text, tipoGatito, Brushes.Black, 500, 250);//resp

            e.Graphics.DrawString("Impreso: " + System.DateTime.Now.ToString(), tipoHora, Brushes.Black, 630, 1150);//trae la hora y la imprime.
            e.Graphics.DrawString("KeySoft", tipoHora, Brushes.Black, 50, 1150);

        }
    }
}
