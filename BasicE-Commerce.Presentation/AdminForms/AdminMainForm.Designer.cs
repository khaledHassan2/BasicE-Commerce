namespace BasicE_Commerce.Presentation
{
    partial class AdminMainForm
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
            CategoriesBtn = new Button();
            ProductsBtn = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // CategoriesBtn
            // 
            CategoriesBtn.Location = new Point(283, 89);
            CategoriesBtn.Name = "CategoriesBtn";
            CategoriesBtn.Size = new Size(134, 42);
            CategoriesBtn.TabIndex = 0;
            CategoriesBtn.Text = "Categories";
            CategoriesBtn.UseVisualStyleBackColor = true;
            CategoriesBtn.Click += CategoriesBtn_Click;
            // 
            // ProductsBtn
            // 
            ProductsBtn.Location = new Point(453, 89);
            ProductsBtn.Name = "ProductsBtn";
            ProductsBtn.Size = new Size(134, 42);
            ProductsBtn.TabIndex = 1;
            ProductsBtn.Text = "Products";
            ProductsBtn.UseVisualStyleBackColor = true;
            ProductsBtn.Click += ProductsBtn_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 450);
            panel1.TabIndex = 2;
            // 
            // AdminMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 450);
            Controls.Add(panel1);
            Controls.Add(ProductsBtn);
            Controls.Add(CategoriesBtn);
            Name = "AdminMainForm";
            Text = "AdminMainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button CategoriesBtn;
        private Button ProductsBtn;
        private Panel panel1;
    }
}