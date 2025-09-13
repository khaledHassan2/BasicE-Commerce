namespace BasicE_Commerce.Presentation.AdminForms.AdminProductForms
{
    partial class AddNewProductForm
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
            AddNewProductLbl = new Label();
            ProductNameinput = new TextBox();
            ProductDescriptionInput = new TextBox();
            ProductNameLbl = new Label();
            ProuctDescriptionLbl = new Label();
            StockLbl = new Label();
            PriceLbl = new Label();
            ProductStockInput = new NumericUpDown();
            ProductPriceInput = new NumericUpDown();
            ProductImageBox = new PictureBox();
            ProductImageLbl = new Label();
            ProductUploadImageBtn = new Button();
            CategoryOptionsList = new ComboBox();
            CategoriesOptionListLbl = new Label();
            SaveNewProductBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)ProductStockInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductPriceInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductImageBox).BeginInit();
            SuspendLayout();
            // 
            // AddNewProductLbl
            // 
            AddNewProductLbl.AutoSize = true;
            AddNewProductLbl.Font = new Font("Simplified Arabic Fixed", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            AddNewProductLbl.Location = new Point(191, 27);
            AddNewProductLbl.Name = "AddNewProductLbl";
            AddNewProductLbl.Size = new Size(459, 56);
            AddNewProductLbl.TabIndex = 0;
            AddNewProductLbl.Text = "Add New Product";
            // 
            // ProductNameinput
            // 
            ProductNameinput.Location = new Point(151, 105);
            ProductNameinput.Name = "ProductNameinput";
            ProductNameinput.Size = new Size(291, 27);
            ProductNameinput.TabIndex = 1;
            // 
            // ProductDescriptionInput
            // 
            ProductDescriptionInput.Location = new Point(151, 167);
            ProductDescriptionInput.Multiline = true;
            ProductDescriptionInput.Name = "ProductDescriptionInput";
            ProductDescriptionInput.Size = new Size(291, 63);
            ProductDescriptionInput.TabIndex = 2;
            // 
            // ProductNameLbl
            // 
            ProductNameLbl.AutoSize = true;
            ProductNameLbl.Location = new Point(32, 108);
            ProductNameLbl.Name = "ProductNameLbl";
            ProductNameLbl.Size = new Size(49, 20);
            ProductNameLbl.TabIndex = 5;
            ProductNameLbl.Text = "Name";
            // 
            // ProuctDescriptionLbl
            // 
            ProuctDescriptionLbl.AutoSize = true;
            ProuctDescriptionLbl.Location = new Point(12, 170);
            ProuctDescriptionLbl.Name = "ProuctDescriptionLbl";
            ProuctDescriptionLbl.Size = new Size(85, 20);
            ProuctDescriptionLbl.TabIndex = 6;
            ProuctDescriptionLbl.Text = "Description";
            // 
            // StockLbl
            // 
            StockLbl.AutoSize = true;
            StockLbl.Location = new Point(32, 261);
            StockLbl.Name = "StockLbl";
            StockLbl.Size = new Size(45, 20);
            StockLbl.TabIndex = 7;
            StockLbl.Text = "Stock";
            // 
            // PriceLbl
            // 
            PriceLbl.AutoSize = true;
            PriceLbl.Location = new Point(36, 327);
            PriceLbl.Name = "PriceLbl";
            PriceLbl.Size = new Size(41, 20);
            PriceLbl.TabIndex = 8;
            PriceLbl.Text = "Price";
            // 
            // ProductStockInput
            // 
            ProductStockInput.Location = new Point(151, 272);
            ProductStockInput.Name = "ProductStockInput";
            ProductStockInput.Size = new Size(291, 27);
            ProductStockInput.TabIndex = 9;
            // 
            // ProductPriceInput
            // 
            ProductPriceInput.DecimalPlaces = 2;
            ProductPriceInput.Location = new Point(151, 327);
            ProductPriceInput.Name = "ProductPriceInput";
            ProductPriceInput.Size = new Size(291, 27);
            ProductPriceInput.TabIndex = 10;
            // 
            // ProductImageBox
            // 
            ProductImageBox.Location = new Point(555, 86);
            ProductImageBox.Name = "ProductImageBox";
            ProductImageBox.Size = new Size(166, 62);
            ProductImageBox.TabIndex = 11;
            ProductImageBox.TabStop = false;
            // 
            // ProductImageLbl
            // 
            ProductImageLbl.AutoSize = true;
            ProductImageLbl.Location = new Point(472, 167);
            ProductImageLbl.Name = "ProductImageLbl";
            ProductImageLbl.Size = new Size(51, 20);
            ProductImageLbl.TabIndex = 12;
            ProductImageLbl.Text = "Image";
            // 
            // ProductUploadImageBtn
            // 
            ProductUploadImageBtn.Location = new Point(565, 170);
            ProductUploadImageBtn.Name = "ProductUploadImageBtn";
            ProductUploadImageBtn.Size = new Size(139, 29);
            ProductUploadImageBtn.TabIndex = 13;
            ProductUploadImageBtn.Text = "Uplaod Image";
            ProductUploadImageBtn.UseVisualStyleBackColor = true;
            ProductUploadImageBtn.Click += ProductUploadImageBtn_Click;
            // 
            // CategoryOptionsList
            // 
            CategoryOptionsList.FormattingEnabled = true;
            CategoryOptionsList.Location = new Point(555, 253);
            CategoryOptionsList.Name = "CategoryOptionsList";
            CategoryOptionsList.Size = new Size(151, 28);
            CategoryOptionsList.TabIndex = 14;
            CategoryOptionsList.SelectedIndexChanged += CategoryOptionsList_SelectedIndexChanged;
            // 
            // CategoriesOptionListLbl
            // 
            CategoriesOptionListLbl.AutoSize = true;
            CategoriesOptionListLbl.Location = new Point(469, 256);
            CategoriesOptionListLbl.Name = "CategoriesOptionListLbl";
            CategoriesOptionListLbl.Size = new Size(80, 20);
            CategoriesOptionListLbl.TabIndex = 15;
            CategoriesOptionListLbl.Text = "Categories";
            // 
            // SaveNewProductBtn
            // 
            SaveNewProductBtn.Location = new Point(264, 397);
            SaveNewProductBtn.Name = "SaveNewProductBtn";
            SaveNewProductBtn.Size = new Size(244, 29);
            SaveNewProductBtn.TabIndex = 16;
            SaveNewProductBtn.Text = "Add";
            SaveNewProductBtn.UseVisualStyleBackColor = true;
            SaveNewProductBtn.Click += SaveNewProductBtn_Click;
            // 
            // AddNewProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SaveNewProductBtn);
            Controls.Add(CategoriesOptionListLbl);
            Controls.Add(CategoryOptionsList);
            Controls.Add(ProductUploadImageBtn);
            Controls.Add(ProductImageLbl);
            Controls.Add(ProductImageBox);
            Controls.Add(ProductPriceInput);
            Controls.Add(ProductStockInput);
            Controls.Add(PriceLbl);
            Controls.Add(StockLbl);
            Controls.Add(ProuctDescriptionLbl);
            Controls.Add(ProductNameLbl);
            Controls.Add(ProductDescriptionInput);
            Controls.Add(ProductNameinput);
            Controls.Add(AddNewProductLbl);
            Name = "AddNewProductForm";
            Text = "AddNewProductForm";
            ((System.ComponentModel.ISupportInitialize)ProductStockInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductPriceInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductImageBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AddNewProductLbl;
        private TextBox ProductNameinput;
        private TextBox ProductDescriptionInput;
        private Label ProductNameLbl;
        private Label ProuctDescriptionLbl;
        private Label StockLbl;
        private Label PriceLbl;
        private NumericUpDown ProductStockInput;
        private NumericUpDown ProductPriceInput;
        private PictureBox ProductImageBox;
        private Label ProductImageLbl;
        private Button ProductUploadImageBtn;
        private ComboBox CategoryOptionsList;
        private Label CategoriesOptionListLbl;
        private Button SaveNewProductBtn;
    }
}