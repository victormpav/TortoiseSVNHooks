namespace HookReviewUi
{
    partial class ReviewCreationDlg
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
            this.reviewMessageTextBox = new System.Windows.Forms.TextBox();
            this.reviewMessageLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.reviewerEmailLabel = new System.Windows.Forms.Label();
            this.reviewerEmailTextBox = new System.Windows.Forms.TextBox();
            this.sendReviewButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reviewMessageTextBox
            // 
            this.reviewMessageTextBox.AcceptsReturn = true;
            this.reviewMessageTextBox.AcceptsTab = true;
            this.reviewMessageTextBox.Location = new System.Drawing.Point(3, 19);
            this.reviewMessageTextBox.MaxLength = 0;
            this.reviewMessageTextBox.Multiline = true;
            this.reviewMessageTextBox.Name = "reviewMessageTextBox";
            this.reviewMessageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.reviewMessageTextBox.Size = new System.Drawing.Size(549, 197);
            this.reviewMessageTextBox.TabIndex = 0;
            // 
            // reviewMessageLabel
            // 
            this.reviewMessageLabel.AutoSize = true;
            this.reviewMessageLabel.Location = new System.Drawing.Point(3, 0);
            this.reviewMessageLabel.Name = "reviewMessageLabel";
            this.reviewMessageLabel.Size = new System.Drawing.Size(92, 13);
            this.reviewMessageLabel.TabIndex = 1;
            this.reviewMessageLabel.Text = "Review Message:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.reviewMessageTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.reviewMessageLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.630522F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.36948F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(555, 254);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.reviewerEmailLabel);
            this.flowLayoutPanel1.Controls.Add(this.reviewerEmailTextBox);
            this.flowLayoutPanel1.Controls.Add(this.sendReviewButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 222);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(549, 28);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // reviewerEmailLabel
            // 
            this.reviewerEmailLabel.AutoSize = true;
            this.reviewerEmailLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reviewerEmailLabel.Location = new System.Drawing.Point(3, 0);
            this.reviewerEmailLabel.Name = "reviewerEmailLabel";
            this.reviewerEmailLabel.Size = new System.Drawing.Size(82, 26);
            this.reviewerEmailLabel.TabIndex = 0;
            this.reviewerEmailLabel.Text = "Reviewer email:";
            // 
            // reviewerEmailTextBox
            // 
            this.reviewerEmailTextBox.Location = new System.Drawing.Point(91, 3);
            this.reviewerEmailTextBox.Name = "reviewerEmailTextBox";
            this.reviewerEmailTextBox.Size = new System.Drawing.Size(218, 20);
            this.reviewerEmailTextBox.TabIndex = 1;
            // 
            // sendReviewButton
            // 
            this.sendReviewButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.sendReviewButton.Location = new System.Drawing.Point(315, 3);
            this.sendReviewButton.Name = "sendReviewButton";
            this.sendReviewButton.Size = new System.Drawing.Size(101, 20);
            this.sendReviewButton.TabIndex = 2;
            this.sendReviewButton.Text = "Send Review";
            this.sendReviewButton.UseVisualStyleBackColor = true;
            this.sendReviewButton.Click += new System.EventHandler(this.sendReviewButton_Click);
            // 
            // ReviewCreationDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 274);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ReviewCreationDlg";
            this.Text = "Review creation";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox reviewMessageTextBox;
        private System.Windows.Forms.Label reviewMessageLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label reviewerEmailLabel;
        private System.Windows.Forms.TextBox reviewerEmailTextBox;
        private System.Windows.Forms.Button sendReviewButton;
    }
}

