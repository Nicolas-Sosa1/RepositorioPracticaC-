namespace AplicacionWindows
{
    partial class FormPractica8
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
            this.lbRecibidos = new System.Windows.Forms.ListBox();
            this.clbNumeros = new System.Windows.Forms.CheckedListBox();
            this.btnMover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbRecibidos
            // 
            this.lbRecibidos.FormattingEnabled = true;
            this.lbRecibidos.Location = new System.Drawing.Point(492, 12);
            this.lbRecibidos.Name = "lbRecibidos";
            this.lbRecibidos.Size = new System.Drawing.Size(296, 420);
            this.lbRecibidos.TabIndex = 0;
            // 
            // clbNumeros
            // 
            this.clbNumeros.CheckOnClick = true;
            this.clbNumeros.FormattingEnabled = true;
            this.clbNumeros.Items.AddRange(new object[] {
            "Uno",
            "Dos",
            "Tres",
            "Cuatro",
            "Cinco",
            "Seis",
            "Sieste",
            "Ocho",
            "Nueve",
            "Diez"});
            this.clbNumeros.Location = new System.Drawing.Point(12, 12);
            this.clbNumeros.Name = "clbNumeros";
            this.clbNumeros.Size = new System.Drawing.Size(296, 424);
            this.clbNumeros.TabIndex = 1;
            // 
            // btnMover
            // 
            this.btnMover.Location = new System.Drawing.Point(339, 194);
            this.btnMover.Name = "btnMover";
            this.btnMover.Size = new System.Drawing.Size(123, 33);
            this.btnMover.TabIndex = 2;
            this.btnMover.Text = "Mover";
            this.btnMover.UseVisualStyleBackColor = true;
            this.btnMover.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // FormPractica8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMover);
            this.Controls.Add(this.clbNumeros);
            this.Controls.Add(this.lbRecibidos);
            this.Name = "FormPractica8";
            this.Text = "ListBox y CheckedListBox";
            this.Load += new System.EventHandler(this.FormPractica8_Load);
            
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbRecibidos;
        private System.Windows.Forms.CheckedListBox clbNumeros;
        private System.Windows.Forms.Button btnMover;
    }
}