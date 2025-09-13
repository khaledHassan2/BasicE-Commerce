namespace BasicE_Commerce.Presentation.AdminForms
{
    partial class AdminCategoriesForm
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
            AddNewCategoryBtn = new Button();
            CategoryListGrid = new DataGridView();
            LoadCategoriesBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)CategoryListGrid).BeginInit();
            SuspendLayout();
            // 
            // AddNewCategoryBtn
            // 
            AddNewCategoryBtn.Location = new Point(627, 33);
            AddNewCategoryBtn.Name = "AddNewCategoryBtn";
            AddNewCategoryBtn.Size = new Size(145, 42);
            AddNewCategoryBtn.TabIndex = 0;
            AddNewCategoryBtn.Text = "Add New Category";
            AddNewCategoryBtn.UseVisualStyleBackColor = true;
            AddNewCategoryBtn.Click += AddNewCategoryBtn_Click;
            // 
            // CategoryListGrid
            // 
            CategoryListGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CategoryListGrid.Location = new Point(1, 115);
            CategoryListGrid.Name = "CategoryListGrid";
            CategoryListGrid.RowHeadersWidth = 51;
            CategoryListGrid.Size = new Size(797, 333);
            CategoryListGrid.TabIndex = 1;
            // 
            // LoadCategoriesBtn
            // 
            LoadCategoriesBtn.Location = new Point(62, 33);
            LoadCategoriesBtn.Name = "LoadCategoriesBtn";
            LoadCategoriesBtn.Size = new Size(145, 42);
            LoadCategoriesBtn.TabIndex = 2;
            LoadCategoriesBtn.Text = "Load";
            LoadCategoriesBtn.UseVisualStyleBackColor = true;
            LoadCategoriesBtn.Click += LoadCategoriesBtn_Click;
            // 
            // AdminCategoriesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LoadCategoriesBtn);
            Controls.Add(CategoryListGrid);
            Controls.Add(AddNewCategoryBtn);
            Name = "AdminCategoriesForm";
            Text = "AdminCategoriesForm";
            ((System.ComponentModel.ISupportInitialize)CategoryListGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button AddNewCategoryBtn;
        private DataGridView CategoryListGrid;
        private Button LoadCategoriesBtn;
    }
}