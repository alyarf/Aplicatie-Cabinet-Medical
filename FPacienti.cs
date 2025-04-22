using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Proiect
{
    public partial class FPacienti : Form
    {
        public FPacienti()
        {
            InitializeComponent();
        }

        private void FPacienti_Load(object sender, EventArgs e)
        {
            this.pacientiTableAdapter.Fill(this.dataSet1.Pacienti);
            this.alergiiTableAdapter.Fill(this.dataSet1.Alergii);


            A1();
         
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // Actualizează poziția în BindingSource
                pacientiBindingSource.Position = dataGridView1.CurrentRow.Index;
            }
        }

        private void istoricToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FIstoric f = new FIstoric();
            f.ShowDialog();
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            A2();
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            A3();
        }

        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            try
            {
                A4();
            }
            catch (Exception exc)
            {
                string s = exc.Message;

                if (s.IndexOf("duplicate values") > 0)
                    MessageBox.Show("Inregistrare deja existenta !");
            }
        }
        private void txtTelefon_Leave(object sender, EventArgs e)
        {
            A5(txtTelefon);
        }

        private void txtCNP_Leave(object sender, EventArgs e)
        {
            A5(txtCNP);
        }


        private void btnModificare_Click(object sender, EventArgs e)
        {
            A7();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo,
MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) return;
            A8();
        }

        private void configureCmbAlergie()
        {
            cmbAlergie.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAlergie.DataSource = null; // Clear existing binding
            cmbAlergie.DataSource = alergiiBindingSource;
            cmbAlergie.DisplayMember = "Alergen";
            cmbAlergie.ValueMember = "IdAlergie";
            cmbAlergie.SelectedIndex = -1; // Reset selection
        }

        private void A1()
        {

            //Umple cu date obiectele DataTable: pacienti, Localitati (din DataSet): 
            pacientiTableAdapter.Fill(dataSet1.Pacienti);
            alergiiTableAdapter.Fill(dataSet1.Alergii);

            //Configurare comboBox-uri 
            cmbAlergie.DropDownStyle = ComboBoxStyle.Simple;

            btnAdministrareAlergii.Enabled = false;

            //Protectie grid  
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;

            txtIdPacient.ReadOnly = true;

            A3();
        }

        private void A2()
        {
            //Configurare butoane 
            configureazaButoane(false);

            //Dezlegare controale Panel 
            legareControale(false);

            //Ridicare protectie controale Panel 
            protectiePanel(false);

            configureCmbAlergie();


            btnAdministrareAlergii.Enabled = true;

            //Modifcare lblOp 
            lblOp.Text = "ADĂUGARE";

            //Pozitionare cursor pe primul camp 
            txtNume.Focus();

            // Golire campuri 
            golireCampuri();
        }

        private void A3()
        {
            //Configurare comboBox-uri 
            cmbAlergie.DropDownStyle = ComboBoxStyle.Simple;

            btnAdministrareAlergii.Enabled = false;
            //Initializare lblOp 
            lblOp.Text = "";

            //Çonfigurare(butoane) 
            configureazaButoane(true);

            //Protectie componente Panel 
            protectiePanel(true);

            //Legare controale 
            legareControale(true);
            pacientiBindingSource.Position = dataGridView1.CurrentRow.Index;
        }

        private void A4()
        {
            if (lblOp.Text == "ADĂUGARE")
            {
                if (!validareCampuriObligatorii()) return;

                adauga_inregistrare();

                golireCampuri();

                //Pune cursor pe primul camp 
                txtNume.Focus();
                refresh_grid(pacientiBindingSource.Position);
            }
            else if (lblOp.Text == "MODIFICARE")
            {
                modifica_inregistrare();
                refresh_grid(pacientiBindingSource.Position);
                A3();
            }
            else
                MessageBox.Show("Operatie actualizare neefectuata");
        }

        private void A5(TextBox txtB)
        {
            decimal p;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader r;

            if (lblOp.Text == "") return;
            if (txtB.Text == "") return;
            if (btnRenuntare.Focused) return;

            if (txtB == txtTelefon)
            {
                // Validare numericitate 
                try { p = Convert.ToDecimal(txtB.Text); }
                catch { MessageBox.Show("Format eronat"); txtB.Focus(); }
                return;
            }

            if (txtB == txtCNP)
            {
                // Validare numericitate 
                try { p = Convert.ToDecimal(txtB.Text); }
                catch { MessageBox.Show("Format eronat"); txtB.Focus(); }
                con.ConnectionString = pacientiTableAdapter.Connection.ConnectionString;
                cmd.Connection = con;

                if (lblOp.Text == "ADĂUGARE")
                {
                    cmd.CommandText = "Select NumePacient From Pacienti where CNP='" + txtCNP.Text + "'";
                    con.Open();
                    r = cmd.ExecuteReader();
                    if (r.Read())
                    {
                        MessageBox.Show("CNP deja existent");
                        txtCNP.Focus();
                    }
                    con.Close();
                }

                else if (lblOp.Text == "MODIFICARE")
                {
                    cmd.CommandText = "Select NumePacient From Pacienti where CNP='" + txtCNP.Text +
                                      "' and IdPacient  <> " + txtIdPacient.Text;
                    con.Open();
                    r = cmd.ExecuteReader();
                    if (r.Read())
                    {
                        MessageBox.Show("CNP deja existent");
                        txtCNP.Focus();
                    }
                    con.Close();
                }
            }
        }

        private void A7()
        {
            //Configurare butoane 
            configureazaButoane(false);

            //Dezlegare controale Panel 
            legareControale(false);

            //Ridicare protectie controale Panel 
            protectiePanel(false);

            configureCmbAlergie();


            btnAdministrareAlergii.Enabled = true;

            //Modifcare lblOp 
            lblOp.Text = "MODIFICARE";

            //Pozitionare cursor pe primul camp 
            txtNume.Focus();
        }

        private void A8()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader r;

            con.ConnectionString = pacientiTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            cmd.CommandText = "Select IdReteta From Retete where IdPacient=" + txtIdPacient.Text;
            con.Open();
            r = cmd.ExecuteReader();
            if (r.Read())
            {
                MessageBox.Show("Persoana referita in tabela Retete! Nu se poate sterge!");
                con.Close();
                return;
            }
            con.Close();

            con.ConnectionString = pacientiTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            cmd.CommandText = "Delete From Pacienti Where IdPacient = " + txtIdPacient.Text;

            MessageBox.Show(cmd.CommandText);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();

            refresh_grid(pacientiBindingSource.Position);

        }
        private void configureazaButoane(bool v)
        {
            btnRenuntare.Visible = !v;
            btnConfirmare.Visible = !v;

            btnAdaugare.Enabled = v;
            btnModificare.Enabled = v;
            btnStergere.Enabled = v;
        }

        private void legareControale(bool v)
        {
            if (v)
            {
                txtNume.DataBindings.Add("Text", pacientiBindingSource, "NumePacient");
                txtCNP.DataBindings.Add("Text", pacientiBindingSource, "CNP");
                txtTelefon.DataBindings.Add("Text", pacientiBindingSource, "NrTelefon");
                cmbAlergie.DataBindings.Add("Text", pacientiBindingSource, "Alergen");
                txtAdresa.DataBindings.Add("Text", pacientiBindingSource, "Adresa");
                txtIdPacient.DataBindings.Add("Text", pacientiBindingSource, "IdPacient");
             }
            else
            {
                txtNume.DataBindings.Clear();
                txtCNP.DataBindings.Clear();
                txtTelefon.DataBindings.Clear();
                txtAdresa.DataBindings.Clear();
                cmbAlergie.DataBindings.Clear();
                txtIdPacient.DataBindings.Clear();
          
            }
        }

        private void protectiePanel(bool v)
        {
            txtNume.ReadOnly = v;
            txtCNP.ReadOnly = v;
            txtTelefon.ReadOnly = v;
            txtAdresa.ReadOnly = v;
            cmbAlergie.Enabled = !v;
        }

        private void golireCampuri()
        {
            txtNume.Text = "";
            txtCNP.Text = "";
            txtIdPacient.Text = "";
            txtTelefon.Text = "";
            txtAdresa.Text = "";
            cmbAlergie.SelectedIndex = -1;
        }

        private bool validareCampuriObligatorii()
        {
            //Validare de completare obligatorie campurile: Nume, CNP, Salariu, Localitate 
            if (txtNume.Text == "")
            {
                MessageBox.Show("Completati Nume!");
                txtNume.Focus();
                return false;
            }
            if (txtCNP.Text == "")
            {
                MessageBox.Show("Completati CNP!");
                txtCNP.Focus();
                return false;
            }
            if (txtTelefon.Text == "")
            {
                MessageBox.Show("Completati numarul de telefon!");
                txtTelefon.Focus();
                return false;
            }

            if (txtAdresa.Text == "")
            {
                MessageBox.Show("Completati adresa!");
                txtAdresa.Focus();
                return false;
            }

            if (cmbAlergie.Text == "")
            {
                MessageBox.Show("Completati tipul de alergie. Daca nu exista, selectati 'Fara alergii'!");
                cmbAlergie.Focus();
                return false;
            }
            return true;
        }

        public void SetAlergieSelectata(string alergie)
        {
            try
            {
                // Make sure the combobox is properly bound
                if (cmbAlergie.DataSource != alergiiBindingSource)
                {
                    cmbAlergie.DataSource = alergiiBindingSource;
                    cmbAlergie.DisplayMember = "Alergen";
                    cmbAlergie.ValueMember = "IdAlergie";
                }

                int index = alergiiBindingSource.Find("Alergen", alergie);

                if (index >= 0)
                {
                    alergiiBindingSource.Position = index;

                    // Get the actual IdAlergie value
                    var currentRow = ((DataRowView)alergiiBindingSource.Current);
                    var idAlergie = currentRow["IdAlergie"];

                    // Set both the SelectedValue and SelectedItem
                    cmbAlergie.SelectedValue = idAlergie;

                    // Force a refresh of the control
                    cmbAlergie.Refresh();

                    // Debug output
                    MessageBox.Show($"Setare alergie: ID={idAlergie}, Alergen={alergie}", "Debug");
                }
                else
                {
                    MessageBox.Show($"Alergia '{alergie}' nu a fost găsită.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la setarea alergiei: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void refreshAlergii(int pozitie)
        {
            try
            {
                // Salvăm selecția curentă înainte de refresh
                object currentSelection = cmbAlergie.SelectedValue;

                // Reîncarcă alergiile din baza de date
                alergiiTableAdapter.Fill(dataSet1.Alergii);

                // Resetează legăturile pentru a reflecta noile date
                alergiiBindingSource.ResetBindings(false);

                // Reconfigurăm ComboBox-ul
                cmbAlergie.DataSource = null;
                cmbAlergie.DataSource = alergiiBindingSource;
                cmbAlergie.DisplayMember = "Alergen";
                cmbAlergie.ValueMember = "IdAlergie";

                // Încercăm să restaurăm selecția anterioară
                if (currentSelection != null)
                {
                    cmbAlergie.SelectedValue = currentSelection;
                }

                // Verificăm dacă restaurarea selecției a reușit
                if (cmbAlergie.SelectedValue != null)
                {
                    MessageBox.Show("Lista de alergii a fost actualizată cu succes!",
                                  "Actualizare",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lista de alergii a fost actualizată, dar selecția anterioară nu mai este disponibilă.",
                                  "Atenție",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la actualizarea listei de alergii: {ex.Message}",
                              "Eroare",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private void btnAdministrareAlergii_Click(object sender, EventArgs e)
        {
            FAlergie f = new FAlergie();
            f.SetMaster(this);
            f.SetSelectVisible();
            f.ShowDialog();
        }

        private void adauga_inregistrare()
        {
            string listaCampuri;
            string listaValori;

            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();

            con.ConnectionString = pacientiTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            string idAlergie = cmbAlergie.SelectedValue?.ToString();

            listaCampuri = "NumePacient, CNP, NrTelefon, Adresa, IdAlergie";
            listaValori = "'" + txtNume.Text + "'" +
                          ",'" + txtCNP.Text + "'" +
                          "," + txtTelefon.Text +
                          ",'" + txtAdresa.Text + "'"+
                          ",'" + idAlergie + "'";

            cmd.CommandText = "Insert into Pacienti(" + listaCampuri + ") " +
                              "Select " + listaValori;

            MessageBox.Show(cmd.CommandText);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void refresh_grid(int p)
        {
            pacientiTableAdapter.Fill(dataSet1.Pacienti);
            pacientiBindingSource.Position = p;

        }

        private void modifica_inregistrare()
        {
            string listaSet;

            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();

            try
            {
                con.ConnectionString = pacientiTableAdapter.Connection.ConnectionString;

                cmd.Connection = con;

                string idAlergie = cmbAlergie.SelectedValue?.ToString();

                if (string.IsNullOrEmpty(idAlergie))
                {
                    MessageBox.Show("Nu a fost selectată nicio alergie validă.");
                    return;
                }

                listaSet = "NumePacient = '" + txtNume.Text + "'," +
                           "CNP = '" + txtCNP.Text + "'," +
                           "NrTelefon = '" + txtTelefon.Text + "'," +
                            "Adresa = '" + txtAdresa.Text + "'," +
                           "IdAlergie = " + idAlergie;


                cmd.CommandText = "Update Pacienti Set " + listaSet + " Where IdPacient=" +
                    txtIdPacient.Text;

                MessageBox.Show(cmd.CommandText);

                con.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception exp)
            {
                MessageBox.Show($"Eroare: {exp.Message}");
            }
            finally { con.Close(); }
        }        
    
   }
}

