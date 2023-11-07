namespace FIT.WinForms
{
    partial class frmRegistracija
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
            label2 = new Label();
            txtLozinka = new TextBox();
            label1 = new Label();
            txtKorisnickoIme = new TextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            cbAktivan = new CheckBox();
            groupBox2 = new GroupBox();
            txtEmail = new TextBox();
            label6 = new Label();
            txtPrezime = new TextBox();
            txtIme = new TextBox();
            label4 = new Label();
            label5 = new Label();
            btnSpasi = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 74);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 7;
            label2.Text = "Lozinka:";
            // 
            // txtLozinka
            // 
            txtLozinka.Location = new Point(18, 92);
            txtLozinka.Name = "txtLozinka";
            txtLozinka.Size = new Size(258, 23);
            txtLozinka.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 29);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 5;
            label1.Text = "Korisničko ime:";
            // 
            // txtKorisnickoIme
            // 
            txtKorisnickoIme.Location = new Point(18, 47);
            txtKorisnickoIme.Name = "txtKorisnickoIme";
            txtKorisnickoIme.Size = new Size(258, 23);
            txtKorisnickoIme.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_fit;
            pictureBox1.Location = new Point(22, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(186, 12);
            label3.Name = "label3";
            label3.Size = new Size(343, 84);
            label3.TabIndex = 9;
            label3.Text = "Univerzitet \"Džemal Bijedić\"\r\nFakultet informacijskih tehnologija\r\nwww.fit.ba";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbAktivan);
            groupBox1.Controls.Add(txtLozinka);
            groupBox1.Controls.Add(txtKorisnickoIme);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(337, 113);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(311, 157);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Korisnički podaci";
            // 
            // cbAktivan
            // 
            cbAktivan.AutoSize = true;
            cbAktivan.Location = new Point(20, 125);
            cbAktivan.Name = "cbAktivan";
            cbAktivan.Size = new Size(66, 19);
            cbAktivan.TabIndex = 8;
            cbAktivan.Text = "Aktivan";
            cbAktivan.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtEmail);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtPrezime);
            groupBox2.Controls.Add(txtIme);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(22, 113);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 183);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lični podaci";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(18, 140);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(258, 23);
            txtEmail.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 122);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 9;
            label6.Text = "Email:";
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(18, 92);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(258, 23);
            txtPrezime.TabIndex = 1;
            txtPrezime.TextChanged += txtPrezime_TextChanged;
            // 
            // txtIme
            // 
            txtIme.Location = new Point(18, 47);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(258, 23);
            txtIme.TabIndex = 0;
            txtIme.TextChanged += txtIme_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 29);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 5;
            label4.Text = "Ime:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 74);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 7;
            label5.Text = "Prezime:";
            // 
            // btnSpasi
            // 
            btnSpasi.Location = new Point(573, 273);
            btnSpasi.Name = "btnSpasi";
            btnSpasi.Size = new Size(75, 23);
            btnSpasi.TabIndex = 1;
            btnSpasi.Text = "Spasi";
            btnSpasi.UseVisualStyleBackColor = true;
            btnSpasi.Click += btnSpasi_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmRegistracija
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 312);
            Controls.Add(btnSpasi);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Name = "frmRegistracija";
            Text = "frmRegistracija";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtLozinka;
        private TextBox txtPrezime;

        private Label label1;
        private TextBox txtKorisnickoIme;
        private PictureBox pictureBox1;
        private Label label3;
        private GroupBox groupBox1;
        private CheckBox cbAktivan;
        private GroupBox groupBox2;
        private CheckBox checkBox1;
        private TextBox textBox1;
        private TextBox txtIme;
        private Label label4;
        private Label label5;
        private TextBox txtEmail;
        private Label label6;
        private Button btnSpasi;
        private ErrorProvider errorProvider1;
    }
}