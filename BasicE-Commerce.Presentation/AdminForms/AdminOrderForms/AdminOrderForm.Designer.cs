namespace BasicE_Commerce.Presentation.AdminForms.AdminOrderForms
{
    partial class AdminOrderForm
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
            flowOrdersPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flowOrdersPanel
            // 
            flowOrdersPanel.Dock = DockStyle.Fill;
            flowOrdersPanel.Location = new Point(0, 0);
            flowOrdersPanel.Name = "flowOrdersPanel";
            flowOrdersPanel.Size = new Size(738, 353);
            flowOrdersPanel.TabIndex = 0;
            flowOrdersPanel.Paint += flowOrdersPanel_Paint;
            // 
            // AdminOrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 353);
            Controls.Add(flowOrdersPanel);
            Name = "AdminOrderForm";
            Text = "AdminOrderForm";
            Load += AdminOrderForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowOrdersPanel;
    }
}