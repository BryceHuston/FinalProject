namespace PipeClient
{
    partial class Main
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
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSortForm = new System.Windows.Forms.Button();
            this.btnAudioPlayer = new System.Windows.Forms.Button();
            this.BtnBST = new System.Windows.Forms.Button();
            this.btnCSVFormat = new System.Windows.Forms.Button();
            this.BtnAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSortForm
            // 
            this.btnSortForm.BackColor = System.Drawing.Color.Cyan;
            this.btnSortForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortForm.Location = new System.Drawing.Point(35, 253);
            this.btnSortForm.Name = "btnSortForm";
            this.btnSortForm.Size = new System.Drawing.Size(225, 89);
            this.btnSortForm.TabIndex = 0;
            this.btnSortForm.Text = "SORT PAYROLL";
            this.btnSortForm.UseVisualStyleBackColor = false;
            this.btnSortForm.Click += new System.EventHandler(this.BtnSortForm_Click);
            // 
            // btnAudioPlayer
            // 
            this.btnAudioPlayer.BackColor = System.Drawing.Color.Cyan;
            this.btnAudioPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAudioPlayer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAudioPlayer.Location = new System.Drawing.Point(35, 41);
            this.btnAudioPlayer.Name = "btnAudioPlayer";
            this.btnAudioPlayer.Size = new System.Drawing.Size(225, 89);
            this.btnAudioPlayer.TabIndex = 1;
            this.btnAudioPlayer.Text = "AUDIO PLAYER";
            this.btnAudioPlayer.UseVisualStyleBackColor = false;
            this.btnAudioPlayer.Click += new System.EventHandler(this.BtnAudioPlayer_Click);
            // 
            // BtnBST
            // 
            this.BtnBST.BackColor = System.Drawing.Color.Cyan;
            this.BtnBST.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBST.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnBST.Location = new System.Drawing.Point(282, 41);
            this.BtnBST.Name = "BtnBST";
            this.BtnBST.Size = new System.Drawing.Size(225, 89);
            this.BtnBST.TabIndex = 2;
            this.BtnBST.Text = "BINARY SEARCH TREE";
            this.BtnBST.UseVisualStyleBackColor = false;
            this.BtnBST.Click += new System.EventHandler(this.BtnBST_Click);
            // 
            // btnCSVFormat
            // 
            this.btnCSVFormat.BackColor = System.Drawing.Color.Cyan;
            this.btnCSVFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCSVFormat.Location = new System.Drawing.Point(282, 254);
            this.btnCSVFormat.Name = "btnCSVFormat";
            this.btnCSVFormat.Size = new System.Drawing.Size(225, 89);
            this.btnCSVFormat.TabIndex = 5;
            this.btnCSVFormat.Text = "CSV FORMAT";
            this.btnCSVFormat.UseVisualStyleBackColor = false;
            this.btnCSVFormat.Click += new System.EventHandler(this.BtnCSVFormat_Click);
            // 
            // BtnAdmin
            // 
            this.BtnAdmin.BackColor = System.Drawing.Color.Black;
            this.BtnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAdmin.Location = new System.Drawing.Point(212, 159);
            this.BtnAdmin.Name = "BtnAdmin";
            this.BtnAdmin.Size = new System.Drawing.Size(117, 63);
            this.BtnAdmin.TabIndex = 6;
            this.BtnAdmin.Text = "ADMIN";
            this.BtnAdmin.UseVisualStyleBackColor = false;
            this.BtnAdmin.Click += new System.EventHandler(this.BtnAdmin_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(549, 378);
            this.Controls.Add(this.BtnAdmin);
            this.Controls.Add(this.btnCSVFormat);
            this.Controls.Add(this.BtnBST);
            this.Controls.Add(this.btnAudioPlayer);
            this.Controls.Add(this.btnSortForm);
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Button btnSortForm;
        private System.Windows.Forms.Button btnAudioPlayer;
        private System.Windows.Forms.Button BtnBST;
        private System.Windows.Forms.Button btnCSVFormat;
        private System.Windows.Forms.Button BtnAdmin;
    }
}