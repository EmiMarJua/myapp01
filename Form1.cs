using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttCalcular_Click(object sender, EventArgs e)
        {

            int a, b = 0;

                a = Int32.Parse(textNum1.Text);
                b = Int32.Parse(textNum2.Text);

            textResultado.Text = (a + b).ToString();

           // MessageBox.Show("La suma es: " + (a + b).ToString());
          //  this.Close();

        }

        private void buttLimpiar_Click(object sender, EventArgs e)
        {
            textNum1.Clear(); 
            textNum2.Clear();
            textResultado.Clear();
            textNum1.Focus();//poner el cursor en el textNum1
        }
    }
}
