namespace Lab7
{
    partial class Lab7
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
            this.futureLbl = new System.Windows.Forms.Label();
            this.annualLbl = new System.Windows.Forms.Label();
            this.yearLbl = new System.Windows.Forms.Label();
            this.presentLbl = new System.Windows.Forms.Label();
            this.futureTxt = new System.Windows.Forms.TextBox();
            this.annualTxt = new System.Windows.Forms.TextBox();
            this.yearTxt = new System.Windows.Forms.TextBox();
            this.outputLbl = new System.Windows.Forms.Label();
            this.calcBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // futureLbl
            // 
            this.futureLbl.AutoSize = true;
            this.futureLbl.Location = new System.Drawing.Point(76, 52);
            this.futureLbl.Name = "futureLbl";
            this.futureLbl.Size = new System.Drawing.Size(70, 13);
            this.futureLbl.TabIndex = 0;
            this.futureLbl.Text = "Future Value:";
            // 
            // annualLbl
            // 
            this.annualLbl.AutoSize = true;
            this.annualLbl.Location = new System.Drawing.Point(79, 96);
            this.annualLbl.Name = "annualLbl";
            this.annualLbl.Size = new System.Drawing.Size(107, 13);
            this.annualLbl.TabIndex = 1;
            this.annualLbl.Text = "Annual Interest Rate:";
            // 
            // yearLbl
            // 
            this.yearLbl.AutoSize = true;
            this.yearLbl.Location = new System.Drawing.Point(82, 145);
            this.yearLbl.Name = "yearLbl";
            this.yearLbl.Size = new System.Drawing.Size(64, 13);
            this.yearLbl.TabIndex = 2;
            this.yearLbl.Text = "No. of Year:";
            // 
            // presentLbl
            // 
            this.presentLbl.AutoSize = true;
            this.presentLbl.Location = new System.Drawing.Point(85, 196);
            this.presentLbl.Name = "presentLbl";
            this.presentLbl.Size = new System.Drawing.Size(76, 13);
            this.presentLbl.TabIndex = 3;
            this.presentLbl.Text = "Present Value:";
            // 
            // futureTxt
            // 
            this.futureTxt.Location = new System.Drawing.Point(209, 49);
            this.futureTxt.Name = "futureTxt";
            this.futureTxt.Size = new System.Drawing.Size(100, 20);
            this.futureTxt.TabIndex = 4;
            // 
            // annualTxt
            // 
            this.annualTxt.Location = new System.Drawing.Point(209, 93);
            this.annualTxt.Name = "annualTxt";
            this.annualTxt.Size = new System.Drawing.Size(100, 20);
            this.annualTxt.TabIndex = 5;
            // 
            // yearTxt
            // 
            this.yearTxt.Location = new System.Drawing.Point(209, 142);
            this.yearTxt.Name = "yearTxt";
            this.yearTxt.Size = new System.Drawing.Size(100, 20);
            this.yearTxt.TabIndex = 6;
            // 
            // outputLbl
            // 
            this.outputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLbl.Location = new System.Drawing.Point(209, 195);
            this.outputLbl.Name = "outputLbl";
            this.outputLbl.Size = new System.Drawing.Size(100, 23);
            this.outputLbl.TabIndex = 7;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(152, 246);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(75, 23);
            this.calcBtn.TabIndex = 8;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // Lab7
            // 
            this.AcceptButton = this.calcBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 319);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.outputLbl);
            this.Controls.Add(this.yearTxt);
            this.Controls.Add(this.annualTxt);
            this.Controls.Add(this.futureTxt);
            this.Controls.Add(this.presentLbl);
            this.Controls.Add(this.yearLbl);
            this.Controls.Add(this.annualLbl);
            this.Controls.Add(this.futureLbl);
            this.Name = "Lab7";
            this.Text = "Lab 7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label futureLbl;
        private System.Windows.Forms.Label annualLbl;
        private System.Windows.Forms.Label yearLbl;
        private System.Windows.Forms.Label presentLbl;
        private System.Windows.Forms.TextBox futureTxt;
        private System.Windows.Forms.TextBox annualTxt;
        private System.Windows.Forms.TextBox yearTxt;
        private System.Windows.Forms.Label outputLbl;
        private System.Windows.Forms.Button calcBtn;
    }
}

