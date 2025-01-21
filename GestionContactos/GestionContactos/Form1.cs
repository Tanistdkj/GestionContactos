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
        void LeerNombre(string[] v)
        {
            for (int i = 0; i < vNombre.Length; i++)
                v[i]= Interaction.InputBox("Introduzca un nombre: ");
        }
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            LeerNombre(vNombre);
        }
    }
}
