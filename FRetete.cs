using Proiect.DataSet1TableAdapters;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class FRetete : Form
    {
        public FRetete()
        {
            InitializeComponent();
        }
        private void refreshGrid()
        {
            try
            {
                // Încarcă datele în tabelele din DataSet
                reteteTableAdapter.Fill(dataSet1.Retete);
                retetaContinutTableAdapter.Fill(dataSet1.RetetaContinut);
                
                // Verifică dacă există erori la rânduri
                foreach (DataTable table in dataSet1.Tables)
                {
                    foreach (DataRow row in table.GetErrors())
                    {
                        MessageBox.Show($"Tabel: {table.TableName}, Eroare: {string.Join(", ", row.GetColumnsInError().Select(col => col.ColumnName))}");
                    }
                }
            }
            catch (ConstraintException ex)
            {
                MessageBox.Show($"Eroare la încărcarea datelor: {ex.Message}");
            }
        }

        private void FRetete_Load(object sender, EventArgs e)
        {
            refreshGrid();

            retetaContinutBindingSource.RemoveFilter();
        }


        private void filtreazaRetete()
        {
          try{
                if (!string.IsNullOrWhiteSpace(txtCautare.Text))
                {
                    // Aplica filtrul pe BindingSource
                       reteteBindingSource.Filter = $"NumePacient LIKE '%{txtCautare.Text}%'";
                }
                 else{
                 // Elimină filtrul dacă textul este gol
                      reteteBindingSource.RemoveFilter();
                   }
               }
           catch { }
        }

        private void filtreazaContinutReteta()
        {
            try
            {
                if (reteteBindingSource.Current == null)
                {
                    retetaContinutBindingSource.RemoveFilter();
                    return;
                }

                // Preia `IdReteta` din rândul curent selectat
                DataRowView currentRow = (DataRowView)reteteBindingSource.Current;
                int idReteta = Convert.ToInt32(currentRow["IdReteta"]);

                // Aplică filtrul pe BindingSource-ul pentru RetetaContinut
                retetaContinutBindingSource.Filter = $"IdReteta = {idReteta}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la filtrarea conținutului rețetei: {ex.Message}");
            }
        }
        private void txtCautare_TextChanged(object sender, EventArgs e)
        {
            filtreazaRetete();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            filtreazaContinutReteta();
        }


        private void btnRetetaNoua_Click(object sender, EventArgs e)
        {
            FActRetete f = new FActRetete();
            f.completeazaTitlu("REȚETĂ NOUĂ");
            f.ShowDialog();
            refreshGrid();
        }

        private void btnMdfReteta_Click(object sender, EventArgs e)
        {
            FActRetete f = new FActRetete();
            f.completeazaTitlu("MODIFICARE REȚETĂ");
            f.bs1 = reteteBindingSource;
            f.bs2 = retetaContinutBindingSource;
            f.ShowDialog();
            refreshGrid();
        }
        private void btnStReteta_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Nu a fost selectată nicio rețetă.");
                return;
            }

            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";

            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) return;

            string NrReteta = dataGridView1.CurrentRow.Cells["NrReteta"].Value.ToString();
            
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();

            con.ConnectionString = reteteTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            try
            {
                con.Open();

                // Șterge conținutul rețetei (din RetetaContinut)
                cmd.CommandText = $@"
            DELETE FROM RetetaContinut 
            WHERE IdReteta IN (
                SELECT IdReteta FROM Retete WHERE NrReteta = '{NrReteta}'
            )";
                cmd.ExecuteNonQuery();

                // Șterge rețeta (din Retete)
                cmd.CommandText = $"DELETE FROM Retete WHERE NrReteta = '{NrReteta}'";

                cmd.ExecuteNonQuery();

                MessageBox.Show("Rețeta a fost ștearsă cu succes.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la ștergerea rețetei: {ex.Message}");
            }
            finally { con.Close(); }

            refreshGrid();
        }

    }
}
