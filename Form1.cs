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
        string conexion = "Server=localhost,1433;Database=TopicosAvanzados;User Id=sa;Password=s1st3m4s;TrustServerCertificate=true;";

        private void tmrReloj_Tick(object sender, EventArgs e)
        {
        }

        private void buttEncener_Click(object sender, EventArgs e)
        {
        }


    }
}
