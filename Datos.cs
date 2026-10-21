using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace MyApp01
{
    internal class Datos
    {

        SqlConnection conexion;

        string cadena = "Server=localhost;Database=Agenda;User Id=sa;Password=s1st3m4s;TrustServerCertificate=true;";


        private void conexionOpen()
        {

            try
            {

                conexion= new SqlConnection(cadena);
                conexion.Open();

            }
            catch(Exception ex){

                MessageBox.Show("Error al conectar: " + ex.ToString());

            }

        }

        private void conexionClose()
        {

            try { conexion.Close(); }
            catch(Exception ex) { Console.WriteLine(ex.ToString()); }

        }

        public bool ejecutar(SqlCommand comando)
        {
            try
            {
                conexionOpen();

                comando.Connection = conexion;
                comando.ExecuteNonQuery();

                conexionClose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                conexionClose();
                return false;
            }
        }

        public DataSet Mostrar(string comando)
        {
            DataSet ds = new DataSet();

            try
            {

                conexionOpen();

                SqlDataAdapter da = new SqlDataAdapter(comando, conexion);
                da.Fill(ds);

                conexionClose();

                return ds ;

            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;

            }

        }

        public bool eliminar(int id)
        {
            SqlCommand comando = new SqlCommand("DELETE FROM Datos WHERE id = @id");

            comando.Parameters.AddWithValue("@id", id);

            return ejecutar(comando);
        }

    }
}
//menu contextual sobre el datagrid, cuando se seleccione se aparezca un menu que muestre eliminar y modificar
//el eliminar va a ser similar al de actualizar y cuando se elimina se tiene que volver a cargar todo en el
// datagrid


//