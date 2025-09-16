namespace BasicE_Commerce.Presentation.AdminForms.AdminOrderForms
{
    partial class AdminOrderDetailsForm
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
            dataGridView1 = new DataGridView();
            OrderIdLabel = new Label();
            DateLabel = new Label();
            statusLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-4, 194);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(808, 266);
            dataGridView1.TabIndex = 1;
            // 
            // OrderIdLabel
            // 
            OrderIdLabel.AutoSize = true;
            OrderIdLabel.Location = new Point(289, 20);
            OrderIdLabel.Name = "OrderIdLabel";
            OrderIdLabel.Size = new Size(38, 15);
            OrderIdLabel.TabIndex = 2;
            OrderIdLabel.Text = "label1";
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Location = new Point(288, 66);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(38, 15);
            DateLabel.TabIndex = 3;
            DateLabel.Text = "label2";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(289, 124);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(38, 15);
            statusLabel.TabIndex = 4;
            statusLabel.Text = "label3";
            // 
            // AdminOrderDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusLabel);
            Controls.Add(DateLabel);
            Controls.Add(OrderIdLabel);
            Controls.Add(dataGridView1);
            Name = "AdminOrderDetailsForm";
            Text = "AdminOrderDetailsForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Label OrderIdLabel;
        private Label DateLabel;
        private Label statusLabel;
    }
}