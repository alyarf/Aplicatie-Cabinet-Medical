using Proiect.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class FAlergie : Form
    {
        private Form master;
        private bool selectie;
        private BindingSource pacientiBindingSource = new BindingSource();
        public FAlergie()
        {
            InitializeComponent();

            pacientiBindingSource.DataSource = this.dataSet1;
            pacientiBindingSource.DataMember = "Pacienti";
        }

        private void FAlergie_Load(object sender, EventArgs e)
        {
            btnSelectie.Visible = false;
            config(true);
            refresh();
        }

        public void SetMaster(Form caller)
        {
            master = caller;
        }

        public void SetSelectVisible()
        {
            selectie = true;

        }

        private void config(bool v)
        {
            dataGridView1.AllowUserToAddRows = !v;
            dataGridView1.AllowUserToDeleteRows = !v;
            dataGridView1.ReadOnly = v;

            btnActualizare.Enabled = v;

            btnSalvare.Visible = !v;
            btnRenuntare.Visible = !v;

            if (selectie) btnSelectie.Visible = v;
        }

        private void refresh()
        {
            int pozitie;
            pozitie = alergiiBindingSource.Position;
            alergiiTableAdapter.Fill(dataSet1.Alergii);
            alergiiBindingSource.Position = pozitie;
        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            config(false);
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            try
            {
                // Obține numele alergiei și ID-ul alergiei din rândul curent
                string numeAlergie = dataGridView1.CurrentRow.Cells["alergenDataGridViewTextBoxColumn"].Value?.ToString();
                string idAlergie = dataGridView1.CurrentRow.Cells["idAlergieDataGridViewTextBoxColumn"].Value?.ToString();

                using (OleDbConnection con = new OleDbConnection(alergiiTableAdapter.Connection.ConnectionString))
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;

                    // Verificare: există deja o alergie cu același nume?
                    cmd.CommandText = "SELECT Alergen FROM Alergii WHERE Alergen = @Alergen AND IdAlergie <> @IdAlergie";
                    cmd.Parameters.AddWithValue("@Alergen", numeAlergie);
                    cmd.Parameters.AddWithValue("@IdAlergie", idAlergie);

                    con.Open();
                    OleDbDataReader r = cmd.ExecuteReader();
                    if (r.Read())
                    {
                        // Dacă există o înregistrare duplicat, afișează un mesaj și oprește salvarea
                        MessageBox.Show("O alergie cu acest nume există deja! Vă rugăm să introduceți un nume unic.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        con.Close();
                        return; // Ieșim din metodă
                    }
                    con.Close();
                }

                // Dacă numele este unic, salvează modificările
                alergiiTableAdapter.Update(dataSet1.Alergii);
                MessageBox.Show("Modificările au fost salvate cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                config(true);
                refresh();
            }
            catch (Exception exc)
            {
                MessageBox.Show($"Eroare la salvare: {exc.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            config(true);
            refresh();
        }

        private void btnSelectie_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DataRowView current = (DataRowView)alergiiBindingSource.Current;
                string alergie = current["Alergen"].ToString();

                // Debugging: verifică valoarea alergiei selectate
                MessageBox.Show($"Alergia selectată: {alergie}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (master is FPacienti fPacienti)
                {
                    fPacienti.SetAlergieSelectata(alergie);
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Selectați o alergie din listă!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

          