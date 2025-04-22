namespace Proiect
{
    partial class FMedicamente
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
            this.denumireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicamenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Proiect.DataSet1();
            this.medicamenteTableAdapter = new Proiect.DataSet1TableAdapters.MedicamenteTableAdapter();
            this.PB = new System.Windows.Forms.PictureBox();
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.btnConfirmare = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtSpPoza = new System.Windows.Forms.TextBox();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.txtUM = new System.Windows.Forms.TextBox();
            this.txtDMed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnModificare = new System.Windows.Forms.Button();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.lblOp = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(255, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista medicamentelor valabile \r\npentru emiterea rețetelor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.denumireDataGridViewTextBoxColumn,
            this.uMDataGridViewTextBoxColumn,
            this.pretDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.medicamenteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(59, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(369, 168);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.DataGridView1_SelectionChanged);
            // 
            // denumireDataGridViewTextBoxColumn
            // 
            this.denumireDataGridViewTextBoxColumn.DataPropertyName = "Denumire";
            this.denumireDataGridViewTextBoxColumn.HeaderText = "Denumire";
            this.denumireDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.denumireDataGridViewTextBoxColumn.Name = "denumireDataGridViewTextBoxColumn";
            this.denumireDataGridViewTextBoxColumn.ReadOnly = true;
            this.denumireDataGridViewTextBoxColumn.Width = 125;
            // 
            // uMDataGridViewTextBoxColumn
            // 
            this.uMDataGridViewTextBoxColumn.DataPropertyName = "UM";
            this.uMDataGridViewTextBoxColumn.HeaderText = "UM";
            this.uMDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uMDataGridViewTextBoxColumn.Name = "uMDataGridViewTextBoxColumn";
            this.uMDataGridViewTextBoxColumn.ReadOnly = true;
            this.uMDataGridViewTextBoxColumn.Width = 125;
            // 
            // pretDataGridViewTextBoxColumn
            // 
            this.pretDataGridViewTextBoxColumn.DataPropertyName = "Pret";
            this.pretDataGridViewTextBoxColumn.HeaderText = "Pret";
            this.pretDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pretDataGridViewTextBoxColumn.Name = "pretDataGridViewTextBoxColumn";
            this.pretDataGridViewTextBoxColumn.ReadOnly = true;
            this.pretDataGridViewTextBoxColumn.Width = 125;
            // 
            // medicamenteBindingSource
            // 
            this.medicamenteBindingSource.DataMember = "Medicamente";
            this.medicamenteBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicamenteTableAdapter
            // 
            this.medicamenteTableAdapter.ClearBeforeFill = true;
            // 
            // PB
            // 
            this.PB.Location = new System.Drawing.Point(322, 21);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(218, 179);
            this.PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB.TabIndex = 2;
            this.PB.TabStop = false;
            this.PB.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtSpPoza_MouseDoubleClick);
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.Location = new System.Drawing.Point(913, 418);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(108, 27);
            this.btnRenuntare.TabIndex = 15;
            this.btnRenuntare.Text = "Renunțare";
            this.btnRenuntare.UseVisualStyleBackColor = true;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click);
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.Location = new System.Drawing.Point(773, 418);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(108, 28);
            this.btnConfirmare.TabIndex = 14;
            this.btnConfirmare.Text = "Confirmare";
            this.btnConfirmare.UseVisualStyleBackColor = true;
            this.btnConfirmare.Click += new System.EventHandler(this.btnConfirmare_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.txtSpPoza);
            this.groupBox1.Controls.Add(this.txtPret);
            this.groupBox1.Controls.Add(this.txtUM);
            this.groupBox1.Controls.Add(this.txtDMed);
            this.groupBox1.Controls.Add(this.PB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(481, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 229);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(61, 167);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 16;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(24, 170);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 16);
            this.lblId.TabIndex = 15;
            this.lblId.Text = "Id";
            // 
            // txtSpPoza
            // 
            this.txtSpPoza.Location = new System.Drawing.Point(103, 131);
            this.txtSpPoza.Name = "txtSpPoza";
            this.txtSpPoza.Size = new System.Drawing.Size(185, 22);
            this.txtSpPoza.TabIndex = 13;
            // 
            // txtPret
            // 
            this.txtPret.Location = new System.Drawing.Point(103, 95);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(155, 22);
            this.txtPret.TabIndex = 12;
            this.txtPret.Leave += new System.EventHandler(this.txtPret_Leave);
            // 
            // txtUM
            // 
            this.txtUM.Location = new System.Drawing.Point(103, 57);
            this.txtUM.Name = "txtUM";
            this.txtUM.Size = new System.Drawing.Size(155, 22);
            this.txtUM.TabIndex = 11;
            this.txtUM.Leave += new System.EventHandler(this.txtUM_Leave);
            // 
            // txtDMed
            // 
            this.txtDMed.Location = new System.Drawing.Point(103, 18);
            this.txtDMed.Name = "txtDMed";
            this.txtDMed.Size = new System.Drawing.Size(155, 22);
            this.txtDMed.TabIndex = 10;
            this.txtDMed.Leave += new System.EventHandler(this.txtDMed_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "UM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "SpPoza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Denumire";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Preț";
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(329, 369);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(99, 30);
            this.btnStergere.TabIndex = 18;
            this.btnStergere.Text = "Ștergere";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnModificare
            // 
            this.btnModificare.Location = new System.Drawing.Point(197, 369);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(108, 30);
            this.btnModificare.TabIndex = 17;
            this.btnModificare.Text = "Modificare";
            this.btnModificare.UseVisualStyleBackColor = true;
            this.btnModificare.Click += new System.EventHandler(this.btnModificare_Click);
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(59, 369);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(106, 30);
            this.btnAdaugare.TabIndex = 16;
            this.btnAdaugare.Text = "Adăugare";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOp.Location = new System.Drawing.Point(499, 418);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(0, 29);
            this.lblOp.TabIndex = 19;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FMedicamente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1075, 511);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnModificare);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.btnConfirmare);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "FMedicamente";
            this.Text = "Medicamente";
            this.Load += new System.EventHandler(this.FMedicamente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource medicamenteBindingSource;
        private DataSet1TableAdapters.MedicamenteTableAdapter medicamenteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox PB;
        private System.Windows.Forms.Button btnRenuntare;
        private System.Windows.Forms.Button btnConfirmare;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtSpPoza;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.TextBox txtUM;
        private System.Windows.Forms.TextBox txtDMed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}