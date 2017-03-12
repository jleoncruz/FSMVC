namespace FSWinApp
{
    partial class MainForm
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
            this.SourceListBox = new System.Windows.Forms.ListBox();
            this.TargetListBox = new System.Windows.Forms.ListBox();
            this.SourceLabel = new System.Windows.Forms.Label();
            this.TargetLabel = new System.Windows.Forms.Label();
            this.SelectFolderButton = new System.Windows.Forms.Button();
            this.FolderSelectedLabel = new System.Windows.Forms.Label();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.AvailablePhotosLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SourceListBox
            // 
            this.SourceListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SourceListBox.FormattingEnabled = true;
            this.SourceListBox.ItemHeight = 16;
            this.SourceListBox.Location = new System.Drawing.Point(49, 123);
            this.SourceListBox.Name = "SourceListBox";
            this.SourceListBox.Size = new System.Drawing.Size(225, 228);
            this.SourceListBox.TabIndex = 0;
            this.SourceListBox.DoubleClick += new System.EventHandler(this.SourceListBox_DoubleClick);
            // 
            // TargetListBox
            // 
            this.TargetListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TargetListBox.FormattingEnabled = true;
            this.TargetListBox.ItemHeight = 16;
            this.TargetListBox.Location = new System.Drawing.Point(418, 123);
            this.TargetListBox.Name = "TargetListBox";
            this.TargetListBox.Size = new System.Drawing.Size(225, 228);
            this.TargetListBox.TabIndex = 1;
            this.TargetListBox.DoubleClick += new System.EventHandler(this.TargetListBox_DoubleClick);
            // 
            // SourceLabel
            // 
            this.SourceLabel.AutoSize = true;
            this.SourceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SourceLabel.Location = new System.Drawing.Point(46, 98);
            this.SourceLabel.Name = "SourceLabel";
            this.SourceLabel.Size = new System.Drawing.Size(114, 17);
            this.SourceLabel.TabIndex = 2;
            this.SourceLabel.Text = "Source Directory";
            // 
            // TargetLabel
            // 
            this.TargetLabel.AutoSize = true;
            this.TargetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TargetLabel.Location = new System.Drawing.Point(415, 98);
            this.TargetLabel.Name = "TargetLabel";
            this.TargetLabel.Size = new System.Drawing.Size(111, 17);
            this.TargetLabel.TabIndex = 3;
            this.TargetLabel.Text = "Target Directory";
            // 
            // SelectFolderButton
            // 
            this.SelectFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectFolderButton.Location = new System.Drawing.Point(515, 51);
            this.SelectFolderButton.Name = "SelectFolderButton";
            this.SelectFolderButton.Size = new System.Drawing.Size(128, 30);
            this.SelectFolderButton.TabIndex = 4;
            this.SelectFolderButton.Text = "Select Folder";
            this.SelectFolderButton.UseVisualStyleBackColor = true;
            this.SelectFolderButton.Click += new System.EventHandler(this.SelectFolderButton_Click);
            // 
            // FolderSelectedLabel
            // 
            this.FolderSelectedLabel.AutoSize = true;
            this.FolderSelectedLabel.Location = new System.Drawing.Point(65, 51);
            this.FolderSelectedLabel.Name = "FolderSelectedLabel";
            this.FolderSelectedLabel.Size = new System.Drawing.Size(0, 13);
            this.FolderSelectedLabel.TabIndex = 5;
            // 
            // ConvertButton
            // 
            this.ConvertButton.Enabled = false;
            this.ConvertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertButton.Location = new System.Drawing.Point(280, 203);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(132, 34);
            this.ConvertButton.TabIndex = 6;
            this.ConvertButton.Text = "---> Convert --->";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // AvailablePhotosLabel
            // 
            this.AvailablePhotosLabel.AutoSize = true;
            this.AvailablePhotosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailablePhotosLabel.Location = new System.Drawing.Point(49, 368);
            this.AvailablePhotosLabel.Name = "AvailablePhotosLabel";
            this.AvailablePhotosLabel.Size = new System.Drawing.Size(0, 17);
            this.AvailablePhotosLabel.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 428);
            this.Controls.Add(this.AvailablePhotosLabel);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.FolderSelectedLabel);
            this.Controls.Add(this.SelectFolderButton);
            this.Controls.Add(this.TargetLabel);
            this.Controls.Add(this.SourceLabel);
            this.Controls.Add(this.TargetListBox);
            this.Controls.Add(this.SourceListBox);
            this.Name = "MainForm";
            this.Text = "ImageResizer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox SourceListBox;
        private System.Windows.Forms.ListBox TargetListBox;
        private System.Windows.Forms.Label SourceLabel;
        private System.Windows.Forms.Label TargetLabel;
        private System.Windows.Forms.Button SelectFolderButton;
        private System.Windows.Forms.Label FolderSelectedLabel;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Label AvailablePhotosLabel;
    }
}

