namespace loginWhitSql
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStock = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnDpto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStock
            // 
            this.btnStock.Image = global::loginWhitSql.Properties.Resources._79732_paste_stock_icon__1_;
            this.btnStock.Location = new System.Drawing.Point(130, 56);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(112, 97);
            this.btnStock.TabIndex = 2;
            this.btnStock.Text = "Stock";
            this.btnStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Image = global::loginWhitSql.Properties.Resources._285641_id_user_icon;
            this.btnEmpleados.Location = new System.Drawing.Point(248, 56);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(122, 97);
            this.btnEmpleados.TabIndex = 1;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnDpto
            // 
            this.btnDpto.Image = global::loginWhitSql.Properties.Resources._299100_screwdriver_wrench_icon;
            this.btnDpto.Location = new System.Drawing.Point(12, 56);
            this.btnDpto.Name = "btnDpto";
            this.btnDpto.Size = new System.Drawing.Size(112, 97);
            this.btnDpto.TabIndex = 0;
            this.btnDpto.Text = "Departamentos ";
            this.btnDpto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDpto.UseVisualStyleBackColor = true;
            this.btnDpto.Click += new System.EventHandler(this.btnDpto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 224);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.btnEmpleados);
            this.Controls.Add(this.btnDpto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDpto;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnStock;
    }
}

