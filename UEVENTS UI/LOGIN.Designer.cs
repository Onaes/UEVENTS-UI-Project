namespace UEVENTS_UI
{
    partial class LOGIN
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
            textBoxEmail = new TextBox();
            textBoxPassword = new TextBox();
            buttonLogIn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(272, 260);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(236, 23);
            textBoxEmail.TabIndex = 0;
            textBoxEmail.Text = "Email";
            textBoxEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(272, 315);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(236, 23);
            textBoxPassword.TabIndex = 1;
            textBoxPassword.Text = "Password";
            textBoxPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonLogIn
            // 
            buttonLogIn.Location = new Point(352, 365);
            buttonLogIn.Name = "buttonLogIn";
            buttonLogIn.Size = new Size(75, 23);
            buttonLogIn.TabIndex = 2;
            buttonLogIn.Text = "Log In";
            buttonLogIn.UseVisualStyleBackColor = true;
            buttonLogIn.Click += buttonLogIn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.uevents;
            pictureBox1.Location = new Point(68, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(655, 223);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // LOGIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(buttonLogIn);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            Name = "LOGIN";
            Text = "LOGIN";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxEmail;
        private TextBox textBoxPassword;
        private Button buttonLogIn;
        private PictureBox pictureBox1;
    }
}