using loginWhitSql.BLL;
using loginWhitSql.BLL_logica_;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loginWhitSql.DAL_acceso_a_datos_
{
    internal class StockDAL
    {
        conexionDal conexion;

        public StockDAL()
        {
            conexion = new conexionDal();   
        }
        
        public bool Agregar(stockBLL oStock)

        {
            //"+odepartamentoBLL.Departamento+" asi se llama a las partes del objeto
            string query = "INSERT INTO idstock (id, descripcion, cantidad, precio, foto) VALUES (@id, @descripcion, @cantidad, @precio, @foto)";


            // Crear y configurar el comando MySql
            MySqlCommand SqlComando = new MySqlCommand(query);

            // Añadir el valor del objeto oDepartamentoBLL
            SqlComando.Parameters.Add("@id", MySqlDbType.VarChar).Value = oStock.Id;
            SqlComando.Parameters.Add("@descripcion", MySqlDbType.VarChar).Value = oStock.Descripcion;
            SqlComando.Parameters.Add("@cantidad", MySqlDbType.VarChar).Value = oStock.Cantidad;
            SqlComando.Parameters.Add("@precio", MySqlDbType.VarChar).Value = oStock.Precio;
            SqlComando.Parameters.Add("@foto", MySqlDbType.Blob).Value = oStock.FotoStock;
            // Ejecutar el comando y devolver el resultado
            return conexion.ejecutarComandosSinRetornos(SqlComando);
        }

    }
}
