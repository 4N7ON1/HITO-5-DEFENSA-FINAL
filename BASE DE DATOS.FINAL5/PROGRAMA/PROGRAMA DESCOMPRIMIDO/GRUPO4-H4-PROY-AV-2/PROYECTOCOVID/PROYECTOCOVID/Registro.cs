using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace PROYECTOCOVID
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-NPQS5G2R\\SQLEXPRESS;Initial Catalog=PROYECTO COVID;Integrated Security=True");
        private void btnregistrar_Click(object sender, EventArgs e)
        {

            conn.Open();


            string nom = txtnombre.Text;
            string docu = txtdocumento.Text;
            string naci = txtnacimiento.Text;
            string servi = cboservicio.Text;
            string vacu = txtvacuna.Text;
            string dosi = cbodosis.Text;
            string prove = cboproveedor.Text;
            SqlCommand query = new SqlCommand("INSERT INTO USUARIOS VALUES('" + nom + "','" + docu + "','" + naci + "','" + servi + "','" + vacu + "','" + dosi + "','" + prove + "')", conn);
            int r = query.ExecuteNonQuery();

            if (r > 0)
            {
                MessageBox.Show("Datos guardados. ");
            }
            else
            {
                MessageBox.Show("No se puedo guardar los datos. ");
            }
            conn.Close();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
                //conexion.Conectar();
                //MessageBox.Show("Connexion exitosa. ");

           
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            txtnombre.Clear();
            txtdocumento.Clear();
            txtnacimiento.Clear();
            cboservicio.ResetText();
            txtvacuna.Clear();
            cbodosis.ResetText();
            cboproveedor.ResetText();
            txtnombre.Focus();
            
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = listar("SELECT * FROM USUARIOS WHERE DOCUMENTO ="+documento.Text+";");
        }

        private void btnlistar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = listar("SELECT * FROM USUARIOS");

        }

        public DataTable listar(string val)
        {
            conn.Open();
            string query = val;
            DataTable tb = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(query, conn);

            adaptador.Fill(tb);

            conn.Close();

            return tb;
        
        
        }


    }
}
