namespace BasicE_Commerce.Presentation
{
    partial class UserMainForm
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
            CategoriesOptionsList = new ComboBox();
            SearchCategoryBtn = new Button();
            ChoiseCategoryLbl = new Label();
            SuspendLayout();
            // 
            // CategoriesOptionsList
            // 
            CategoriesOptionsList.FormattingEnabled = true;
            CategoriesOptionsList.Location = new Point(308, 181);
            CategoriesOptionsList.Name = "CategoriesOptionsList";
            CategoriesOptionsList.Size = new Size(317, 28);
            CategoriesOptionsList.TabIndex = 0;
            CategoriesOptionsList.SelectedIndexChanged += CategoriesOptionsList_SelectedIndexChanged;
            // 
            // SearchCategoryBtn
            // 
            SearchCategoryBtn.Location = new Point(29, 181);
            SearchCategoryBtn.Name = "SearchCategoryBtn";
            SearchCategoryBtn.Size = new Size(239, 29);
            SearchCategoryBtn.TabIndex = 1;
            SearchCategoryBtn.Text = "Search";
            SearchCategoryBtn.UseVisualStyleBackColor = true;
            SearchCategoryBtn.Click += SearchCategoryBtn_Click;
            // 
            // ChoiseCategoryLbl
            // 
            ChoiseCategoryLbl.AutoSize = true;
            ChoiseCategoryLbl.Font = new Font("Simplified Arabic Fixed", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ChoiseCategoryLbl.Location = new Point(179, 64);
            ChoiseCategoryLbl.Name = "ChoiseCategoryLbl";
            ChoiseCategoryLbl.Size = new Size(365, 45);
            ChoiseCategoryLbl.TabIndex = 2;
            ChoiseCategoryLbl.Text = "Choise Category";
            // 
            // UserMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ChoiseCategoryLbl);
            Controls.Add(SearchCategoryBtn);
            Controls.Add(CategoriesOptionsList);
            Name = "UserMainForm";
            Text = "UserMainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CategoriesOptionsList;
        private Button SearchCategoryBtn;
        private Label ChoiseCategoryLbl;
    }
}