namespace BasicE_Commerce.Presentation.AdminForms
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            AddNewCategoryBtn = new Button();
            CategoryListGrid = new DataGridView();
            LoadCategoriesBtn = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            AddNewProductBtn = new Button();
            LoadProductsBtn = new Button();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)CategoryListGrid).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // AddNewCategoryBtn
            // 
            AddNewCategoryBtn.Location = new Point(3, 96);
            AddNewCategoryBtn.Margin = new Padding(3, 2, 3, 2);
            AddNewCategoryBtn.Name = "AddNewCategoryBtn";
            AddNewCategoryBtn.Size = new Size(197, 62);
            AddNewCategoryBtn.TabIndex = 0;
            AddNewCategoryBtn.Text = "Add New Category";
            AddNewCategoryBtn.UseVisualStyleBackColor = true;
            AddNewCategoryBtn.Click += AddNewCategoryBtn_Click;
            // 
            // CategoryListGrid
            // 
            CategoryListGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CategoryListGrid.Dock = DockStyle.Fill;
            CategoryListGrid.Location = new Point(0, 0);
            CategoryListGrid.Margin = new Padding(3, 2, 3, 2);
            CategoryListGrid.Name = "CategoryListGrid";
            CategoryListGrid.RowHeadersWidth = 51;
            CategoryListGrid.Size = new Size(735, 373);
            CategoryListGrid.TabIndex = 1;
            // 
            // LoadCategoriesBtn
            // 
            LoadCategoriesBtn.Location = new Point(3, 36);
            LoadCategoriesBtn.Margin = new Padding(3, 2, 3, 2);
            LoadCategoriesBtn.Name = "LoadCategoriesBtn";
            LoadCategoriesBtn.Size = new Size(197, 56);
            LoadCategoriesBtn.TabIndex = 2;
            LoadCategoriesBtn.Text = "Load Catrgor";
            LoadCategoriesBtn.UseVisualStyleBackColor = true;
            LoadCategoriesBtn.Click += LoadCategoriesBtn_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(AddNewProductBtn);
            panel1.Controls.Add(LoadProductsBtn);
            panel1.Controls.Add(LoadCategoriesBtn);
            panel1.Controls.Add(AddNewCategoryBtn);
            panel1.Location = new Point(12, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(203, 373);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 179);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 2;
            label1.Text = "Product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 11);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 3;
            label2.Text = "Category";
            // 
            // AddNewProductBtn
            // 
            AddNewProductBtn.Location = new Point(3, 267);
            AddNewProductBtn.Margin = new Padding(3, 2, 3, 2);
            AddNewProductBtn.Name = "AddNewProductBtn";
            AddNewProductBtn.Size = new Size(196, 54);
            AddNewProductBtn.TabIndex = 4;
            AddNewProductBtn.Text = "Add New Product";
            AddNewProductBtn.UseVisualStyleBackColor = true;
            AddNewProductBtn.Click += AddNewProductBtn_Click;
            // 
            // LoadProductsBtn
            // 
            LoadProductsBtn.Location = new Point(3, 208);
            LoadProductsBtn.Margin = new Padding(3, 2, 3, 2);
            LoadProductsBtn.Name = "LoadProductsBtn";
            LoadProductsBtn.Size = new Size(196, 55);
            LoadProductsBtn.TabIndex = 3;
            LoadProductsBtn.Text = "Load Product";
            LoadProductsBtn.UseVisualStyleBackColor = true;
            LoadProductsBtn.Click += LoadProductsBtn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(CategoryListGrid);
            panel2.Location = new Point(221, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(735, 373);
            panel2.TabIndex = 4;
            // 
            // AdminCategoriesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 388);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminCategoriesForm";
            Text = "Admin Form";
            ((System.ComponentModel.ISupportInitialize)CategoryListGrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button AddNewCategoryBtn;
        private DataGridView CategoryListGrid;
        private Button LoadCategoriesBtn;
        private Panel panel1;
        private Panel panel2;
        private Button LoadProductsBtn;
        private Label label1;
        private Label label2;
        private Button AddNewProductBtn;
    }
}