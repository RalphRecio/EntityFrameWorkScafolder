namespace EntityFrameWorkScafolder
{
    partial class frmMain
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
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtserver = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtdatabase = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.rchoutconnection = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chckforce = new System.Windows.Forms.CheckBox();
            this.chcMultiActRes = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtfldname = new System.Windows.Forms.TextBox();
            this.chcktrustcert = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pnlscaffold = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlscaffold.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(565, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Scaffold";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Project name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtserver
            // 
            this.txtserver.Location = new System.Drawing.Point(91, 39);
            this.txtserver.Name = "txtserver";
            this.txtserver.Size = new System.Drawing.Size(291, 27);
            this.txtserver.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Server :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Username : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtdatabase);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.txtpassword);
            this.groupBox1.Controls.Add(this.txtusername);
            this.groupBox1.Controls.Add(this.txtserver);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(3, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 222);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server Credentials";
            // 
            // txtdatabase
            // 
            this.txtdatabase.Location = new System.Drawing.Point(91, 75);
            this.txtdatabase.Name = "txtdatabase";
            this.txtdatabase.Size = new System.Drawing.Size(291, 27);
            this.txtdatabase.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Database :";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(286, 174);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 29);
            this.button3.TabIndex = 12;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(91, 141);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(291, 27);
            this.txtpassword.TabIndex = 10;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(91, 108);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(291, 27);
            this.txtusername.TabIndex = 9;
            // 
            // rchoutconnection
            // 
            this.rchoutconnection.Location = new System.Drawing.Point(3, 331);
            this.rchoutconnection.Name = "rchoutconnection";
            this.rchoutconnection.ReadOnly = true;
            this.rchoutconnection.Size = new System.Drawing.Size(656, 140);
            this.rchoutconnection.TabIndex = 10;
            this.rchoutconnection.Text = "";
            this.rchoutconnection.TextChanged += new System.EventHandler(this.rchoutconnection_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chckforce);
            this.groupBox2.Controls.Add(this.chcMultiActRes);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtfldname);
            this.groupBox2.Controls.Add(this.chcktrustcert);
            this.groupBox2.Location = new System.Drawing.Point(405, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 222);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // chckforce
            // 
            this.chckforce.AutoSize = true;
            this.chckforce.Checked = true;
            this.chckforce.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckforce.Location = new System.Drawing.Point(8, 148);
            this.chckforce.Name = "chckforce";
            this.chckforce.Size = new System.Drawing.Size(67, 24);
            this.chckforce.TabIndex = 9;
            this.chckforce.Text = "Force";
            this.chckforce.UseVisualStyleBackColor = true;
            // 
            // chcMultiActRes
            // 
            this.chcMultiActRes.AutoSize = true;
            this.chcMultiActRes.Checked = true;
            this.chcMultiActRes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chcMultiActRes.Location = new System.Drawing.Point(8, 118);
            this.chcMultiActRes.Name = "chcMultiActRes";
            this.chcMultiActRes.Size = new System.Drawing.Size(206, 24);
            this.chcMultiActRes.TabIndex = 8;
            this.chcMultiActRes.Text = "Multiple Active Result Sets";
            this.chcMultiActRes.UseVisualStyleBackColor = true;
            this.chcMultiActRes.CheckedChanged += new System.EventHandler(this.chcMultiActRes_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Output Folder :";
            // 
            // txtfldname
            // 
            this.txtfldname.Location = new System.Drawing.Point(122, 39);
            this.txtfldname.Name = "txtfldname";
            this.txtfldname.Size = new System.Drawing.Size(125, 27);
            this.txtfldname.TabIndex = 1;
            this.txtfldname.Text = "Models";
            // 
            // chcktrustcert
            // 
            this.chcktrustcert.AutoSize = true;
            this.chcktrustcert.Checked = true;
            this.chcktrustcert.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chcktrustcert.Location = new System.Drawing.Point(8, 88);
            this.chcktrustcert.Name = "chcktrustcert";
            this.chcktrustcert.Size = new System.Drawing.Size(196, 24);
            this.chcktrustcert.TabIndex = 0;
            this.chcktrustcert.Text = "Trusted Server Certificate";
            this.chcktrustcert.UseVisualStyleBackColor = true;
            this.chcktrustcert.CheckedChanged += new System.EventHandler(this.chcktrustcert_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.exitToolStripMenuItem.Text = "Manage Projects";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(202, 26);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(637, 28);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pnlscaffold
            // 
            this.pnlscaffold.Controls.Add(this.groupBox3);
            this.pnlscaffold.Controls.Add(this.button1);
            this.pnlscaffold.Controls.Add(this.groupBox2);
            this.pnlscaffold.Controls.Add(this.rchoutconnection);
            this.pnlscaffold.Controls.Add(this.groupBox1);
            this.pnlscaffold.Location = new System.Drawing.Point(6, 32);
            this.pnlscaffold.MaximumSize = new System.Drawing.Size(672, 533);
            this.pnlscaffold.Name = "pnlscaffold";
            this.pnlscaffold.Size = new System.Drawing.Size(672, 533);
            this.pnlscaffold.TabIndex = 14;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Location = new System.Drawing.Point(9, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(650, 92);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 570);
            this.Controls.Add(this.pnlscaffold);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Net Core Scaffold";
            this.Load += new System.EventHandler(this.frmMain_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlscaffold.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private OpenFileDialog openFileDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label label1;
        private TextBox txtserver;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private TextBox txtpassword;
        private TextBox txtusername;
        private RichTextBox rchoutconnection;
        private Button button3;
        private GroupBox groupBox2;
        private Label label5;
        private TextBox txtfldname;
        private CheckBox chcktrustcert;
        private CheckBox chcMultiActRes;
        private TextBox txtdatabase;
        private Label label6;
        private CheckBox chckforce;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private ComboBox comboBox1;
        private Panel pnlscaffold;
        private GroupBox groupBox3;
    }
}