namespace Proiect
{
    partial class FStart
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
            this.lblTitlu = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.paciențiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rețeteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicamenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblParola = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.PB = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitlu.Location = new System.Drawing.Point(170, 103);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(0, 36);
            this.lblTitlu.TabIndex = 0;
            this.lblTitlu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paciențiToolStripMenuItem,
            this.rețeteToolStripMenuItem,
            this.medicamenteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // paciențiToolStripMenuItem
            // 
            this.paciențiToolStripMenuItem.Name = "paciențiToolStripMenuItem";
            this.paciențiToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.paciențiToolStripMenuItem.Text = "Pacienți";
            this.paciențiToolStripMenuItem.Click += new System.EventHandler(this.paciențiToolStripMenuItem_Click);
            // 
            // rețeteToolStripMenuItem
            // 
            this.rețeteToolStripMenuItem.Name = "rețeteToolStripMenuItem";
            this.rețeteToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.rețeteToolStripMenuItem.Text = "Rețete";
            this.rețeteToolStripMenuItem.Click += new System.EventHandler(this.rețeteToolStripMenuItem_Click);
            // 
            // medicamenteToolStripMenuItem
            // 
            this.medicamenteToolStripMenuItem.Name = "medicamenteToolStripMenuItem";
            this.medicamenteToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.medicamenteToolStripMenuItem.Text = "Medicamente";
            this.medicamenteToolStripMenuItem.Click += new System.EventHandler(this.medicamenteToolStripMenuItem_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(351, 441);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(111, 32);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(362, 361);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(100, 22);
            this.txtParola.TabIndex = 9;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(362, 312);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 22);
            this.txtUser.TabIndex = 8;
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblParola.Location = new System.Drawing.Point(282, 364);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(53, 16);
            this.lblParola.TabIndex = 7;
            this.lblParola.Text = "Parolă";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUser.Location = new System.Drawing.Point(267, 312);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(68, 16);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "Utilizator";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAutor.Location = new System.Drawing.Point(323, 203);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(0, 25);
            this.lblAutor.TabIndex = 10;
            // 
            // PB
            // 
            this.PB.Location = new System.Drawing.Point(314, 265);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(177, 147);
            this.PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB.TabIndex = 11;
            this.PB.TabStop = false;
            // 
            // FStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 556);
            this.Controls.Add(this.PB);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FStart";
            this.Text = "Aplicatie";
            this.Load += new System.EventHandler(this.FStart_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem paciențiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rețeteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicamenteToolStripMenuItem;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.PictureBox PB;
    }
}

