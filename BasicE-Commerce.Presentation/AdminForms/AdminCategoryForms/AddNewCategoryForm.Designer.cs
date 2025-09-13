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
            CategoryNameinput = new TextBox();
            AddNewCategoryLbl = new Label();
            CategoryNameLbl = new Label();
            CategoryDescriptionInput = new TextBox();
            CategoryDescriptionLbl = new Label();
            SaveNewCategoryBtn = new Button();
            SuspendLayout();
            // 
            // CategoryNameinput
            // 
            CategoryNameinput.Location = new Point(257, 131);
            CategoryNameinput.Name = "CategoryNameinput";
            CategoryNameinput.Size = new Size(326, 27);
            CategoryNameinput.TabIndex = 0;
            // 
            // AddNewCategoryLbl
            // 
            AddNewCategoryLbl.AutoSize = true;
            AddNewCategoryLbl.Font = new Font("Simplified Arabic Fixed", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            AddNewCategoryLbl.Location = new Point(151, 27);
            AddNewCategoryLbl.Name = "AddNewCategoryLbl";
            AddNewCategoryLbl.Size = new Size(488, 56);
            AddNewCategoryLbl.TabIndex = 1;
            AddNewCategoryLbl.Text = "Add New Category";
            // 
            // CategoryNameLbl
            // 
            CategoryNameLbl.AutoSize = true;
            CategoryNameLbl.Location = new Point(112, 138);
            CategoryNameLbl.Name = "CategoryNameLbl";
            CategoryNameLbl.Size = new Size(113, 20);
            CategoryNameLbl.TabIndex = 2;
            CategoryNameLbl.Text = "Category Name";
            // 
            // CategoryDescriptionInput
            // 
            CategoryDescriptionInput.Location = new Point(257, 210);
            CategoryDescriptionInput.Multiline = true;
            CategoryDescriptionInput.Name = "CategoryDescriptionInput";
            CategoryDescriptionInput.Size = new Size(326, 92);
            CategoryDescriptionInput.TabIndex = 3;
            // 
            // CategoryDescriptionLbl
            // 
            CategoryDescriptionLbl.AutoSize = true;
            CategoryDescriptionLbl.Location = new Point(92, 241);
            CategoryDescriptionLbl.Name = "CategoryDescriptionLbl";
            CategoryDescriptionLbl.Size = new Size(149, 20);
            CategoryDescriptionLbl.TabIndex = 4;
            CategoryDescriptionLbl.Text = "Category Description";
            // 
            // SaveNewCategoryBtn
            // 
            SaveNewCategoryBtn.Location = new Point(331, 343);
            SaveNewCategoryBtn.Name = "SaveNewCategoryBtn";
            SaveNewCategoryBtn.Size = new Size(155, 46);
            SaveNewCategoryBtn.TabIndex = 5;
            SaveNewCategoryBtn.Text = "Add";
            SaveNewCategoryBtn.UseVisualStyleBackColor = true;
            SaveNewCategoryBtn.Click += SaveNewCategoryBtn_Click;
            // 
            // AddNewCategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SaveNewCategoryBtn);
            Controls.Add(CategoryDescriptionLbl);
            Controls.Add(CategoryDescriptionInput);
            Controls.Add(CategoryNameLbl);
            Controls.Add(AddNewCategoryLbl);
            Controls.Add(CategoryNameinput);
            Name = "AddNewCategoryForm";
            Text = "AddNewCategoryForm";
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
    }
}