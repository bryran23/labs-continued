namespace Lab6
{
    partial class Lab6
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
            this.messageLbl = new System.Windows.Forms.Label();
            this.numOfWordsTxt = new System.Windows.Forms.TextBox();
            this.gradeLbl = new System.Windows.Forms.Label();
            this.AcceptBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messageLbl
            // 
            this.messageLbl.AutoSize = true;
            this.messageLbl.Location = new System.Drawing.Point(71, 34);
            this.messageLbl.Name = "messageLbl";
            this.messageLbl.Size = new System.Drawing.Size(221, 13);
            this.messageLbl.TabIndex = 0;
            this.messageLbl.Text = "Please enter the number of words typed here:";
            // 
            // numOfWordsTxt
            // 
            this.numOfWordsTxt.Location = new System.Drawing.Point(127, 75);
            this.numOfWordsTxt.Name = "numOfWordsTxt";
            this.numOfWordsTxt.Size = new System.Drawing.Size(100, 20);
            this.numOfWordsTxt.TabIndex = 1;
            // 
            // gradeLbl
            // 
            this.gradeLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradeLbl.Location = new System.Drawing.Point(127, 120);
            this.gradeLbl.Name = "gradeLbl";
            this.gradeLbl.Size = new System.Drawing.Size(100, 23);
            this.gradeLbl.TabIndex = 2;
            // 
            // AcceptBtn
            // 
            this.AcceptBtn.Location = new System.Drawing.Point(57, 166);
            this.AcceptBtn.Name = "AcceptBtn";
            this.AcceptBtn.Size = new System.Drawing.Size(75, 23);
            this.AcceptBtn.TabIndex = 3;
            this.AcceptBtn.Text = "Accept";
            this.AcceptBtn.UseVisualStyleBackColor = true;
            this.AcceptBtn.Click += new System.EventHandler(this.AcceptBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ResetBtn.Location = new System.Drawing.Point(217, 166);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(75, 23);
            this.ResetBtn.TabIndex = 4;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // Lab6
            // 
            this.AcceptButton = this.AcceptBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ResetBtn;
            this.ClientSize = new System.Drawing.Size(376, 254);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.AcceptBtn);
            this.Controls.Add(this.gradeLbl);
            this.Controls.Add(this.numOfWordsTxt);
            this.Controls.Add(this.messageLbl);
            this.Name = "Lab6";
            this.Text = "Lab 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label messageLbl;
        private System.Windows.Forms.TextBox numOfWordsTxt;
        private System.Windows.Forms.Label gradeLbl;
        private System.Windows.Forms.Button AcceptBtn;
        private System.Windows.Forms.Button ResetBtn;
    }
}

