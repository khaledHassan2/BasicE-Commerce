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
            RegisterNameInput = new TextBox();
            RegisterEmailInput = new TextBox();
            RegisterPasswordInput = new TextBox();
            NameLbl = new Label();
            EmailLbl = new Label();
            PasswordLbl = new Label();
            SignUpBtn = new Button();
            RegisterLabel = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // RegisterNameInput
            // 
            RegisterNameInput.Location = new Point(29, 118);
            RegisterNameInput.Margin = new Padding(4, 2, 4, 2);
            RegisterNameInput.Name = "RegisterNameInput";
            RegisterNameInput.Size = new Size(313, 26);
            RegisterNameInput.TabIndex = 0;
            // 
            // RegisterEmailInput
            // 
            RegisterEmailInput.Location = new Point(29, 171);
            RegisterEmailInput.Margin = new Padding(4, 2, 4, 2);
            RegisterEmailInput.Name = "RegisterEmailInput";
            RegisterEmailInput.Size = new Size(313, 26);
            RegisterEmailInput.TabIndex = 1;
            // 
            // RegisterPasswordInput
            // 
            RegisterPasswordInput.Location = new Point(29, 232);
            RegisterPasswordInput.Margin = new Padding(4, 2, 4, 2);
            RegisterPasswordInput.Name = "RegisterPasswordInput";
            RegisterPasswordInput.Size = new Size(313, 26);
            RegisterPasswordInput.TabIndex = 2;
            RegisterPasswordInput.UseSystemPasswordChar = true;
            // 
            // NameLbl
            // 
            NameLbl.AutoSize = true;
            NameLbl.Location = new Point(29, 98);
            NameLbl.Margin = new Padding(4, 0, 4, 0);
            NameLbl.Name = "NameLbl";
            NameLbl.Size = new Size(48, 18);
            NameLbl.TabIndex = 3;
            NameLbl.Text = "Name";
            // 
            // EmailLbl
            // 
            EmailLbl.AutoSize = true;
            EmailLbl.Location = new Point(29, 150);
            EmailLbl.Margin = new Padding(4, 0, 4, 0);
            EmailLbl.Name = "EmailLbl";
            EmailLbl.Size = new Size(58, 18);
            EmailLbl.TabIndex = 4;
            EmailLbl.Text = "Email";
            // 
            // PasswordLbl
            // 
            PasswordLbl.AutoSize = true;
            PasswordLbl.Location = new Point(29, 212);
            PasswordLbl.Margin = new Padding(4, 0, 4, 0);
            PasswordLbl.Name = "PasswordLbl";
            PasswordLbl.Size = new Size(88, 18);
            PasswordLbl.TabIndex = 5;
            PasswordLbl.Text = "Password";
            // 
            // SignUpBtn
            // 
            SignUpBtn.Location = new Point(70, 280);
            SignUpBtn.Margin = new Padding(4, 2, 4, 2);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.Size = new Size(229, 37);
            SignUpBtn.TabIndex = 6;
            SignUpBtn.Text = "Register";
            SignUpBtn.UseVisualStyleBackColor = true;
            SignUpBtn.Click += SignUpBtn_Click;
            // 
            // RegisterLabel
            // 
            RegisterLabel.AutoSize = true;
            RegisterLabel.Location = new Point(95, 34);
            RegisterLabel.Margin = new Padding(4, 0, 4, 0);
            RegisterLabel.Name = "RegisterLabel";
            RegisterLabel.Size = new Size(138, 18);
            RegisterLabel.TabIndex = 7;
            RegisterLabel.Text = "Register Form";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_register_100;
            pictureBox1.Location = new Point(369, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(372, 306);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 330);
            Controls.Add(pictureBox1);
            Controls.Add(RegisterLabel);
            Controls.Add(SignUpBtn);
            Controls.Add(PasswordLbl);
            Controls.Add(EmailLbl);
            Controls.Add(NameLbl);
            Controls.Add(RegisterPasswordInput);
            Controls.Add(RegisterEmailInput);
            Controls.Add(RegisterNameInput);
            Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 2, 4, 2);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}