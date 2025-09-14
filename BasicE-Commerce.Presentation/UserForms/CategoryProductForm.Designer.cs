namespace BasicE_Commerce.Presentation.UserForms
{
    partial class CategoryProductForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            menuStrip1 = new MenuStrip();
            profileToolStripMenuItem = new ToolStripMenuItem();
            myCartToolStripMenuItem = new ToolStripMenuItem();
            myOrdersToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 28);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(806, 450);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { profileToolStripMenuItem, myCartToolStripMenuItem, myOrdersToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(806, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.Size = new Size(70, 24);
            profileToolStripMenuItem.Text = "Logout";
            // 
            // myCartToolStripMenuItem
            // 
            myCartToolStripMenuItem.Name = "myCartToolStripMenuItem";
            myCartToolStripMenuItem.Size = new Size(74, 24);
            myCartToolStripMenuItem.Text = "my Cart";
            // 
            // myOrdersToolStripMenuItem
            // 
            myOrdersToolStripMenuItem.Name = "myOrdersToolStripMenuItem";
            myOrdersToolStripMenuItem.Size = new Size(91, 24);
            myOrdersToolStripMenuItem.Text = "My Orders";
            // 
            // CategoryProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 478);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "CategoryProductForm";
            Text = "CategoryProductForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem profileToolStripMenuItem;
        private ToolStripMenuItem myCartToolStripMenuItem;
        private ToolStripMenuItem myOrdersToolStripMenuItem;
    }
}