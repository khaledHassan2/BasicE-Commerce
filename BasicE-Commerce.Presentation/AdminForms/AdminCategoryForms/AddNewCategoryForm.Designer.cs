namespace BasicE_Commerce.Presentation.AdminForms.AdminCategoryForms
{
    partial class AddNewCategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewCategoryForm));
            CategoryNameinput = new TextBox();
            AddNewCategoryLbl = new Label();
            CategoryNameLbl = new Label();
            CategoryDescriptionInput = new TextBox();
            CategoryDescriptionLbl = new Label();
            SaveNewCategoryBtn = new Button();
            pictureBox1 = new PictureBox();
            headerPanel = new Panel();
            iconLabel = new Label();
            formPanel = new Panel();
            buttonPanel = new Panel();
            cancelBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            headerPanel.SuspendLayout();
            formPanel.SuspendLayout();
            buttonPanel.SuspendLayout();
            SuspendLayout();

            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(74, 144, 226);
            headerPanel.Controls.Add(iconLabel);
            headerPanel.Controls.Add(AddNewCategoryLbl);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(700, 80);
            headerPanel.TabIndex = 7;

            // 
            // iconLabel
            // 
            iconLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconLabel.ForeColor = Color.White;
            iconLabel.Location = new Point(30, 20);
            iconLabel.Name = "iconLabel";
            iconLabel.Size = new Size(60, 40);
            iconLabel.TabIndex = 8;
            iconLabel.Text = "📂";
            iconLabel.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // AddNewCategoryLbl
            // 
            AddNewCategoryLbl.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddNewCategoryLbl.ForeColor = Color.White;
            AddNewCategoryLbl.Location = new Point(100, 20);
            AddNewCategoryLbl.Name = "AddNewCategoryLbl";
            AddNewCategoryLbl.Size = new Size(300, 40);
            AddNewCategoryLbl.TabIndex = 1;
            AddNewCategoryLbl.Text = "Add New Category";
            AddNewCategoryLbl.TextAlign = ContentAlignment.MiddleLeft;

            // 
            // formPanel
            // 
            formPanel.BackColor = Color.White;
            formPanel.Controls.Add(CategoryDescriptionInput);
            formPanel.Controls.Add(CategoryDescriptionLbl);
            formPanel.Controls.Add(CategoryNameinput);
            formPanel.Controls.Add(CategoryNameLbl);
            formPanel.Controls.Add(pictureBox1);
            formPanel.Dock = DockStyle.Fill;
            formPanel.Location = new Point(0, 80);
            formPanel.Name = "formPanel";
            formPanel.Padding = new Padding(30);
            formPanel.Size = new Size(700, 350);
            formPanel.TabIndex = 8;

            // 
            // CategoryNameLbl
            // 
            CategoryNameLbl.AutoSize = true;
            CategoryNameLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CategoryNameLbl.ForeColor = Color.FromArgb(52, 58, 64);
            CategoryNameLbl.Location = new Point(40, 40);
            CategoryNameLbl.Name = "CategoryNameLbl";
            CategoryNameLbl.Size = new Size(128, 21);
            CategoryNameLbl.TabIndex = 2;
            CategoryNameLbl.Text = "Category Name";

            // 
            // CategoryNameinput
            // 
            CategoryNameinput.BackColor = Color.FromArgb(248, 249, 250);
            CategoryNameinput.BorderStyle = BorderStyle.None;
            CategoryNameinput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CategoryNameinput.ForeColor = Color.FromArgb(33, 37, 43);
            CategoryNameinput.Location = new Point(40, 70);
            CategoryNameinput.Name = "CategoryNameinput";
            CategoryNameinput.Padding = new Padding(15, 12, 15, 12);
            CategoryNameinput.Size = new Size(300, 22);
            CategoryNameinput.TabIndex = 0;

            // 
            // CategoryDescriptionLbl
            // 
            CategoryDescriptionLbl.AutoSize = true;
            CategoryDescriptionLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CategoryDescriptionLbl.ForeColor = Color.FromArgb(52, 58, 64);
            CategoryDescriptionLbl.Location = new Point(40, 120);
            CategoryDescriptionLbl.Name = "CategoryDescriptionLbl";
            CategoryDescriptionLbl.Size = new Size(168, 21);
            CategoryDescriptionLbl.TabIndex = 4;
            CategoryDescriptionLbl.Text = "Category Description";

            // 
            // CategoryDescriptionInput
            // 
            CategoryDescriptionInput.BackColor = Color.FromArgb(248, 249, 250);
            CategoryDescriptionInput.BorderStyle = BorderStyle.None;
            CategoryDescriptionInput.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CategoryDescriptionInput.ForeColor = Color.FromArgb(33, 37, 43);
            CategoryDescriptionInput.Location = new Point(40, 150);
            CategoryDescriptionInput.Multiline = true;
            CategoryDescriptionInput.Name = "CategoryDescriptionInput";
            CategoryDescriptionInput.Padding = new Padding(15, 12, 15, 12);
            CategoryDescriptionInput.ScrollBars = ScrollBars.Vertical;
            CategoryDescriptionInput.Size = new Size(300, 100);
            CategoryDescriptionInput.TabIndex = 3;

            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(248, 249, 250);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(380, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(280, 210);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;

            // 
            // buttonPanel
            // 
            buttonPanel.BackColor = Color.FromArgb(248, 249, 250);
            buttonPanel.Controls.Add(cancelBtn);
            buttonPanel.Controls.Add(SaveNewCategoryBtn);
            buttonPanel.Dock = DockStyle.Bottom;
            buttonPanel.Location = new Point(0, 430);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Size = new Size(700, 80);
            buttonPanel.TabIndex = 9;

            // 
            // SaveNewCategoryBtn
            // 
            SaveNewCategoryBtn.BackColor = Color.FromArgb(40, 167, 69);
            SaveNewCategoryBtn.Cursor = Cursors.Hand;
            SaveNewCategoryBtn.FlatAppearance.BorderSize = 0;
            SaveNewCategoryBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 139, 58);
            SaveNewCategoryBtn.FlatStyle = FlatStyle.Flat;
            SaveNewCategoryBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveNewCategoryBtn.ForeColor = Color.White;
            SaveNewCategoryBtn.Location = new Point(480, 20);
            SaveNewCategoryBtn.Name = "SaveNewCategoryBtn";
            SaveNewCategoryBtn.Size = new Size(120, 40);
            SaveNewCategoryBtn.TabIndex = 5;
            SaveNewCategoryBtn.Text = "✅ Save";
            SaveNewCategoryBtn.UseVisualStyleBackColor = false;
            SaveNewCategoryBtn.Click += SaveNewCategoryBtn_Click;

            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.FromArgb(108, 117, 125);
            cancelBtn.Cursor = Cursors.Hand;
            cancelBtn.FlatAppearance.BorderSize = 0;
            cancelBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 98, 104);
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelBtn.ForeColor = Color.White;
            cancelBtn.Location = new Point(350, 20);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(120, 40);
            cancelBtn.TabIndex = 10;
            cancelBtn.Text = "❌ Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += new EventHandler(this.cancelBtn_Click);

            // 
            // AddNewCategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 510);
            Controls.Add(formPanel);
            Controls.Add(buttonPanel);
            Controls.Add(headerPanel);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddNewCategoryForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add New Category";
            Load += AddNewCategoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            headerPanel.ResumeLayout(false);
            formPanel.ResumeLayout(false);
            formPanel.PerformLayout();
            buttonPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox CategoryNameinput;
        private Label AddNewCategoryLbl;
        private Label CategoryNameLbl;
        private TextBox CategoryDescriptionInput;
        private Label CategoryDescriptionLbl;
        private Button SaveNewCategoryBtn;
        private PictureBox pictureBox1;
        private Panel headerPanel;
        private Label iconLabel;
        private Panel formPanel;
        private Panel buttonPanel;
        private Button cancelBtn;

        // Add this method to handle cancel button click
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}