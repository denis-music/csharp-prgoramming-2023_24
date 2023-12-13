namespace FIT.WinForms.Predmeti
{
    partial class frmPredmeti
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
            dgvPredmeti = new DataGridView();
            Naziv = new DataGridViewTextBoxColumn();
            Semestar = new DataGridViewTextBoxColumn();
            txtNaziv = new TextBox();
            cmbSemestar = new ComboBox();
            btnDodaj = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPredmeti).BeginInit();
            SuspendLayout();
            // 
            // dgvPredmeti
            // 
            dgvPredmeti.AllowUserToAddRows = false;
            dgvPredmeti.AllowUserToDeleteRows = false;
            dgvPredmeti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPredmeti.Columns.AddRange(new DataGridViewColumn[] { Naziv, Semestar });
            dgvPredmeti.Location = new Point(9, 66);
            dgvPredmeti.Name = "dgvPredmeti";
            dgvPredmeti.ReadOnly = true;
            dgvPredmeti.RowTemplate.Height = 25;
            dgvPredmeti.Size = new Size(390, 173);
            dgvPredmeti.TabIndex = 0;
            // 
            // Naziv
            // 
            Naziv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Naziv.DataPropertyName = "Naziv";
            Naziv.HeaderText = "Naziv";
            Naziv.Name = "Naziv";
            Naziv.ReadOnly = true;
            // 
            // Semestar
            // 
            Semestar.DataPropertyName = "Semestar";
            Semestar.HeaderText = "Semestar";
            Semestar.Name = "Semestar";
            Semestar.ReadOnly = true;
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(12, 37);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(204, 23);
            txtNaziv.TabIndex = 1;
            // 
            // cmbSemestar
            // 
            cmbSemestar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSemestar.FormattingEnabled = true;
            cmbSemestar.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8" });
            cmbSemestar.Location = new Point(222, 37);
            cmbSemestar.Name = "cmbSemestar";
            cmbSemestar.Size = new Size(74, 23);
            cmbSemestar.TabIndex = 2;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(302, 36);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(97, 23);
            btnDodaj.TabIndex = 3;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // frmPredmeti
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 251);
            Controls.Add(btnDodaj);
            Controls.Add(cmbSemestar);
            Controls.Add(txtNaziv);
            Controls.Add(dgvPredmeti);
            Name = "frmPredmeti";
            Text = "Predmeti";
            Load += frmPredmeti_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPredmeti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPredmeti;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewTextBoxColumn Semestar;
        private TextBox txtNaziv;
        private ComboBox cmbSemestar;
        private Button btnDodaj;
    }
}