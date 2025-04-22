namespace Proiect
{
    partial class FActRetete
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOp = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpEmitere = new System.Windows.Forms.DateTimePicker();
            this.cmbPacienti = new System.Windows.Forms.ComboBox();
            this.pacientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Proiect.DataSet1();
            this.txtNrReteta = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.crtMedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dMedicamentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.medicamenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretVanzareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMedicament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diagnostic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spPozaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retetaContinutManevraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.alergiiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alergiiTableAdapter = new Proiect.DataSet1TableAdapters.AlergiiTableAdapter();
            this.pacientiTableAdapter = new Proiect.DataSet1TableAdapters.PacientiTableAdapter();
            this.medicamenteTableAdapter = new Proiect.DataSet1TableAdapters.MedicamenteTableAdapter();
            this.reteteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reteteTableAdapter = new Proiect.DataSet1TableAdapters.ReteteTableAdapter();
            this.txtAlergie = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pacientiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retetaContinutManevraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alergiiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reteteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nr, Rețetă ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pacient";
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOp.Location = new System.Drawing.Point(98, 52);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(0, 32);
            this.lblOp.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(805, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total";
            // 
            // dtpEmitere
            // 
            this.dtpEmitere.Location = new System.Drawing.Point(184, 209);
            this.dtpEmitere.Name = "dtpEmitere";
            this.dtpEmitere.Size = new System.Drawing.Size(130, 22);
            this.dtpEmitere.TabIndex = 5;
            // 
            // cmbPacienti
            // 
            this.cmbPacienti.DataSource = this.pacientiBindingSource;
            this.cmbPacienti.DisplayMember = "NumePacient";
            this.cmbPacienti.FormattingEnabled = true;
            this.cmbPacienti.Location = new System.Drawing.Point(184, 163);
            this.cmbPacienti.Name = "cmbPacienti";
            this.cmbPacienti.Size = new System.Drawing.Size(114, 24);
            this.cmbPacienti.TabIndex = 6;
            this.cmbPacienti.ValueMember = "IdPacient";
            // 
            // pacientiBindingSource
            // 
            this.pacientiBindingSource.DataMember = "Pacienti";
            this.pacientiBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNrReteta
            // 
            this.txtNrReteta.Location = new System.Drawing.Point(184, 117);
            this.txtNrReteta.Name = "txtNrReteta";
            this.txtNrReteta.Size = new System.Drawing.Size(100, 22);
            this.txtNrReteta.TabIndex = 7;
            this.txtNrReteta.Leave += new System.EventHandler(this.txtNrReteta_Leave);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(487, 480);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(113, 31);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Confirmare";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirmare_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(873, 239);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.crtMedDataGridViewTextBoxColumn,
            this.dMedicamentDataGridViewTextBoxColumn,
            this.uMDataGridViewTextBoxColumn,
            this.pretVanzareDataGridViewTextBoxColumn,
            this.cantitateDataGridViewTextBoxColumn,
            this.valoareDataGridViewTextBoxColumn,
            this.IdMedicament,
            this.Diagnostic,
            this.spPozaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.retetaContinutManevraBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(39, 289);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(963, 161);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridView1.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserDeletedRow);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // crtMedDataGridViewTextBoxColumn
            // 
            this.crtMedDataGridViewTextBoxColumn.DataPropertyName = "CrtMed";
            this.crtMedDataGridViewTextBoxColumn.HeaderText = "CrtMed";
            this.crtMedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.crtMedDataGridViewTextBoxColumn.Name = "crtMedDataGridViewTextBoxColumn";
            this.crtMedDataGridViewTextBoxColumn.Width = 125;
            // 
            // dMedicamentDataGridViewTextBoxColumn
            // 
            this.dMedicamentDataGridViewTextBoxColumn.DataPropertyName = "IdMedicament";
            this.dMedicamentDataGridViewTextBoxColumn.DataSource = this.medicamenteBindingSource;
            this.dMedicamentDataGridViewTextBoxColumn.DisplayMember = "Denumire";
            this.dMedicamentDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dMedicamentDataGridViewTextBoxColumn.DisplayStyleForCurrentCellOnly = true;
            this.dMedicamentDataGridViewTextBoxColumn.HeaderText = "DMedicament";
            this.dMedicamentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dMedicamentDataGridViewTextBoxColumn.Name = "dMedicamentDataGridViewTextBoxColumn";
            this.dMedicamentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dMedicamentDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dMedicamentDataGridViewTextBoxColumn.ValueMember = "IDMedicament";
            this.dMedicamentDataGridViewTextBoxColumn.Width = 120;
            // 
            // medicamenteBindingSource
            // 
            this.medicamenteBindingSource.DataMember = "Medicamente";
            this.medicamenteBindingSource.DataSource = this.dataSet1;
            // 
            // uMDataGridViewTextBoxColumn
            // 
            this.uMDataGridViewTextBoxColumn.DataPropertyName = "UM";
            this.uMDataGridViewTextBoxColumn.HeaderText = "UM";
            this.uMDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uMDataGridViewTextBoxColumn.Name = "uMDataGridViewTextBoxColumn";
            this.uMDataGridViewTextBoxColumn.Width = 50;
            // 
            // pretVanzareDataGridViewTextBoxColumn
            // 
            this.pretVanzareDataGridViewTextBoxColumn.DataPropertyName = "PretVanzare";
            this.pretVanzareDataGridViewTextBoxColumn.HeaderText = "Preț vânzare";
            this.pretVanzareDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pretVanzareDataGridViewTextBoxColumn.Name = "pretVanzareDataGridViewTextBoxColumn";
            this.pretVanzareDataGridViewTextBoxColumn.Width = 125;
            // 
            // cantitateDataGridViewTextBoxColumn
            // 
            this.cantitateDataGridViewTextBoxColumn.DataPropertyName = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.HeaderText = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantitateDataGridViewTextBoxColumn.Name = "cantitateDataGridViewTextBoxColumn";
            this.cantitateDataGridViewTextBoxColumn.Width = 80;
            // 
            // valoareDataGridViewTextBoxColumn
            // 
            this.valoareDataGridViewTextBoxColumn.DataPropertyName = "Valoare";
            this.valoareDataGridViewTextBoxColumn.HeaderText = "Valoare";
            this.valoareDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valoareDataGridViewTextBoxColumn.Name = "valoareDataGridViewTextBoxColumn";
            this.valoareDataGridViewTextBoxColumn.ReadOnly = true;
            this.valoareDataGridViewTextBoxColumn.Width = 70;
            // 
            // IdMedicament
            // 
            this.IdMedicament.DataPropertyName = "IdMedicament";
            this.IdMedicament.HeaderText = "Id Medicament";
            this.IdMedicament.MinimumWidth = 6;
            this.IdMedicament.Name = "IdMedicament";
            this.IdMedicament.ReadOnly = true;
            this.IdMedicament.Width = 125;
            // 
            // Diagnostic
            // 
            this.Diagnostic.DataPropertyName = "Diagnostic";
            this.Diagnostic.HeaderText = "Diagnostic";
            this.Diagnostic.MinimumWidth = 6;
            this.Diagnostic.Name = "Diagnostic";
            this.Diagnostic.Width = 125;
            // 
            // spPozaDataGridViewTextBoxColumn
            // 
            this.spPozaDataGridViewTextBoxColumn.DataPropertyName = "SpPoza";
            this.spPozaDataGridViewTextBoxColumn.HeaderText = "SpPoza";
            this.spPozaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.spPozaDataGridViewTextBoxColumn.Name = "spPozaDataGridViewTextBoxColumn";
            this.spPozaDataGridViewTextBoxColumn.Width = 125;
            // 
            // retetaContinutManevraBindingSource
            // 
            this.retetaContinutManevraBindingSource.DataMember = "RetetaContinutManevra";
            this.retetaContinutManevraBindingSource.DataSource = this.dataSet1;
            this.retetaContinutManevraBindingSource.CurrentChanged += new System.EventHandler(this.retetaContinutManevraBindingSource_CurrentChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(434, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tip alergie";
            // 
            // alergiiBindingSource
            // 
            this.alergiiBindingSource.DataMember = "Alergii";
            this.alergiiBindingSource.DataSource = this.dataSet1;
            // 
            // alergiiTableAdapter
            // 
            this.alergiiTableAdapter.ClearBeforeFill = true;
            // 
            // pacientiTableAdapter
            // 
            this.pacientiTableAdapter.ClearBeforeFill = true;
            // 
            // medicamenteTableAdapter
            // 
            this.medicamenteTableAdapter.ClearBeforeFill = true;
            // 
            // reteteBindingSource
            // 
            this.reteteBindingSource.DataMember = "Retete";
            this.reteteBindingSource.DataSource = this.dataSet1;
            // 
            // reteteTableAdapter
            // 
            this.reteteTableAdapter.ClearBeforeFill = true;
            // 
            // txtAlergie
            // 
            this.txtAlergie.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientiBindingSource, "Alergen", true));
            this.txtAlergie.Location = new System.Drawing.Point(512, 162);
            this.txtAlergie.Name = "txtAlergie";
            this.txtAlergie.Size = new System.Drawing.Size(88, 22);
            this.txtAlergie.TabIndex = 16;
            // 
            // FActRetete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1136, 609);
            this.Controls.Add(this.txtAlergie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtNrReteta);
            this.Controls.Add(this.cmbPacienti);
            this.Controls.Add(this.dtpEmitere);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FActRetete";
            this.Text = "Actualizare Rețete";
            this.Load += new System.EventHandler(this.FActRetete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pacientiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retetaContinutManevraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alergiiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reteteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpEmitere;
        private System.Windows.Forms.ComboBox cmbPacienti;
        private System.Windows.Forms.TextBox txtNrReteta;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource retetaContinutManevraBindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource alergiiBindingSource;
        private DataSet1TableAdapters.AlergiiTableAdapter alergiiTableAdapter;
        private System.Windows.Forms.BindingSource pacientiBindingSource;
        private DataSet1TableAdapters.PacientiTableAdapter pacientiTableAdapter;
        private System.Windows.Forms.BindingSource medicamenteBindingSource;
        private DataSet1TableAdapters.MedicamenteTableAdapter medicamenteTableAdapter;
        private System.Windows.Forms.BindingSource reteteBindingSource;
        private DataSet1TableAdapters.ReteteTableAdapter reteteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn crtMedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dMedicamentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretVanzareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMedicament;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diagnostic;
        private System.Windows.Forms.DataGridViewTextBoxColumn spPozaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtAlergie;
    }
}