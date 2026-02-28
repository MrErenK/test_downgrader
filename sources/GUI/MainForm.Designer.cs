using System.Drawing;
using System.Windows.Forms;
using ReaLTaiizor.Controls;

namespace JetpackDowngraderGUI
{
    partial class MainForm
    {
        System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));

            this.button1 = new NightButton();
            this.buttonDownloadPatches = new NightButton();
            this.progressLabel = new NightLabel();
            this.GamePath = new NightTextBox();
            this.label1 = new NightLabel();
            this.checkBox1 = new CrownCheckBox();
            this.checkBox2 = new CrownCheckBox();
            this.checkBox3 = new CrownCheckBox();
            this.checkBox4 = new CrownCheckBox();
            this.checkBox5 = new CrownCheckBox();
            this.checkBox6 = new CrownCheckBox();
            this.checkBox7 = new CrownCheckBox();
            this.checkBox9 = new CrownCheckBox();
            this.button6 = new NightButton();
            this.button2 = new NightButton();
            this.button7 = new NightButton();
            this.darkTitle1 = new NightLabel();
            this.darkTitle2 = new NightLabel();
            this.HelloUser = new NightLabel();
            this.DSPanel = new System.Windows.Forms.Panel();
            this.ModsPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DSPanelHeader = new System.Windows.Forms.Panel();
            this.DSPanelHeaderLabel = new NightLabel();
            this.ModsPanelHeader = new System.Windows.Forms.Panel();
            this.ModsPanelHeaderLabel = new NightLabel();

            this.DSPanel.SuspendLayout();
            this.ModsPanel.SuspendLayout();
            this.DSPanelHeader.SuspendLayout();
            this.ModsPanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();

            // button1 (Downgrade)
            this.button1.Font = new Font("Arial", 9.75F);
            this.button1.Location = new Point(448, 15);
            this.button1.Name = "button1";
            this.button1.Size = new Size(166, 31);
            this.button1.TabIndex = 2;
            this.button1.TabStop = false;
            this.button1.Text = "3. Downgrade";
            this.button1.Click += new System.EventHandler(this.button1_Click);

            // buttonDownloadPatches
            this.buttonDownloadPatches.Font = new Font("Arial", 9.75F);
            this.buttonDownloadPatches.Location = new Point(448, 15);
            this.buttonDownloadPatches.Name = "buttonDownloadPatches";
            this.buttonDownloadPatches.Size = new Size(166, 31);
            this.buttonDownloadPatches.TabIndex = 3;
            this.buttonDownloadPatches.TabStop = false;
            this.buttonDownloadPatches.Text = "3. Download patches";
            this.buttonDownloadPatches.Visible = false;
            this.buttonDownloadPatches.Click += new System.EventHandler(this.buttonDownloadPatches_Click);

            // progressLabel
            this.progressLabel.AutoSize = false;
            this.progressLabel.Font = new Font("Arial", 8.25F);
            this.progressLabel.ForeColor = Color.LightGray;
            this.progressLabel.Location = new Point(448, 49);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new Size(166, 16);
            this.progressLabel.TabIndex = 20;
            this.progressLabel.Text = "";
            this.progressLabel.TextAlign = ContentAlignment.MiddleCenter;
            this.progressLabel.Visible = false;
            this.progressLabel.BackColor = Color.Transparent;

            // GamePath
            this.GamePath.Location = new Point(184, 43);
            this.GamePath.Name = "GamePath";
            this.GamePath.Size = new Size(600, 30);
            this.GamePath.TabIndex = 9;
            this.GamePath.TabStop = false;
            this.GamePath.Font = new Font("Arial", 9.75F);

            // label1 (Path to the game folder)
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Gadugi", 11.25F);
            this.label1.ForeColor = Color.LightGray;
            this.label1.Location = new Point(9, 47);
            this.label1.Name = "label1";
            this.label1.TabIndex = 12;
            this.label1.Text = "Path to the game folder:";
            this.label1.BackColor = Color.Transparent;

            // darkTitle1 (Recommended settings)
            this.darkTitle1.AutoSize = true;
            this.darkTitle1.Font = new Font("Gadugi", 11.25F);
            this.darkTitle1.ForeColor = Color.LightGray;
            this.darkTitle1.Location = new Point(133, 108);
            this.darkTitle1.Name = "darkTitle1";
            this.darkTitle1.TabIndex = 12;
            this.darkTitle1.Text = "Recommended settings";
            this.darkTitle1.BackColor = Color.Transparent;

            // darkTitle2 (Optional settings)
            this.darkTitle2.AutoSize = true;
            this.darkTitle2.Font = new Font("Gadugi", 11.25F);
            this.darkTitle2.ForeColor = Color.LightGray;
            this.darkTitle2.Location = new Point(570, 108);
            this.darkTitle2.Name = "darkTitle2";
            this.darkTitle2.TabIndex = 12;
            this.darkTitle2.Text = "Optional settings";
            this.darkTitle2.BackColor = Color.Transparent;

            // checkBox2 (Make shortcut on Desktop)
            this.checkBox2.Font = new Font("Arial", 9.75F);
            this.checkBox2.Location = new Point(53, 137);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new Size(220, 26);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.TabStop = false;
            this.checkBox2.Text = "Make shortcut on Desktop";
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);

            // checkBox9 (Remove GTA_SA.SET)
            this.checkBox9.Font = new Font("Arial", 9.75F);
            this.checkBox9.Location = new Point(53, 163);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new Size(430, 26);
            this.checkBox9.TabIndex = 11;
            this.checkBox9.TabStop = false;
            this.checkBox9.Text = "Remove GTA-SA.SET (Reset game settings and prevents crash)";
            this.checkBox9.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);

            // checkBox3 (Move game to another folder)
            this.checkBox3.Font = new Font("Arial", 9.75F);
            this.checkBox3.Location = new Point(53, 189);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new Size(430, 26);
            this.checkBox3.TabIndex = 11;
            this.checkBox3.TabStop = false;
            this.checkBox3.Text = "Move game to another folder (Prevents auto-update and rehash)";
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);

            // checkBox7 (DirectPlay)
            this.checkBox7.Font = new Font("Arial", 9.75F);
            this.checkBox7.Location = new Point(53, 215);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new Size(260, 26);
            this.checkBox7.TabIndex = 11;
            this.checkBox7.TabStop = false;
            this.checkBox7.Text = "DirectPlay (ONLY for Windows 10)";
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);

            // checkBox1 (Backup)
            this.checkBox1.Font = new Font("Arial", 9.75F);
            this.checkBox1.Location = new Point(501, 140);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new Size(280, 26);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.TabStop = false;
            this.checkBox1.Text = "Backup original files before downgrade";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);

            // checkBox4 (GarbageCleaning)
            this.checkBox4.Font = new Font("Arial", 9.75F);
            this.checkBox4.Location = new Point(501, 165);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new Size(310, 39);
            this.checkBox4.TabIndex = 11;
            this.checkBox4.TabStop = false;
            this.checkBox4.Text = "Remove unneeded files (ONLY for version from Rockstar Games Launcher)";
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);

            // checkBox6 (RegisterGamePath)
            this.checkBox6.Font = new Font("Arial", 9.75F);
            this.checkBox6.Location = new Point(501, 204);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new Size(280, 26);
            this.checkBox6.TabIndex = 11;
            this.checkBox6.TabStop = false;
            this.checkBox6.Text = "Register game path (Make game visible)";
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);

            // checkBox5 (Forced)
            this.checkBox5.Font = new Font("Arial", 9.75F);
            this.checkBox5.Location = new Point(501, 230);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new Size(220, 26);
            this.checkBox5.TabIndex = 11;
            this.checkBox5.TabStop = false;
            this.checkBox5.Text = "Forced (ONLY for version 1.0)";
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);

            // button6 (1. Downgrader Settings)
            this.button6.Font = new Font("Arial", 9.75F);
            this.button6.Location = new Point(107, 15);
            this.button6.Name = "button6";
            this.button6.Size = new Size(176, 31);
            this.button6.TabIndex = 8;
            this.button6.TabStop = false;
            this.button6.Text = "1. Downgrader Settings";
            this.button6.Click += new System.EventHandler(this.button6_Click);

            // button2 (2. Modifications)
            this.button2.Font = new Font("Arial", 9.75F);
            this.button2.Location = new Point(289, 15);
            this.button2.Name = "button2";
            this.button2.Size = new Size(153, 31);
            this.button2.TabIndex = 8;
            this.button2.TabStop = false;
            this.button2.Text = "2. Modifications";
            this.button2.Click += new System.EventHandler(this.button2_Click);

            // button7 (Edit settings manually)
            this.button7.Font = new Font("Arial", 9.75F);
            this.button7.Location = new Point(323, 283);
            this.button7.Name = "button7";
            this.button7.Size = new Size(167, 29);
            this.button7.TabIndex = 8;
            this.button7.TabStop = false;
            this.button7.Text = "Edit settings manually";
            this.button7.Click += new System.EventHandler(this.button7_Click);

            // DSPanelHeaderLabel
            this.DSPanelHeaderLabel.AutoSize = false;
            this.DSPanelHeaderLabel.Dock = DockStyle.Fill;
            this.DSPanelHeaderLabel.Font = new Font("Arial", 9F);
            this.DSPanelHeaderLabel.ForeColor = Color.LightGray;
            this.DSPanelHeaderLabel.Name = "DSPanelHeaderLabel";
            this.DSPanelHeaderLabel.Text = "Downgrader Settings";
            this.DSPanelHeaderLabel.TextAlign = ContentAlignment.MiddleLeft;
            this.DSPanelHeaderLabel.BackColor = Color.Transparent;
            this.DSPanelHeaderLabel.Padding = new Padding(6, 0, 0, 0);

            // DSPanelHeader
            this.DSPanelHeader.BackColor = Color.FromArgb(51, 54, 56);
            this.DSPanelHeader.Dock = DockStyle.Top;
            this.DSPanelHeader.Height = 25;
            this.DSPanelHeader.Name = "DSPanelHeader";
            this.DSPanelHeader.Controls.Add(this.DSPanelHeaderLabel);

            // ModsPanelHeaderLabel
            this.ModsPanelHeaderLabel.AutoSize = false;
            this.ModsPanelHeaderLabel.Dock = DockStyle.Fill;
            this.ModsPanelHeaderLabel.Font = new Font("Arial", 9F);
            this.ModsPanelHeaderLabel.ForeColor = Color.LightGray;
            this.ModsPanelHeaderLabel.Name = "ModsPanelHeaderLabel";
            this.ModsPanelHeaderLabel.Text = "Modifications";
            this.ModsPanelHeaderLabel.TextAlign = ContentAlignment.MiddleLeft;
            this.ModsPanelHeaderLabel.BackColor = Color.Transparent;
            this.ModsPanelHeaderLabel.Padding = new Padding(6, 0, 0, 0);

            // ModsPanelHeader
            this.ModsPanelHeader.BackColor = Color.FromArgb(51, 54, 56);
            this.ModsPanelHeader.Dock = DockStyle.Top;
            this.ModsPanelHeader.Height = 25;
            this.ModsPanelHeader.Name = "ModsPanelHeader";
            this.ModsPanelHeader.Controls.Add(this.ModsPanelHeaderLabel);

            // DSPanel
            this.DSPanel.BackColor = Color.FromArgb(60, 63, 65);
            this.DSPanel.BorderStyle = BorderStyle.FixedSingle;
            this.DSPanel.Location = new Point(12, 62);
            this.DSPanel.Name = "DSPanel";
            this.DSPanel.Size = new Size(834, 329);
            this.DSPanel.TabIndex = 14;
            this.DSPanel.Visible = false;
            this.DSPanel.Controls.Add(this.DSPanelHeader);
            this.DSPanel.Controls.Add(this.ModsPanel);
            this.DSPanel.Controls.Add(this.darkTitle1);
            this.DSPanel.Controls.Add(this.darkTitle2);
            this.DSPanel.Controls.Add(this.button7);
            this.DSPanel.Controls.Add(this.label1);
            this.DSPanel.Controls.Add(this.pictureBox1);
            this.DSPanel.Controls.Add(this.GamePath);
            this.DSPanel.Controls.Add(this.checkBox1);
            this.DSPanel.Controls.Add(this.checkBox2);
            this.DSPanel.Controls.Add(this.checkBox3);
            this.DSPanel.Controls.Add(this.checkBox4);
            this.DSPanel.Controls.Add(this.checkBox5);
            this.DSPanel.Controls.Add(this.checkBox6);
            this.DSPanel.Controls.Add(this.checkBox7);
            this.DSPanel.Controls.Add(this.checkBox9);

            // ModsPanel
            this.ModsPanel.BackColor = Color.FromArgb(60, 63, 65);
            this.ModsPanel.BorderStyle = BorderStyle.FixedSingle;
            this.ModsPanel.Location = new Point(0, 0);
            this.ModsPanel.Name = "ModsPanel";
            this.ModsPanel.Size = new Size(832, 327);
            this.ModsPanel.TabIndex = 15;
            this.ModsPanel.Visible = false;
            this.ModsPanel.Controls.Add(this.ModsPanelHeader);

            // pictureBox1 (folder icon)
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new Point(790, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(30, 30);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);

            // pictureBox3 (JPD icon)
            this.pictureBox3.Image = global::JetpackDowngraderGUI.Properties.Resources.JPD;
            this.pictureBox3.Location = new Point(752, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new Size(44, 34);
            this.pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);

            // pictureBox4 (GitHub icon)
            this.pictureBox4.Image = global::JetpackDowngraderGUI.Properties.Resources.GitHub;
            this.pictureBox4.Location = new Point(802, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new Size(44, 34);
            this.pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);

            // pictureBox5
            this.pictureBox5.Image = global::JetpackDowngraderGUI.Properties.Resources.Up;
            this.pictureBox5.Location = new Point(65, 69);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new Size(44, 39);
            this.pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;

            // pictureBox6
            this.pictureBox6.Image = global::JetpackDowngraderGUI.Properties.Resources.Up;
            this.pictureBox6.Location = new Point(247, 69);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new Size(44, 39);
            this.pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.TabStop = false;

            // pictureBox7
            this.pictureBox7.Image = global::JetpackDowngraderGUI.Properties.Resources.Up;
            this.pictureBox7.Location = new Point(409, 69);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new Size(44, 39);
            this.pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 13;
            this.pictureBox7.TabStop = false;

            // pictureBox8
            this.pictureBox8.Image = global::JetpackDowngraderGUI.Properties.Resources.Up;
            this.pictureBox8.Location = new Point(586, 69);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new Size(44, 39);
            this.pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 13;
            this.pictureBox8.TabStop = false;

            // HelloUser
            this.HelloUser.AutoSize = false;
            this.HelloUser.Font = new Font("Arial", 26.25F);
            this.HelloUser.ForeColor = Color.LightGray;
            this.HelloUser.Location = new Point(142, 142);
            this.HelloUser.Name = "HelloUser";
            this.HelloUser.Size = new Size(393, 46);
            this.HelloUser.TabIndex = 12;
            this.HelloUser.Text = "Select the desired stage";
            this.HelloUser.TextAlign = ContentAlignment.MiddleCenter;
            this.HelloUser.BackColor = Color.Transparent;

            // panel1 (top bar)
            this.panel1.BackColor = Color.FromArgb(51, 54, 56);
            this.panel1.BorderStyle = BorderStyle.None;
            this.panel1.Location = new Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(880, 60);
            this.panel1.TabIndex = 0;

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(60, 63, 65);
            this.ClientSize = new Size(859, 403);
            this.Controls.Add(this.DSPanel);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.HelloUser);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDownloadPatches);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = SizeGripStyle.Hide;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Jetpack GUI";
            this.Load += new System.EventHandler(this.MainForm_Load);


            this.DSPanel.ResumeLayout(false);
            this.DSPanel.PerformLayout();
            this.ModsPanel.ResumeLayout(false);
            this.DSPanelHeader.ResumeLayout(false);
            this.ModsPanelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
        }

        NightButton button1;
        NightButton buttonDownloadPatches;
        NightLabel progressLabel;
        NightTextBox GamePath;
        NightLabel label1;
        CrownCheckBox checkBox1;
        CrownCheckBox checkBox2;
        CrownCheckBox checkBox3;
        CrownCheckBox checkBox4;
        CrownCheckBox checkBox5;
        CrownCheckBox checkBox6;
        CrownCheckBox checkBox7;
        CrownCheckBox checkBox9;
        NightButton button6;
        NightButton button2;
        NightButton button7;
        NightLabel darkTitle1;
        NightLabel darkTitle2;
        NightLabel HelloUser;
        System.Windows.Forms.Panel DSPanel;
        System.Windows.Forms.Panel ModsPanel;
        System.Windows.Forms.Panel DSPanelHeader;
        NightLabel DSPanelHeaderLabel;
        System.Windows.Forms.Panel ModsPanelHeader;
        NightLabel ModsPanelHeaderLabel;
        System.Windows.Forms.PictureBox pictureBox1;
        System.Windows.Forms.PictureBox pictureBox3;
        System.Windows.Forms.PictureBox pictureBox4;
        System.Windows.Forms.PictureBox pictureBox5;
        System.Windows.Forms.PictureBox pictureBox6;
        System.Windows.Forms.PictureBox pictureBox7;
        System.Windows.Forms.PictureBox pictureBox8;
        System.Windows.Forms.Panel panel1;
    }
}
