namespace StorageSizesPE
{
    partial class Form1
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
            this.lstOut = new System.Windows.Forms.ListBox();
            this.lstSorted = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtMBin = new System.Windows.Forms.TextBox();
            this.lblListNo = new System.Windows.Forms.Label();
            this.lblMaxNo = new System.Windows.Forms.Label();
            this.lblMinNo = new System.Windows.Forms.Label();
            this.lblAvgNo = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstOut
            // 
            this.lstOut.FormatString = "#.##MB";
            this.lstOut.FormattingEnabled = true;
            this.lstOut.Location = new System.Drawing.Point(12, 12);
            this.lstOut.Name = "lstOut";
            this.lstOut.Size = new System.Drawing.Size(120, 147);
            this.lstOut.TabIndex = 0;
            // 
            // lstSorted
            // 
            this.lstSorted.FormatString = "#.##MB";
            this.lstSorted.FormattingEnabled = true;
            this.lstSorted.Location = new System.Drawing.Point(300, 12);
            this.lstSorted.Name = "lstSorted";
            this.lstSorted.Size = new System.Drawing.Size(120, 147);
            this.lstSorted.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 191);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add MB";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(240, 191);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 3;
            this.btnSort.Text = "Sort ";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(345, 191);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtMBin
            // 
            this.txtMBin.Location = new System.Drawing.Point(114, 193);
            this.txtMBin.Name = "txtMBin";
            this.txtMBin.Size = new System.Drawing.Size(100, 20);
            this.txtMBin.TabIndex = 5;
            // 
            // lblListNo
            // 
            this.lblListNo.AutoSize = true;
            this.lblListNo.Location = new System.Drawing.Point(139, 13);
            this.lblListNo.Name = "lblListNo";
            this.lblListNo.Size = new System.Drawing.Size(76, 13);
            this.lblListNo.TabIndex = 6;
            this.lblListNo.Text = "No. of entries: ";
            // 
            // lblMaxNo
            // 
            this.lblMaxNo.AutoSize = true;
            this.lblMaxNo.Location = new System.Drawing.Point(139, 41);
            this.lblMaxNo.Name = "lblMaxNo";
            this.lblMaxNo.Size = new System.Drawing.Size(75, 13);
            this.lblMaxNo.TabIndex = 7;
            this.lblMaxNo.Text = "Largest Entry: ";
            // 
            // lblMinNo
            // 
            this.lblMinNo.AutoSize = true;
            this.lblMinNo.Location = new System.Drawing.Point(139, 74);
            this.lblMinNo.Name = "lblMinNo";
            this.lblMinNo.Size = new System.Drawing.Size(79, 13);
            this.lblMinNo.TabIndex = 8;
            this.lblMinNo.Text = "Smallest Entry: ";
            // 
            // lblAvgNo
            // 
            this.lblAvgNo.AutoSize = true;
            this.lblAvgNo.Location = new System.Drawing.Point(139, 107);
            this.lblAvgNo.Name = "lblAvgNo";
            this.lblAvgNo.Size = new System.Drawing.Size(100, 13);
            this.lblAvgNo.TabIndex = 9;
            this.lblAvgNo.Text = "Average of Entries: ";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(139, 136);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(81, 13);
            this.lblSum.TabIndex = 10;
            this.lblSum.Text = "Sum of Entries: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 233);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.lblAvgNo);
            this.Controls.Add(this.lblMinNo);
            this.Controls.Add(this.lblMaxNo);
            this.Controls.Add(this.lblListNo);
            this.Controls.Add(this.txtMBin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstSorted);
            this.Controls.Add(this.lstOut);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstOut;
        private System.Windows.Forms.ListBox lstSorted;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtMBin;
        private System.Windows.Forms.Label lblListNo;
        private System.Windows.Forms.Label lblMaxNo;
        private System.Windows.Forms.Label lblMinNo;
        private System.Windows.Forms.Label lblAvgNo;
        private System.Windows.Forms.Label lblSum;
    }
}

