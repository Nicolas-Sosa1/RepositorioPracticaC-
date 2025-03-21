namespace AplicacionWindows
{
    partial class FormEjercicioTp1
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
            this.btnVolverPrincipal = new System.Windows.Forms.Button();
            this.lblIngresarNombre = new System.Windows.Forms.Label();
            this.txtIngresarNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnPasarNombre = new System.Windows.Forms.Button();
            this.btnPasarTodos = new System.Windows.Forms.Button();
            this.lbNombresAgregados = new System.Windows.Forms.ListBox();
            this.lbNombresRecibidos = new System.Windows.Forms.ListBox();
            this.btnPasarVarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVolverPrincipal
            // 
            this.btnVolverPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnVolverPrincipal.Font = new System.Drawing.Font("Press Start 2P", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverPrincipal.Location = new System.Drawing.Point(644, 366);
            this.btnVolverPrincipal.Name = "btnVolverPrincipal";
            this.btnVolverPrincipal.Size = new System.Drawing.Size(135, 72);
            this.btnVolverPrincipal.TabIndex = 0;
            this.btnVolverPrincipal.Text = "Volver";
            this.btnVolverPrincipal.UseVisualStyleBackColor = false;
            this.btnVolverPrincipal.Click += new System.EventHandler(this.btnVolverPrincipal_Click);
            // 
            // lblIngresarNombre
            // 
            this.lblIngresarNombre.AutoSize = true;
            this.lblIngresarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresarNombre.Location = new System.Drawing.Point(46, 50);
            this.lblIngresarNombre.Name = "lblIngresarNombre";
            this.lblIngresarNombre.Size = new System.Drawing.Size(159, 20);
            this.lblIngresarNombre.TabIndex = 1;
            this.lblIngresarNombre.Text = "Ingrese su nombre";
            // 
            // txtIngresarNombre
            // 
            this.txtIngresarNombre.Location = new System.Drawing.Point(231, 50);
            this.txtIngresarNombre.Name = "txtIngresarNombre";
            this.txtIngresarNombre.Size = new System.Drawing.Size(333, 20);
            this.txtIngresarNombre.TabIndex = 2;
            this.txtIngresarNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIngresarNombre_KeyDown);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAgregar.Font = new System.Drawing.Font("Norwester", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(603, 44);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(83, 34);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnPasarNombre
            // 
            this.btnPasarNombre.BackColor = System.Drawing.Color.Fuchsia;
            this.btnPasarNombre.Font = new System.Drawing.Font("Merienda One", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasarNombre.Location = new System.Drawing.Point(337, 190);
            this.btnPasarNombre.Name = "btnPasarNombre";
            this.btnPasarNombre.Size = new System.Drawing.Size(75, 23);
            this.btnPasarNombre.TabIndex = 4;
            this.btnPasarNombre.Text = ">";
            this.btnPasarNombre.UseVisualStyleBackColor = false;
            this.btnPasarNombre.Click += new System.EventHandler(this.btnPasarNombre_Click);
            // 
            // btnPasarTodos
            // 
            this.btnPasarTodos.BackColor = System.Drawing.Color.Fuchsia;
            this.btnPasarTodos.Font = new System.Drawing.Font("Merienda One", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasarTodos.Location = new System.Drawing.Point(337, 219);
            this.btnPasarTodos.Name = "btnPasarTodos";
            this.btnPasarTodos.Size = new System.Drawing.Size(75, 23);
            this.btnPasarTodos.TabIndex = 5;
            this.btnPasarTodos.Text = ">>";
            this.btnPasarTodos.UseVisualStyleBackColor = false;
            this.btnPasarTodos.Click += new System.EventHandler(this.btnPasarTodos_Click);
            // 
            // lbNombresAgregados
            // 
            this.lbNombresAgregados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbNombresAgregados.Font = new System.Drawing.Font("Black Ops One", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombresAgregados.FormattingEnabled = true;
            this.lbNombresAgregados.ItemHeight = 16;
            this.lbNombresAgregados.Location = new System.Drawing.Point(62, 97);
            this.lbNombresAgregados.Name = "lbNombresAgregados";
            this.lbNombresAgregados.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbNombresAgregados.Size = new System.Drawing.Size(269, 244);
            this.lbNombresAgregados.TabIndex = 6;
            // 
            // lbNombresRecibidos
            // 
            this.lbNombresRecibidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbNombresRecibidos.Font = new System.Drawing.Font("Black Ops One", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombresRecibidos.FormattingEnabled = true;
            this.lbNombresRecibidos.ItemHeight = 16;
            this.lbNombresRecibidos.Location = new System.Drawing.Point(418, 97);
            this.lbNombresRecibidos.Name = "lbNombresRecibidos";
            this.lbNombresRecibidos.Size = new System.Drawing.Size(269, 244);
            this.lbNombresRecibidos.TabIndex = 7;
            // 
            // btnPasarVarios
            // 
            this.btnPasarVarios.BackColor = System.Drawing.Color.Fuchsia;
            this.btnPasarVarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasarVarios.Location = new System.Drawing.Point(338, 249);
            this.btnPasarVarios.Name = "btnPasarVarios";
            this.btnPasarVarios.Size = new System.Drawing.Size(75, 23);
            this.btnPasarVarios.TabIndex = 8;
            this.btnPasarVarios.Text = ">>";
            this.btnPasarVarios.UseVisualStyleBackColor = false;
            this.btnPasarVarios.Click += new System.EventHandler(this.btnPasarVarios_Click);
            // 
            // FormEjercicioTp1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AplicacionWindows.Properties.Resources.charles_oliveira_islam_makhachev1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPasarVarios);
            this.Controls.Add(this.lbNombresRecibidos);
            this.Controls.Add(this.lbNombresAgregados);
            this.Controls.Add(this.btnPasarTodos);
            this.Controls.Add(this.btnPasarNombre);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtIngresarNombre);
            this.Controls.Add(this.lblIngresarNombre);
            this.Controls.Add(this.btnVolverPrincipal);
            this.MinimizeBox = false;
            this.Name = "FormEjercicioTp1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nombres";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEjercicioTp1_FormClosed);
            this.Load += new System.EventHandler(this.FormEjercicioTp1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolverPrincipal;
        private System.Windows.Forms.Label lblIngresarNombre;
        private System.Windows.Forms.TextBox txtIngresarNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnPasarNombre;
        private System.Windows.Forms.Button btnPasarTodos;
        private System.Windows.Forms.ListBox lbNombresAgregados;
        private System.Windows.Forms.ListBox lbNombresRecibidos;
        private System.Windows.Forms.Button btnPasarVarios;
    }
}