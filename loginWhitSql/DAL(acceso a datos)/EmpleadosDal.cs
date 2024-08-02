using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using loginWhitSql.BLL_logica_;
using System.Collections;

namespace loginWhitSql.DAL_acceso_a_datos_
{

    internal class EmpleadosDal
    {

        conexionDal conexion;

        public EmpleadosDal()
        {

            conexion = new conexionDal();

        }

        public bool Agregar(empleadosBLL oEmpleadosBll )

        {
            //"+odepartamentoBLL.Departamento+" asi se llama a las partes del objeto
            string query = "INSERT INTO empleados (id, nombre, primerapellido, segundoapellido, correo, foto) VALUES (@id, @nombre, @primerapellido, @segundoapellido, @correo, @foto)";


            // Crear y configurar el comando MySql
            MySqlCommand SqlComando = new MySqlCommand(query);

            // Añadir el valor del objeto oDepartamentoBLL
            SqlComando.Parameters.Add("@id", MySqlDbType.VarChar).Value = oEmpleadosBll.ID;
            SqlComando.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = oEmpleadosBll.NombreEmpleado;
            SqlComando.Parameters.Add("@primerapellido", MySqlDbType.VarChar).Value = oEmpleadosBll.PrimerApellido;
            SqlComando.Parameters.Add("@segundoapellido", MySqlDbType.VarChar).Value = oEmpleadosBll.SegundoApellido;
            SqlComando.Parameters.Add("@correo", MySqlDbType.VarChar).Value = oEmpleadosBll.Correo;
            SqlComando.Parameters.Add("@foto", MySqlDbType.Blob).Value = oEmpleadosBll.FotoEmpleado;
            // Ejecutar el comando y devolver el resultado
            return conexion.ejecutarComandosSinRetornos(SqlComando);
        }

        public DataSet MostrarEmpleados()
        {
            // Crear el comando SQL
            MySqlCommand sentencia = new MySqlCommand("SELECT * FROM empleados");

            // Ejecutar la sentencia y devolver el resultado
            return conexion.EjecutarSentencia(sentencia);


        }


        public bool Eliminar(empleadosBLL oEmpleadosBll)
        {
            string query = "DELETE FROM empleados where Id = @ID";
            MySqlCommand SqlComando = new MySqlCommand(query);


            SqlComando.Parameters.Add("@ID", MySqlDbType.Int32).Value = oEmpleadosBll.ID;
            return conexion.ejecutarComandosSinRetornos(SqlComando);


        }

        


    }
}
