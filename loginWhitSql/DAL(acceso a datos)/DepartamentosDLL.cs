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

        public bool Agregar()
        {
         return conexion.ejecutarComandosSinRetornos("INSERT INTO departamentos (departamento) VALUES('Diseño');")

        }


    }
}
