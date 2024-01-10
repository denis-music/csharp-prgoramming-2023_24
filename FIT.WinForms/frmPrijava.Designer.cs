namespace FIT.WinForms
{
    partial class frmPrijava
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
            txtKorisnickoIme = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtLozinka = new TextBox();
            btnPrijava = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            err = new ErrorProvider(components);
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // txtKorisnickoIme
            // 
            txtKorisnickoIme.Location = new Point(241, 64);
            txtKorisnickoIme.Name = "txtKorisnickoIme";
            txtKorisnickoIme.Size = new Size(258, 23);
            txtKorisnickoIme.TabIndex = 0;
            txtKorisnickoIme.Text = "admin";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(241, 46);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 1;
            label1.Text = "Korisničko ime:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(241, 91);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 3;
            label2.Text = "Lozinka:";
            // 
            // txtLozinka
            // 
            txtLozinka.Location = new Point(241, 109);
            txtLozinka.Name = "txtLozinka";
            txtLozinka.PasswordChar = '*';
            txtLozinka.Size = new Size(258, 23);
            txtLozinka.TabIndex = 2;
            txtLozinka.Text = "admin";
            // 
            // btnPrijava
            // 
            btnPrijava.Location = new Point(424, 149);
            btnPrijava.Name = "btnPrijava";
            btnPrijava.Size = new Size(75, 23);
            btnPrijava.TabIndex = 4;
            btnPrijava.Text = "Prijava";
            btnPrijava.UseVisualStyleBackColor = true;
            btnPrijava.Click += btnPrijava_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_fit;
            pictureBox1.Location = new Point(12, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.BackColor = Color.Black;
            label3.Location = new Point(217, 35);
            label3.Name = "label3";
            label3.Size = new Size(1, 135);
            label3.TabIndex = 6;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(241, 153);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(104, 15);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Niste registrovani?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // frmPrijava
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 189);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(btnPrijava);
            Controls.Add(label2);
            Controls.Add(txtLozinka);
            Controls.Add(label1);
            Controls.Add(txtKorisnickoIme);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPrijava";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DLWMS :: Prijava";
            Load += frmPrijava_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKorisnickoIme;
        private Label label1;
        private Label label2;
        private TextBox txtLozinka;
        private Button btnPrijava;
        private PictureBox pictureBox1;
        private Label label3;
        private ErrorProvider err;
        private LinkLabel linkLabel1;
    }
}