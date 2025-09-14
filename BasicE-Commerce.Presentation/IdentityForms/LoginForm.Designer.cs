namespace BasicE_Commerce.Presentation
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            LoginEmailInput = new TextBox();
            LoginPasswordInput = new TextBox();
            LoginEmailLbl = new Label();
            LoginPasswordLbl = new Label();
            LoginBtn = new Button();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            RegisterLink = new LinkLabel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LoginEmailInput
            // 
            LoginEmailInput.Location = new Point(381, 82);
            LoginEmailInput.Margin = new Padding(4, 2, 4, 2);
            LoginEmailInput.Name = "LoginEmailInput";
            LoginEmailInput.Size = new Size(259, 26);
            LoginEmailInput.TabIndex = 0;
            // 
            // LoginPasswordInput
            // 
            LoginPasswordInput.Location = new Point(381, 152);
            LoginPasswordInput.Margin = new Padding(4, 2, 4, 2);
            LoginPasswordInput.Name = "LoginPasswordInput";
            LoginPasswordInput.Size = new Size(259, 26);
            LoginPasswordInput.TabIndex = 1;
            LoginPasswordInput.UseSystemPasswordChar = true;
            // 
            // LoginEmailLbl
            // 
            LoginEmailLbl.AutoSize = true;
            LoginEmailLbl.Location = new Point(381, 62);
            LoginEmailLbl.Margin = new Padding(4, 0, 4, 0);
            LoginEmailLbl.Name = "LoginEmailLbl";
            LoginEmailLbl.Size = new Size(58, 18);
            LoginEmailLbl.TabIndex = 2;
            LoginEmailLbl.Text = "Email";
            // 
            // LoginPasswordLbl
            // 
            LoginPasswordLbl.AutoSize = true;
            LoginPasswordLbl.Location = new Point(381, 131);
            LoginPasswordLbl.Margin = new Padding(4, 0, 4, 0);
            LoginPasswordLbl.Name = "LoginPasswordLbl";
            LoginPasswordLbl.Size = new Size(88, 18);
            LoginPasswordLbl.TabIndex = 3;
            LoginPasswordLbl.Text = "Password";
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.Teal;
            LoginBtn.ForeColor = Color.White;
            LoginBtn.Location = new Point(381, 195);
            LoginBtn.Margin = new Padding(4, 2, 4, 2);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(116, 33);
            LoginBtn.TabIndex = 4;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(336, 261);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(647, 82);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(26, 26);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(647, 152);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(399, 230);
            label1.Name = "label1";
            label1.Size = new Size(241, 22);
            label1.TabIndex = 9;
            label1.Text = "Don't havean account!";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(RegisterLink);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(LoginEmailLbl);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(LoginEmailInput);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(LoginPasswordInput);
            panel1.Controls.Add(LoginBtn);
            panel1.Controls.Add(LoginPasswordLbl);
            panel1.Location = new Point(49, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(724, 302);
            panel1.TabIndex = 10;
            // 
            // RegisterLink
            // 
            RegisterLink.AutoSize = true;
            RegisterLink.Font = new Font("Courier New", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegisterLink.LinkColor = Color.Red;
            RegisterLink.Location = new Point(455, 256);
            RegisterLink.Name = "RegisterLink";
            RegisterLink.Size = new Size(98, 22);
            RegisterLink.TabIndex = 11;
            RegisterLink.TabStop = true;
            RegisterLink.Text = "Register";
            RegisterLink.LinkClicked += RegisterLink_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(469, 18);
            label2.Name = "label2";
            label2.Size = new Size(110, 36);
            label2.TabIndex = 10;
            label2.Text = "Login";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(816, 368);
            Controls.Add(panel1);
            Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 2, 4, 2);
            Name = "LoginForm";
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox LoginEmailInput;
        private TextBox LoginPasswordInput;
        private Label LoginEmailLbl;
        private Label LoginPasswordLbl;
        private Button LoginBtn;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private LinkLabel RegisterLink;
    }
}