namespace AplicacionWindows
{
    partial class FormPractica6
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblSalida = new System.Windows.Forms.Label();
            this.txtIngresoNombre = new System.Windows.Forms.TextBox();
            this.checkBoxProgramador = new System.Windows.Forms.CheckBox();
            this.groupBoxSexo = new System.Windows.Forms.GroupBox();
            this.rdbMujer = new System.Windows.Forms.RadioButton();
            this.rdbHombre = new System.Windows.Forms.RadioButton();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.groupBoxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(533, 74);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(533, 361);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(113, 76);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(104, 247);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(36, 13);
            this.lblSalida.TabIndex = 3;
            this.lblSalida.Text = "Salida";
            // 
            // txtIngresoNombre
            // 
            this.txtIngresoNombre.Location = new System.Drawing.Point(181, 76);
            this.txtIngresoNombre.Name = "txtIngresoNombre";
            this.txtIngresoNombre.Size = new System.Drawing.Size(330, 20);
            this.txtIngresoNombre.TabIndex = 4;
            this.txtIngresoNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIngresoNombre_KeyPress);
            // 
            // checkBoxProgramador
            // 
            this.checkBoxProgramador.AutoSize = true;
            this.checkBoxProgramador.Checked = true;
            this.checkBoxProgramador.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxProgramador.Location = new System.Drawing.Point(181, 114);
            this.checkBoxProgramador.Name = "checkBoxProgramador";
            this.checkBoxProgramador.Size = new System.Drawing.Size(86, 17);
            this.checkBoxProgramador.TabIndex = 5;
            this.checkBoxProgramador.Text = "Programador";
            this.checkBoxProgramador.UseVisualStyleBackColor = true;
            // 
            // groupBoxSexo
            // 
            this.groupBoxSexo.Controls.Add(this.rdbMujer);
            this.groupBoxSexo.Controls.Add(this.rdbHombre);
            this.groupBoxSexo.Location = new System.Drawing.Point(181, 137);
            this.groupBoxSexo.Name = "groupBoxSexo";
            this.groupBoxSexo.Size = new System.Drawing.Size(331, 100);
            this.groupBoxSexo.TabIndex = 6;
            this.groupBoxSexo.TabStop = false;
            this.groupBoxSexo.Text = "Sexo";
            // 
            // rdbMujer
            // 
            this.rdbMujer.AutoSize = true;
            this.rdbMujer.Location = new System.Drawing.Point(87, 29);
            this.rdbMujer.Name = "rdbMujer";
            this.rdbMujer.Size = new System.Drawing.Size(51, 17);
            this.rdbMujer.TabIndex = 1;
            this.rdbMujer.Text = "Mujer";
            this.rdbMujer.UseVisualStyleBackColor = true;
            // 
            // rdbHombre
            // 
            this.rdbHombre.AutoSize = true;
            this.rdbHombre.Checked = true;
            this.rdbHombre.Location = new System.Drawing.Point(7, 29);
            this.rdbHombre.Name = "rdbHombre";
            this.rdbHombre.Size = new System.Drawing.Size(62, 17);
            this.rdbHombre.TabIndex = 0;
            this.rdbHombre.TabStop = true;
            this.rdbHombre.Text = "Hombre";
            this.rdbHombre.UseVisualStyleBackColor = true;
            // 
            // txtSalida
            // 
            this.txtSalida.Location = new System.Drawing.Point(107, 263);
            this.txtSalida.Multiline = true;
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSalida.Size = new System.Drawing.Size(405, 121);
            this.txtSalida.TabIndex = 7;
            // 
            // FormPractica6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSalida);
            this.Controls.Add(this.groupBoxSexo);
            this.Controls.Add(this.checkBoxProgramador);
            this.Controls.Add(this.txtIngresoNombre);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnOk);
            this.Name = "FormPractica6";
            this.Text = "Radiobutton y CheckBox";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPractica6_FormClosed);
            this.Load += new System.EventHandler(this.FormPractica6_Load);
            this.groupBoxSexo.ResumeLayout(false);
            this.groupBoxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.TextBox txtIngresoNombre;
        private System.Windows.Forms.CheckBox checkBoxProgramador;
        private System.Windows.Forms.GroupBox groupBoxSexo;
        private System.Windows.Forms.RadioButton rdbMujer;
        private System.Windows.Forms.RadioButton rdbHombre;
        private System.Windows.Forms.TextBox txtSalida;
    }
}