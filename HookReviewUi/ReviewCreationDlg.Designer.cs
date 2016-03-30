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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReviewCreationDlg));
            this.reviewDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.reviewDescriptionLabel = new System.Windows.Forms.Label();
            this.GroupLabel = new System.Windows.Forms.Label();
            this.GroupTextBox = new System.Windows.Forms.TextBox();
            this.sendReviewButton = new System.Windows.Forms.Button();
            this.RepositoryLabel = new System.Windows.Forms.Label();
            this.RepositoryTextBox = new System.Windows.Forms.TextBox();
            this.BranchLabel = new System.Windows.Forms.Label();
            this.BranchComboBox = new System.Windows.Forms.ComboBox();
            this.SummaryTextBox = new System.Windows.Forms.TextBox();
            this.ReviewSummaryLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // reviewDescriptionTextBox
            // 
            this.reviewDescriptionTextBox.AcceptsReturn = true;
            this.reviewDescriptionTextBox.AcceptsTab = true;
            this.reviewDescriptionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reviewDescriptionTextBox.Location = new System.Drawing.Point(3, 35);
            this.reviewDescriptionTextBox.MaxLength = 0;
            this.reviewDescriptionTextBox.Multiline = true;
            this.reviewDescriptionTextBox.Name = "reviewDescriptionTextBox";
            this.reviewDescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.reviewDescriptionTextBox.Size = new System.Drawing.Size(553, 164);
            this.reviewDescriptionTextBox.TabIndex = 0;
            // 
            // reviewDescriptionLabel
            // 
            this.reviewDescriptionLabel.AutoSize = true;
            this.reviewDescriptionLabel.Location = new System.Drawing.Point(3, 0);
            this.reviewDescriptionLabel.Name = "reviewDescriptionLabel";
            this.reviewDescriptionLabel.Size = new System.Drawing.Size(100, 13);
            this.reviewDescriptionLabel.TabIndex = 1;
            this.reviewDescriptionLabel.Text = "Review description:";
            // 
            // GroupLabel
            // 
            this.GroupLabel.AutoSize = true;
            this.GroupLabel.Location = new System.Drawing.Point(3, 0);
            this.GroupLabel.Name = "GroupLabel";
            this.GroupLabel.Size = new System.Drawing.Size(39, 13);
            this.GroupLabel.TabIndex = 0;
            this.GroupLabel.Text = "Group:";
            // 
            // GroupTextBox
            // 
            this.GroupTextBox.Location = new System.Drawing.Point(147, 3);
            this.GroupTextBox.Name = "GroupTextBox";
            this.GroupTextBox.Size = new System.Drawing.Size(409, 20);
            this.GroupTextBox.TabIndex = 1;
            // 
            // sendReviewButton
            // 
            this.sendReviewButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.sendReviewButton.Location = new System.Drawing.Point(433, 78);
            this.sendReviewButton.Name = "sendReviewButton";
            this.sendReviewButton.Size = new System.Drawing.Size(123, 24);
            this.sendReviewButton.TabIndex = 2;
            this.sendReviewButton.Text = "Send Review";
            this.sendReviewButton.UseVisualStyleBackColor = true;
            this.sendReviewButton.Click += new System.EventHandler(this.sendReviewButton_Click);
            // 
            // RepositoryLabel
            // 
            this.RepositoryLabel.AutoSize = true;
            this.RepositoryLabel.Location = new System.Drawing.Point(3, 25);
            this.RepositoryLabel.Name = "RepositoryLabel";
            this.RepositoryLabel.Size = new System.Drawing.Size(60, 13);
            this.RepositoryLabel.TabIndex = 3;
            this.RepositoryLabel.Text = "Repository:";
            // 
            // RepositoryTextBox
            // 
            this.RepositoryTextBox.Location = new System.Drawing.Point(147, 28);
            this.RepositoryTextBox.Name = "RepositoryTextBox";
            this.RepositoryTextBox.Size = new System.Drawing.Size(409, 20);
            this.RepositoryTextBox.TabIndex = 4;
            // 
            // BranchLabel
            // 
            this.BranchLabel.AutoSize = true;
            this.BranchLabel.Location = new System.Drawing.Point(3, 50);
            this.BranchLabel.Name = "BranchLabel";
            this.BranchLabel.Size = new System.Drawing.Size(44, 13);
            this.BranchLabel.TabIndex = 5;
            this.BranchLabel.Text = "Branch:";
            // 
            // BranchComboBox
            // 
            this.BranchComboBox.FormattingEnabled = true;
            this.BranchComboBox.Items.AddRange(new object[] {
            "trunk/altamira",
            "branches/lyra"});
            this.BranchComboBox.Location = new System.Drawing.Point(147, 53);
            this.BranchComboBox.Name = "BranchComboBox";
            this.BranchComboBox.Size = new System.Drawing.Size(409, 21);
            this.BranchComboBox.TabIndex = 6;
            // 
            // SummaryTextBox
            // 
            this.SummaryTextBox.Location = new System.Drawing.Point(72, 3);
            this.SummaryTextBox.Name = "SummaryTextBox";
            this.SummaryTextBox.Size = new System.Drawing.Size(484, 20);
            this.SummaryTextBox.TabIndex = 8;
            // 
            // ReviewSummaryLabel
            // 
            this.ReviewSummaryLabel.AutoSize = true;
            this.ReviewSummaryLabel.Location = new System.Drawing.Point(3, 0);
            this.ReviewSummaryLabel.Name = "ReviewSummaryLabel";
            this.ReviewSummaryLabel.Size = new System.Drawing.Size(53, 13);
            this.ReviewSummaryLabel.TabIndex = 7;
            this.ReviewSummaryLabel.Text = "Summary:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel6);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(575, 361);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.41259F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.58741F));
            this.tableLayoutPanel1.Controls.Add(this.ReviewSummaryLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SummaryTextBox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(559, 25);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.reviewDescriptionLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.reviewDescriptionTextBox, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(8, 39);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(559, 202);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.AutoSize = true;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.8348F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.1652F));
            this.tableLayoutPanel6.Controls.Add(this.BranchComboBox, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.RepositoryTextBox, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.BranchLabel, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.GroupLabel, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.RepositoryLabel, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.GroupTextBox, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.sendReviewButton, 1, 3);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(8, 247);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 4;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(559, 105);
            this.tableLayoutPanel6.TabIndex = 14;
            // 
            // ReviewCreationDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 361);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReviewCreationDlg";
            this.Text = "Review creation";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox reviewDescriptionTextBox;
        private System.Windows.Forms.Label reviewDescriptionLabel;
        private System.Windows.Forms.Label GroupLabel;
        private System.Windows.Forms.TextBox GroupTextBox;
        private System.Windows.Forms.Button sendReviewButton;
        private System.Windows.Forms.Label RepositoryLabel;
        private System.Windows.Forms.TextBox RepositoryTextBox;
        private System.Windows.Forms.Label BranchLabel;
        private System.Windows.Forms.ComboBox BranchComboBox;
        private System.Windows.Forms.TextBox SummaryTextBox;
        private System.Windows.Forms.Label ReviewSummaryLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
    }
}

