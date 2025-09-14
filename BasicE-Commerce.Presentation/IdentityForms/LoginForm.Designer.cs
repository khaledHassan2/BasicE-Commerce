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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // LoginEmailInput
            // 
            LoginEmailInput.Location = new Point(470, 79);
            LoginEmailInput.Margin = new Padding(4, 2, 4, 2);
            LoginEmailInput.Name = "LoginEmailInput";
            LoginEmailInput.Size = new Size(291, 26);
            LoginEmailInput.TabIndex = 0;
            // 
            // LoginPasswordInput
            // 
            LoginPasswordInput.Location = new Point(470, 149);
            LoginPasswordInput.Margin = new Padding(4, 2, 4, 2);
            LoginPasswordInput.Name = "LoginPasswordInput";
            LoginPasswordInput.Size = new Size(291, 26);
            LoginPasswordInput.TabIndex = 1;
            LoginPasswordInput.UseSystemPasswordChar = true;
            // 
            // LoginEmailLbl
            // 
            LoginEmailLbl.AutoSize = true;
            LoginEmailLbl.Location = new Point(470, 59);
            LoginEmailLbl.Margin = new Padding(4, 0, 4, 0);
            LoginEmailLbl.Name = "LoginEmailLbl";
            LoginEmailLbl.Size = new Size(58, 18);
            LoginEmailLbl.TabIndex = 2;
            LoginEmailLbl.Text = "Email";
            // 
            // LoginPasswordLbl
            // 
            LoginPasswordLbl.AutoSize = true;
            LoginPasswordLbl.Location = new Point(470, 128);
            LoginPasswordLbl.Margin = new Padding(4, 0, 4, 0);
            LoginPasswordLbl.Name = "LoginPasswordLbl";
            LoginPasswordLbl.Size = new Size(88, 18);
            LoginPasswordLbl.TabIndex = 3;
            LoginPasswordLbl.Text = "Password";
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(470, 194);
            LoginBtn.Margin = new Padding(4, 2, 4, 2);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(156, 41);
            LoginBtn.TabIndex = 4;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(441, 285);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(768, 79);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 26);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(768, 149);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(485, 253);
            label1.Name = "label1";
            label1.Size = new Size(241, 22);
            label1.TabIndex = 9;
            label1.Text = "Don't havean account!";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(828, 309);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(LoginBtn);
            Controls.Add(LoginPasswordLbl);
            Controls.Add(LoginEmailLbl);
            Controls.Add(LoginPasswordInput);
            Controls.Add(LoginEmailInput);
            Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 2, 4, 2);
            Name = "LoginForm";
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}