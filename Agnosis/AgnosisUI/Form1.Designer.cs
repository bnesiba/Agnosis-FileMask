namespace AgnosisUI
{
    partial class AgnosisUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgnosisUI));
            this.MaskDirSelector = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MaskSelector = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectFolderButton = new System.Windows.Forms.Button();
            this.CopyPathButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ResultDirSelector = new System.Windows.Forms.TextBox();
            this.RunMaskButton = new System.Windows.Forms.Button();
            this.StatusText = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.WarningLabel = new System.Windows.Forms.Label();
            this.MaskColumnCheckbox = new System.Windows.Forms.CheckBox();
            this.HideColumnCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RenameSpreadsheetCheckbox = new System.Windows.Forms.CheckBox();
            this.SpreadsheetFileNameSelector = new System.Windows.Forms.TextBox();
            this.SpreadsheetNameLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MaskDirSelector
            // 
            this.MaskDirSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaskDirSelector.Location = new System.Drawing.Point(10, 87);
            this.MaskDirSelector.Name = "MaskDirSelector";
            this.MaskDirSelector.Size = new System.Drawing.Size(155, 20);
            this.MaskDirSelector.TabIndex = 2;
            this.MaskDirSelector.MouseHover += new System.EventHandler(this.MaskDirSelector_MouseHover);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Folder path to mask:";
            // 
            // MaskSelector
            // 
            this.MaskSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaskSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MaskSelector.FormattingEnabled = true;
            this.MaskSelector.Items.AddRange(new object[] {
            "Mask In-Place",
            "Mask and Copy to Folder"});
            this.MaskSelector.Location = new System.Drawing.Point(10, 40);
            this.MaskSelector.Name = "MaskSelector";
            this.MaskSelector.Size = new System.Drawing.Size(155, 21);
            this.MaskSelector.TabIndex = 1;
            this.MaskSelector.SelectedIndexChanged += new System.EventHandler(this.MaskSelector_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mask in-place or copy?";
            // 
            // SelectFolderButton
            // 
            this.SelectFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectFolderButton.Location = new System.Drawing.Point(165, 86);
            this.SelectFolderButton.Name = "SelectFolderButton";
            this.SelectFolderButton.Size = new System.Drawing.Size(79, 22);
            this.SelectFolderButton.TabIndex = 3;
            this.SelectFolderButton.Text = "Select Folder";
            this.SelectFolderButton.UseVisualStyleBackColor = true;
            this.SelectFolderButton.Click += new System.EventHandler(this.SelectFolderButton_Click);
            // 
            // CopyPathButton
            // 
            this.CopyPathButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CopyPathButton.Location = new System.Drawing.Point(405, 86);
            this.CopyPathButton.Name = "CopyPathButton";
            this.CopyPathButton.Size = new System.Drawing.Size(79, 22);
            this.CopyPathButton.TabIndex = 5;
            this.CopyPathButton.Text = "Select Folder";
            this.CopyPathButton.UseVisualStyleBackColor = true;
            this.CopyPathButton.Click += new System.EventHandler(this.CopyPathButton_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Folder path to copy to:";
            // 
            // ResultDirSelector
            // 
            this.ResultDirSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultDirSelector.Location = new System.Drawing.Point(249, 87);
            this.ResultDirSelector.Name = "ResultDirSelector";
            this.ResultDirSelector.Size = new System.Drawing.Size(155, 20);
            this.ResultDirSelector.TabIndex = 4;
            this.ResultDirSelector.MouseHover += new System.EventHandler(this.ResultDirSelector_MouseHover);
            // 
            // RunMaskButton
            // 
            this.RunMaskButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RunMaskButton.Location = new System.Drawing.Point(10, 215);
            this.RunMaskButton.Name = "RunMaskButton";
            this.RunMaskButton.Size = new System.Drawing.Size(474, 31);
            this.RunMaskButton.TabIndex = 6;
            this.RunMaskButton.Text = "Mask Files";
            this.RunMaskButton.UseVisualStyleBackColor = true;
            this.RunMaskButton.Click += new System.EventHandler(this.RunMaskButton_Click);
            // 
            // StatusText
            // 
            this.StatusText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusText.AutoSize = true;
            this.StatusText.Location = new System.Drawing.Point(7, 257);
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(134, 13);
            this.StatusText.TabIndex = 9;
            this.StatusText.Text = "StatusOfProcessGoesHere";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(0, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "By Brandon Nesiba";
            // 
            // WarningLabel
            // 
            this.WarningLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WarningLabel.AutoSize = true;
            this.WarningLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.WarningLabel.Location = new System.Drawing.Point(171, 43);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(294, 13);
            this.WarningLabel.TabIndex = 11;
            this.WarningLabel.Text = "Warning: In-place mask will permenately replace all filenames";
            // 
            // MaskColumnCheckbox
            // 
            this.MaskColumnCheckbox.AutoSize = true;
            this.MaskColumnCheckbox.Location = new System.Drawing.Point(6, 19);
            this.MaskColumnCheckbox.Name = "MaskColumnCheckbox";
            this.MaskColumnCheckbox.Size = new System.Drawing.Size(327, 17);
            this.MaskColumnCheckbox.TabIndex = 13;
            this.MaskColumnCheckbox.Text = "Mask original filename column (black text w/ black background)";
            this.MaskColumnCheckbox.UseVisualStyleBackColor = true;
            // 
            // HideColumnCheckbox
            // 
            this.HideColumnCheckbox.AutoSize = true;
            this.HideColumnCheckbox.Location = new System.Drawing.Point(6, 41);
            this.HideColumnCheckbox.Name = "HideColumnCheckbox";
            this.HideColumnCheckbox.Size = new System.Drawing.Size(163, 17);
            this.HideColumnCheckbox.TabIndex = 14;
            this.HideColumnCheckbox.Text = "Hide original filename column";
            this.HideColumnCheckbox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SpreadsheetNameLabel);
            this.groupBox1.Controls.Add(this.SpreadsheetFileNameSelector);
            this.groupBox1.Controls.Add(this.RenameSpreadsheetCheckbox);
            this.groupBox1.Controls.Add(this.HideColumnCheckbox);
            this.groupBox1.Controls.Add(this.MaskColumnCheckbox);
            this.groupBox1.Location = new System.Drawing.Point(10, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 89);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Spreadsheet Settings:";
            // 
            // RenameSpreadsheetCheckbox
            // 
            this.RenameSpreadsheetCheckbox.AutoSize = true;
            this.RenameSpreadsheetCheckbox.Location = new System.Drawing.Point(6, 64);
            this.RenameSpreadsheetCheckbox.Name = "RenameSpreadsheetCheckbox";
            this.RenameSpreadsheetCheckbox.Size = new System.Drawing.Size(132, 17);
            this.RenameSpreadsheetCheckbox.TabIndex = 15;
            this.RenameSpreadsheetCheckbox.Text = "Rename Spreadsheet:";
            this.RenameSpreadsheetCheckbox.UseVisualStyleBackColor = true;
            this.RenameSpreadsheetCheckbox.CheckedChanged += new System.EventHandler(this.RenameSpreadsheetCheckbox_CheckedChanged);
            // 
            // SpreadsheetFileNameSelector
            // 
            this.SpreadsheetFileNameSelector.Location = new System.Drawing.Point(134, 61);
            this.SpreadsheetFileNameSelector.Name = "SpreadsheetFileNameSelector";
            this.SpreadsheetFileNameSelector.Size = new System.Drawing.Size(100, 20);
            this.SpreadsheetFileNameSelector.TabIndex = 16;
            this.SpreadsheetFileNameSelector.Text = "Spreadsheet";
            // 
            // SpreadsheetNameLabel
            // 
            this.SpreadsheetNameLabel.AutoSize = true;
            this.SpreadsheetNameLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.SpreadsheetNameLabel.Location = new System.Drawing.Point(236, 65);
            this.SpreadsheetNameLabel.Name = "SpreadsheetNameLabel";
            this.SpreadsheetNameLabel.Size = new System.Drawing.Size(219, 13);
            this.SpreadsheetNameLabel.TabIndex = 16;
            this.SpreadsheetNameLabel.Text = "Do not include the file extension in the name.";
            // 
            // AgnosisUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 279);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.WarningLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StatusText);
            this.Controls.Add(this.RunMaskButton);
            this.Controls.Add(this.CopyPathButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ResultDirSelector);
            this.Controls.Add(this.SelectFolderButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MaskSelector);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MaskDirSelector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AgnosisUI";
            this.Text = "Agnosis";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MaskDirSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox MaskSelector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SelectFolderButton;
        private System.Windows.Forms.Button CopyPathButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ResultDirSelector;
        private System.Windows.Forms.Button RunMaskButton;
        private System.Windows.Forms.Label StatusText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label WarningLabel;
        private System.Windows.Forms.CheckBox MaskColumnCheckbox;
        private System.Windows.Forms.CheckBox HideColumnCheckbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox RenameSpreadsheetCheckbox;
        private System.Windows.Forms.TextBox SpreadsheetFileNameSelector;
        private System.Windows.Forms.Label SpreadsheetNameLabel;
    }
}

