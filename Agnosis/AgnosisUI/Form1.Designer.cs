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
            this.SuspendLayout();
            // 
            // MaskDirSelector
            // 
            this.MaskDirSelector.Location = new System.Drawing.Point(10, 103);
            this.MaskDirSelector.Name = "MaskDirSelector";
            this.MaskDirSelector.Size = new System.Drawing.Size(155, 20);
            this.MaskDirSelector.TabIndex = 2;
            this.MaskDirSelector.MouseHover += new System.EventHandler(this.MaskDirSelector_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Folder path to mask:";
            // 
            // MaskSelector
            // 
            this.MaskSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MaskSelector.FormattingEnabled = true;
            this.MaskSelector.Items.AddRange(new object[] {
            "Mask In-Place",
            "Mask and Copy to Folder"});
            this.MaskSelector.Location = new System.Drawing.Point(10, 56);
            this.MaskSelector.Name = "MaskSelector";
            this.MaskSelector.Size = new System.Drawing.Size(155, 21);
            this.MaskSelector.TabIndex = 1;
            this.MaskSelector.SelectedIndexChanged += new System.EventHandler(this.MaskSelector_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mask in-place or copy?";
            // 
            // SelectFolderButton
            // 
            this.SelectFolderButton.Location = new System.Drawing.Point(165, 102);
            this.SelectFolderButton.Name = "SelectFolderButton";
            this.SelectFolderButton.Size = new System.Drawing.Size(79, 22);
            this.SelectFolderButton.TabIndex = 3;
            this.SelectFolderButton.Text = "Select Folder";
            this.SelectFolderButton.UseVisualStyleBackColor = true;
            this.SelectFolderButton.Click += new System.EventHandler(this.SelectFolderButton_Click);
            // 
            // CopyPathButton
            // 
            this.CopyPathButton.Location = new System.Drawing.Point(405, 102);
            this.CopyPathButton.Name = "CopyPathButton";
            this.CopyPathButton.Size = new System.Drawing.Size(79, 22);
            this.CopyPathButton.TabIndex = 5;
            this.CopyPathButton.Text = "Select Folder";
            this.CopyPathButton.UseVisualStyleBackColor = true;
            this.CopyPathButton.Click += new System.EventHandler(this.CopyPathButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Folder path to copy to:";
            // 
            // ResultDirSelector
            // 
            this.ResultDirSelector.Location = new System.Drawing.Point(249, 103);
            this.ResultDirSelector.Name = "ResultDirSelector";
            this.ResultDirSelector.Size = new System.Drawing.Size(155, 20);
            this.ResultDirSelector.TabIndex = 4;
            this.ResultDirSelector.MouseHover += new System.EventHandler(this.ResultDirSelector_MouseHover);
            // 
            // RunMaskButton
            // 
            this.RunMaskButton.Location = new System.Drawing.Point(10, 140);
            this.RunMaskButton.Name = "RunMaskButton";
            this.RunMaskButton.Size = new System.Drawing.Size(474, 31);
            this.RunMaskButton.TabIndex = 6;
            this.RunMaskButton.Text = "Mask Files";
            this.RunMaskButton.UseVisualStyleBackColor = true;
            this.RunMaskButton.Click += new System.EventHandler(this.RunMaskButton_Click);
            // 
            // StatusText
            // 
            this.StatusText.AutoSize = true;
            this.StatusText.Location = new System.Drawing.Point(7, 191);
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
            this.WarningLabel.AutoSize = true;
            this.WarningLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.WarningLabel.Location = new System.Drawing.Point(171, 59);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(294, 13);
            this.WarningLabel.TabIndex = 11;
            this.WarningLabel.Text = "Warning: In-place mask will permenately replace all filenames";
            // 
            // AgnosisUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 213);
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
    }
}

