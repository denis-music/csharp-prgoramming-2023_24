namespace FIT.WinForms.Predavanja
{
    partial class frmMarketing
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
            button1 = new Button();
            txtPoruka = new TextBox();
            cbBHTelecom = new CheckBox();
            cbHTEronet = new CheckBox();
            cbMTel = new CheckBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(363, 168);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Posalji";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtPoruka
            // 
            txtPoruka.Location = new Point(12, 12);
            txtPoruka.Multiline = true;
            txtPoruka.Name = "txtPoruka";
            txtPoruka.Size = new Size(426, 150);
            txtPoruka.TabIndex = 1;
            // 
            // cbBHTelecom
            // 
            cbBHTelecom.AutoSize = true;
            cbBHTelecom.Location = new Point(12, 168);
            cbBHTelecom.Name = "cbBHTelecom";
            cbBHTelecom.Size = new Size(89, 19);
            cbBHTelecom.TabIndex = 2;
            cbBHTelecom.Text = "BH Telecom";
            cbBHTelecom.UseVisualStyleBackColor = true;
            cbBHTelecom.CheckedChanged += cbBHTelecom_CheckedChanged;
            // 
            // cbHTEronet
            // 
            cbHTEronet.AutoSize = true;
            cbHTEronet.Location = new Point(107, 168);
            cbHTEronet.Name = "cbHTEronet";
            cbHTEronet.Size = new Size(78, 19);
            cbHTEronet.TabIndex = 3;
            cbHTEronet.Text = "HT Eronet";
            cbHTEronet.UseVisualStyleBackColor = true;
            cbHTEronet.CheckedChanged += cbHTEronet_CheckedChanged;
            // 
            // cbMTel
            // 
            cbMTel.AutoSize = true;
            cbMTel.Location = new Point(202, 168);
            cbMTel.Name = "cbMTel";
            cbMTel.Size = new Size(51, 19);
            cbMTel.TabIndex = 4;
            cbMTel.Text = "mTel";
            cbMTel.UseVisualStyleBackColor = true;
            cbMTel.CheckedChanged += cbMTel_CheckedChanged;
            // 
            // frmMarketing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 202);
            Controls.Add(cbMTel);
            Controls.Add(cbHTEronet);
            Controls.Add(cbBHTelecom);
            Controls.Add(txtPoruka);
            Controls.Add(button1);
            Name = "frmMarketing";
            Text = "frmMarketing";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtPoruka;
        private CheckBox cbBHTelecom;
        private CheckBox cbHTEronet;
        private CheckBox cbMTel;
    }
}