namespace LibraryManagement
{
    partial class Fees
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
            label1 = new Label();
            label2 = new Label();
            feesLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(414, 20);
            label1.Name = "label1";
            label1.Size = new Size(446, 50);
            label1.TabIndex = 3;
            label1.Text = "Advanced Media Library";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(466, 199);
            label2.Name = "label2";
            label2.Size = new Size(344, 50);
            label2.TabIndex = 4;
            label2.Text = "Current Fees owed";
            // 
            // feesLabel
            // 
            feesLabel.AutoSize = true;
            feesLabel.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            feesLabel.Location = new Point(566, 265);
            feesLabel.Name = "feesLabel";
            feesLabel.Size = new Size(43, 50);
            feesLabel.TabIndex = 5;
            feesLabel.Text = "£";
            // 
            // Fees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1372, 744);
            Controls.Add(feesLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Fees";
            Text = "Fees";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label feesLabel;
    }
}