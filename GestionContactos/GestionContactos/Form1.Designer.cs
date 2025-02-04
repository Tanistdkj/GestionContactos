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
            SuspendLayout();
            // 
            // btnAñadir
            // 
            btnAñadir.Location = new Point(366, 86);
            btnAñadir.Margin = new Padding(3, 4, 3, 4);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(141, 41);
            btnAñadir.TabIndex = 0;
            btnAñadir.Text = "Añadir Contacto";
            btnAñadir.UseVisualStyleBackColor = true;
            btnAñadir.Click += btnAñadir_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(550, 85);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(141, 42);
            btnMostrar.TabIndex = 1;
            btnMostrar.Text = "Mostrar Contacto";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(366, 168);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(141, 50);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar Contacto";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnEliminar);
            Controls.Add(btnMostrar);
            Controls.Add(btnAñadir);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAñadir;
        private Button btnMostrar;
        private Button btnEliminar;
    }
}
