namespace PipeClient
{
    partial class FormBST
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
            this.tbFindMax = new System.Windows.Forms.TextBox();
            this.tbFindMin = new System.Windows.Forms.TextBox();
            this.tbRemove = new System.Windows.Forms.TextBox();
            this.tbInsert = new System.Windows.Forms.TextBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnFindMax = new System.Windows.Forms.Button();
            this.btnFindMin = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.stsDisplay = new System.Windows.Forms.StatusStrip();
            this.SuspendLayout();
            // 
            // tbFindMax
            // 
            this.tbFindMax.Location = new System.Drawing.Point(550, 249);
            this.tbFindMax.Margin = new System.Windows.Forms.Padding(4);
            this.tbFindMax.Name = "tbFindMax";
            this.tbFindMax.ReadOnly = true;
            this.tbFindMax.Size = new System.Drawing.Size(132, 22);
            this.tbFindMax.TabIndex = 23;
            // 
            // tbFindMin
            // 
            this.tbFindMin.Location = new System.Drawing.Point(550, 194);
            this.tbFindMin.Margin = new System.Windows.Forms.Padding(4);
            this.tbFindMin.Name = "tbFindMin";
            this.tbFindMin.ReadOnly = true;
            this.tbFindMin.Size = new System.Drawing.Size(132, 22);
            this.tbFindMin.TabIndex = 22;
            // 
            // tbRemove
            // 
            this.tbRemove.Location = new System.Drawing.Point(550, 140);
            this.tbRemove.Margin = new System.Windows.Forms.Padding(4);
            this.tbRemove.Name = "tbRemove";
            this.tbRemove.Size = new System.Drawing.Size(132, 22);
            this.tbRemove.TabIndex = 21;
            // 
            // tbInsert
            // 
            this.tbInsert.Location = new System.Drawing.Point(550, 83);
            this.tbInsert.Margin = new System.Windows.Forms.Padding(4);
            this.tbInsert.Name = "tbInsert";
            this.tbInsert.Size = new System.Drawing.Size(132, 22);
            this.tbInsert.TabIndex = 20;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(550, 24);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(132, 22);
            this.tbSearch.TabIndex = 19;
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.HorizontalScrollbar = true;
            this.lstOutput.ItemHeight = 16;
            this.lstOutput.Location = new System.Drawing.Point(25, 390);
            this.lstOutput.Margin = new System.Windows.Forms.Padding(4);
            this.lstOutput.MultiColumn = true;
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.ScrollAlwaysVisible = true;
            this.lstOutput.Size = new System.Drawing.Size(1043, 196);
            this.lstOutput.TabIndex = 18;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(414, 311);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(241, 57);
            this.btnDisplay.TabIndex = 17;
            this.btnDisplay.Text = "Display All";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.BtnDisplay_Click);
            // 
            // btnFindMax
            // 
            this.btnFindMax.Location = new System.Drawing.Point(398, 249);
            this.btnFindMax.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindMax.Name = "btnFindMax";
            this.btnFindMax.Size = new System.Drawing.Size(123, 28);
            this.btnFindMax.TabIndex = 16;
            this.btnFindMax.Text = "Find Maximum";
            this.btnFindMax.UseVisualStyleBackColor = true;
            this.btnFindMax.Click += new System.EventHandler(this.BtnFindMax_Click);
            // 
            // btnFindMin
            // 
            this.btnFindMin.Location = new System.Drawing.Point(398, 191);
            this.btnFindMin.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindMin.Name = "btnFindMin";
            this.btnFindMin.Size = new System.Drawing.Size(123, 28);
            this.btnFindMin.TabIndex = 15;
            this.btnFindMin.Text = "Find Minimum";
            this.btnFindMin.UseVisualStyleBackColor = true;
            this.btnFindMin.Click += new System.EventHandler(this.BtnFindMin_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(398, 140);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(123, 28);
            this.btnRemove.TabIndex = 14;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(398, 81);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(123, 28);
            this.btnInsert.TabIndex = 13;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(398, 24);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(123, 28);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // stsDisplay
            // 
            this.stsDisplay.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stsDisplay.Location = new System.Drawing.Point(0, 600);
            this.stsDisplay.Name = "stsDisplay";
            this.stsDisplay.Size = new System.Drawing.Size(1117, 22);
            this.stsDisplay.TabIndex = 24;
            this.stsDisplay.Text = "statusStrip1";
            // 
            // FormBST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1117, 622);
            this.Controls.Add(this.stsDisplay);
            this.Controls.Add(this.tbFindMax);
            this.Controls.Add(this.tbFindMin);
            this.Controls.Add(this.tbRemove);
            this.Controls.Add(this.tbInsert);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnFindMax);
            this.Controls.Add(this.btnFindMin);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnSearch);
            this.Name = "FormBST";
            this.Text = "Binary Search Tree";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFindMax;
        private System.Windows.Forms.TextBox tbFindMin;
        private System.Windows.Forms.TextBox tbRemove;
        private System.Windows.Forms.TextBox tbInsert;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnFindMax;
        private System.Windows.Forms.Button btnFindMin;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.StatusStrip stsDisplay;
    }
}