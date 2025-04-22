using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class FStart : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;

        public FStart()
        {
            InitializeComponent();
        }
        private void FStart_Load(object sender, EventArgs e)
        {
            A1(true);
            string imagePath = @"C:\Users\Alina\OneDrive\Desktop\Facultate\TAP\Proiect TAP\Proiect\Images\logoDoctor.png"; // Calea absolută
            if (System.IO.File.Exists(imagePath))
            {
                PB.Image = Image.FromFile(imagePath);
                PB.SizeMode = PictureBoxSizeMode.StretchImage; // Setează modul de afișare
            }
            else
            {
                MessageBox.Show("Imaginea nu a fost găsită!");
            }
        }


        private void A1(Boolean v)
        {
            menuStrip1.Visible = !v;
           // lblTitlu.Visible = !v;
           // lblAutor.Visible = !v;
            lblParola.Visible = v;
            txtParola.Visible = v;
            lblUser.Visible = v;
            txtUser.Visible = v;
            

            if (v)
            {
                btnStart.Text = "Log In";
                lblTitlu.Text = "";
                lblAutor.Text = "";
                PB.Visible = false;

            }
            else
            {

                btnStart.Text = "Log Out";
                lblTitlu.Text = "Aplicație Personal\r\nCabinet Medicină de Familie\r\n";
                lblAutor.Text = "Autor Alina Arfir ";
                PB.Visible = true;
            }

        }

        private Boolean Logare_OK()
        {
            if (txtUser.Text == "")
            {
                MessageBox.Show("Completați utilizator!");
                txtUser.Focus();
                return false;
            }
            if (txtParola.Text == "")
            {
                MessageBox.Show("Completați parola!");
                txtParola.Focus();
                return false;
            }

            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                                   "Data Source=C:\\Users\\Alina\\OneDrive\\Desktop\\Facultate\\TAP\\Proiect TAP\\BD.accdb";
            //aici trb schimbat!
            cmd.Connection = con;
            cmd.CommandText = "Select IdUser, Parola from Users " +
                              "where Nume='" + txtUser.Text + "'";
            con.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                if (txtParola.Text != rdr.GetString(1))
                {
                    MessageBox.Show("Parolă eronată");
                    txtParola.Focus();
                    con.Close();
                    return false;
                }
                con.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Utilizator eronat");
                txtUser.Focus();
                con.Close();
                return false;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Log In")
            {
                if (Logare_OK()) A1(false);
            }
            else A1(true);
        }




        private void paciențiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FPacienti f = new FPacienti();
            f.ShowDialog();
        }

        private void rețeteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRetete f = new FRetete();
            f.ShowDialog();
        }


        private void medicamenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FMedicamente f = new FMedicamente();
            f.ShowDialog();
        }



    }

}
