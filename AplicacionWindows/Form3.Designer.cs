namespace AplicacionWindows
{
    partial class FormEjercicio2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbIngresoDatos = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grbElementos = new System.Windows.Forms.GroupBox();
            this.lbRecibeElementos = new System.Windows.Forms.ListBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.grbIngresoDatos.SuspendLayout();
            this.grbElementos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbIngresoDatos
            // 
            this.grbIngresoDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grbIngresoDatos.Controls.Add(this.btnAgregar);
            this.grbIngresoDatos.Controls.Add(this.txtApellido);
            this.grbIngresoDatos.Controls.Add(this.txtNombre);
            this.grbIngresoDatos.Controls.Add(this.lblApellido);
            this.grbIngresoDatos.Controls.Add(this.lblNombre);
            this.grbIngresoDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbIngresoDatos.Location = new System.Drawing.Point(22, 12);
            this.grbIngresoDatos.Name = "grbIngresoDatos";
            this.grbIngresoDatos.Size = new System.Drawing.Size(352, 426);
            this.grbIngresoDatos.TabIndex = 0;
            this.grbIngresoDatos.TabStop = false;
            this.grbIngresoDatos.Text = "Ingreso de Datos";
            
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(75, 200);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(125, 41);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(108, 147);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(151, 23);
            this.txtApellido.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(108, 118);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(151, 23);
            this.txtNombre.TabIndex = 2;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(22, 151);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(65, 16);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(22, 119);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // grbElementos
            // 
            this.grbElementos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grbElementos.Controls.Add(this.lbRecibeElementos);
            this.grbElementos.Controls.Add(this.btnVolver);
            this.grbElementos.Controls.Add(this.btnBorrar);
            this.grbElementos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbElementos.Location = new System.Drawing.Point(398, 12);
            this.grbElementos.Name = "grbElementos";
            this.grbElementos.Size = new System.Drawing.Size(352, 426);
            this.grbElementos.TabIndex = 1;
            this.grbElementos.TabStop = false;
            this.grbElementos.Text = "Elementos";
            // 
            // lbRecibeElementos
            // 
            this.lbRecibeElementos.FormattingEnabled = true;
            this.lbRecibeElementos.ItemHeight = 16;
            this.lbRecibeElementos.Location = new System.Drawing.Point(19, 31);
            this.lbRecibeElementos.Name = "lbRecibeElementos";
            this.lbRecibeElementos.Size = new System.Drawing.Size(327, 308);
            this.lbRecibeElementos.TabIndex = 7;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(192, 361);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(91, 40);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(82, 361);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(91, 40);
            this.btnBorrar.TabIndex = 6;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // FormEjercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbElementos);
            this.Controls.Add(this.grbIngresoDatos);
            this.Name = "FormEjercicio2";
            this.Text = "Nombre y Apellido";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEjercicio2_FormClosed);
            this.Load += new System.EventHandler(this.FormEjercicio2_Load);
            this.grbIngresoDatos.ResumeLayout(false);
            this.grbIngresoDatos.PerformLayout();
            this.grbElementos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbIngresoDatos;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox grbElementos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lbRecibeElementos;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnBorrar;
    }
}