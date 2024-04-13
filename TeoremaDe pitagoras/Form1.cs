using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;


namespace TeoremaDe_pitagoras
{
    public partial class Form1 : Form
    {
        string user = "Amparo";
        string contr = "121820095";
        private Form1 form;


        public Form1()
        {
            InitializeComponent();


            Thread hilos = new Thread(mostrarSplash);
            hilos.Start();
            Thread.Sleep(5000);
            hilos.Abort();
            ///agregar progress bar para que paresca que esta cargando.
            txtUsuario.Text = "Amparo";


        }

        public Form1(Form1 form)
        {
            this.form = form;
          
        }

        void mostrarSplash()
        {
            splashTeorema sp = new splashTeorema();
            sp.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim().Equals(user) && txtContrasenia.Text.Trim().Equals(contr))
            {
                this.Hide();//oculta una ventana 

               // MessageBox.Show("correcto ingreso", "Teorema de Pitagoras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                operacionesPitagoras op = new operacionesPitagoras();
                op.ShowDialog();//crea la ventana linea agregada

            }
            else
            {
                MessageBox.Show("Contraseña o Usuario incorrecto ¡Intentalo una vez mas!", "¡Opss,Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
