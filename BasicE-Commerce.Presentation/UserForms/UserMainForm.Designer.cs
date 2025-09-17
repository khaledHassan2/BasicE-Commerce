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
            sidePanel = new Panel();
            btnOrder = new Button();
            btnCart = new Button();
            btnProducts = new Button();
            btnCategories = new Button();
            mainPanel = new Panel();
            headerLabel = new Label();
            checkoutbtn = new Button();
            logOutbtn = new Button();
            sidePanel.SuspendLayout();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.LightSteelBlue;
            sidePanel.Controls.Add(btnOrder);
            sidePanel.Controls.Add(btnCart);
            sidePanel.Controls.Add(btnProducts);
            sidePanel.Controls.Add(btnCategories);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Location = new Point(0, 40);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(200, 391);
            sidePanel.TabIndex = 1;
            // 
            // btnOrder
            // 
            btnOrder.Dock = DockStyle.Top;
            btnOrder.FlatStyle = FlatStyle.Flat;
            btnOrder.Location = new Point(0, 150);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(200, 50);
            btnOrder.TabIndex = 3;
            btnOrder.Text = "My Order";
            btnOrder.Click += btnOrder_Click;
            // 
            // btnCart
            // 
            btnCart.Dock = DockStyle.Top;
            btnCart.FlatStyle = FlatStyle.Flat;
            btnCart.Location = new Point(0, 100);
            btnCart.Name = "btnCart";
            btnCart.Size = new Size(200, 50);
            btnCart.TabIndex = 2;
            btnCart.Text = "My Cart";
            btnCart.Click += btnCart_Click;
            // 
            // btnProducts
            // 
            btnProducts.Dock = DockStyle.Top;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Location = new Point(0, 50);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(200, 50);
            btnProducts.TabIndex = 0;
            btnProducts.Text = "Products";
            btnProducts.Click += btnProducts_Click;
            // 
            // btnCategories
            // 
            btnCategories.Dock = DockStyle.Top;
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.Location = new Point(0, 0);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(200, 50);
            btnCategories.TabIndex = 1;
            btnCategories.Text = "Categories";
            btnCategories.Click += btnCategories_Click;
            // 
            // mainPanel
            // 
            mainPanel.AutoScroll = true;
            mainPanel.BackColor = Color.WhiteSmoke;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(200, 40);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(903, 391);
            mainPanel.TabIndex = 0;
            // 
            // headerLabel
            // 
            headerLabel.Dock = DockStyle.Top;
            headerLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            headerLabel.Location = new Point(0, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(1103, 40);
            headerLabel.TabIndex = 2;
            headerLabel.Text = "Categories";
            headerLabel.TextAlign = ContentAlignment.MiddleCenter;
            headerLabel.Click += headerLabel_Click;
            // 
            // checkoutbtn
            // 
            checkoutbtn.Anchor = AnchorStyles.Bottom;
            checkoutbtn.Location = new Point(446, 398);
            checkoutbtn.Name = "checkoutbtn";
            checkoutbtn.Size = new Size(362, 23);
            checkoutbtn.TabIndex = 3;
            checkoutbtn.Text = "Check out";
            checkoutbtn.UseVisualStyleBackColor = true;
            checkoutbtn.Click += checkoutbtn_Click;
            // 
            // logOutbtn
            // 
            logOutbtn.Location = new Point(1002, 11);
            logOutbtn.Name = "logOutbtn";
            logOutbtn.Size = new Size(75, 23);
            logOutbtn.TabIndex = 4;
            logOutbtn.Text = "Log Out";
            logOutbtn.UseVisualStyleBackColor = true;
            // 
            // UserMainForm
            // 
            ClientSize = new Size(1103, 431);
            Controls.Add(logOutbtn);
            Controls.Add(checkoutbtn);
            Controls.Add(mainPanel);
            Controls.Add(sidePanel);
            Controls.Add(headerLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "UserMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Main Form";
            Load += UserMainForm_Load;
            sidePanel.ResumeLayout(false);
            ResumeLayout(false);
        }
        #endregion

        private Button btnOrder;
        private Button checkoutbtn;
        private Button logOutbtn;
    }
}
