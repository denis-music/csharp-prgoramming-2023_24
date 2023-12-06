namespace FIT.WinForms.Studenti
{
    partial class frmStudentiPretraga
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
            dgvStudenti = new DataGridView();
            btnNoviStudent = new Button();
            txtFilter = new TextBox();
            Indeks = new DataGridViewTextBoxColumn();
            Ime = new DataGridViewTextBoxColumn();
            Prezime = new DataGridViewTextBoxColumn();
            DatumRodjenja = new DataGridViewTextBoxColumn();
            Semestar = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            Polozeni = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).BeginInit();
            SuspendLayout();
            // 
            // dgvStudenti
            // 
            dgvStudenti.AllowUserToAddRows = false;
            dgvStudenti.AllowUserToDeleteRows = false;
            dgvStudenti.AllowUserToOrderColumns = true;
            dgvStudenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudenti.Columns.AddRange(new DataGridViewColumn[] { Indeks, Ime, Prezime, DatumRodjenja, Semestar, Aktivan, Polozeni });
            dgvStudenti.Location = new Point(12, 50);
            dgvStudenti.Name = "dgvStudenti";
            dgvStudenti.ReadOnly = true;
            dgvStudenti.RowTemplate.Height = 25;
            dgvStudenti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudenti.Size = new Size(757, 244);
            dgvStudenti.TabIndex = 0;
            dgvStudenti.CellContentClick += dgvStudenti_CellContentClick;
            // 
            // btnNoviStudent
            // 
            btnNoviStudent.Location = new Point(678, 21);
            btnNoviStudent.Name = "btnNoviStudent";
            btnNoviStudent.Size = new Size(91, 23);
            btnNoviStudent.TabIndex = 1;
            btnNoviStudent.Text = "Novi student";
            btnNoviStudent.UseVisualStyleBackColor = true;
            btnNoviStudent.Click += btnNoviStudent_Click;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(12, 22);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(660, 23);
            txtFilter.TabIndex = 2;
            txtFilter.TextChanged += txtFilter_TextChanged;
            // 
            // Indeks
            // 
            Indeks.DataPropertyName = "Indeks";
            Indeks.HeaderText = "Indeksa";
            Indeks.Name = "Indeks";
            Indeks.ReadOnly = true;
            // 
            // Ime
            // 
            Ime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ime.DataPropertyName = "Ime";
            Ime.HeaderText = "Ime";
            Ime.Name = "Ime";
            Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            Prezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Prezime.DataPropertyName = "Prezime";
            Prezime.HeaderText = "Prezime";
            Prezime.Name = "Prezime";
            Prezime.ReadOnly = true;
            // 
            // DatumRodjenja
            // 
            DatumRodjenja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatumRodjenja.DataPropertyName = "DatumRodjenja";
            DatumRodjenja.HeaderText = "Datum rođenja";
            DatumRodjenja.Name = "DatumRodjenja";
            DatumRodjenja.ReadOnly = true;
            // 
            // Semestar
            // 
            Semestar.DataPropertyName = "Semestar";
            Semestar.HeaderText = "Semestar";
            Semestar.Name = "Semestar";
            Semestar.ReadOnly = true;
            // 
            // Aktivan
            // 
            Aktivan.DataPropertyName = "Aktivan";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            // 
            // Polozeni
            // 
            Polozeni.HeaderText = "";
            Polozeni.Name = "Polozeni";
            Polozeni.ReadOnly = true;
            Polozeni.Text = "Predmeti";
            Polozeni.UseColumnTextForButtonValue = true;
            // 
            // frmStudentiPretraga
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 308);
            Controls.Add(txtFilter);
            Controls.Add(btnNoviStudent);
            Controls.Add(dgvStudenti);
            Name = "frmStudentiPretraga";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pretraga studenata";
            Load += frmStudentiPretraga_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudenti;
        private Button btnNoviStudent;
        private TextBox txtFilter;
        private DataGridViewTextBoxColumn Indeks;
        private DataGridViewTextBoxColumn Ime;
        private DataGridViewTextBoxColumn Prezime;
        private DataGridViewTextBoxColumn DatumRodjenja;
        private DataGridViewTextBoxColumn Semestar;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn Polozeni;
    }
}