using Proiect.DataSet1TableAdapters;
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
using System.IO;

namespace Proiect
{
    public partial class FMedicamente : Form
    {
        public FMedicamente()
        {
            InitializeComponent();
        }

        private void FMedicamente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Medicamente' table. You can move, or remove it, as needed.
            this.medicamenteTableAdapter.Fill(this.dataSet1.Medicamente);

            A1();
        }


        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            LoadImage(); // Actualizează imaginea pentru persoana curentă
        }


        // acest buton permite util. sa intre in modul editare
        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            A2();

        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            A3();
        }

        // valideaza si salveaza datele dupa adaugare
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

        private void txtPret_Leave(object sender, EventArgs e)
        {
            A5(txtPret);
        }

        private void txtDMed_Leave(object sender, EventArgs e)
        {
            A5(txtDMed);
        }

        private void txtUM_Leave(object sender, EventArgs e)
        {
            A5(txtUM);
        }

        private void txtSpPoza_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            A6();
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

        private void A1()
        {

            //Umple cu date obiectele DataTable: Persoane, Localitati (din DataSet): 
            medicamenteTableAdapter.Fill(dataSet1.Medicamente);
     

            //Configurare PB 
            PB.SizeMode = PictureBoxSizeMode.StretchImage;

            //Protectie grid  
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;

            //Protectie txtId
            txtId.ReadOnly = true;

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

            //Modifcare lblOp 
            lblOp.Text = "ADĂUGARE";

            //Pozitionare cursor pe primul camp 
            txtDMed.Focus();

            // Golire campuri 
            golireCampuri();

        }

        private void A3()
        {
            //Initializare lblOp 
            lblOp.Text = "";

            //Çonfigurare(butoane) 
            configureazaButoane(true);

            //Protectie componente Panel 
            protectiePanel(true);

            //Legare controale 
            legareControale(true);
        }

        private void A4()
        {
            if (lblOp.Text == "ADĂUGARE")
            {
                if (!validareCampuriObligatorii()) return;

                adauga_inregistrare();

                golireCampuri();

                //Pune cursor pe primul camp 
                txtDMed.Focus();
                refresh_grid(medicamenteBindingSource.Position);

                LoadImage();
            }
            else if (lblOp.Text == "MODIFICARE")
            {
                modifica_inregistrare();
                refresh_grid(medicamenteBindingSource.Position);

                LoadImage();
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

            if (txtB == txtPret)
            {
                // Validare numericitate 
                try { p = Convert.ToDecimal(txtB.Text); }
                catch { MessageBox.Show("Coloana trebuie să conțină un număr valid (numeric)"); txtB.Focus(); }
                return;
            }

            if (txtB == txtUM)
            {
                // Validare numericitate 
                try { p = Convert.ToDecimal(txtB.Text); }
                catch { MessageBox.Show("Coloana trebuie să conțină un număr valid (numeric)"); txtB.Focus(); }
                return;
            }

            if (txtB == txtDMed)
            {
                con.ConnectionString = medicamenteTableAdapter.Connection.ConnectionString;
                cmd.Connection = con;

                if (lblOp.Text == "ADĂUGARE")
                {
                    cmd.CommandText = "Select Denumire From Medicamente where Denumire='" + txtDMed.Text + "'";
                    con.Open();
                    r = cmd.ExecuteReader();
                    if (r.Read())
                    {
                        MessageBox.Show("Medicament deja existent");
                        txtDMed.Focus();
                    }
                    con.Close();
                }

                else if (lblOp.Text == "MODIFICARE")
                {
                    cmd.CommandText = "Select Denumire From Medicamente where Denumire='" + txtDMed.Text +
                                      "' and IdMedicament  <> " + txtId.Text;
                    con.Open();
                    r = cmd.ExecuteReader();
                    if (r.Read())
                    {
                        MessageBox.Show("Medicament deja existent");
                        txtDMed.Focus();
                    }
                    con.Close();
                }
            }
        }

        // Metoda aceasta este folosita pt a selecta o imagine noua
        // Copiaza imaginea in folderul Images si actualizeaza calea relativa
        private void A6()
        {
            if (lblOp.Text == "")
                return;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog.Title = "Selectează o imagine";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = openFileDialog.FileName;
                    PB.ImageLocation = selectedPath;
                    txtSpPoza.Text = selectedPath;
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

            
            //Modifcare lblOp 
            lblOp.Text = "MODIFICARE";

            //Pozitionare cursor pe primul camp 
            txtDMed.Focus();
        }

        private void A8()
        {

                OleDbConnection con = new OleDbConnection();
                OleDbCommand cmd = new OleDbCommand();
                OleDbDataReader r;

                con.ConnectionString = medicamenteTableAdapter.Connection.ConnectionString;

                cmd.Connection = con;

                cmd.CommandText = "Select IdMedicament From RetetaContinut where IdMedicament=" + txtId.Text;
                con.Open();
                r = cmd.ExecuteReader();
                
                if (r.Read())
                {
                    MessageBox.Show("Medicament referit in tabela Retete! Nu se poate sterge!");
                    con.Close();
                    return;
                }

                con.Close();

                con.ConnectionString = medicamenteTableAdapter.Connection.ConnectionString;

                cmd.Connection = con;

                cmd.CommandText = "Delete From Medicamente Where IdMedicament = " + txtId.Text;

                MessageBox.Show(cmd.CommandText);

                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();

                refresh_grid(medicamenteBindingSource.Position);

                LoadImage();
            
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
                txtDMed.DataBindings.Add("Text", medicamenteBindingSource, "Denumire");
                txtUM.DataBindings.Add("Text", medicamenteBindingSource, "UM");
                txtPret.DataBindings.Add("Text", medicamenteBindingSource, "Pret");
                txtId.DataBindings.Add("Text", medicamenteBindingSource, "IdMedicament");

                LoadImage();

            }
            else
            {
                txtDMed.DataBindings.Clear();
                txtUM.DataBindings.Clear();
                txtPret.DataBindings.Clear();
                PB.DataBindings.Clear();
                txtId.DataBindings.Clear();


            }
        }

        private void protectiePanel(bool v)
        {
            txtDMed.ReadOnly = v;
            txtUM.ReadOnly = v;
            txtPret.ReadOnly = v;
            txtSpPoza.ReadOnly = v;
        }

        private void golireCampuri()
        {
            txtDMed.Text = "";
            txtUM.Text = "";
            txtId.Text = "";
            txtPret.Text = "";
            txtSpPoza.Text = "";

            PB.ImageLocation = "";
            PB.Image = null;

            


        }

        private bool validareCampuriObligatorii()
        {
            //Validare de completare obligatorie campurile: Nume, CNP, Salariu, Localitate, Data angajarii 
            if (txtDMed.Text == "")
            {
                MessageBox.Show("Completati Denumire!");
                txtDMed.Focus();
                return false;
            }
            /*if (txtUM.Text == "")
            {
                MessageBox.Show("Completati UM!");
                txtUM.Focus();
                return false;
            }
            if (txtPret.Text == "")
            {
                MessageBox.Show("Completati Pret !");
                txtPret.Focus();
                return false;
            }*/
            return true;
        }

        private void adauga_inregistrare()
        {
            string listaCampuri;
            string listaValori;

            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();

            con.ConnectionString = medicamenteTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            listaCampuri = "Denumire, UM, Pret, SpPoza";
            listaValori = "'" + txtDMed.Text + "'" +
                          ",'" + txtUM.Text + "'" +
                          "," + txtPret.Text +
                          ",'" + PB.Text + "'";

            cmd.CommandText = "Insert into Medicamente(" + listaCampuri + ") " +
                              "Select " + listaValori;

            MessageBox.Show(cmd.CommandText);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void refresh_grid(int p)
        {
            medicamenteTableAdapter.Fill(dataSet1.Medicamente);
            medicamenteBindingSource.Position = p;

            LoadImage();
        }

        private void modifica_inregistrare()
        {
            string listaSet;

            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();

            con.ConnectionString = medicamenteTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            listaSet = "Denumire = '" + txtDMed.Text + "'," +
                       "UM = '" + txtUM.Text + "'," +
                       "Pret = " + txtPret.Text+ "," +
                       "SpPoza = '" + PB.Text + "'";

            cmd.CommandText = "Update Medicamente Set " + listaSet + " Where IdMedicament=" +
            txtId.Text;

            MessageBox.Show(cmd.CommandText);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }


        private void LoadImage()
        {
            try
            {
                if (medicamenteBindingSource.Current is DataRowView currentRow)
                {
                    string imagePath = currentRow["SpPoza"].ToString();
                    if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                    {
                        PB.ImageLocation = imagePath;
                        txtSpPoza.Text = imagePath;
                    }
                    else
                    {
                        PB.ImageLocation = null;
                        txtSpPoza.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la încărcarea imaginii: {ex.Message}");
                PB.ImageLocation = null;
                txtSpPoza.Text = "";
            }
        }
       

    }
}
