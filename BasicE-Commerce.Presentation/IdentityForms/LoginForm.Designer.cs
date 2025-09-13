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
            LoginEmailInput = new TextBox();
            LoginPasswordInput = new TextBox();
            LoginEmailLbl = new Label();
            LoginPasswordLbl = new Label();
            LoginBtn = new Button();
            SuspendLayout();
            // 
            // LoginEmailInput
            // 
            LoginEmailInput.Location = new Point(259, 154);
            LoginEmailInput.Name = "LoginEmailInput";
            LoginEmailInput.Size = new Size(265, 27);
            LoginEmailInput.TabIndex = 0;
            // 
            // LoginPasswordInput
            // 
            LoginPasswordInput.Location = new Point(259, 232);
            LoginPasswordInput.Name = "LoginPasswordInput";
            LoginPasswordInput.Size = new Size(265, 27);
            LoginPasswordInput.TabIndex = 1;
            LoginPasswordInput.UseSystemPasswordChar = true;
            // 
            // LoginEmailLbl
            // 
            LoginEmailLbl.AutoSize = true;
            LoginEmailLbl.Location = new Point(184, 157);
            LoginEmailLbl.Name = "LoginEmailLbl";
            LoginEmailLbl.Size = new Size(46, 20);
            LoginEmailLbl.TabIndex = 2;
            LoginEmailLbl.Text = "Email";
            // 
            // LoginPasswordLbl
            // 
            LoginPasswordLbl.AutoSize = true;
            LoginPasswordLbl.Location = new Point(160, 235);
            LoginPasswordLbl.Name = "LoginPasswordLbl";
            LoginPasswordLbl.Size = new Size(70, 20);
            LoginPasswordLbl.TabIndex = 3;
            LoginPasswordLbl.Text = "Password";
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(269, 325);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(216, 45);
            LoginBtn.TabIndex = 4;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LoginBtn);
            Controls.Add(LoginPasswordLbl);
            Controls.Add(LoginEmailLbl);
            Controls.Add(LoginPasswordInput);
            Controls.Add(LoginEmailInput);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LoginEmailInput;
        private TextBox LoginPasswordInput;
        private Label LoginEmailLbl;
        private Label LoginPasswordLbl;
        private Button LoginBtn;
    }
}