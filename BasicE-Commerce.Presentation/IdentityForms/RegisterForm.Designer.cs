namespace BasicE_Commerce.Presentation
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            RegisterNameInput = new TextBox();
            RegisterEmailInput = new TextBox();
            RegisterPasswordInput = new TextBox();
            NameLbl = new Label();
            EmailLbl = new Label();
            PasswordLbl = new Label();
            SignUpBtn = new Button();
            RegisterLabel = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // RegisterNameInput
            // 
            RegisterNameInput.Location = new Point(54, 105);
            RegisterNameInput.Margin = new Padding(4, 2, 4, 2);
            RegisterNameInput.Name = "RegisterNameInput";
            RegisterNameInput.Size = new Size(257, 26);
            RegisterNameInput.TabIndex = 0;
            // 
            // RegisterEmailInput
            // 
            RegisterEmailInput.Location = new Point(54, 158);
            RegisterEmailInput.Margin = new Padding(4, 2, 4, 2);
            RegisterEmailInput.Name = "RegisterEmailInput";
            RegisterEmailInput.Size = new Size(257, 26);
            RegisterEmailInput.TabIndex = 1;
            // 
            // RegisterPasswordInput
            // 
            RegisterPasswordInput.Location = new Point(54, 219);
            RegisterPasswordInput.Margin = new Padding(4, 2, 4, 2);
            RegisterPasswordInput.Name = "RegisterPasswordInput";
            RegisterPasswordInput.Size = new Size(257, 26);
            RegisterPasswordInput.TabIndex = 2;
            RegisterPasswordInput.UseSystemPasswordChar = true;
            // 
            // NameLbl
            // 
            NameLbl.AutoSize = true;
            NameLbl.Location = new Point(54, 85);
            NameLbl.Margin = new Padding(4, 0, 4, 0);
            NameLbl.Name = "NameLbl";
            NameLbl.Size = new Size(48, 18);
            NameLbl.TabIndex = 3;
            NameLbl.Text = "Name";
            // 
            // EmailLbl
            // 
            EmailLbl.AutoSize = true;
            EmailLbl.Location = new Point(54, 137);
            EmailLbl.Margin = new Padding(4, 0, 4, 0);
            EmailLbl.Name = "EmailLbl";
            EmailLbl.Size = new Size(58, 18);
            EmailLbl.TabIndex = 4;
            EmailLbl.Text = "Email";
            // 
            // PasswordLbl
            // 
            PasswordLbl.AutoSize = true;
            PasswordLbl.Location = new Point(54, 199);
            PasswordLbl.Margin = new Padding(4, 0, 4, 0);
            PasswordLbl.Name = "PasswordLbl";
            PasswordLbl.Size = new Size(88, 18);
            PasswordLbl.TabIndex = 5;
            PasswordLbl.Text = "Password";
            // 
            // SignUpBtn
            // 
            SignUpBtn.BackColor = Color.Teal;
            SignUpBtn.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUpBtn.ForeColor = Color.White;
            SignUpBtn.Location = new Point(95, 267);
            SignUpBtn.Margin = new Padding(4, 2, 4, 2);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.Size = new Size(166, 37);
            SignUpBtn.TabIndex = 6;
            SignUpBtn.Text = "Register";
            SignUpBtn.UseVisualStyleBackColor = false;
            SignUpBtn.Click += SignUpBtn_Click;
            // 
            // RegisterLabel
            // 
            RegisterLabel.AutoSize = true;
            RegisterLabel.Font = new Font("Courier New", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegisterLabel.Location = new Point(89, 21);
            RegisterLabel.Margin = new Padding(4, 0, 4, 0);
            RegisterLabel.Name = "RegisterLabel";
            RegisterLabel.Size = new Size(222, 31);
            RegisterLabel.TabIndex = 7;
            RegisterLabel.Text = "Register Form";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(384, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(377, 332);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(RegisterLabel);
            panel1.Controls.Add(SignUpBtn);
            panel1.Controls.Add(RegisterNameInput);
            panel1.Controls.Add(PasswordLbl);
            panel1.Controls.Add(RegisterEmailInput);
            panel1.Controls.Add(EmailLbl);
            panel1.Controls.Add(RegisterPasswordInput);
            panel1.Controls.Add(NameLbl);
            panel1.Location = new Point(27, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(761, 335);
            panel1.TabIndex = 9;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(818, 382);
            Controls.Add(panel1);
            Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 2, 4, 2);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox RegisterNameInput;
        private TextBox RegisterEmailInput;
        private TextBox RegisterPasswordInput;
        private Label NameLbl;
        private Label EmailLbl;
        private Label PasswordLbl;
        private Button SignUpBtn;
        private Label RegisterLabel;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}