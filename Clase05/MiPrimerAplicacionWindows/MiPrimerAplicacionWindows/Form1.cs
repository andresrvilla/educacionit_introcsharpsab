using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerAplicacionWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";

            //Conviene crear una variable con el trim y todo lo que necesite
            // y despues validar con la variable

            if (txtUsuario.Text.Trim() == "")
            {
                txtResultado.Text = "Debe ingresar el nombre de usuario";
                return;
            }

            if (txtContrasena.Text.Trim() == "")
            {
                txtResultado.Text = "Debe ingresar su contraseña";
                return;
            }

            //Si llego hasta aca es porque tiene usuario y tiene contraseña
            //Puedo validar si los datos son correctos

            if (txtContrasena.Text.Trim() == "admin" && txtUsuario.Text.Trim().ToLower() == "admin")
            {
                txtResultado.Text = "Bienvenido Administrador";
                FrmPrincipal frmPrincipal = new FrmPrincipal();
                frmPrincipal.Show();
                //Close(); SE CIERRA EL PROGRAMA!!!
            }
            else
            {
                txtResultado.Text = "Usuario inexistente";
            }
        }
    }
}
