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

        int estadoRegistro = 0;
        int municipioRegistro = 0;

        public Agregar()
        {
            InitializeComponent();
        }

        Datos d = new Datos();

        public  Agregar(string nombre, string paterno, string materno, string telefono, string correo, int idEstado, int idMunicipio,int id)
        {

            InitializeComponent();

            textNombre.Text = nombre;
            textPaterno.Text = paterno;
            textMaterno.Text = materno;
            mtbTelefono.Text = telefono;
            textCorreo.Text = correo;
            estadoRegistro = idEstado;
            municipioRegistro = idMunicipio;
            idRegistro = id;

            updateMode = true;

            buttAgregar.Text = "Actualizar";
        }

        private void buttAgregar_Click(object sender, EventArgs e)
        {

            if (updateMode == false)
            {

                SqlCommand comando = new SqlCommand("INSERT INTO Datos(nombre, paterno, materno, telefono, correo, idEstado, idMunicipio)" +
                        " VALUES ('" + textNombre.Text + "', '" + textPaterno.Text + "', '" + textMaterno.Text
                        + "', '" + mtbTelefono.Text + "', '" + textCorreo.Text + "', " + cmbEstados.SelectedValue + ", " + cmbMunicpios.SelectedValue + " )");

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
                    "telefono = @telefono, correo = @correo, idEstado = @idEstado, idMunicipio = @idMunicipio " + 
                    "WHERE id = @id")  ;

                comando.Parameters.AddWithValue("@nombre", textNombre.Text);
                comando.Parameters.AddWithValue("@paterno", textPaterno.Text);
                comando.Parameters.AddWithValue("@materno", textMaterno.Text);
                comando.Parameters.AddWithValue("@telefono", mtbTelefono.Text);
                comando.Parameters.AddWithValue("@correo", textCorreo.Text);
                comando.Parameters.AddWithValue("@idEstado", cmbEstados.SelectedValue);
                comando.Parameters.AddWithValue("@idMunicipio", cmbMunicpios.SelectedValue);
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
            Datos datos = new Datos();

            DataSet dsEstados = new DataSet();

            dsEstados = datos.Mostrar("Select * from estado");

            if(dsEstados != null && dsEstados.Tables.Count > 0)
            {
                cmbEstados.DataSource = dsEstados.Tables[0];
                cmbEstados.DisplayMember = "nombre";
                cmbEstados.ValueMember = "idEstado";

                if (updateMode)
                {
                    cmbEstados.SelectedValue = estadoRegistro;
                }

                cambiosMun(Convert.ToInt32(cmbEstados.SelectedValue));

                if (updateMode)
                {
                    cmbMunicpios.SelectedValue = municipioRegistro;
                }

            }

        }

        private void cmbEstados_SelectedIndexChanged(object sender, EventArgs e)
        {

            cambiosMun(Convert.ToInt32(cmbEstados.SelectedIndex + 1));

        }

        private void cambiosMun(int idEstado)
        {

            Datos datos = new Datos();

            DataSet dsMunicipios = new DataSet();
            dsMunicipios = datos.Mostrar("select * from municipios where idEstado = " + idEstado );

            if (dsMunicipios != null && dsMunicipios.Tables.Count > 0)
            {
                cmbMunicpios.DataSource = dsMunicipios.Tables[0];
                cmbMunicpios.DisplayMember = "nombre";
                cmbMunicpios.ValueMember = "idMunicipios";
            }

        }

    }
}

//modificiar 


