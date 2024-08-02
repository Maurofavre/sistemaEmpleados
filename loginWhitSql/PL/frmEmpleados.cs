﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using loginWhitSql.DAL_acceso_a_datos_;
using loginWhitSql.BLL_logica_; 

namespace loginWhitSql.PL_presentacion__
{
    public partial class frmEmpleados : Form
    {
        byte[] imagenByte;
        EmpleadosDal oEmpleadosDal;
              
        public frmEmpleados()
        {
            oEmpleadosDal = new EmpleadosDal();
            InitializeComponent();
        }

        



        //Llenamos el combo con los datos 
        private void frmEmpleados_Load(object sender, EventArgs e)
        {

            //IMPORTANTE COMO RECUPERAR INFORMACION DEL USUARIO PARA FILTRAR 
            DepartamentosDLL objDepartamentos = new DepartamentosDLL();
            //DataSource ?
            cmbDepartamento.DataSource = objDepartamentos.MostrarDepartamentos().Tables[0];
            //DisplayMember ??
            cmbDepartamento.DisplayMember = "departamento";
            //ValueMember ? 
            cmbDepartamento.ValueMember = "ID";


         }

        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            

            oEmpleadosDal.Agregar(RecolectarDatos());
        }
      
        private empleadosBLL RecolectarDatos()
        {
            empleadosBLL objEmplados = new empleadosBLL();

            int codigoEmpleado = 1;
            //si tiene codigo lo usa, sino le pone 1 
            int.TryParse(txtId.Text, out codigoEmpleado);


            objEmplados.ID = codigoEmpleado;
            objEmplados.NombreEmpleado= txtNombre.Text;
            objEmplados.PrimerApellido = txtPrimerApellido.Text;
            objEmplados.SegundoApellido = txtSengundoApellid.Text;
            objEmplados.Correo=txtCorreo.Text;


            int departamentoIDD = 0;

            int.TryParse(cmbDepartamento.SelectedValue.ToString(), out departamentoIDD);

            objEmplados.Departamento = departamentoIDD;

            objEmplados.FotoEmpleado = imagenByte;

            return objEmplados; 


        }

        public void LlenarGrid()
        {
            dgvEmpleados.DataSource = oEmpleadosDal.MostrarEmpleados().Tables[0];

            dgvEmpleados.Columns[0].HeaderText = "Id";
            dgvEmpleados.Columns[1].HeaderText = "Nombre Departamento";

        }

        private void btnExaminar_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog selectorImagen = new OpenFileDialog();

            selectorImagen.Title = "seleccionar Imagen";

            //Verifica si ya selecciono una foto 
            if (selectorImagen.ShowDialog() == DialogResult.OK)
            {
                picFoto.Image = Image.FromStream(selectorImagen.OpenFile());
                MemoryStream memoria = new MemoryStream();

                picFoto.Image.Save(memoria, System.Drawing.Imaging.ImageFormat.Png);


                imagenByte = memoria.ToArray();

            }

        }
    }
}
