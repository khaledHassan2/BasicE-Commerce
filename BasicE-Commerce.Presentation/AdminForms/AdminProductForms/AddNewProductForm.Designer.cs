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
            AddNewProductLbl.Location = new Point(343, 27);
            AddNewProductLbl.Margin = new Padding(5, 0, 5, 0);
            AddNewProductLbl.Name = "AddNewProductLbl";
            AddNewProductLbl.Size = new Size(380, 47);
            AddNewProductLbl.TabIndex = 0;
            AddNewProductLbl.Text = "Add New Product";
            // 
            // ProductNameinput
            // 
            ProductNameinput.BorderStyle = BorderStyle.FixedSingle;
            ProductNameinput.Location = new Point(194, 117);
            ProductNameinput.Margin = new Padding(5, 3, 5, 3);
            ProductNameinput.Name = "ProductNameinput";
            ProductNameinput.Size = new Size(418, 29);
            ProductNameinput.TabIndex = 1;
            // 
            // ProductDescriptionInput
            // 
            ProductDescriptionInput.BorderStyle = BorderStyle.FixedSingle;
            ProductDescriptionInput.Location = new Point(194, 177);
            ProductDescriptionInput.Margin = new Padding(5, 3, 5, 3);
            ProductDescriptionInput.Multiline = true;
            ProductDescriptionInput.Name = "ProductDescriptionInput";
            ProductDescriptionInput.Size = new Size(418, 69);
            ProductDescriptionInput.TabIndex = 2;
            // 
            // ProductNameLbl
            // 
            ProductNameLbl.AutoSize = true;
            ProductNameLbl.Location = new Point(50, 117);
            ProductNameLbl.Margin = new Padding(5, 0, 5, 0);
            ProductNameLbl.Name = "ProductNameLbl";
            ProductNameLbl.Size = new Size(54, 22);
            ProductNameLbl.TabIndex = 5;
            ProductNameLbl.Text = "Name";
            // 
            // ProuctDescriptionLbl
            // 
            ProuctDescriptionLbl.AutoSize = true;
            ProuctDescriptionLbl.Location = new Point(26, 196);
            ProuctDescriptionLbl.Margin = new Padding(5, 0, 5, 0);
            ProuctDescriptionLbl.Name = "ProuctDescriptionLbl";
            ProuctDescriptionLbl.Size = new Size(131, 22);
            ProuctDescriptionLbl.TabIndex = 6;
            ProuctDescriptionLbl.Text = "Description";
            // 
            // StockLbl
            // 
            StockLbl.AutoSize = true;
            StockLbl.Location = new Point(44, 287);
            StockLbl.Margin = new Padding(5, 0, 5, 0);
            StockLbl.Name = "StockLbl";
            StockLbl.Size = new Size(65, 22);
            StockLbl.TabIndex = 7;
            StockLbl.Text = "Stock";
            // 
            // PriceLbl
            // 
            PriceLbl.AutoSize = true;
            PriceLbl.Location = new Point(50, 359);
            PriceLbl.Margin = new Padding(5, 0, 5, 0);
            PriceLbl.Name = "PriceLbl";
            PriceLbl.Size = new Size(65, 22);
            PriceLbl.TabIndex = 8;
            PriceLbl.Text = "Price";
            // 
            // ProductStockInput
            // 
            ProductStockInput.BorderStyle = BorderStyle.FixedSingle;
            ProductStockInput.Location = new Point(194, 287);
            ProductStockInput.Margin = new Padding(5, 3, 5, 3);
            ProductStockInput.Name = "ProductStockInput";
            ProductStockInput.Size = new Size(418, 29);
            ProductStockInput.TabIndex = 9;
            // 
            // ProductPriceInput
            // 
            ProductPriceInput.DecimalPlaces = 2;
            ProductPriceInput.Location = new Point(194, 359);
            ProductPriceInput.Margin = new Padding(5, 3, 5, 3);
            ProductPriceInput.Name = "ProductPriceInput";
            ProductPriceInput.Size = new Size(418, 29);
            ProductPriceInput.TabIndex = 10;
            // 
            // ProductImageBox
            // 
            ProductImageBox.BackColor = SystemColors.InactiveBorder;
            ProductImageBox.BorderStyle = BorderStyle.FixedSingle;
            ProductImageBox.Location = new Point(785, 117);
            ProductImageBox.Margin = new Padding(5, 3, 5, 3);
            ProductImageBox.Name = "ProductImageBox";
            ProductImageBox.Size = new Size(228, 67);
            ProductImageBox.TabIndex = 11;
            ProductImageBox.TabStop = false;
            // 
            // ProductImageLbl
            // 
            ProductImageLbl.AutoSize = true;
            ProductImageLbl.Location = new Point(694, 233);
            ProductImageLbl.Margin = new Padding(5, 0, 5, 0);
            ProductImageLbl.Name = "ProductImageLbl";
            ProductImageLbl.Size = new Size(65, 22);
            ProductImageLbl.TabIndex = 12;
            ProductImageLbl.Text = "Image";
            ProductImageLbl.Click += ProductImageLbl_Click;
            // 
            // ProductUploadImageBtn
            // 
            ProductUploadImageBtn.ForeColor = SystemColors.ActiveCaptionText;
            ProductUploadImageBtn.Location = new Point(796, 223);
            ProductUploadImageBtn.Margin = new Padding(5, 3, 5, 3);
            ProductUploadImageBtn.Name = "ProductUploadImageBtn";
            ProductUploadImageBtn.Size = new Size(192, 32);
            ProductUploadImageBtn.TabIndex = 13;
            ProductUploadImageBtn.Text = "Uplaod Image";
            ProductUploadImageBtn.UseVisualStyleBackColor = true;
            ProductUploadImageBtn.Click += ProductUploadImageBtn_Click;
            // 
            // CategoryOptionsList
            // 
            CategoryOptionsList.FormattingEnabled = true;
            CategoryOptionsList.Location = new Point(796, 317);
            CategoryOptionsList.Margin = new Padding(5, 3, 5, 3);
            CategoryOptionsList.Name = "CategoryOptionsList";
            CategoryOptionsList.Size = new Size(207, 30);
            CategoryOptionsList.TabIndex = 14;
            CategoryOptionsList.SelectedIndexChanged += CategoryOptionsList_SelectedIndexChanged;
            // 
            // CategoriesOptionListLbl
            // 
            CategoriesOptionListLbl.AutoSize = true;
            CategoriesOptionListLbl.Location = new Point(656, 320);
            CategoriesOptionListLbl.Margin = new Padding(5, 0, 5, 0);
            CategoriesOptionListLbl.Name = "CategoriesOptionListLbl";
            CategoriesOptionListLbl.Size = new Size(120, 22);
            CategoriesOptionListLbl.TabIndex = 15;
            CategoriesOptionListLbl.Text = "Categories";
            // 
            // SaveNewProductBtn
            // 
            SaveNewProductBtn.ForeColor = Color.Black;
            SaveNewProductBtn.Location = new Point(400, 440);
            SaveNewProductBtn.Margin = new Padding(5, 3, 5, 3);
            SaveNewProductBtn.Name = "SaveNewProductBtn";
            SaveNewProductBtn.Size = new Size(336, 32);
            SaveNewProductBtn.TabIndex = 16;
            SaveNewProductBtn.Text = "Add";
            SaveNewProductBtn.UseVisualStyleBackColor = true;
            SaveNewProductBtn.Click += SaveNewProductBtn_Click;
            // 
            // AddNewProductForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1100, 496);
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
            Font = new Font("Courier New", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ButtonHighlight;
            Margin = new Padding(5, 3, 5, 3);
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