namespace Proiect
{
    partial class FAlergie
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idAlergieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alergenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alergiiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Proiect.DataSet1();
            this.alergiiTableAdapter = new Proiect.DataSet1TableAdapters.AlergiiTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.btnActualizare = new System.Windows.Forms.Button();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.btnSelectie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alergiiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAlergieDataGridViewTextBoxColumn,
            this.alergenDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.alergiiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(197, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(389, 183);
            this.dataGridView1.TabIndex = 0;
            // 
            // idAlergieDataGridViewTextBoxColumn
            // 
            this.idAlergieDataGridViewTextBoxColumn.DataPropertyName = "IdAlergie";
            this.idAlergieDataGridViewTextBoxColumn.HeaderText = "IdAlergie";
            this.idAlergieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idAlergieDataGridViewTextBoxColumn.Name = "idAlergieDataGridViewTextBoxColumn";
            this.idAlergieDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAlergieDataGridViewTextBoxColumn.Width = 125;
            // 
            // alergenDataGridViewTextBoxColumn
            // 
            this.alergenDataGridViewTextBoxColumn.DataPropertyName = "Alergen";
            this.alergenDataGridViewTextBoxColumn.HeaderText = "Alergen";
            this.alergenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alergenDataGridViewTextBoxColumn.Name = "alergenDataGridViewTextBoxColumn";
            this.alergenDataGridViewTextBoxColumn.ReadOnly = true;
            this.alergenDataGridViewTextBoxColumn.Width = 125;
            // 
            // alergiiBindingSource
            // 
            this.alergiiBindingSource.DataMember = "Alergii";
            this.alergiiBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alergiiTableAdapter
            // 
            this.alergiiTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(216, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lista de alergii ale pacienților";
            // 
            // btnActualizare
            // 
            this.btnActualizare.Location = new System.Drawing.Point(197, 340);
            this.btnActualizare.Name = "btnActualizare";
            this.btnActualizare.Size = new System.Drawing.Size(117, 30);
            this.btnActualizare.TabIndex = 1;
            this.btnActualizare.Text = "Actualizare";
            this.btnActualizare.UseVisualStyleBackColor = true;
            this.btnActualizare.Click += new System.EventHandler(this.btnActualizare_Click);
            // 
            // btnSalvare
            // 
            this.btnSalvare.Location = new System.Drawing.Point(345, 340);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(119, 30);
            this.btnSalvare.TabIndex = 2;
            this.btnSalvare.Text = "Salvare";
            this.btnSalvare.UseVisualStyleBackColor = true;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.Location = new System.Drawing.Point(494, 340);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(119, 29);
            this.btnRenuntare.TabIndex = 3;
            this.btnRenuntare.Text = "Renuntare";
            this.btnRenuntare.UseVisualStyleBackColor = true;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click);
            // 
            // btnSelectie
            // 
            this.btnSelectie.Location = new System.Drawing.Point(347, 340);
            this.btnSelectie.Name = "btnSelectie";
            this.btnSelectie.Size = new System.Drawing.Size(117, 30);
            this.btnSelectie.TabIndex = 5;
            this.btnSelectie.Text = "Selecție";
            this.btnSelectie.UseVisualStyleBackColor = true;
            this.btnSelectie.Click += new System.EventHandler(this.btnSelectie_Click);
            // 
            // FAlergie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSelectie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.btnActualizare);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FAlergie";
            this.Text = "Alergii";
            this.Load += new System.EventHandler(this.FAlergie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alergiiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource alergiiBindingSource;
        private DataSet1TableAdapters.AlergiiTableAdapter alergiiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlergieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alergenDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnActualizare;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.Button btnRenuntare;
        private System.Windows.Forms.Button btnSelectie;
    }
}