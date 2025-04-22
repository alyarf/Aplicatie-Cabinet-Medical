using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class FActRetete : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;
        private int idRet;
        public BindingSource bs1;
        public BindingSource bs2;

        public FActRetete()
        {
            InitializeComponent();

            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Alina\\OneDrive\\Desktop\\Facultate\\TAP\\Proiect TAP\\BD.accdb";
            cmd.Connection = con;
        }

        private void completeazaReteta()
        {
            DataRowView current = (DataRowView)bs1.Current;

            idRet = (int)current["IdReteta"];
            txtNrReteta.Text = Convert.ToString(current["NrReteta"]);

            cmbPacienti.Text = current["NumePacient"].ToString();
            txtTotal.Text = current["Total"].ToString();

            dtpEmitere.Value = Convert.ToDateTime(current["DataEmiterii"]);

            bs2.MoveFirst();

            dataSet1.RetetaContinutManevra.Clear();


            for (int i = 1; i <= bs2.Count; i++)
            {
                current = (DataRowView)bs2.Current;

                DataSet1.RetetaContinutManevraRow r =
                dataSet1.RetetaContinutManevra.NewRetetaContinutManevraRow();
                r.CrtMed = Convert.ToInt16(current["CrtMed"]);
                r.DMedicament = Convert.ToString(current["DMedicament"]);
                r.UM = Convert.ToString(current["UM"]);
                r.PretVanzare = Convert.ToDecimal(current["PretVanzare"]);
                r.Cantitate = Convert.ToDecimal(current["Cantitate"]);
                r.IdMedicament= Convert.ToInt32(current["IdMedicament"]);
                r.Valoare = Convert.ToDecimal(current["Valoare"]);

                dataSet1.RetetaContinutManevra.Rows.Add(r);
                bs2.MoveNext();
            }
        }

        public void completeazaTitlu(String titlu)
        {
            lblOp.Text = titlu;
        }

        private void FActRetete_Load(object sender, EventArgs e)
        {
      
            dtpEmitere.Format = DateTimePickerFormat.Custom;
            dtpEmitere.CustomFormat = "dd.MM.yyyy";

            A1();
        }

        private void A1()
        {
            medicamenteTableAdapter.Fill(this.dataSet1.Medicamente);
         
            pacientiTableAdapter.Fill(this.dataSet1.Pacienti);
           
            alergiiTableAdapter.Fill(this.dataSet1.Alergii);
            
            // Protectie la modificare 
            txtTotal.ReadOnly = true;


            txtAlergie.ReadOnly = true;

            crtMedDataGridViewTextBoxColumn.ReadOnly = true;
            uMDataGridViewTextBoxColumn.ReadOnly = true;
            pretVanzareDataGridViewTextBoxColumn.ReadOnly = true;
            IdMedicament.ReadOnly = true;

            if (lblOp.Text == "MODIFICARE REȚETĂ") completeazaReteta();
            else if (lblOp.Text == "REȚETĂ NOUĂ")
            {
                cmbPacienti.SelectedIndex = -1;
                txtNrReteta.Text = "";
            }
        }

        // metoda pt. validarea campurilor obligatorii, dupa ce am apasat pe Confirmare
        private void A2()
        {
            if (!validareCampuriObligatorii()) return;

            if (lblOp.Text == "MODIFICARE REȚETĂ")
            {
                modificaInregistrare();
                stergeContinut();
                adaugaInregistrariReteteContinut();
                this.Close();
            }
            else if (lblOp.Text == "REȚETĂ NOUĂ")
            {
                adaugaInregistrareRetete();
                cautaInregistrare();
                adaugaInregistrariReteteContinut();
                golireCampuri();
            }
           
        }

        private void A3()
        {
            
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentCell == null || retetaContinutManevraBindingSource.Current == null)
            {
                return; // Ieșire dacă nu există rânduri curente sau celula curentă
            }
            // Generare nr. medicamentelor/reteta
            DataRowView current = (DataRowView)retetaContinutManevraBindingSource.Current;
            try
            {
                current["CrtMed"] = retetaContinutManevraBindingSource.Position + 1; }
            catch {  }
        }


        private void A4()
        {
            
            if (dataGridView1.CurrentCell == null || dataGridView1.CurrentRow == null)
            {
                return;
            }

            try
            {
                if (dataGridView1.CurrentCell.ColumnIndex == 1)
                {
                    DataRowView current = (DataRowView)medicamenteBindingSource.Current;

                    dataGridView1.CurrentRow.Cells[2].Value = current["UM"];
                    dataGridView1.CurrentRow.Cells[3].Value = current["Pret"];
                    dataGridView1.CurrentRow.Cells[6].Value = current["IdMedicament"];

                    dataGridView1.CurrentRow.Cells["spPozaDataGridViewTextBoxColumn"].Value = current["SpPoza"];


                    calcTotal();
                }

                if (dataGridView1.CurrentCell.ColumnIndex == 4)
                {
                    retetaContinutManevraBindingSource.EndEdit();
                    calcTotal();
                }
            }
            catch (Exception ex) { MessageBox.Show("Eroare la actualizarea datelor: " + ex.Message); }
        }

        private void A5(DataGridViewRowCancelEventArgs e)
        {

            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu,
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

            if (rezultat == DialogResult.No) e.Cancel = true;
        }


        private void calcTotal()
        { // Calcul total valori 
            decimal t = 0;
            foreach (DataRow r in dataSet1.RetetaContinutManevra)
            {
                if (r["Valoare"] != DBNull.Value)
                    t += (decimal)r["Valoare"];
            }

            txtTotal.Text = Convert.ToString(t);
        }

        private bool validareCampuriObligatorii() 
        { 
            //Validare de completare obligatorie campul Pacient 
            if (cmbPacienti.Text == "")
            {
                MessageBox.Show("Completați pacient!");
                cmbPacienti.Focus();
                return false;
            }


            if (txtNrReteta.Text == "")
            {
                MessageBox.Show("Completați nr. retetei!");
                txtNrReteta.Focus();
                return false;
            }

            // Validare completare continut 
            if (retetaContinutManevraBindingSource.Count == 0)
            {
                MessageBox.Show("Completați conținut rețetă!");
                dataGridView1.Focus();
                return false;
            }
            return true;
        }

        private void retetaContinutManevraBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            A3();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            A4();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            A5(e);
        }


        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //    MessageBox.Show($"Eroare de format: {e.Exception.Message}\nColoana: {dataGridView1.Columns[e.ColumnIndex].Name}\nRând: {e.RowIndex}");
            string columnName = dataGridView1.Columns[e.ColumnIndex].Name;

            // Verifică dacă eroarea este pe coloanele Cantitate sau Pret
            if (columnName == "cantitateDataGridViewTextBoxColumn")
            {
                MessageBox.Show($"Coloana 'Cantitate' trebuie să conțină un număr valid (numeric)!",
                                "Eroare de format",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                // Ignoră eroarea și permite utilizatorului să corecteze valoarea
                e.ThrowException = false;
            }
            else
            {
                // Tratament generic pentru alte erori
                MessageBox.Show($"Eroare de format: {e.Exception.Message}\nColoana: {columnName}\nRând: {e.RowIndex}",
                                "Eroare",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                // Ignorăm excepția pentru a permite continuarea
                e.ThrowException = false;
            }

        }



        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            calcTotal();
        }
        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            try
            {
                A2();
            }
            catch (Exception exc)
            {
                string s = exc.Message;

                if (s.IndexOf("duplicate values") > 0)
                    MessageBox.Show("Inregistrare deja existenta !");
            }
        }

        private void txtNrReteta_Leave(object sender, EventArgs e)
        {
            verificareIntegritate(txtNrReteta);
        }

        private void verificareIntegritate(TextBox txtB)
        {
            if (lblOp.Text == "")
            {
                MessageBox.Show("lblOp.Text este gol.");
                return; // Iesim daca lblOp nu are valoare.
            }
            if (txtB.Text == "")
            {
                MessageBox.Show("TextBox-ul este gol.");
                return; // Iesim daca TextBox-ul este gol.
            }

            try {

                cmd.Connection = con;

                if (txtB == txtNrReteta)
                {
                    con.ConnectionString = reteteTableAdapter.Connection.ConnectionString;
                    

                    if (lblOp.Text == "REȚETĂ NOUĂ")
                    {
                        cmd.CommandText = "Select NrReteta From Retete where NrReteta='" + txtNrReteta.Text + "'";
                    
                    }

                    else if (lblOp.Text == "MODIFICARE REȚETĂ")
                    {
                        cmd.CommandText = "Select NrReteta From Retete where NrReteta='" + txtNrReteta.Text + "'";

                    }

                    con.Open();

                    using (OleDbDataReader r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            // Dacă există deja o intrare cu același număr de rețetă.
                            MessageBox.Show("Nr. rețetă deja existent.");
                            txtNrReteta.Focus();
                            txtNrReteta.SelectAll(); // Selectăm textul pentru ca utilizatorul să-l poată șterge/modifica.
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la verificare: {ex.Message}");
            }
            finally
            {
                // Ne asigurăm că închidem conexiunea.
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        // adaug inregistrarile din FActualizareRetete in Retete
        private void adaugaInregistrareRetete()
        {
            string listaCampuri;
            string listaValori;
            DateTime d = dtpEmitere.Value;

            
            string diagnosticAles = "";
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Cells["Diagnostic"].Value != null)
            {
                diagnosticAles = dataGridView1.CurrentRow.Cells["Diagnostic"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Introduceți un diagnostic valid în tabelul DataGridView1.");
                return;
            }

            listaCampuri = "NrReteta, DataEmiterii, IdPacient, Diagnostic"; 

            // Formatarea valorilor
            listaValori = "'" + txtNrReteta.Text + "', " + // NrReteta încadrat în ghilimele simple
                          "#" + Convert.ToString(d.Month) + "/"
                               + Convert.ToString(d.Day) + "/"
                               + Convert.ToString(d.Year) + "#," + // DataEmiterii în format MM/dd/yyyy
                  cmbPacienti.SelectedValue + ", " + // IdPacient este numeric
                  "'" + diagnosticAles + "'";

            cmd.CommandText = "INSERT INTO Retete(" + listaCampuri + ") " +
                              "VALUES (" + listaValori + ")";
            try
            {
                MessageBox.Show(cmd.CommandText);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la adăugarea rețetei: {ex.Message}");
            }
            finally
            {
                con.Close();
            }
        }

        private void cautaInregistrare()
        {
            if (string.IsNullOrWhiteSpace(txtNrReteta.Text))
            {
                MessageBox.Show("Introduceți un număr de rețetă valid.");
                return;
            }

            cmd.CommandText = $"SELECT IdReteta FROM Retete WHERE NrReteta = '{txtNrReteta.Text}'";

            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    idRet = rdr.GetInt32(0);
                }
                else
                {
                    MessageBox.Show("Nu există o rețetă cu acest număr în baza de date.");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la căutarea rețetei: {ex.Message}");
            }
            finally
            {
                rdr?.Close();
                con.Close();
            }
        }

        // adaug inregistrarile din FActualizareRetete in ReteteContinut
        private void adaugaInregistrariReteteContinut()
        {
            string listaCampuri = "IdReteta, CrtMed, IdMedicament, Cantitate, PretVanzare";
            
            try
            {
                con.Open();

                foreach (DataRow r in dataSet1.RetetaContinutManevra)
                {
                     string listaValori = $"{idRet}, {r["CrtMed"]}, {r["IdMedicament"]}, {r["Cantitate"]}, {r["PretVanzare"]}";

                    cmd.CommandText = $"INSERT INTO RetetaContinut ({listaCampuri}) SELECT {listaValori}";

                    MessageBox.Show(cmd.CommandText);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"Eroare la adăugarea conținutului rețetei: {ex.Message}");
            }

            finally
            {
                con.Close();

            }
        }

        private void golireCampuri()
        {
            txtNrReteta.Text = "";
            cmbPacienti.SelectedIndex = -1;
            txtAlergie.Text = "";
            txtTotal.Text = "";
            dataSet1.RetetaContinutManevra.Clear();
        }

        private void modificaInregistrare()
        {
            DateTime d1 = dtpEmitere.Value;
            
            string clauzaWhere = " Where IdReteta = " + idRet;

            string clauzaSet = "Set DataEmiterii = #" + d1.Month + "/"
                               + d1.Day + "/"
                               + d1.Year + "#,"
                               + "IdPacient = " + cmbPacienti.SelectedValue;

            cmd.CommandText = "Update Retete " + clauzaSet + clauzaWhere;

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void stergeContinut()
        {
            cmd.CommandText = "Delete from RetetaContinut Where IdReteta = " + idRet;

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }



    }

}
