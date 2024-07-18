using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using loginWhitSql.BLL_logica_;
using loginWhitSql.DAL_acceso_a_datos_; 

namespace loginWhitSql.PL_presentacion__
{
    public partial class frmDepartamentos : Form
    {
        public frmDepartamentos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            recuperarInfo(); 

            conexionDal conexion = new conexionDal();

            MessageBox.Show("Conectado... " + conexion.pruebaConexion()); 

        }
        //crear un obejetro apartir de la clase bll , y obtener los valores del form 
        private void recuperarInfo()
        {       

            // creamos objeto usando plantilla de la clase departamentoBLL 
            departamentoBLL odepartamentoBLL = new departamentoBLL();

            int ID = 0; int.TryParse(txtId.Text, out ID);

            odepartamentoBLL.ID = ID;

            odepartamentoBLL.Departamento = txtDepartamento.Text;

            MessageBox.Show(odepartamentoBLL.ID.ToString());
            MessageBox.Show(odepartamentoBLL.Departamento);

        }

      
    }
}
