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
            headerPanel = new Panel();
            iconLabel = new Label();
            formPanel = new Panel();
            leftPanel = new Panel();
            rightPanel = new Panel();
            buttonPanel = new Panel();
            cancelBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)ProductStockInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductPriceInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductImageBox).BeginInit();
            headerPanel.SuspendLayout();
            formPanel.SuspendLayout();
            leftPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            buttonPanel.SuspendLayout();
            SuspendLayout();

            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(74, 144, 226);
            headerPanel.Controls.Add(iconLabel);
            headerPanel.Controls.Add(AddNewProductLbl);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(900, 80);
            headerPanel.TabIndex = 0;

            // 
            // iconLabel
            // 
            iconLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconLabel.ForeColor = Color.White;
            iconLabel.Location = new Point(30, 20);
            iconLabel.Name = "iconLabel";
            iconLabel.Size = new Size(60, 40);
            iconLabel.TabIndex = 1;
            iconLabel.Text = "🛍️";
            iconLabel.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // AddNewProductLbl
            // 
            AddNewProductLbl.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddNewProductLbl.ForeColor = Color.White;
            AddNewProductLbl.Location = new Point(100, 20);
            AddNewProductLbl.Name = "AddNewProductLbl";
            AddNewProductLbl.Size = new Size(300, 40);
            AddNewProductLbl.TabIndex = 0;
            AddNewProductLbl.Text = "Add New Product";
            AddNewProductLbl.TextAlign = ContentAlignment.MiddleLeft;

            // 
            // formPanel
            // 
            formPanel.BackColor = Color.White;
            formPanel.Controls.Add(rightPanel);
            formPanel.Controls.Add(leftPanel);
            formPanel.Dock = DockStyle.Fill;
            formPanel.Location = new Point(0, 80);
            formPanel.Name = "formPanel";
            formPanel.Padding = new Padding(30, 20, 30, 20);
            formPanel.Size = new Size(900, 450);
            formPanel.TabIndex = 1;

            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(CategoryOptionsList);
            leftPanel.Controls.Add(CategoriesOptionListLbl);
            leftPanel.Controls.Add(ProductUploadImageBtn);
            leftPanel.Controls.Add(ProductImageLbl);
            leftPanel.Controls.Add(ProductPriceInput);
            leftPanel.Controls.Add(PriceLbl);
            leftPanel.Controls.Add(ProductStockInput);
            leftPanel.Controls.Add(StockLbl);
            leftPanel.Controls.Add(ProductDescriptionInput);
            leftPanel.Controls.Add(ProuctDescriptionLbl);
            leftPanel.Controls.Add(ProductNameinput);
            leftPanel.Controls.Add(ProductNameLbl);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(30, 20);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(400, 410);
            leftPanel.TabIndex = 0;

            // 
            // ProductNameLbl
            // 
            ProductNameLbl.AutoSize = true;
            ProductNameLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductNameLbl.ForeColor = Color.FromArgb(52, 58, 64);
            ProductNameLbl.Location = new Point(20, 20);
            ProductNameLbl.Name = "ProductNameLbl";
            ProductNameLbl.Size = new Size(117, 21);
            ProductNameLbl.TabIndex = 5;
            ProductNameLbl.Text = "Product Name";

            // 
            // ProductNameinput
            // 
            ProductNameinput.BackColor = Color.FromArgb(248, 249, 250);
            ProductNameinput.BorderStyle = BorderStyle.FixedSingle;
            ProductNameinput.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductNameinput.ForeColor = Color.FromArgb(33, 37, 43);
            ProductNameinput.Location = new Point(20, 50);
            ProductNameinput.Name = "ProductNameinput";
            ProductNameinput.Size = new Size(350, 27);
            ProductNameinput.TabIndex = 1;

            // 
            // ProuctDescriptionLbl
            // 
            ProuctDescriptionLbl.AutoSize = true;
            ProuctDescriptionLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProuctDescriptionLbl.ForeColor = Color.FromArgb(52, 58, 64);
            ProuctDescriptionLbl.Location = new Point(20, 90);
            ProuctDescriptionLbl.Name = "ProuctDescriptionLbl";
            ProuctDescriptionLbl.Size = new Size(95, 21);
            ProuctDescriptionLbl.TabIndex = 6;
            ProuctDescriptionLbl.Text = "Description";

            // 
            // ProductDescriptionInput
            // 
            ProductDescriptionInput.BackColor = Color.FromArgb(248, 249, 250);
            ProductDescriptionInput.BorderStyle = BorderStyle.FixedSingle;
            ProductDescriptionInput.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductDescriptionInput.ForeColor = Color.FromArgb(33, 37, 43);
            ProductDescriptionInput.Location = new Point(20, 120);
            ProductDescriptionInput.Multiline = true;
            ProductDescriptionInput.Name = "ProductDescriptionInput";
            ProductDescriptionInput.ScrollBars = ScrollBars.Vertical;
            ProductDescriptionInput.Size = new Size(350, 60);
            ProductDescriptionInput.TabIndex = 2;

            // 
            // StockLbl
            // 
            StockLbl.AutoSize = true;
            StockLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StockLbl.ForeColor = Color.FromArgb(52, 58, 64);
            StockLbl.Location = new Point(20, 195);
            StockLbl.Name = "StockLbl";
            StockLbl.Size = new Size(116, 21);
            StockLbl.TabIndex = 7;
            StockLbl.Text = "Stock Quantity";

            // 
            // ProductStockInput
            // 
            ProductStockInput.BackColor = Color.FromArgb(248, 249, 250);
            ProductStockInput.BorderStyle = BorderStyle.FixedSingle;
            ProductStockInput.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductStockInput.ForeColor = Color.FromArgb(33, 37, 43);
            ProductStockInput.Location = new Point(20, 225);
            ProductStockInput.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            ProductStockInput.Name = "ProductStockInput";
            ProductStockInput.Size = new Size(150, 27);
            ProductStockInput.TabIndex = 9;

            // 
            // PriceLbl
            // 
            PriceLbl.AutoSize = true;
            PriceLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PriceLbl.ForeColor = Color.FromArgb(52, 58, 64);
            PriceLbl.Location = new Point(220, 195);
            PriceLbl.Name = "PriceLbl";
            PriceLbl.Size = new Size(44, 21);
            PriceLbl.TabIndex = 8;
            PriceLbl.Text = "Price";

            // 
            // ProductPriceInput
            // 
            ProductPriceInput.BackColor = Color.FromArgb(248, 249, 250);
            ProductPriceInput.BorderStyle = BorderStyle.FixedSingle;
            ProductPriceInput.DecimalPlaces = 2;
            ProductPriceInput.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductPriceInput.ForeColor = Color.FromArgb(33, 37, 43);
            ProductPriceInput.Location = new Point(220, 225);
            ProductPriceInput.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            ProductPriceInput.Name = "ProductPriceInput";
            ProductPriceInput.Size = new Size(150, 27);
            ProductPriceInput.TabIndex = 10;

            // 
            // CategoriesOptionListLbl
            // 
            CategoriesOptionListLbl.AutoSize = true;
            CategoriesOptionListLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CategoriesOptionListLbl.ForeColor = Color.FromArgb(52, 58, 64);
            CategoriesOptionListLbl.Location = new Point(20, 270);
            CategoriesOptionListLbl.Name = "CategoriesOptionListLbl";
            CategoriesOptionListLbl.Size = new Size(80, 21);
            CategoriesOptionListLbl.TabIndex = 15;
            CategoriesOptionListLbl.Text = "Category";

            // 
            // CategoryOptionsList
            // 
            CategoryOptionsList.BackColor = Color.FromArgb(248, 249, 250);
            CategoryOptionsList.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoryOptionsList.FlatStyle = FlatStyle.Flat;
            CategoryOptionsList.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CategoryOptionsList.ForeColor = Color.FromArgb(33, 37, 43);
            CategoryOptionsList.FormattingEnabled = true;
            CategoryOptionsList.Location = new Point(20, 300);
            CategoryOptionsList.Name = "CategoryOptionsList";
            CategoryOptionsList.Size = new Size(200, 28);
            CategoryOptionsList.TabIndex = 14;
            CategoryOptionsList.SelectedIndexChanged += CategoryOptionsList_SelectedIndexChanged;

            // 
            // ProductImageLbl
            // 
            ProductImageLbl.AutoSize = true;
            ProductImageLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductImageLbl.ForeColor = Color.FromArgb(52, 58, 64);
            ProductImageLbl.Location = new Point(20, 340);
            ProductImageLbl.Name = "ProductImageLbl";
            ProductImageLbl.Size = new Size(117, 21);
            ProductImageLbl.TabIndex = 12;
            ProductImageLbl.Text = "Product Image";
            ProductImageLbl.Click += ProductImageLbl_Click;

            // 
            // ProductUploadImageBtn
            // 
            ProductUploadImageBtn.BackColor = Color.FromArgb(108, 117, 125);
            ProductUploadImageBtn.Cursor = Cursors.Hand;
            ProductUploadImageBtn.FlatAppearance.BorderSize = 0;
            ProductUploadImageBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 98, 104);
            ProductUploadImageBtn.FlatStyle = FlatStyle.Flat;
            ProductUploadImageBtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductUploadImageBtn.ForeColor = Color.White;
            ProductUploadImageBtn.Location = new Point(20, 370);
            ProductUploadImageBtn.Name = "ProductUploadImageBtn";
            ProductUploadImageBtn.Size = new Size(150, 35);
            ProductUploadImageBtn.TabIndex = 13;
            ProductUploadImageBtn.Text = "📁 Upload Image";
            ProductUploadImageBtn.UseVisualStyleBackColor = false;
            ProductUploadImageBtn.Click += ProductUploadImageBtn_Click;

            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(ProductImageBox);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Location = new Point(430, 20);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(440, 410);
            rightPanel.TabIndex = 1;

            // 
            // ProductImageBox
            // 
            ProductImageBox.BackColor = Color.FromArgb(248, 249, 250);
            ProductImageBox.BorderStyle = BorderStyle.FixedSingle;
            ProductImageBox.Location = new Point(20, 20);
            ProductImageBox.Name = "ProductImageBox";
            ProductImageBox.Size = new Size(400, 350);
            ProductImageBox.SizeMode = PictureBoxSizeMode.Zoom;
            ProductImageBox.TabIndex = 11;
            ProductImageBox.TabStop = false;

            // 
            // buttonPanel
            // 
            buttonPanel.BackColor = Color.FromArgb(248, 249, 250);
            buttonPanel.Controls.Add(cancelBtn);
            buttonPanel.Controls.Add(SaveNewProductBtn);
            buttonPanel.Dock = DockStyle.Bottom;
            buttonPanel.Location = new Point(0, 530);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Size = new Size(900, 80);
            buttonPanel.TabIndex = 2;

            // 
            // SaveNewProductBtn
            // 
            SaveNewProductBtn.BackColor = Color.FromArgb(40, 167, 69);
            SaveNewProductBtn.Cursor = Cursors.Hand;
            SaveNewProductBtn.FlatAppearance.BorderSize = 0;
            SaveNewProductBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 139, 58);
            SaveNewProductBtn.FlatStyle = FlatStyle.Flat;
            SaveNewProductBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveNewProductBtn.ForeColor = Color.White;
            SaveNewProductBtn.Location = new Point(700, 20);
            SaveNewProductBtn.Name = "SaveNewProductBtn";
            SaveNewProductBtn.Size = new Size(150, 40);
            SaveNewProductBtn.TabIndex = 16;
            SaveNewProductBtn.Text = "✅ Save Product";
            SaveNewProductBtn.UseVisualStyleBackColor = false;
            SaveNewProductBtn.Click += SaveNewProductBtn_Click;

            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.FromArgb(108, 117, 125);
            cancelBtn.Cursor = Cursors.Hand;
            cancelBtn.FlatAppearance.BorderSize = 0;
            cancelBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 98, 104);
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelBtn.ForeColor = Color.White;
            cancelBtn.Location = new Point(540, 20);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(150, 40);
            cancelBtn.TabIndex = 17;
            cancelBtn.Text = "❌ Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += new EventHandler(this.cancelBtn_Click);

            // 
            // AddNewProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 610);
            Controls.Add(formPanel);
            Controls.Add(buttonPanel);
            Controls.Add(headerPanel);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddNewProductForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add New Product";
            ((System.ComponentModel.ISupportInitialize)ProductStockInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductPriceInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductImageBox).EndInit();
            headerPanel.ResumeLayout(false);
            formPanel.ResumeLayout(false);
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            rightPanel.ResumeLayout(false);
            buttonPanel.ResumeLayout(false);
            ResumeLayout(false);
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
        private Panel headerPanel;
        private Label iconLabel;
        private Panel formPanel;
        private Panel leftPanel;
        private Panel rightPanel;
        private Panel buttonPanel;
        private Button cancelBtn;

        // Add this method to handle cancel button click
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to cancel? Any unsaved changes will be lost.",
                                       "Confirm Cancel",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}