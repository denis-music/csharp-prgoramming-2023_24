namespace FIT.WinForms
{
    partial class frmGlavna
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            studentiToolStripMenuItem = new ToolStripMenuItem();
            noviStudentToolStripMenuItem = new ToolStripMenuItem();
            pretragaStudenataToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            odjavaToolStripMenuItem = new ToolStripMenuItem();
            krajRadaToolStripMenuItem = new ToolStripMenuItem();
            igreToolStripMenuItem = new ToolStripMenuItem();
            xOToolStripMenuItem = new ToolStripMenuItem();
            infoToolStripMenuItem = new ToolStripMenuItem();
            oProgramuToolStripMenuItem = new ToolStripMenuItem();
            ažuriranjeToolStripMenuItem = new ToolStripMenuItem();
            pomoToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            tslImePrezime = new ToolStripStatusLabel();
            tslDatumVrijeme = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, igreToolStripMenuItem, infoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(859, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { studentiToolStripMenuItem, toolStripSeparator1, odjavaToolStripMenuItem, krajRadaToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // studentiToolStripMenuItem
            // 
            studentiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { noviStudentToolStripMenuItem, pretragaStudenataToolStripMenuItem });
            studentiToolStripMenuItem.Name = "studentiToolStripMenuItem";
            studentiToolStripMenuItem.Size = new Size(120, 22);
            studentiToolStripMenuItem.Text = "Studenti";
            // 
            // noviStudentToolStripMenuItem
            // 
            noviStudentToolStripMenuItem.Name = "noviStudentToolStripMenuItem";
            noviStudentToolStripMenuItem.Size = new Size(173, 22);
            noviStudentToolStripMenuItem.Text = "Novi student";
            noviStudentToolStripMenuItem.Click += noviStudentToolStripMenuItem_Click;
            // 
            // pretragaStudenataToolStripMenuItem
            // 
            pretragaStudenataToolStripMenuItem.Name = "pretragaStudenataToolStripMenuItem";
            pretragaStudenataToolStripMenuItem.Size = new Size(173, 22);
            pretragaStudenataToolStripMenuItem.Text = "Pretraga studenata";
            pretragaStudenataToolStripMenuItem.Click += pretragaStudenataToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(117, 6);
            // 
            // odjavaToolStripMenuItem
            // 
            odjavaToolStripMenuItem.Name = "odjavaToolStripMenuItem";
            odjavaToolStripMenuItem.Size = new Size(120, 22);
            odjavaToolStripMenuItem.Text = "Odjava";
            odjavaToolStripMenuItem.Click += odjavaToolStripMenuItem_Click;
            // 
            // krajRadaToolStripMenuItem
            // 
            krajRadaToolStripMenuItem.Name = "krajRadaToolStripMenuItem";
            krajRadaToolStripMenuItem.Size = new Size(120, 22);
            krajRadaToolStripMenuItem.Text = "Kraj rada";
            krajRadaToolStripMenuItem.Click += krajRadaToolStripMenuItem_Click;
            // 
            // igreToolStripMenuItem
            // 
            igreToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { xOToolStripMenuItem });
            igreToolStripMenuItem.Name = "igreToolStripMenuItem";
            igreToolStripMenuItem.Size = new Size(39, 20);
            igreToolStripMenuItem.Text = "Igre";
            // 
            // xOToolStripMenuItem
            // 
            xOToolStripMenuItem.Name = "xOToolStripMenuItem";
            xOToolStripMenuItem.Size = new Size(90, 22);
            xOToolStripMenuItem.Text = "XO";
            xOToolStripMenuItem.Click += xOToolStripMenuItem_Click;
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { oProgramuToolStripMenuItem, ažuriranjeToolStripMenuItem, pomoToolStripMenuItem });
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(40, 20);
            infoToolStripMenuItem.Text = "Info";
            // 
            // oProgramuToolStripMenuItem
            // 
            oProgramuToolStripMenuItem.Name = "oProgramuToolStripMenuItem";
            oProgramuToolStripMenuItem.Size = new Size(139, 22);
            oProgramuToolStripMenuItem.Text = "O programu";
            oProgramuToolStripMenuItem.Click += oProgramuToolStripMenuItem_Click;
            // 
            // ažuriranjeToolStripMenuItem
            // 
            ažuriranjeToolStripMenuItem.Name = "ažuriranjeToolStripMenuItem";
            ažuriranjeToolStripMenuItem.Size = new Size(139, 22);
            ažuriranjeToolStripMenuItem.Text = "Ažuriranje";
            // 
            // pomoToolStripMenuItem
            // 
            pomoToolStripMenuItem.Name = "pomoToolStripMenuItem";
            pomoToolStripMenuItem.Size = new Size(139, 22);
            pomoToolStripMenuItem.Text = "Pomoć";
            pomoToolStripMenuItem.Click += pomoToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tslImePrezime, tslDatumVrijeme });
            statusStrip1.Location = new Point(0, 492);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(859, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // tslImePrezime
            // 
            tslImePrezime.Name = "tslImePrezime";
            tslImePrezime.Size = new Size(118, 17);
            tslImePrezime.Text = "toolStripStatusLabel1";
            // 
            // tslDatumVrijeme
            // 
            tslDatumVrijeme.Name = "tslDatumVrijeme";
            tslDatumVrijeme.Size = new Size(118, 17);
            tslDatumVrijeme.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // frmGlavna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 514);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmGlavna";
            Text = "DLWMS v.1.4";
            WindowState = FormWindowState.Maximized;
            Load += frmGlavna_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem studentiToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem krajRadaToolStripMenuItem;
        private ToolStripMenuItem noviStudentToolStripMenuItem;
        private ToolStripMenuItem pretragaStudenataToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tslImePrezime;
        private ToolStripMenuItem odjavaToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private ToolStripStatusLabel tslDatumVrijeme;
        private ToolStripMenuItem igreToolStripMenuItem;
        private ToolStripMenuItem xOToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem;
        private ToolStripMenuItem oProgramuToolStripMenuItem;
        private ToolStripMenuItem pomoToolStripMenuItem;
        private ToolStripMenuItem ažuriranjeToolStripMenuItem;
    }
}