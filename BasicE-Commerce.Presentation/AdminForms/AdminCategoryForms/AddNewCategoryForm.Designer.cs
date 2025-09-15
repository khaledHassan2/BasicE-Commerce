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
            CategoryNameinput.Location = new Point(423, 117);
            CategoryNameinput.Margin = new Padding(3, 2, 3, 2);
            CategoryNameinput.Name = "CategoryNameinput";
            CategoryNameinput.Size = new Size(230, 23);
            CategoryNameinput.TabIndex = 0;
            // 
            // AddNewCategoryLbl
            // 
            AddNewCategoryLbl.AutoSize = true;
            AddNewCategoryLbl.Font = new Font("Simplified Arabic Fixed", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            AddNewCategoryLbl.Location = new Point(274, 39);
            AddNewCategoryLbl.Name = "AddNewCategoryLbl";
            AddNewCategoryLbl.Size = new Size(404, 47);
            AddNewCategoryLbl.TabIndex = 1;
            AddNewCategoryLbl.Text = "Add New Category";
            // 
            // CategoryNameLbl
            // 
            CategoryNameLbl.AutoSize = true;
            CategoryNameLbl.Location = new Point(285, 125);
            CategoryNameLbl.Name = "CategoryNameLbl";
            CategoryNameLbl.Size = new Size(90, 15);
            CategoryNameLbl.TabIndex = 2;
            CategoryNameLbl.Text = "Category Name";
            // 
            // CategoryDescriptionInput
            // 
            CategoryDescriptionInput.Location = new Point(423, 177);
            CategoryDescriptionInput.Margin = new Padding(3, 2, 3, 2);
            CategoryDescriptionInput.Multiline = true;
            CategoryDescriptionInput.Name = "CategoryDescriptionInput";
            CategoryDescriptionInput.Size = new Size(230, 70);
            CategoryDescriptionInput.TabIndex = 3;
            // 
            // CategoryDescriptionLbl
            // 
            CategoryDescriptionLbl.AutoSize = true;
            CategoryDescriptionLbl.Location = new Point(285, 201);
            CategoryDescriptionLbl.Name = "CategoryDescriptionLbl";
            CategoryDescriptionLbl.Size = new Size(118, 15);
            CategoryDescriptionLbl.TabIndex = 4;
            CategoryDescriptionLbl.Text = "Category Description";
            // 
            // SaveNewCategoryBtn
            // 
            SaveNewCategoryBtn.Location = new Point(488, 276);
            SaveNewCategoryBtn.Margin = new Padding(3, 2, 3, 2);
            SaveNewCategoryBtn.Name = "SaveNewCategoryBtn";
            SaveNewCategoryBtn.Size = new Size(80, 34);
            SaveNewCategoryBtn.TabIndex = 5;
            SaveNewCategoryBtn.Text = "Add";
            SaveNewCategoryBtn.UseVisualStyleBackColor = true;
            SaveNewCategoryBtn.Click += SaveNewCategoryBtn_Click;
            // 
            // AddNewCategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(SaveNewCategoryBtn);
            Controls.Add(CategoryDescriptionLbl);
            Controls.Add(CategoryDescriptionInput);
            Controls.Add(CategoryNameLbl);
            Controls.Add(AddNewCategoryLbl);
            Controls.Add(CategoryNameinput);
            Margin = new Padding(3, 2, 3, 2);
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