namespace Proiect
{
    partial class FIstoric
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtCautare = new System.Windows.Forms.TextBox();
            this.numePacientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeBoalaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDiagnosticDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.istoricBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Proiect.DataSet1();
            this.istoricTableAdapter = new Proiect.DataSet1TableAdapters.IstoricTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.istoricBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(116, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(577, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Istoricul medical al pacienților din cabinet";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numePacientDataGridViewTextBoxColumn,
            this.numeBoalaDataGridViewTextBoxColumn,
            this.dataDiagnosticDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.istoricBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(122, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(559, 176);
            this.dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(389, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Căutați pacientul:";
            // 
            // txtCautare
            // 
            this.txtCautare.Location = new System.Drawing.Point(552, 154);
            this.txtCautare.Name = "txtCautare";
            this.txtCautare.Size = new System.Drawing.Size(129, 22);
            this.txtCautare.TabIndex = 3;
            this.txtCautare.TextChanged += new System.EventHandler(this.txtCautare_TextChanged);
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
            // numeBoalaDataGridViewTextBoxColumn
            // 
            this.numeBoalaDataGridViewTextBoxColumn.DataPropertyName = "NumeBoala";
            this.numeBoalaDataGridViewTextBoxColumn.HeaderText = "Denumire Boala";
            this.numeBoalaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeBoalaDataGridViewTextBoxColumn.Name = "numeBoalaDataGridViewTextBoxColumn";
            this.numeBoalaDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeBoalaDataGridViewTextBoxColumn.Width = 140;
            // 
            // dataDiagnosticDataGridViewTextBoxColumn
            // 
            this.dataDiagnosticDataGridViewTextBoxColumn.DataPropertyName = "DataDiagnostic";
            this.dataDiagnosticDataGridViewTextBoxColumn.HeaderText = "Data Diagnostic";
            this.dataDiagnosticDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataDiagnosticDataGridViewTextBoxColumn.Name = "dataDiagnosticDataGridViewTextBoxColumn";
            this.dataDiagnosticDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataDiagnosticDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataDiagnosticDataGridViewTextBoxColumn.Width = 150;
            // 
            // istoricBindingSource
            // 
            this.istoricBindingSource.DataMember = "Istoric";
            this.istoricBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // istoricTableAdapter
            // 
            this.istoricTableAdapter.ClearBeforeFill = true;
            // 
            // FIstoric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCautare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "FIstoric";
            this.Text = "Istoric Medical";
            this.Load += new System.EventHandler(this.FIstoric_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.istoricBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource istoricBindingSource;
        private DataSet1TableAdapters.IstoricTableAdapter istoricTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numePacientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeBoalaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDiagnosticDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCautare;
    }
}