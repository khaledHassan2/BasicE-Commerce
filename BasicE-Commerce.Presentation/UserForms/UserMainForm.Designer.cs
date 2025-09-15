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
			button1 = new Button();
			btnCart = new Button();
			btnProducts = new Button();
			btnCategories = new Button();
			mainPanel = new Panel();
			headerLabel = new Label();
			button2 = new Button();
			sidePanel.SuspendLayout();
			SuspendLayout();
			// 
			// sidePanel
			// 
			sidePanel.BackColor = Color.LightSteelBlue;
			sidePanel.Controls.Add(button1);
			sidePanel.Controls.Add(btnCart);
			sidePanel.Controls.Add(btnProducts);
			sidePanel.Controls.Add(btnCategories);
			sidePanel.Dock = DockStyle.Left;
			sidePanel.Location = new Point(0, 40);
			sidePanel.Name = "sidePanel";
			sidePanel.Size = new Size(200, 391);
			sidePanel.TabIndex = 1;
			// 
			// button1
			// 
			button1.Dock = DockStyle.Top;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Location = new Point(0, 150);
			button1.Name = "button1";
			button1.Size = new Size(200, 50);
			button1.TabIndex = 3;
			button1.Text = "My Order";
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
			mainPanel.Size = new Size(800, 391);
			mainPanel.TabIndex = 0;
			// 
			// headerLabel
			// 
			headerLabel.Dock = DockStyle.Top;
			headerLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
			headerLabel.Location = new Point(0, 0);
			headerLabel.Name = "headerLabel";
			headerLabel.Size = new Size(1000, 40);
			headerLabel.TabIndex = 2;
			headerLabel.Text = "Categories";
			headerLabel.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// button2
			// 
			button2.Anchor = AnchorStyles.Bottom;
			button2.Location = new Point(395, 398);
			button2.Name = "button2";
			button2.Size = new Size(362, 23);
			button2.TabIndex = 3;
			button2.Text = "Check out";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// UserMainForm
			// 
			ClientSize = new Size(1000, 431);
			Controls.Add(button2);
			Controls.Add(mainPanel);
			Controls.Add(sidePanel);
			Controls.Add(headerLabel);
			Name = "UserMainForm";
			Text = "User Main Form";
			Load += UserMainForm_Load;
			sidePanel.ResumeLayout(false);
			ResumeLayout(false);
		}
		#endregion

		private Button button1;
        private Button button2;
    }
}
