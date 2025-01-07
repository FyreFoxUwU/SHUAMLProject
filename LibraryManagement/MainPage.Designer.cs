namespace LibraryManagement
{
    partial class MainPage
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
            button2 = new Button();
            textBox1 = new TextBox();
            button1 = new Button();
            bookTitleLabel = new Label();
            bookAuthorLabel = new Label();
            bookISBNLabel = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(411, 9);
            label1.Name = "label1";
            label1.Size = new Size(446, 50);
            label1.TabIndex = 2;
            label1.Text = "Advanced Media Library";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(758, 84);
            button2.Name = "button2";
            button2.Size = new Size(163, 66);
            button2.TabIndex = 9;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(356, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(396, 71);
            textBox1.TabIndex = 10;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(1197, 12);
            button1.Name = "button1";
            button1.Size = new Size(163, 66);
            button1.TabIndex = 11;
            button1.Text = "Fees";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // bookTitleLabel
            // 
            bookTitleLabel.AutoSize = true;
            bookTitleLabel.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookTitleLabel.Location = new Point(176, 259);
            bookTitleLabel.Name = "bookTitleLabel";
            bookTitleLabel.Size = new Size(120, 50);
            bookTitleLabel.TabIndex = 12;
            bookTitleLabel.Text = "Title: ";
            // 
            // bookAuthorLabel
            // 
            bookAuthorLabel.AutoSize = true;
            bookAuthorLabel.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookAuthorLabel.Location = new Point(131, 324);
            bookAuthorLabel.Name = "bookAuthorLabel";
            bookAuthorLabel.Size = new Size(165, 50);
            bookAuthorLabel.TabIndex = 13;
            bookAuthorLabel.Text = "Author: ";
            // 
            // bookISBNLabel
            // 
            bookISBNLabel.AutoSize = true;
            bookISBNLabel.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookISBNLabel.Location = new Point(168, 387);
            bookISBNLabel.Name = "bookISBNLabel";
            bookISBNLabel.Size = new Size(128, 50);
            bookISBNLabel.TabIndex = 14;
            bookISBNLabel.Text = "ISBN: ";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(447, 547);
            button3.Name = "button3";
            button3.Size = new Size(410, 66);
            button3.TabIndex = 15;
            button3.Text = "Borrow Book";
            button3.UseVisualStyleBackColor = true;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1372, 744);
            Controls.Add(button3);
            Controls.Add(bookISBNLabel);
            Controls.Add(bookAuthorLabel);
            Controls.Add(bookTitleLabel);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(label1);
            Name = "MainPage";
            Text = "MainPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button2;
        private TextBox textBox1;
        private Button button1;
        private Label bookTitleLabel;
        private Label bookAuthorLabel;
        private Label bookISBNLabel;
        private Button button3;
    }
}