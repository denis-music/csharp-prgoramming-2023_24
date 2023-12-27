namespace FIT.WinForms.Studenti
{
    partial class frmStudentiPredmeti
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
            components = new System.ComponentModel.Container();
            dgvPolozeniPredmeti = new DataGridView();
            Predmet = new DataGridViewTextBoxColumn();
            DatumPolaganja = new DataGridViewTextBoxColumn();
            Ocjena = new DataGridViewTextBoxColumn();
            cmbPredmeti = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            cmbOcjene = new ComboBox();
            dtpDatumPolaganja = new DateTimePicker();
            label3 = new Label();
            btnDodaj = new Button();
            errorProvider1 = new ErrorProvider(components);
            lblIndeks = new Label();
            pbSlika = new PictureBox();
            lblImePrezime = new Label();
            btnPrint = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPolozeniPredmeti).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            SuspendLayout();
            // 
            // dgvPolozeniPredmeti
            // 
            dgvPolozeniPredmeti.AllowUserToAddRows = false;
            dgvPolozeniPredmeti.AllowUserToDeleteRows = false;
            dgvPolozeniPredmeti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPolozeniPredmeti.Columns.AddRange(new DataGridViewColumn[] { Predmet, DatumPolaganja, Ocjena });
            dgvPolozeniPredmeti.Location = new Point(12, 170);
            dgvPolozeniPredmeti.Name = "dgvPolozeniPredmeti";
            dgvPolozeniPredmeti.ReadOnly = true;
            dgvPolozeniPredmeti.RowTemplate.Height = 25;
            dgvPolozeniPredmeti.Size = new Size(541, 150);
            dgvPolozeniPredmeti.TabIndex = 0;
            // 
            // Predmet
            // 
            Predmet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Predmet.DataPropertyName = "Predmet";
            Predmet.HeaderText = "Predmet";
            Predmet.Name = "Predmet";
            Predmet.ReadOnly = true;
            // 
            // DatumPolaganja
            // 
            DatumPolaganja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatumPolaganja.DataPropertyName = "DatumPolaganja";
            DatumPolaganja.HeaderText = "Datum polaganja";
            DatumPolaganja.Name = "DatumPolaganja";
            DatumPolaganja.ReadOnly = true;
            // 
            // Ocjena
            // 
            Ocjena.DataPropertyName = "Ocjena";
            Ocjena.HeaderText = "Ocjena";
            Ocjena.Name = "Ocjena";
            Ocjena.ReadOnly = true;
            // 
            // cmbPredmeti
            // 
            cmbPredmeti.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPredmeti.FormattingEnabled = true;
            cmbPredmeti.Location = new Point(12, 141);
            cmbPredmeti.Name = "cmbPredmeti";
            cmbPredmeti.Size = new Size(166, 23);
            cmbPredmeti.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 122);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 2;
            label1.Text = "Predmet:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(184, 122);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 4;
            label2.Text = "Ocjena:";
            // 
            // cmbOcjene
            // 
            cmbOcjene.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOcjene.FormattingEnabled = true;
            cmbOcjene.Items.AddRange(new object[] { "6", "7", "8", "9", "10" });
            cmbOcjene.Location = new Point(186, 141);
            cmbOcjene.Name = "cmbOcjene";
            cmbOcjene.Size = new Size(80, 23);
            cmbOcjene.TabIndex = 3;
            // 
            // dtpDatumPolaganja
            // 
            dtpDatumPolaganja.Location = new Point(272, 141);
            dtpDatumPolaganja.Name = "dtpDatumPolaganja";
            dtpDatumPolaganja.Size = new Size(200, 23);
            dtpDatumPolaganja.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(272, 123);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 6;
            label3.Text = "Datum polaganja:";
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(478, 141);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(75, 23);
            btnDodaj.TabIndex = 7;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // lblIndeks
            // 
            lblIndeks.AutoSize = true;
            lblIndeks.Font = new Font("Segoe UI", 20F);
            lblIndeks.Location = new Point(123, 18);
            lblIndeks.Name = "lblIndeks";
            lblIndeks.Size = new Size(0, 37);
            lblIndeks.TabIndex = 8;
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(10, 12);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(100, 96);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 9;
            pbSlika.TabStop = false;
            // 
            // lblImePrezime
            // 
            lblImePrezime.AutoSize = true;
            lblImePrezime.Font = new Font("Segoe UI", 13F);
            lblImePrezime.Location = new Point(123, 68);
            lblImePrezime.Name = "lblImePrezime";
            lblImePrezime.Size = new Size(0, 25);
            lblImePrezime.TabIndex = 10;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(436, 326);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(117, 23);
            btnPrint.TabIndex = 11;
            btnPrint.Text = "Printaj uvjerenje";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // frmStudentiPredmeti
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 359);
            Controls.Add(btnPrint);
            Controls.Add(lblImePrezime);
            Controls.Add(pbSlika);
            Controls.Add(lblIndeks);
            Controls.Add(btnDodaj);
            Controls.Add(label3);
            Controls.Add(dtpDatumPolaganja);
            Controls.Add(label2);
            Controls.Add(cmbOcjene);
            Controls.Add(label1);
            Controls.Add(cmbPredmeti);
            Controls.Add(dgvPolozeniPredmeti);
            Name = "frmStudentiPredmeti";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Uspjeha studenta";
            Load += frmStudentiPredmeti_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPolozeniPredmeti).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPolozeniPredmeti;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn DatumPolaganja;
        private DataGridViewTextBoxColumn Ocjena;
        private ComboBox cmbPredmeti;
        private Label label1;
        private Label label2;
        private ComboBox cmbOcjene;
        private DateTimePicker dtpDatumPolaganja;
        private Label label3;
        private Button btnDodaj;
        private ErrorProvider errorProvider1;
        private Label lblIndeks;
        private PictureBox pbSlika;
        private Label lblImePrezime;
        private Button btnPrint;
    }
}