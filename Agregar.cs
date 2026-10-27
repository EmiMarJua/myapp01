using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp01
{
    public partial class Agregar : Form
    {

        bool updateMode = false;
        int idRegistro = 0;

        public Agregar()
        {
            InitializeComponent();
        }

        Datos d = new Datos();

        public  Agregar(string nombre, string paterno, string materno, string telefono, string correo, int id)
        {

            InitializeComponent();

            textNombre.Text = nombre;
            textPaterno.Text = paterno;
            textMaterno.Text = materno;
            mtbTelefono.Text = telefono;
            textCorreo.Text = correo;
            idRegistro = id;

            updateMode = true;

            buttAgregar.Text = "Actualizar";
        }

        private void buttAgregar_Click(object sender, EventArgs e)
        {

            if (updateMode == false)
            {

                SqlCommand comando = new SqlCommand("INSERT INTO Datos(nombre, paterno, materno, telefono, correo)" +
                        " VALUES ('" + textNombre.Text + "', '" + textPaterno.Text + "', '" + textMaterno.Text
                        + "', '" + mtbTelefono.Text + "', '" + textCorreo.Text + "' )");

                bool f = d.ejecutar(comando);


                if (f == true)
                {
                    MessageBox.Show("Registro Completado");
                }
                else
                {

                    MessageBox.Show("Registro no Completado");
                }

                
            }
            else
            {
                SqlCommand comando =new SqlCommand("UPDATE Datos SET nombre = @nombre, " +
                    "paterno = @paterno, materno = @materno, " +
                    "telefono = @telefono, correo = @correo " +
                    "WHERE id = @id")  ;

                comando.Parameters.AddWithValue("@nombre", textNombre.Text);
                comando.Parameters.AddWithValue("@paterno", textPaterno.Text);
                comando.Parameters.AddWithValue("@materno", textMaterno.Text);
                comando.Parameters.AddWithValue("@telefono", mtbTelefono.Text);
                comando.Parameters.AddWithValue("@correo", textCorreo.Text);
                comando.Parameters.AddWithValue("@id", idRegistro);

                bool f = d.ejecutar(comando);

                if (f == true)
                {
                    MessageBox.Show("Registro Actualizado Correctamente");
                }
                else
                {
                    MessageBox.Show("registro no completado");
                }
            }

            this.Close();
        }

        private void buttCerrar_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            EstadosMunicipios datos = new EstadosMunicipios();

            DataSet dsEstados = new DataSet();

            dsEstados = datos.Mostrar("Select * from estado");

            if(dsEstados != null && dsEstados.Tables.Count > 0)
            {
                cmbEstados.DataSource = dsEstados.Tables[0];
                cmbEstados.DisplayMember = "nombre";
                cmbEstados.ValueMember = "id";
            }

        }
    }
}
