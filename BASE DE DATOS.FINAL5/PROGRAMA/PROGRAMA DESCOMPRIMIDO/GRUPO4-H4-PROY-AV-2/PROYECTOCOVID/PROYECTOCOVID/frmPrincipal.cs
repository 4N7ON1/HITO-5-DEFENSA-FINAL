using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PROYECTOCOVID
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnmaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnmaximizar.Visible = true;
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void AbrirFormHija(object formhija) {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btninformacion_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Informacion());
        }
        private void AbrirFormMama(object formMama)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form sh = formMama as Form;
            sh.TopLevel = false;
            sh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(sh);
            this.panelContenedor.Tag = sh;
            sh.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormMama(new Prevencion());
        }
        private void AbrirFormTia(object formTia)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form ph = formTia as Form;
            ph.TopLevel = false;
            ph.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(ph);
            this.panelContenedor.Tag = ph;
            ph.Show();
        }

        private void btnSintomas_Click(object sender, EventArgs e)
        {
            AbrirFormTia(new Sintomas());
        }
        private void AbrirFormHermana(object formHermana)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form hh = formHermana as Form;
            hh.TopLevel = false;
            hh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(hh);
            this.panelContenedor.Tag = hh;
            hh.Show();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            AbrirFormHermana(new Registro());
        }

        
    }
}
