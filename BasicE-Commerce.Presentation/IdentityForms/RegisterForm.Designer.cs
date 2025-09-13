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
            SuspendLayout();
            // 
            // RegisterNameInput
            // 
            RegisterNameInput.Location = new Point(272, 127);
            RegisterNameInput.Name = "RegisterNameInput";
            RegisterNameInput.Size = new Size(338, 27);
            RegisterNameInput.TabIndex = 0;
            // 
            // RegisterEmailInput
            // 
            RegisterEmailInput.Location = new Point(272, 185);
            RegisterEmailInput.Name = "RegisterEmailInput";
            RegisterEmailInput.Size = new Size(338, 27);
            RegisterEmailInput.TabIndex = 1;
            // 
            // RegisterPasswordInput
            // 
            RegisterPasswordInput.Location = new Point(272, 253);
            RegisterPasswordInput.Name = "RegisterPasswordInput";
            RegisterPasswordInput.Size = new Size(338, 27);
            RegisterPasswordInput.TabIndex = 2;
            RegisterPasswordInput.UseSystemPasswordChar = true;
            // 
            // NameLbl
            // 
            NameLbl.AutoSize = true;
            NameLbl.Location = new Point(177, 127);
            NameLbl.Name = "NameLbl";
            NameLbl.Size = new Size(49, 20);
            NameLbl.TabIndex = 3;
            NameLbl.Text = "Name";
            // 
            // EmailLbl
            // 
            EmailLbl.AutoSize = true;
            EmailLbl.Location = new Point(177, 192);
            EmailLbl.Name = "EmailLbl";
            EmailLbl.Size = new Size(46, 20);
            EmailLbl.TabIndex = 4;
            EmailLbl.Text = "Email";
            // 
            // PasswordLbl
            // 
            PasswordLbl.AutoSize = true;
            PasswordLbl.Location = new Point(177, 256);
            PasswordLbl.Name = "PasswordLbl";
            PasswordLbl.Size = new Size(70, 20);
            PasswordLbl.TabIndex = 5;
            PasswordLbl.Text = "Password";
            // 
            // SignUpBtn
            // 
            SignUpBtn.Location = new Point(289, 337);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.Size = new Size(234, 29);
            SignUpBtn.TabIndex = 6;
            SignUpBtn.Text = "Register";
            SignUpBtn.UseVisualStyleBackColor = true;
            SignUpBtn.Click += SignUpBtn_Click;
            // 
            // RegisterLabel
            // 
            RegisterLabel.AutoSize = true;
            RegisterLabel.Location = new Point(340, 62);
            RegisterLabel.Name = "RegisterLabel";
            RegisterLabel.Size = new Size(101, 20);
            RegisterLabel.TabIndex = 7;
            RegisterLabel.Text = "Register Form";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RegisterLabel);
            Controls.Add(SignUpBtn);
            Controls.Add(PasswordLbl);
            Controls.Add(EmailLbl);
            Controls.Add(NameLbl);
            Controls.Add(RegisterPasswordInput);
            Controls.Add(RegisterEmailInput);
            Controls.Add(RegisterNameInput);
            Name = "RegisterForm";
            Text = "RegisterForm";
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
    }
}