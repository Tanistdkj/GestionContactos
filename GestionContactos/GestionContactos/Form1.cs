using System.Numerics;
using Microsoft.VisualBasic;
namespace GestionContactos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int Tam = 10;
        string[] vNombre = new string[Tam];
        string[] vTelefono = new string[Tam];
        void LeerNombre(string[] v, string[] vtlf)
        {
            int i;
            for (i = 0; i < vNombre.Length; i++)
                v[i] = Interaction.InputBox("Introduzca un nombre: ");
                vtlf[i] = Interaction.InputBox("Introduzca un telefono: ");
        }
        string MostrarVector(string[] v)
        {
            string texto = "";
            for(int i = 0; i < v.Length; i++)
            {
                texto += v[i];
                if (i < v.Length - 1) texto += ", ";
            }
            return texto;
        }
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Introduzca los usuarios");
            LeerNombre(vNombre, vTelefono);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MostrarVector(vNombre));
            MessageBox.Show(MostrarVector(vTelefono));
        }
    }
}
