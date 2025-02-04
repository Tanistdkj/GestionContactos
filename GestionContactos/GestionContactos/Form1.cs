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
        const int Tam = 5;
        string[] vNombre = new string[Tam];
        string[] vTelefono = new string[Tam];
        void LeerNombre(string[] vNom, string[] vtlf)
        {
            int i;
            string aux;
            bool parar = false;
            bool rep = false;
            for (i = 0; i < vNombre.Length && !parar; i++)
            {
                if (vNom[i] == null || vNom[i] == "")
                {
                    MessageBox.Show("Introducir la persona: " + i);
                    aux = Interaction.InputBox("Introduzca un nombre: ");
                    rep = ComprobarIguales(aux, vNom);
                    if (!rep)
                    {
                        vNom[i] = aux;
                        vtlf[i] = Interaction.InputBox("Introduzca un telefono: ");
                    }
                    else
                    {
                        MessageBox.Show("Persona ya introducida.");
                    }
                    parar= true;
                }
            }
        }
        bool ComprobarIgual()es
        string MostrarVector(string[] v)
        {
            string texto = "";
            for (int i = 0; i < v.Length; i++)
            {
                texto += v[i];
                if (i < v.Length - 1) texto += ", ";
            }
            return texto;
        }
        int Index(string[] v, string value)
        {
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] == value)
                    return i; 
            }
            return -1;
        }

        //bool ContieneContacto(string[] v, string value)
        //{
        //    bool result = false;
        //    for(int i = 0; i <= v.Length; i++)
        //    {
        //        if (v[i] == value)
        //        {
        //            result = true;
        //            break;
        //        }
        //    }
        //    return result;
        //}

        void Eliminar(string nombre)
        {
            for(int i = 0; i < vNombre.Length; i++)
            {
                if (Index(vNombre, nombre) != -1)
                {
                    vNombre[i] = "";
                    vTelefono[i] = "";
                }
            }
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Introduzca el nombre a eliminar");
            Eliminar(nombre);
        }
    }
}
