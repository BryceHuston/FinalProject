namespace PipeClient
{
    partial class SortPayroll
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
            this.label4 = new System.Windows.Forms.Label();
            this.lbRadix = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.stopWatchTimer = new System.Windows.Forms.Timer(this.components);
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.stopWatch = new System.Windows.Forms.Label();
            this.rbRadix = new System.Windows.Forms.RadioButton();
            this.btnRegenerate = new System.Windows.Forms.Button();
            this.tbRadix = new System.Windows.Forms.TextBox();
            this.btnRadixSort = new System.Windows.Forms.Button();
            this.btnSortAll = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstSortedOutput = new System.Windows.Forms.ListBox();
            this.lstDataOutput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(266, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 75;
            this.label4.Text = "Total Time";
            // 
            // lbRadix
            // 
            this.lbRadix.AutoSize = true;
            this.lbRadix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRadix.Location = new System.Drawing.Point(243, 230);
            this.lbRadix.Name = "lbRadix";
            this.lbRadix.Size = new System.Drawing.Size(0, 25);
            this.lbRadix.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(282, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 71;
            this.label1.Text = "Output :";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(28, 526);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(564, 42);
            this.progressBar.TabIndex = 70;
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.Location = new System.Drawing.Point(285, 470);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(63, 21);
            this.rbNone.TabIndex = 69;
            this.rbNone.TabStop = true;
            this.rbNone.Text = "None";
            this.rbNone.UseVisualStyleBackColor = true;
            // 
            // stopWatch
            // 
            this.stopWatch.AutoSize = true;
            this.stopWatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopWatch.Location = new System.Drawing.Point(249, 39);
            this.stopWatch.Name = "stopWatch";
            this.stopWatch.Size = new System.Drawing.Size(0, 29);
            this.stopWatch.TabIndex = 50;
            // 
            // rbRadix
            // 
            this.rbRadix.AutoSize = true;
            this.rbRadix.BackColor = System.Drawing.Color.Transparent;
            this.rbRadix.Location = new System.Drawing.Point(285, 430);
            this.rbRadix.Name = "rbRadix";
            this.rbRadix.Size = new System.Drawing.Size(64, 21);
            this.rbRadix.TabIndex = 66;
            this.rbRadix.TabStop = true;
            this.rbRadix.Text = "Radix";
            this.rbRadix.UseVisualStyleBackColor = false;
            // 
            // btnRegenerate
            // 
            this.btnRegenerate.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnRegenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegenerate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegenerate.Location = new System.Drawing.Point(29, 12);
            this.btnRegenerate.Name = "btnRegenerate";
            this.btnRegenerate.Size = new System.Drawing.Size(191, 57);
            this.btnRegenerate.TabIndex = 65;
            this.btnRegenerate.Text = "Regenerate Numbers";
            this.btnRegenerate.UseVisualStyleBackColor = false;
            this.btnRegenerate.Click += new System.EventHandler(this.BtnRegenerate_Click_1);
            // 
            // tbRadix
            // 
            this.tbRadix.Location = new System.Drawing.Point(246, 183);
            this.tbRadix.Name = "tbRadix";
            this.tbRadix.Size = new System.Drawing.Size(124, 22);
            this.tbRadix.TabIndex = 62;
            // 
            // btnRadixSort
            // 
            this.btnRadixSort.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnRadixSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRadixSort.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRadixSort.Location = new System.Drawing.Point(246, 145);
            this.btnRadixSort.Name = "btnRadixSort";
            this.btnRadixSort.Size = new System.Drawing.Size(124, 32);
            this.btnRadixSort.TabIndex = 59;
            this.btnRadixSort.Text = "Radix Sort";
            this.btnRadixSort.UseVisualStyleBackColor = false;
            this.btnRadixSort.Click += new System.EventHandler(this.BtnRadixSort_Click_1);
            // 
            // btnSortAll
            // 
            this.btnSortAll.BackColor = System.Drawing.Color.DimGray;
            this.btnSortAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSortAll.Location = new System.Drawing.Point(414, 12);
            this.btnSortAll.Name = "btnSortAll";
            this.btnSortAll.Size = new System.Drawing.Size(178, 57);
            this.btnSortAll.TabIndex = 58;
            this.btnSortAll.Text = "Sort All";
            this.btnSortAll.UseVisualStyleBackColor = false;
            this.btnSortAll.Click += new System.EventHandler(this.BtnSortAll_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(442, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 57;
            this.label3.Text = "Sorted Numbers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 17);
            this.label2.TabIndex = 56;
            this.label2.Text = "Payroll Salarys Between 50 -100K";
            // 
            // lstSortedOutput
            // 
            this.lstSortedOutput.FormattingEnabled = true;
            this.lstSortedOutput.ItemHeight = 16;
            this.lstSortedOutput.Location = new System.Drawing.Point(405, 117);
            this.lstSortedOutput.Name = "lstSortedOutput";
            this.lstSortedOutput.Size = new System.Drawing.Size(187, 388);
            this.lstSortedOutput.TabIndex = 55;
            // 
            // lstDataOutput
            // 
            this.lstDataOutput.BackColor = System.Drawing.SystemColors.Window;
            this.lstDataOutput.FormattingEnabled = true;
            this.lstDataOutput.ItemHeight = 16;
            this.lstDataOutput.Location = new System.Drawing.Point(28, 117);
            this.lstDataOutput.Name = "lstDataOutput";
            this.lstDataOutput.Size = new System.Drawing.Size(187, 388);
            this.lstDataOutput.TabIndex = 54;
            // 
            // SortPayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(621, 589);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbRadix);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.rbNone);
            this.Controls.Add(this.stopWatch);
            this.Controls.Add(this.rbRadix);
            this.Controls.Add(this.btnRegenerate);
            this.Controls.Add(this.tbRadix);
            this.Controls.Add(this.btnRadixSort);
            this.Controls.Add(this.btnSortAll);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstSortedOutput);
            this.Controls.Add(this.lstDataOutput);
            this.Name = "SortPayroll";
            this.Text = "SortPayroll";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbRadix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer stopWatchTimer;
        private System.Windows.Forms.RadioButton rbNone;
        private System.Windows.Forms.Label stopWatch;
        private System.Windows.Forms.RadioButton rbRadix;
        private System.Windows.Forms.Button btnRegenerate;
        private System.Windows.Forms.TextBox tbRadix;
        private System.Windows.Forms.Button btnRadixSort;
        private System.Windows.Forms.Button btnSortAll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstSortedOutput;
        private System.Windows.Forms.ListBox lstDataOutput;
    }
}