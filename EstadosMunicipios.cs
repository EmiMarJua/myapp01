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
    internal class EstadosMunicipios
    {
        SqlConnection conexion;
        string cadena = "Server=localhost;Database=TopicoAvanzados;User Id=sa;Password=s1st3m4s;TrustServerCertificate=true;";

        private void conexionOpen()
        {

            try
            {

                conexion = new SqlConnection(cadena);
                conexion.Open();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al conectar: " + ex.ToString());

            }

        }

        private void conexionClose()
        {

            try { conexion.Close(); }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }

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

                return ds;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;

            }

        }

        

    }
}
