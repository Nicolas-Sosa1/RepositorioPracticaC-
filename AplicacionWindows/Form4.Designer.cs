namespace AplicacionWindows
{
    partial class FormEjercicio3
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
            this.grbSexo = new System.Windows.Forms.GroupBox();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.grbEstadoCivil = new System.Windows.Forms.GroupBox();
            this.rdbSoltero = new System.Windows.Forms.RadioButton();
            this.rdbCasado = new System.Windows.Forms.RadioButton();
            this.clbOficio = new System.Windows.Forms.CheckedListBox();
            this.lblResultados = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.grbSexo.SuspendLayout();
            this.grbEstadoCivil.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbSexo
            // 
            this.grbSexo.Controls.Add(this.rdbMasculino);
            this.grbSexo.Controls.Add(this.rdbFemenino);
            this.grbSexo.Font = new System.Drawing.Font("Questrial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSexo.Location = new System.Drawing.Point(121, 24);
            this.grbSexo.Name = "grbSexo";
            this.grbSexo.Size = new System.Drawing.Size(226, 118);
            this.grbSexo.TabIndex = 0;
            this.grbSexo.TabStop = false;
            this.grbSexo.Text = "Sexo";
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(7, 52);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(89, 17);
            this.rdbMasculino.TabIndex = 1;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Checked = true;
            this.rdbFemenino.Location = new System.Drawing.Point(7, 20);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(87, 17);
            this.rdbFemenino.TabIndex = 0;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // grbEstadoCivil
            // 
            this.grbEstadoCivil.Controls.Add(this.rdbSoltero);
            this.grbEstadoCivil.Controls.Add(this.rdbCasado);
            this.grbEstadoCivil.Font = new System.Drawing.Font("Questrial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEstadoCivil.Location = new System.Drawing.Point(433, 24);
            this.grbEstadoCivil.Name = "grbEstadoCivil";
            this.grbEstadoCivil.Size = new System.Drawing.Size(226, 118);
            this.grbEstadoCivil.TabIndex = 1;
            this.grbEstadoCivil.TabStop = false;
            this.grbEstadoCivil.Text = "Estado Civil";
            // 
            // rdbSoltero
            // 
            this.rdbSoltero.AutoSize = true;
            this.rdbSoltero.Location = new System.Drawing.Point(0, 52);
            this.rdbSoltero.Name = "rdbSoltero";
            this.rdbSoltero.Size = new System.Drawing.Size(70, 17);
            this.rdbSoltero.TabIndex = 3;
            this.rdbSoltero.TabStop = true;
            this.rdbSoltero.Text = "Soltero";
            this.rdbSoltero.UseVisualStyleBackColor = true;
            // 
            // rdbCasado
            // 
            this.rdbCasado.AutoSize = true;
            this.rdbCasado.Checked = true;
            this.rdbCasado.Location = new System.Drawing.Point(0, 20);
            this.rdbCasado.Name = "rdbCasado";
            this.rdbCasado.Size = new System.Drawing.Size(73, 17);
            this.rdbCasado.TabIndex = 2;
            this.rdbCasado.TabStop = true;
            this.rdbCasado.Text = "Casado";
            this.rdbCasado.UseVisualStyleBackColor = true;
            // 
            // clbOficio
            // 
            this.clbOficio.FormattingEnabled = true;
            this.clbOficio.Items.AddRange(new object[] {
            "Data Entry",
            "Operador de PC",
            "Programador",
            "Reparador de PC",
            "Tester"});
            this.clbOficio.Location = new System.Drawing.Point(196, 148);
            this.clbOficio.Name = "clbOficio";
            this.clbOficio.Size = new System.Drawing.Size(307, 169);
            this.clbOficio.TabIndex = 2;
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultados.Location = new System.Drawing.Point(118, 388);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(0, 24);
            this.lblResultados.TabIndex = 3;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(254, 332);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(186, 37);
            this.btnMostrar.TabIndex = 4;
            this.btnMostrar.Text = "Mostrar lo que se seleciono";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(657, 512);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(94, 37);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FormEjercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 584);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.lblResultados);
            this.Controls.Add(this.clbOficio);
            this.Controls.Add(this.grbEstadoCivil);
            this.Controls.Add(this.grbSexo);
            this.Name = "FormEjercicio3";
            this.Text = "Ejercicio 3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEjercicio3_FormClosed);
            this.Load += new System.EventHandler(this.FormEjercicio3_Load);
            this.grbSexo.ResumeLayout(false);
            this.grbSexo.PerformLayout();
            this.grbEstadoCivil.ResumeLayout(false);
            this.grbEstadoCivil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSexo;
        private System.Windows.Forms.GroupBox grbEstadoCivil;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.RadioButton rdbSoltero;
        private System.Windows.Forms.RadioButton rdbCasado;
        private System.Windows.Forms.CheckedListBox clbOficio;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnVolver;
    }
}