using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace loginWhitSql.DAL_acceso_a_datos_
{
     class conexionDal
    {
        //preba si entra la conexion 
        public bool pruebaConexion()
        {
            try
            {
                // Armar la conexión 
                MySqlConnection conexion = new MySqlConnection("Server=localhost;Port=3306;Database=dbsistema;User Id=root;Password=;");

                // Comando para poder hacer consultas 
                MySqlCommand comando = new MySqlCommand
                {
                    CommandText = "SELECT * FROM empleados",
                    Connection = conexion
                };

                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();

                return true;
            }
            catch
            {
                return false;
            }

        }

    }



}
