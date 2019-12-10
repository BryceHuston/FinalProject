namespace PipeClient
{
    partial class CSVFormat
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
            this.lstShowFiles = new System.Windows.Forms.ListBox();
            this.tbBrowseFile = new System.Windows.Forms.TextBox();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstShowFiles
            // 
            this.lstShowFiles.FormattingEnabled = true;
            this.lstShowFiles.ItemHeight = 16;
            this.lstShowFiles.Location = new System.Drawing.Point(167, 100);
            this.lstShowFiles.Margin = new System.Windows.Forms.Padding(4);
            this.lstShowFiles.Name = "lstShowFiles";
            this.lstShowFiles.Size = new System.Drawing.Size(493, 324);
            this.lstShowFiles.TabIndex = 7;
            // 
            // tbBrowseFile
            // 
            this.tbBrowseFile.Location = new System.Drawing.Point(167, 27);
            this.tbBrowseFile.Margin = new System.Windows.Forms.Padding(4);
            this.tbBrowseFile.Name = "tbBrowseFile";
            this.tbBrowseFile.Size = new System.Drawing.Size(493, 22);
            this.tbBrowseFile.TabIndex = 6;
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(24, 100);
            this.btnReadFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(100, 28);
            this.btnReadFile.TabIndex = 5;
            this.btnReadFile.Text = "Read File";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.BtnReadFile_Click);
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.Location = new System.Drawing.Point(24, 25);
            this.btnBrowseFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(100, 28);
            this.btnBrowseFile.TabIndex = 4;
            this.btnBrowseFile.Text = "Browse File";
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            this.btnBrowseFile.Click += new System.EventHandler(this.BtnBrowseFile_Click);
            // 
            // CSVFormat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstShowFiles);
            this.Controls.Add(this.tbBrowseFile);
            this.Controls.Add(this.btnReadFile);
            this.Controls.Add(this.btnBrowseFile);
            this.Name = "CSVFormat";
            this.Text = "CSVFormat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstShowFiles;
        private System.Windows.Forms.TextBox tbBrowseFile;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.Button btnBrowseFile;
    }
}