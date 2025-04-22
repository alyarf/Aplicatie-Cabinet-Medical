using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class FIstoric : Form
    {
        private DataSet1TableAdapters.PacientiTableAdapter pacientiTableAdapter = new DataSet1TableAdapters.PacientiTableAdapter();
        private BindingSource pacientiBindingSource = new BindingSource();

        public FIstoric()
        {
            InitializeComponent();
        }

        private void FIstoric_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Istoric' table. You can move, or remove it, as needed.
            this.istoricTableAdapter.Fill(this.dataSet1.Istoric);
            /*this.pacientiTableAdapter.Fill(this.dataSet1.Pacienti);

            pacientiBindingSource.DataSource = this.dataSet1.Pacienti;

            dataGridView1.DataSource = pacientiBindingSource;*/
        }


        private void txtCautare_TextChanged(object sender, EventArgs e)
        {

            istoricBindingSource.Filter = "NumePacient Like '" + txtCautare.Text + "*'";
            /*string filterValue = txtCautare.Text.Trim();

            if (!string.IsNullOrEmpty(filterValue))
            {
                pacientiBindingSource.Filter = $"NumePacient LIKE '{filterValue}%'";
            }
            else
            {
                pacientiBindingSource.RemoveFilter();
            }
        */
        }
    }

}
