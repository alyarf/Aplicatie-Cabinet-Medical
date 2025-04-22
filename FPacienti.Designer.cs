namespace Proiect
{
    partial class FPacienti
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
            this.numePacientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alergen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacientiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Proiect.DataSet1();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.btnModificare = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.istoricMedicalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacientiTableAdapter = new Proiect.DataSet1TableAdapters.PacientiTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdministrareAlergii = new System.Windows.Forms.Button();
            this.cmbAlergie = new System.Windows.Forms.ComboBox();
            this.txtIdPacient = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblAlergie = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtCNP = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.btnConfirmare = new System.Windows.Forms.Button();
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.alergiiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alergiiTableAdapter = new Proiect.DataSet1TableAdapters.AlergiiTableAdapter();
            this.lblOp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacientiBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alergiiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(391, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(546, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista pacienților înregistrați în cabinet";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numePacientDataGridViewTextBoxColumn,
            this.cNPDataGridViewTextBoxColumn,
            this.nrTelefonDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.Alergen});
            this.dataGridView1.DataSource = this.pacientiBindingSource1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.Location = new System.Drawing.Point(32, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(651, 220);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
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
            // cNPDataGridViewTextBoxColumn
            // 
            this.cNPDataGridViewTextBoxColumn.DataPropertyName = "CNP";
            this.cNPDataGridViewTextBoxColumn.HeaderText = "CNP";
            this.cNPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cNPDataGridViewTextBoxColumn.Name = "cNPDataGridViewTextBoxColumn";
            this.cNPDataGridViewTextBoxColumn.ReadOnly = true;
            this.cNPDataGridViewTextBoxColumn.Width = 125;
            // 
            // nrTelefonDataGridViewTextBoxColumn
            // 
            this.nrTelefonDataGridViewTextBoxColumn.DataPropertyName = "NrTelefon";
            this.nrTelefonDataGridViewTextBoxColumn.HeaderText = "Nr. Telefon";
            this.nrTelefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nrTelefonDataGridViewTextBoxColumn.Name = "nrTelefonDataGridViewTextBoxColumn";
            this.nrTelefonDataGridViewTextBoxColumn.ReadOnly = true;
            this.nrTelefonDataGridViewTextBoxColumn.Width = 125;
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            this.adresaDataGridViewTextBoxColumn.ReadOnly = true;
            this.adresaDataGridViewTextBoxColumn.Width = 125;
            // 
            // Alergen
            // 
            this.Alergen.DataPropertyName = "Alergen";
            this.Alergen.HeaderText = "Tip Alergie";
            this.Alergen.MinimumWidth = 6;
            this.Alergen.Name = "Alergen";
            this.Alergen.ReadOnly = true;
            this.Alergen.Width = 125;
            // 
            // pacientiBindingSource1
            // 
            this.pacientiBindingSource1.DataMember = "Pacienti";
            this.pacientiBindingSource1.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(160, 481);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(106, 30);
            this.btnAdaugare.TabIndex = 2;
            this.btnAdaugare.Text = "Adăugare";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // btnModificare
            // 
            this.btnModificare.Location = new System.Drawing.Point(311, 480);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(108, 31);
            this.btnModificare.TabIndex = 3;
            this.btnModificare.Text = "Modificare";
            this.btnModificare.UseVisualStyleBackColor = true;
            this.btnModificare.Click += new System.EventHandler(this.btnModificare_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(462, 480);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(99, 31);
            this.btnStergere.TabIndex = 4;
            this.btnStergere.Text = "Ștergere";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.istoricMedicalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1322, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // istoricMedicalToolStripMenuItem
            // 
            this.istoricMedicalToolStripMenuItem.Name = "istoricMedicalToolStripMenuItem";
            this.istoricMedicalToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.istoricMedicalToolStripMenuItem.Text = "Istoric Medical";
            this.istoricMedicalToolStripMenuItem.Click += new System.EventHandler(this.istoricToolStripMenuItem_Click);
            // 
            // pacientiBindingSource
            // 
            this.pacientiBindingSource.DataMember = "Pacienti";
            this.pacientiBindingSource.DataSource = this.dataSet1;
            // 
            // pacientiTableAdapter
            // 
            this.pacientiTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "CNP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nr. Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Adresa";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdministrareAlergii);
            this.groupBox1.Controls.Add(this.cmbAlergie);
            this.groupBox1.Controls.Add(this.txtIdPacient);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.lblAlergie);
            this.groupBox1.Controls.Add(this.txtAdresa);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.txtCNP);
            this.groupBox1.Controls.Add(this.txtNume);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(735, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 232);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // btnAdministrareAlergii
            // 
            this.btnAdministrareAlergii.Location = new System.Drawing.Point(527, 68);
            this.btnAdministrareAlergii.Name = "btnAdministrareAlergii";
            this.btnAdministrareAlergii.Size = new System.Drawing.Size(29, 24);
            this.btnAdministrareAlergii.TabIndex = 18;
            this.btnAdministrareAlergii.UseVisualStyleBackColor = true;
            this.btnAdministrareAlergii.Click += new System.EventHandler(this.btnAdministrareAlergii_Click);
            // 
            // cmbAlergie
            // 
            this.cmbAlergie.FormattingEnabled = true;
            this.cmbAlergie.Location = new System.Drawing.Point(400, 69);
            this.cmbAlergie.Name = "cmbAlergie";
            this.cmbAlergie.Size = new System.Drawing.Size(121, 24);
            this.cmbAlergie.TabIndex = 17;
            // 
            // txtIdPacient
            // 
            this.txtIdPacient.Location = new System.Drawing.Point(102, 187);
            this.txtIdPacient.Name = "txtIdPacient";
            this.txtIdPacient.Size = new System.Drawing.Size(100, 22);
            this.txtIdPacient.TabIndex = 16;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(66, 190);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 16);
            this.lblId.TabIndex = 15;
            this.lblId.Text = "Id";
            // 
            // lblAlergie
            // 
            this.lblAlergie.AutoSize = true;
            this.lblAlergie.Location = new System.Drawing.Point(321, 72);
            this.lblAlergie.Name = "lblAlergie";
            this.lblAlergie.Size = new System.Drawing.Size(73, 16);
            this.lblAlergie.TabIndex = 13;
            this.lblAlergie.Text = "Tip Alergie";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(102, 143);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(185, 22);
            this.txtAdresa.TabIndex = 13;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(102, 107);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(155, 22);
            this.txtTelefon.TabIndex = 12;
            this.txtTelefon.Leave += new System.EventHandler(this.txtTelefon_Leave);
            // 
            // txtCNP
            // 
            this.txtCNP.Location = new System.Drawing.Point(102, 69);
            this.txtCNP.Name = "txtCNP";
            this.txtCNP.Size = new System.Drawing.Size(155, 22);
            this.txtCNP.TabIndex = 11;
            this.txtCNP.Leave += new System.EventHandler(this.txtCNP_Leave);
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(102, 30);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(155, 22);
            this.txtNume.TabIndex = 10;
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.Location = new System.Drawing.Point(1019, 480);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(108, 28);
            this.btnConfirmare.TabIndex = 11;
            this.btnConfirmare.Text = "Confirmare";
            this.btnConfirmare.UseVisualStyleBackColor = true;
            this.btnConfirmare.Click += new System.EventHandler(this.btnConfirmare_Click);
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.Location = new System.Drawing.Point(1169, 480);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(108, 28);
            this.btnRenuntare.TabIndex = 12;
            this.btnRenuntare.Text = "Renunțare";
            this.btnRenuntare.UseVisualStyleBackColor = true;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click);
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
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOp.Location = new System.Drawing.Point(752, 486);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(0, 25);
            this.lblOp.TabIndex = 13;
            // 
            // FPacienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1322, 585);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.btnConfirmare);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnModificare);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FPacienti";
            this.Text = "Pacienți";
            this.Load += new System.EventHandler(this.FPacienti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacientiBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alergiiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource pacientiBindingSource;
        private DataSet1TableAdapters.PacientiTableAdapter pacientiTableAdapter;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem istoricMedicalToolStripMenuItem;
        private System.Windows.Forms.BindingSource pacientiBindingSource1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtCNP;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Button btnConfirmare;
        private System.Windows.Forms.Button btnRenuntare;
        private System.Windows.Forms.DataGridViewTextBoxColumn numePacientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alergen;
        private System.Windows.Forms.Label lblAlergie;
        private System.Windows.Forms.BindingSource alergiiBindingSource;
        private DataSet1TableAdapters.AlergiiTableAdapter alergiiTableAdapter;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.TextBox txtIdPacient;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ComboBox cmbAlergie;
        private System.Windows.Forms.Button btnAdministrareAlergii;
    }
}