namespace GestionContactos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAñadir = new Button();
            btnMostrar = new Button();
            btnEliminar = new Button();
            btnModifTlf = new Button();
            SuspendLayout();
            // 
            // btnAñadir
            // 
            btnAñadir.Location = new Point(52, 64);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(123, 31);
            btnAñadir.TabIndex = 0;
            btnAñadir.Text = "Añadir Contacto";
            btnAñadir.UseVisualStyleBackColor = true;
            btnAñadir.Click += btnAñadir_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(236, 63);
            btnMostrar.Margin = new Padding(3, 2, 3, 2);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(123, 32);
            btnMostrar.TabIndex = 1;
            btnMostrar.Text = "Mostrar Contacto";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(52, 128);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(123, 38);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar Contacto";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModifTlf
            // 
            btnModifTlf.Location = new Point(236, 128);
            btnModifTlf.Name = "btnModifTlf";
            btnModifTlf.Size = new Size(123, 38);
            btnModifTlf.TabIndex = 3;
            btnModifTlf.Text = "Modificar telefono";
            btnModifTlf.UseVisualStyleBackColor = true;
            btnModifTlf.Click += btnModifTlf_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 218);
            Controls.Add(btnModifTlf);
            Controls.Add(btnEliminar);
            Controls.Add(btnMostrar);
            Controls.Add(btnAñadir);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAñadir;
        private Button btnMostrar;
        private Button btnEliminar;
        private Button btnModifTlf;
    }
}
