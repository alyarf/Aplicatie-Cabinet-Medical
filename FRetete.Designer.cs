namespace Proiect
{
    partial class FRetete
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NrReteta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numePacientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEmiteriiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosticDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reteteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Proiect.DataSet1();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.IdReteta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrtMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dMedicamentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretVanzareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retetaContinutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btnRetetaNoua = new System.Windows.Forms.Button();
            this.btnMdfReteta = new System.Windows.Forms.Button();
            this.btnStReteta = new System.Windows.Forms.Button();
            this.txtCautare = new System.Windows.Forms.TextBox();
            this.reteteTableAdapter = new Proiect.DataSet1TableAdapters.ReteteTableAdapter();
            this.retetaContinutTableAdapter = new Proiect.DataSet1TableAdapters.RetetaContinutTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reteteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retetaContinutBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(319, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista rețetelor eliberate\r\n(în ordinea cronologică eliberării lor)\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NrReteta,
            this.numePacientDataGridViewTextBoxColumn,
            this.dataEmiteriiDataGridViewTextBoxColumn,
            this.diagnosticDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.reteteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(95, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(681, 176);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // NrReteta
            // 
            this.NrReteta.DataPropertyName = "NrReteta";
            this.NrReteta.HeaderText = "Rețeta";
            this.NrReteta.MinimumWidth = 6;
            this.NrReteta.Name = "NrReteta";
            this.NrReteta.ReadOnly = true;
            this.NrReteta.Width = 125;
            // 
            // numePacientDataGridViewTextBoxColumn
            // 
            this.numePacientDataGridViewTextBoxColumn.DataPropertyName = "NumePacient";
            this.numePacientDataGridViewTextBoxColumn.HeaderText = "Nume Pacient";
            this.numePacientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numePacientDataGridViewTextBoxColumn.Name = "numePacientDataGridViewTextBoxColumn";
            this.numePacientDataGridViewTextBoxColumn.ReadOnly = true;
            this.numePacientDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataEmiteriiDataGridViewTextBoxColumn
            // 
            this.dataEmiteriiDataGridViewTextBoxColumn.DataPropertyName = "DataEmiterii";
            this.dataEmiteriiDataGridViewTextBoxColumn.HeaderText = "Data Emiterii";
            this.dataEmiteriiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataEmiteriiDataGridViewTextBoxColumn.Name = "dataEmiteriiDataGridViewTextBoxColumn";
            this.dataEmiteriiDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataEmiteriiDataGridViewTextBoxColumn.Width = 125;
            // 
            // diagnosticDataGridViewTextBoxColumn
            // 
            this.diagnosticDataGridViewTextBoxColumn.DataPropertyName = "Diagnostic";
            this.diagnosticDataGridViewTextBoxColumn.HeaderText = "Diagnostic";
            this.diagnosticDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diagnosticDataGridViewTextBoxColumn.Name = "diagnosticDataGridViewTextBoxColumn";
            this.diagnosticDataGridViewTextBoxColumn.ReadOnly = true;
            this.diagnosticDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Width = 125;
            // 
            // reteteBindingSource
            // 
            this.reteteBindingSource.DataMember = "Retete";
            this.reteteBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdReteta,
            this.CrtMed,
            this.dMedicamentDataGridViewTextBoxColumn,
            this.uMDataGridViewTextBoxColumn,
            this.pretVanzareDataGridViewTextBoxColumn,
            this.cantitateDataGridViewTextBoxColumn,
            this.valoareDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.retetaContinutBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(95, 432);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(780, 150);
            this.dataGridView2.TabIndex = 2;
            // 
            // IdReteta
            // 
            this.IdReteta.DataPropertyName = "IdReteta";
            this.IdReteta.HeaderText = "Id Rețetă";
            this.IdReteta.MinimumWidth = 6;
            this.IdReteta.Name = "IdReteta";
            this.IdReteta.ReadOnly = true;
            this.IdReteta.Width = 125;
            // 
            // CrtMed
            // 
            this.CrtMed.DataPropertyName = "CrtMed";
            this.CrtMed.HeaderText = "CrtMed";
            this.CrtMed.MinimumWidth = 6;
            this.CrtMed.Name = "CrtMed";
            this.CrtMed.ReadOnly = true;
            this.CrtMed.Width = 80;
            // 
            // dMedicamentDataGridViewTextBoxColumn
            // 
            this.dMedicamentDataGridViewTextBoxColumn.DataPropertyName = "DMedicament";
            this.dMedicamentDataGridViewTextBoxColumn.HeaderText = "Denumire medicament";
            this.dMedicamentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dMedicamentDataGridViewTextBoxColumn.Name = "dMedicamentDataGridViewTextBoxColumn";
            this.dMedicamentDataGridViewTextBoxColumn.ReadOnly = true;
            this.dMedicamentDataGridViewTextBoxColumn.Width = 180;
            // 
            // uMDataGridViewTextBoxColumn
            // 
            this.uMDataGridViewTextBoxColumn.DataPropertyName = "UM";
            this.uMDataGridViewTextBoxColumn.HeaderText = "UM";
            this.uMDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uMDataGridViewTextBoxColumn.Name = "uMDataGridViewTextBoxColumn";
            this.uMDataGridViewTextBoxColumn.ReadOnly = true;
            this.uMDataGridViewTextBoxColumn.Width = 50;
            // 
            // pretVanzareDataGridViewTextBoxColumn
            // 
            this.pretVanzareDataGridViewTextBoxColumn.DataPropertyName = "PretVanzare";
            this.pretVanzareDataGridViewTextBoxColumn.HeaderText = "Preț vânzare";
            this.pretVanzareDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pretVanzareDataGridViewTextBoxColumn.Name = "pretVanzareDataGridViewTextBoxColumn";
            this.pretVanzareDataGridViewTextBoxColumn.ReadOnly = true;
            this.pretVanzareDataGridViewTextBoxColumn.Width = 130;
            // 
            // cantitateDataGridViewTextBoxColumn
            // 
            this.cantitateDataGridViewTextBoxColumn.DataPropertyName = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.HeaderText = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantitateDataGridViewTextBoxColumn.Name = "cantitateDataGridViewTextBoxColumn";
            this.cantitateDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantitateDataGridViewTextBoxColumn.Width = 85;
            // 
            // valoareDataGridViewTextBoxColumn
            // 
            this.valoareDataGridViewTextBoxColumn.DataPropertyName = "Valoare";
            this.valoareDataGridViewTextBoxColumn.HeaderText = "Valoare";
            this.valoareDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valoareDataGridViewTextBoxColumn.Name = "valoareDataGridViewTextBoxColumn";
            this.valoareDataGridViewTextBoxColumn.ReadOnly = true;
            this.valoareDataGridViewTextBoxColumn.Width = 80;
            // 
            // retetaContinutBindingSource
            // 
            this.retetaContinutBindingSource.DataMember = "RetetaContinut";
            this.retetaContinutBindingSource.DataSource = this.dataSet1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(821, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Căutare pacient:";
            // 
            // btnRetetaNoua
            // 
            this.btnRetetaNoua.Location = new System.Drawing.Point(974, 432);
            this.btnRetetaNoua.Name = "btnRetetaNoua";
            this.btnRetetaNoua.Size = new System.Drawing.Size(130, 30);
            this.btnRetetaNoua.TabIndex = 5;
            this.btnRetetaNoua.Text = "Rețetă nouă";
            this.btnRetetaNoua.UseVisualStyleBackColor = true;
            this.btnRetetaNoua.Click += new System.EventHandler(this.btnRetetaNoua_Click);
            // 
            // btnMdfReteta
            // 
            this.btnMdfReteta.Location = new System.Drawing.Point(974, 489);
            this.btnMdfReteta.Name = "btnMdfReteta";
            this.btnMdfReteta.Size = new System.Drawing.Size(130, 32);
            this.btnMdfReteta.TabIndex = 6;
            this.btnMdfReteta.Text = "Modificare rețetă";
            this.btnMdfReteta.UseVisualStyleBackColor = true;
            this.btnMdfReteta.Click += new System.EventHandler(this.btnMdfReteta_Click);
            // 
            // btnStReteta
            // 
            this.btnStReteta.Location = new System.Drawing.Point(974, 550);
            this.btnStReteta.Name = "btnStReteta";
            this.btnStReteta.Size = new System.Drawing.Size(130, 32);
            this.btnStReteta.TabIndex = 7;
            this.btnStReteta.Text = "Șterge rețetă";
            this.btnStReteta.UseVisualStyleBackColor = true;
            this.btnStReteta.Click += new System.EventHandler(this.btnStReteta_Click);
            // 
            // txtCautare
            // 
            this.txtCautare.Location = new System.Drawing.Point(974, 178);
            this.txtCautare.Name = "txtCautare";
            this.txtCautare.Size = new System.Drawing.Size(100, 22);
            this.txtCautare.TabIndex = 8;
            this.txtCautare.TextChanged += new System.EventHandler(this.txtCautare_TextChanged);
            // 
            // reteteTableAdapter
            // 
            this.reteteTableAdapter.ClearBeforeFill = true;
            // 
            // retetaContinutTableAdapter
            // 
            this.retetaContinutTableAdapter.ClearBeforeFill = true;
            // 
            // FRetete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1164, 626);
            this.Controls.Add(this.txtCautare);
            this.Controls.Add(this.btnStReteta);
            this.Controls.Add(this.btnMdfReteta);
            this.Controls.Add(this.btnRetetaNoua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "FRetete";
            this.Text = "Rețete";
            this.Load += new System.EventHandler(this.FRetete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reteteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retetaContinutBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource reteteBindingSource;
        private DataSet1TableAdapters.ReteteTableAdapter reteteTableAdapter;
        private System.Windows.Forms.BindingSource retetaContinutBindingSource;
        private DataSet1TableAdapters.RetetaContinutTableAdapter retetaContinutTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRetetaNoua;
        private System.Windows.Forms.Button btnMdfReteta;
        private System.Windows.Forms.Button btnStReteta;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrReteta;
        private System.Windows.Forms.DataGridViewTextBoxColumn numePacientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEmiteriiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosticDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdReteta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrtMed;
        private System.Windows.Forms.DataGridViewTextBoxColumn dMedicamentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretVanzareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoareDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtCautare;
    }
}