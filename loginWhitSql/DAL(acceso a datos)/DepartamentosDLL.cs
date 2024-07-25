using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using loginWhitSql.BLL_logica_;

namespace loginWhitSql.DAL_acceso_a_datos_
{
    internal class DepartamentosDLL
    {
        conexionDal conexion; 

        //COSNTRUCTOR
        public DepartamentosDLL(){

            conexion = new conexionDal();   

        }
        //recibe el objeto de odepartamentoBll
        public bool Agregar(departamentoBLL odepartamentoBLL)

        {
            //"+odepartamentoBLL.Departamento+" asi se llama a las partes del objeto
            return conexion.ejecutarComandosSinRetornos("INSERT INTO departamentos (departamento) VALUES('"+odepartamentoBLL.Departamento+"');");

        }
        //traer todo de la tabla de departamentos 
        public DataSet MostrarDepartamentos()
        {
            // Crear el comando SQL
            MySqlCommand sentencia = new MySqlCommand("SELECT * FROM Departamentos");

            // Ejecutar la sentencia y devolver el resultado
            return conexion.EjecutarSentencia(sentencia);
        }

        public int Eliminar(departamentoBLL odepartamentoBLL)
        {
            conexion.ejecutarComandosSinRetornos("DELETE FROM departamentos WHERE ID=" + odepartamentoBLL.ID);

            return 1; 
        }

        public int Modificar(departamentoBLL odepartamentoBLL)
        {
            conexion.ejecutarComandosSinRetornos(
                "UPDATE Departamentos" +
                " SET departamento= '" + odepartamentoBLL.Departamento + " '" +
                "WHERE ID=" + odepartamentoBLL.ID); 
                

            return 1;
        }

    }
}
