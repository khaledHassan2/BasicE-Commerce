namespace BasicE_Commerce.Presentation
{
    partial class UserMainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label headerLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.sidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Width = 200;
            this.sidePanel.Controls.Add(this.btnProducts);
            this.sidePanel.Controls.Add(this.btnCategories);
            // 
            // btnCategories
            // 
            this.btnCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategories.Height = 50;
            this.btnCategories.Text = "Categories";
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProducts.Height = 50;
            this.btnProducts.Text = "Products";
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnCart
            // 
            this.btnCart = new System.Windows.Forms.Button();
            this.btnCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCart.Height = 50;
            this.btnCart.Text = "My Cart";
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);

            // ضيفه للسلايد
            this.sidePanel.Controls.Add(this.btnCart);
            this.sidePanel.Controls.SetChildIndex(this.btnCart, 0);
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainPanel.AutoScroll = true;
            // 
            // headerLabel
            // 
            this.headerLabel.Text = "Categories";
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.headerLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerLabel.Height = 60;
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserMainForm
            // 
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.headerLabel);
            this.Text = "User Main Form";
            this.Load += new System.EventHandler(this.UserMainForm_Load);
            this.sidePanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion
    }
}
