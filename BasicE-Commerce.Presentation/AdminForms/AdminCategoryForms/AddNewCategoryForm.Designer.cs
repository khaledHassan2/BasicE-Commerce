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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // CategoryNameinput
            // 
            CategoryNameinput.Location = new Point(37, 127);
            CategoryNameinput.Margin = new Padding(5, 3, 5, 3);
            CategoryNameinput.Name = "CategoryNameinput";
            CategoryNameinput.Size = new Size(359, 29);
            CategoryNameinput.TabIndex = 0;
            // 
            // AddNewCategoryLbl
            // 
            AddNewCategoryLbl.AutoSize = true;
            AddNewCategoryLbl.Font = new Font("Simplified Arabic Fixed", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            AddNewCategoryLbl.Location = new Point(287, 10);
            AddNewCategoryLbl.Margin = new Padding(5, 0, 5, 0);
            AddNewCategoryLbl.Name = "AddNewCategoryLbl";
            AddNewCategoryLbl.Size = new Size(404, 47);
            AddNewCategoryLbl.TabIndex = 1;
            AddNewCategoryLbl.Text = "Add New Category";
            // 
            // CategoryNameLbl
            // 
            CategoryNameLbl.AutoSize = true;
            CategoryNameLbl.Location = new Point(37, 92);
            CategoryNameLbl.Margin = new Padding(5, 0, 5, 0);
            CategoryNameLbl.Name = "CategoryNameLbl";
            CategoryNameLbl.Size = new Size(153, 22);
            CategoryNameLbl.TabIndex = 2;
            CategoryNameLbl.Text = "Category Name";
            // 
            // CategoryDescriptionInput
            // 
            CategoryDescriptionInput.Location = new Point(37, 215);
            CategoryDescriptionInput.Margin = new Padding(5, 3, 5, 3);
            CategoryDescriptionInput.Multiline = true;
            CategoryDescriptionInput.Name = "CategoryDescriptionInput";
            CategoryDescriptionInput.Size = new Size(359, 89);
            CategoryDescriptionInput.TabIndex = 3;
            // 
            // CategoryDescriptionLbl
            // 
            CategoryDescriptionLbl.AutoSize = true;
            CategoryDescriptionLbl.Location = new Point(37, 179);
            CategoryDescriptionLbl.Margin = new Padding(5, 0, 5, 0);
            CategoryDescriptionLbl.Name = "CategoryDescriptionLbl";
            CategoryDescriptionLbl.Size = new Size(230, 22);
            CategoryDescriptionLbl.TabIndex = 4;
            CategoryDescriptionLbl.Text = "Category Description";
            // 
            // SaveNewCategoryBtn
            // 
            SaveNewCategoryBtn.ForeColor = Color.DarkOliveGreen;
            SaveNewCategoryBtn.Location = new Point(141, 338);
            SaveNewCategoryBtn.Margin = new Padding(5, 3, 5, 3);
            SaveNewCategoryBtn.Name = "SaveNewCategoryBtn";
            SaveNewCategoryBtn.Size = new Size(126, 50);
            SaveNewCategoryBtn.TabIndex = 5;
            SaveNewCategoryBtn.Text = "Add";
            SaveNewCategoryBtn.UseVisualStyleBackColor = true;
            SaveNewCategoryBtn.Click += SaveNewCategoryBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(428, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(455, 357);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // AddNewCategoryForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(915, 420);
            Controls.Add(pictureBox1);
            Controls.Add(SaveNewCategoryBtn);
            Controls.Add(CategoryDescriptionLbl);
            Controls.Add(CategoryDescriptionInput);
            Controls.Add(CategoryNameLbl);
            Controls.Add(AddNewCategoryLbl);
            Controls.Add(CategoryNameinput);
            Font = new Font("Courier New", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ButtonFace;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 3, 5, 3);
            Name = "AddNewCategoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddNewCategoryForm";
            Load += AddNewCategoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CategoryNameinput;
        private Label AddNewCategoryLbl;
        private Label CategoryNameLbl;
        private TextBox CategoryDescriptionInput;
        private Label CategoryDescriptionLbl;
        private Button SaveNewCategoryBtn;
        private PictureBox pictureBox1;
    }
}