﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using loginWhitSql.PL_presentacion__;

namespace loginWhitSql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDpto_Click(object sender, EventArgs e)
        {
            frmDepartamentos formularioDepartamentos = new frmDepartamentos();
            formularioDepartamentos.ShowDialog(); // Abre frmDepartamentos como modal
           // this.Hide();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            frmEmpleados formularioEmpleados = new frmEmpleados();
            formularioEmpleados.ShowDialog(); // Abre frmDepartamentos como modal
            //this.Hide();
        }
    }
}
