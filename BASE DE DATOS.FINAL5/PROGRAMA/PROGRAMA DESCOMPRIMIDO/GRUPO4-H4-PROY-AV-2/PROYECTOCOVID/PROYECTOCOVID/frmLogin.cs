using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTOCOVID
{
    public partial class frmLogin : Form

    {
        string Usuario = "Datoscovid";
        string Contraseña = "1234";

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text !=Usuario || txtContraseña.Text != Contraseña)
            {
                if (txtUsuario.Text != Usuario)
                {
                    MessageBox.Show("Usuario incorrecto");
                    txtUsuario.Clear();
                    txtUsuario.Focus();
                    return;
                }
                if (txtContraseña.Text != Contraseña)
                {
                    MessageBox.Show("Contraseña Incorrecta");
                    txtContraseña.Clear();
                    txtContraseña.Focus();
                    return;
                }
            }
            else
            {
                txtUsuario.Clear();
                txtContraseña.Clear();
                frmPrincipal Form = new frmPrincipal();
                Form.ShowDialog();
            }
        }
    }
}
