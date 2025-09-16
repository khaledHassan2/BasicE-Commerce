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
            sidePanel = new Panel();
            label1 = new Label();
            label2 = new Label();
            AddNewProductBtn = new Button();
            LoadProductsBtn = new Button();
            panel2 = new Panel();
            mangmentOrderbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)CategoryListGrid).BeginInit();
            sidePanel.SuspendLayout();
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
            CategoryListGrid.Size = new Size(735, 349);
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
            // sidePanel
            // 
            sidePanel.BackColor = SystemColors.ActiveCaption;
            sidePanel.Controls.Add(mangmentOrderbtn);
            sidePanel.Controls.Add(label1);
            sidePanel.Controls.Add(label2);
            sidePanel.Controls.Add(AddNewProductBtn);
            sidePanel.Controls.Add(LoadProductsBtn);
            sidePanel.Controls.Add(LoadCategoriesBtn);
            sidePanel.Controls.Add(AddNewCategoryBtn);
            sidePanel.Dock = DockStyle.Fill;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(968, 388);
            sidePanel.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 160);
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
            AddNewProductBtn.Location = new Point(4, 236);
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
            LoadProductsBtn.Location = new Point(4, 177);
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
            panel2.Location = new Point(221, 36);
            panel2.Name = "panel2";
            panel2.Size = new Size(735, 349);
            panel2.TabIndex = 4;
            // 
            // mangmentOrderbtn
            // 
            mangmentOrderbtn.Location = new Point(4, 294);
            mangmentOrderbtn.Margin = new Padding(3, 2, 3, 2);
            mangmentOrderbtn.Name = "mangmentOrderbtn";
            mangmentOrderbtn.Size = new Size(196, 54);
            mangmentOrderbtn.TabIndex = 5;
            mangmentOrderbtn.Text = "Mangment Orders";
            mangmentOrderbtn.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 388);
            Controls.Add(panel2);
            Controls.Add(sidePanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Form";
            ((System.ComponentModel.ISupportInitialize)CategoryListGrid).EndInit();
            sidePanel.ResumeLayout(false);
            sidePanel.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button AddNewCategoryBtn;
        private DataGridView CategoryListGrid;
        private Button LoadCategoriesBtn;
        private Panel sidePanel;
        private Panel panel2;
        private Button LoadProductsBtn;
        private Label label1;
        private Label label2;
        private Button AddNewProductBtn;
        private Button mangmentOrderbtn;
    }
}