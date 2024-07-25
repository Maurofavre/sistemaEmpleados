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
        //creamos objeto
        DepartamentosDLL oDepartamentosDLL;

        public frmDepartamentos()
        {
            oDepartamentosDLL = new DepartamentosDLL();
            InitializeComponent();
            //Llenar la tabla con los datos de la bd 
            LlenarGrid();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("Conectado... ");
            //traemos recuperarInfo para llevar la informacion al metodo agregar de la base logica departamento 
            oDepartamentosDLL.Agregar(recuperarInfo() );

        }
        //crear un obejeto apartir de la clase bll , y obtener los valores del form 
        //departamentoBLL el private
        //este metodo devuelve un objeto de departamentoBLL y al ser invocado regresa ese dato 
        private departamentoBLL recuperarInfo()
        {       
            // creamos objeto usando plantilla de la clase departamentoBLL 
            departamentoBLL odepartamentoBLL = new departamentoBLL();

            int ID = 0; int.TryParse(txtId.Text, out ID);

            odepartamentoBLL.ID = ID;
            odepartamentoBLL.Departamento = txtDepartamento.Text;
            //Retornamos el objeto departamentoBLL 
            return odepartamentoBLL;    
        }
        //Envento mouseclick frmDepartamento para llevar informacion seleccionada 
        private void Seleccionar(object sender, DataGridViewCellMouseEventArgs e)
        {
            //e.RowIndex se usa para obtener el índice de la fila en la que ocurrió el evento,
            int indice = e.RowIndex;

            txtId.Text = dgvDepartamento.Rows[indice].Cells[0].Value.ToString();
            txtDepartamento.Text = dgvDepartamento.Rows[indice].Cells[1].Value.ToString();
        }

        public void LlenarGrid()
        {
            dgvDepartamento.DataSource = oDepartamentosDLL.MostrarDepartamentos().Tables[0];

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            oDepartamentosDLL.Eliminar(recuperarInfo());
            LlenarGrid();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            oDepartamentosDLL.Modificar(recuperarInfo());
            LlenarGrid();
        }

        
    }
}
