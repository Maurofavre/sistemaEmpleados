using loginWhitSql.BLL;
using loginWhitSql.BLL_logica_;
using loginWhitSql.DAL_acceso_a_datos_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginWhitSql.PL
{
    public partial class frmStock : Form
    {

        byte[] imgStock;
        StockDAL oStock;

        public frmStock()
        {
            oStock = new StockDAL();
            InitializeComponent();
        }
        // Recuperamo datos y lo gurdamos en obj oStock
        private stockBLL guardarDatos()
        {
            stockBLL oStock = new stockBLL();

            int codigoStock = 1;
            //si tiene codigo lo usa, sino le pone 1 
            int.TryParse(txtId.Text, out codigoStock);

            oStock.Id = codigoStock;
            oStock.Descripcion = txtDescr.Text;
            oStock.Cantidad = int.Parse(txtCant.Text);
            oStock.Precio = int.Parse(txtPrecio.Text);
            oStock.FotoStock = imgStock;
            return oStock;

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            oStock.Agregar(guardarDatos());

            Limpiar(); 
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectorImagen = new OpenFileDialog();

            selectorImagen.Title = "seleccionar Imagen";

            //Verifica si ya selecciono una foto 
            if (selectorImagen.ShowDialog() == DialogResult.OK)
            {
                picStock.Image = Image.FromStream(selectorImagen.OpenFile());
                MemoryStream memoria = new MemoryStream();

                picStock.Image.Save(memoria, System.Drawing.Imaging.ImageFormat.Png);
                imgStock = memoria.ToArray();

            }

        }
        public void Limpiar()
        {
            txtId.Clear();
            txtDescr.Clear();
            txtCant.Clear();
            txtPrecio.Clear();
           

        }
    }
}
