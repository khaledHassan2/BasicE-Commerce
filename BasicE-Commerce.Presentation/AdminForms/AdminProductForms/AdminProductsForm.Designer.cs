namespace BasicE_Commerce.Presentation.AdminForms.AdminProductForms
{
    partial class AdminProductsForm
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
            ProductListGrid = new DataGridView();
            AddNewProductBtn = new Button();
            LoadProductsBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)ProductListGrid).BeginInit();
            SuspendLayout();
            // 
            // ProductListGrid
            // 
            ProductListGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductListGrid.Location = new Point(1, 71);
            ProductListGrid.Name = "ProductListGrid";
            ProductListGrid.RowHeadersWidth = 51;
            ProductListGrid.Size = new Size(798, 375);
            ProductListGrid.TabIndex = 0;
            // 
            // AddNewProductBtn
            // 
            AddNewProductBtn.Location = new Point(606, 12);
            AddNewProductBtn.Name = "AddNewProductBtn";
            AddNewProductBtn.Size = new Size(173, 47);
            AddNewProductBtn.TabIndex = 1;
            AddNewProductBtn.Text = "Add New Product";
            AddNewProductBtn.UseVisualStyleBackColor = true;
            AddNewProductBtn.Click += AddNewProductBtn_Click;
            // 
            // LoadProductsBtn
            // 
            LoadProductsBtn.Location = new Point(47, 12);
            LoadProductsBtn.Name = "LoadProductsBtn";
            LoadProductsBtn.Size = new Size(173, 47);
            LoadProductsBtn.TabIndex = 2;
            LoadProductsBtn.Text = "Load";
            LoadProductsBtn.UseVisualStyleBackColor = true;
            LoadProductsBtn.Click += LoadProductsBtn_Click;
            // 
            // AdminProductsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LoadProductsBtn);
            Controls.Add(AddNewProductBtn);
            Controls.Add(ProductListGrid);
            Name = "AdminProductsForm";
            Text = "AdminProductsForm";
            ((System.ComponentModel.ISupportInitialize)ProductListGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ProductListGrid;
        private Button AddNewProductBtn;
        private Button LoadProductsBtn;
    }
}