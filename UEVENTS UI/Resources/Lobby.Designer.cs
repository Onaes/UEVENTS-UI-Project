namespace UEVENTS_UI.Resources
{
    partial class Lobby
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBoxSearch = new PictureBox();
            pictureBoxAccount = new PictureBox();
            pictureBoxCalendar = new PictureBox();
            pictureBox2 = new PictureBox();
            labelAccount = new Label();
            labelSearch = new Label();
            labelNotification = new Label();
            labelCalendar = new Label();
            labelSettings = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAccount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCalendar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(labelSettings);
            panel1.Controls.Add(labelCalendar);
            panel1.Controls.Add(labelNotification);
            panel1.Controls.Add(labelSearch);
            panel1.Controls.Add(labelAccount);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBoxCalendar);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBoxSearch);
            panel1.Controls.Add(pictureBoxAccount);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(103, 449);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.notification;
            pictureBox1.Location = new Point(20, 192);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBoxSearch
            // 
            pictureBoxSearch.Image = Properties.Resources.search;
            pictureBoxSearch.Location = new Point(20, 111);
            pictureBoxSearch.Name = "pictureBoxSearch";
            pictureBoxSearch.Size = new Size(58, 52);
            pictureBoxSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxSearch.TabIndex = 1;
            pictureBoxSearch.TabStop = false;
            // 
            // pictureBoxAccount
            // 
            pictureBoxAccount.Image = Properties.Resources.Hidden_King_Griddy;
            pictureBoxAccount.Location = new Point(20, 11);
            pictureBoxAccount.Name = "pictureBoxAccount";
            pictureBoxAccount.Size = new Size(58, 48);
            pictureBoxAccount.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAccount.TabIndex = 1;
            pictureBoxAccount.TabStop = false;
            // 
            // pictureBoxCalendar
            // 
            pictureBoxCalendar.Image = Properties.Resources.calendar;
            pictureBoxCalendar.Location = new Point(12, 270);
            pictureBoxCalendar.Name = "pictureBoxCalendar";
            pictureBoxCalendar.Size = new Size(68, 58);
            pictureBoxCalendar.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCalendar.TabIndex = 1;
            pictureBoxCalendar.TabStop = false;
            pictureBoxCalendar.Click += pictureBox2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.settings;
            pictureBox2.Location = new Point(12, 355);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // labelAccount
            // 
            labelAccount.AutoSize = true;
            labelAccount.ForeColor = Color.White;
            labelAccount.Location = new Point(26, 73);
            labelAccount.Name = "labelAccount";
            labelAccount.Size = new Size(52, 15);
            labelAccount.TabIndex = 1;
            labelAccount.Text = "Account";
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.ForeColor = Color.White;
            labelSearch.Location = new Point(26, 166);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(42, 15);
            labelSearch.TabIndex = 2;
            labelSearch.Text = "Search";
            // 
            // labelNotification
            // 
            labelNotification.AutoSize = true;
            labelNotification.ForeColor = Color.White;
            labelNotification.Location = new Point(12, 245);
            labelNotification.Name = "labelNotification";
            labelNotification.Size = new Size(70, 15);
            labelNotification.TabIndex = 2;
            labelNotification.Text = "Notification";
            // 
            // labelCalendar
            // 
            labelCalendar.AutoSize = true;
            labelCalendar.ForeColor = Color.White;
            labelCalendar.Location = new Point(20, 331);
            labelCalendar.Name = "labelCalendar";
            labelCalendar.Size = new Size(54, 15);
            labelCalendar.TabIndex = 2;
            labelCalendar.Text = "Calendar";
            // 
            // labelSettings
            // 
            labelSettings.AutoSize = true;
            labelSettings.ForeColor = Color.White;
            labelSettings.Location = new Point(16, 410);
            labelSettings.Name = "labelSettings";
            labelSettings.Size = new Size(49, 15);
            labelSettings.TabIndex = 2;
            labelSettings.Text = "Settings";
            // 
            // Lobby
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Lobby";
            Text = "Lobby";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAccount).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCalendar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBoxAccount;
        private PictureBox pictureBox1;
        private PictureBox pictureBoxSearch;
        private PictureBox pictureBoxCalendar;
        private Label labelAccount;
        private PictureBox pictureBox2;
        private Label labelSettings;
        private Label labelCalendar;
        private Label labelNotification;
        private Label labelSearch;
    }
}