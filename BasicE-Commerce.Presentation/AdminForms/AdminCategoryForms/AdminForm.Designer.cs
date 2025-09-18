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
            logOutbtn = new Button();
            mangmentOrderbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            AddNewProductBtn = new Button();
            LoadProductsBtn = new Button();
            logoPanel = new Panel();
            logoLabel = new Label();
            panel2 = new Panel();
            headerPanel = new Panel();
            titleLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)CategoryListGrid).BeginInit();
            sidePanel.SuspendLayout();
            logoPanel.SuspendLayout();
            panel2.SuspendLayout();
            headerPanel.SuspendLayout();
            SuspendLayout();

            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(45, 52, 62);
            sidePanel.Controls.Add(logOutbtn);
            sidePanel.Controls.Add(mangmentOrderbtn);
            sidePanel.Controls.Add(label1);
            sidePanel.Controls.Add(AddNewProductBtn);
            sidePanel.Controls.Add(LoadProductsBtn);
            sidePanel.Controls.Add(label2);
            sidePanel.Controls.Add(AddNewCategoryBtn);
            sidePanel.Controls.Add(LoadCategoriesBtn);
            sidePanel.Controls.Add(logoPanel);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(220, 600);
            sidePanel.TabIndex = 3;
            sidePanel.Paint += sidePanel_Paint;

            // 
            // logoPanel
            // 
            logoPanel.BackColor = Color.FromArgb(33, 37, 43);
            logoPanel.Controls.Add(logoLabel);
            logoPanel.Dock = DockStyle.Top;
            logoPanel.Location = new Point(0, 0);
            logoPanel.Name = "logoPanel";
            logoPanel.Size = new Size(220, 80);
            logoPanel.TabIndex = 7;

            // 
            // logoLabel
            // 
            logoLabel.Dock = DockStyle.Fill;
            logoLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoLabel.ForeColor = Color.FromArgb(74, 144, 226);
            logoLabel.Location = new Point(0, 0);
            logoLabel.Name = "logoLabel";
            logoLabel.Size = new Size(220, 80);
            logoLabel.TabIndex = 0;
            logoLabel.Text = "ADMIN PANEL";
            logoLabel.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(74, 144, 226);
            label2.Location = new Point(15, 95);
            label2.Name = "label2";
            label2.Size = new Size(88, 21);
            label2.TabIndex = 3;
            label2.Text = "Categories";

            // 
            // LoadCategoriesBtn
            // 
            LoadCategoriesBtn.BackColor = Color.FromArgb(52, 58, 64);
            LoadCategoriesBtn.Cursor = Cursors.Hand;
            LoadCategoriesBtn.FlatAppearance.BorderSize = 0;
            LoadCategoriesBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 144, 226);
            LoadCategoriesBtn.FlatStyle = FlatStyle.Flat;
            LoadCategoriesBtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoadCategoriesBtn.ForeColor = Color.White;
            LoadCategoriesBtn.Location = new Point(10, 125);
            LoadCategoriesBtn.Margin = new Padding(3, 2, 3, 2);
            LoadCategoriesBtn.Name = "LoadCategoriesBtn";
            LoadCategoriesBtn.Size = new Size(200, 45);
            LoadCategoriesBtn.TabIndex = 2;
            LoadCategoriesBtn.Text = "📂 Load Categories";
            LoadCategoriesBtn.TextAlign = ContentAlignment.MiddleLeft;
            LoadCategoriesBtn.UseVisualStyleBackColor = false;
            LoadCategoriesBtn.Click += LoadCategoriesBtn_Click;

            // 
            // AddNewCategoryBtn
            // 
            AddNewCategoryBtn.BackColor = Color.FromArgb(52, 58, 64);
            AddNewCategoryBtn.Cursor = Cursors.Hand;
            AddNewCategoryBtn.FlatAppearance.BorderSize = 0;
            AddNewCategoryBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 167, 69);
            AddNewCategoryBtn.FlatStyle = FlatStyle.Flat;
            AddNewCategoryBtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddNewCategoryBtn.ForeColor = Color.White;
            AddNewCategoryBtn.Location = new Point(10, 175);
            AddNewCategoryBtn.Margin = new Padding(3, 2, 3, 2);
            AddNewCategoryBtn.Name = "AddNewCategoryBtn";
            AddNewCategoryBtn.Size = new Size(200, 45);
            AddNewCategoryBtn.TabIndex = 0;
            AddNewCategoryBtn.Text = "➕ Add New Category";
            AddNewCategoryBtn.TextAlign = ContentAlignment.MiddleLeft;
            AddNewCategoryBtn.UseVisualStyleBackColor = false;
            AddNewCategoryBtn.Click += AddNewCategoryBtn_Click;

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(74, 144, 226);
            label1.Location = new Point(15, 240);
            label1.Name = "label1";
            label1.Size = new Size(76, 21);
            label1.TabIndex = 2;
            label1.Text = "Products";

            // 
            // LoadProductsBtn
            // 
            LoadProductsBtn.BackColor = Color.FromArgb(52, 58, 64);
            LoadProductsBtn.Cursor = Cursors.Hand;
            LoadProductsBtn.FlatAppearance.BorderSize = 0;
            LoadProductsBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 144, 226);
            LoadProductsBtn.FlatStyle = FlatStyle.Flat;
            LoadProductsBtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoadProductsBtn.ForeColor = Color.White;
            LoadProductsBtn.Location = new Point(10, 270);
            LoadProductsBtn.Margin = new Padding(3, 2, 3, 2);
            LoadProductsBtn.Name = "LoadProductsBtn";
            LoadProductsBtn.Size = new Size(200, 45);
            LoadProductsBtn.TabIndex = 3;
            LoadProductsBtn.Text = "📦 Load Products";
            LoadProductsBtn.TextAlign = ContentAlignment.MiddleLeft;
            LoadProductsBtn.UseVisualStyleBackColor = false;
            LoadProductsBtn.Click += LoadProductsBtn_Click;

            // 
            // AddNewProductBtn
            // 
            AddNewProductBtn.BackColor = Color.FromArgb(52, 58, 64);
            AddNewProductBtn.Cursor = Cursors.Hand;
            AddNewProductBtn.FlatAppearance.BorderSize = 0;
            AddNewProductBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 167, 69);
            AddNewProductBtn.FlatStyle = FlatStyle.Flat;
            AddNewProductBtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddNewProductBtn.ForeColor = Color.White;
            AddNewProductBtn.Location = new Point(10, 320);
            AddNewProductBtn.Margin = new Padding(3, 2, 3, 2);
            AddNewProductBtn.Name = "AddNewProductBtn";
            AddNewProductBtn.Size = new Size(200, 45);
            AddNewProductBtn.TabIndex = 4;
            AddNewProductBtn.Text = "🛍️ Add New Product";
            AddNewProductBtn.TextAlign = ContentAlignment.MiddleLeft;
            AddNewProductBtn.UseVisualStyleBackColor = false;
            AddNewProductBtn.Click += AddNewProductBtn_Click;

            // 
            // mangmentOrderbtn
            // 
            mangmentOrderbtn.BackColor = Color.FromArgb(52, 58, 64);
            mangmentOrderbtn.Cursor = Cursors.Hand;
            mangmentOrderbtn.FlatAppearance.BorderSize = 0;
            mangmentOrderbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 193, 7);
            mangmentOrderbtn.FlatStyle = FlatStyle.Flat;
            mangmentOrderbtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mangmentOrderbtn.ForeColor = Color.White;
            mangmentOrderbtn.Location = new Point(10, 400);
            mangmentOrderbtn.Margin = new Padding(3, 2, 3, 2);
            mangmentOrderbtn.Name = "mangmentOrderbtn";
            mangmentOrderbtn.Size = new Size(200, 45);
            mangmentOrderbtn.TabIndex = 5;
            mangmentOrderbtn.Text = "📋 Manage Orders";
            mangmentOrderbtn.TextAlign = ContentAlignment.MiddleLeft;
            mangmentOrderbtn.UseVisualStyleBackColor = false;
            mangmentOrderbtn.Click += mangmentOrderbtn_Click;

            // 
            // logOutbtn
            // 
            logOutbtn.BackColor = Color.FromArgb(220, 53, 69);
            logOutbtn.Cursor = Cursors.Hand;
            logOutbtn.FlatAppearance.BorderSize = 0;
            logOutbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 35, 51);
            logOutbtn.FlatStyle = FlatStyle.Flat;
            logOutbtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logOutbtn.ForeColor = Color.White;
            logOutbtn.Location = new Point(10, 550);
            logOutbtn.Name = "logOutbtn";
            logOutbtn.Size = new Size(200, 40);
            logOutbtn.TabIndex = 6;
            logOutbtn.Text = "🚪 Logout";
            logOutbtn.UseVisualStyleBackColor = false;
            logOutbtn.Click += button1_Click;

            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(248, 249, 250);
            headerPanel.Controls.Add(titleLabel);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(220, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(780, 70);
            headerPanel.TabIndex = 4;

            // 
            // titleLabel
            // 
            titleLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.FromArgb(33, 37, 43);
            titleLabel.Location = new Point(20, 15);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(400, 40);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Admin Dashboard";
            titleLabel.TextAlign = ContentAlignment.MiddleLeft;

            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(CategoryListGrid);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(220, 70);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(20);
            panel2.Size = new Size(780, 530);
            panel2.TabIndex = 5;

            // 
            // CategoryListGrid
            // 
            CategoryListGrid.AllowUserToAddRows = false;
            CategoryListGrid.BackgroundColor = Color.White;
            CategoryListGrid.BorderStyle = BorderStyle.None;
            CategoryListGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            CategoryListGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            CategoryListGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(74, 144, 226);
            CategoryListGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CategoryListGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            CategoryListGrid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(74, 144, 226);
            CategoryListGrid.ColumnHeadersHeight = 45;
            CategoryListGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            CategoryListGrid.DefaultCellStyle.BackColor = Color.White;
            CategoryListGrid.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CategoryListGrid.DefaultCellStyle.ForeColor = Color.FromArgb(33, 37, 43);
            CategoryListGrid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 244, 255);
            CategoryListGrid.DefaultCellStyle.SelectionForeColor = Color.FromArgb(33, 37, 43);
            CategoryListGrid.Dock = DockStyle.Fill;
            CategoryListGrid.EnableHeadersVisualStyles = false;
            CategoryListGrid.GridColor = Color.FromArgb(224, 224, 224);
            CategoryListGrid.Location = new Point(20, 20);
            CategoryListGrid.Margin = new Padding(3, 2, 3, 2);
            CategoryListGrid.MultiSelect = false;
            CategoryListGrid.Name = "CategoryListGrid";
            CategoryListGrid.RowHeadersVisible = false;
            CategoryListGrid.RowHeadersWidth = 51;
            CategoryListGrid.RowTemplate.Height = 35;
            CategoryListGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CategoryListGrid.Size = new Size(740, 490);
            CategoryListGrid.TabIndex = 1;
            CategoryListGrid.CellContentClick += CategoryListGrid_CellContentClick;

            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 600);
            Controls.Add(panel2);
            Controls.Add(headerPanel);
            Controls.Add(sidePanel);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = true;
            MinimumSize = new Size(1000, 600);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "E-Commerce Admin Panel";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)CategoryListGrid).EndInit();
            sidePanel.ResumeLayout(false);
            sidePanel.PerformLayout();
            logoPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
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
        private Button logOutbtn;
        private Panel logoPanel;
        private Label logoLabel;
        private Panel headerPanel;
        private Label titleLabel;
    }
}