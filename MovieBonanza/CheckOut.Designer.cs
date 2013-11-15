namespace MovieBonanza
{
    partial class CheckOut
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
            this.OKbutton = new System.Windows.Forms.Button();
            this.StartLabel = new System.Windows.Forms.Label();
            this.MoneyLabel = new System.Windows.Forms.Label();
            this.MidLabel = new System.Windows.Forms.Label();
            this.MovieLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OKbutton
            // 
            this.OKbutton.Location = new System.Drawing.Point(208, 181);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(75, 23);
            this.OKbutton.TabIndex = 0;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartLabel.Location = new System.Drawing.Point(50, 54);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(248, 24);
            this.StartLabel.TabIndex = 1;
            this.StartLabel.Text = "You Have Been Charged:";
            // 
            // MoneyLabel
            // 
            this.MoneyLabel.AutoSize = true;
            this.MoneyLabel.Location = new System.Drawing.Point(326, 62);
            this.MoneyLabel.Name = "MoneyLabel";
            this.MoneyLabel.Size = new System.Drawing.Size(19, 13);
            this.MoneyLabel.TabIndex = 2;
            this.MoneyLabel.Text = "$$";
            // 
            // MidLabel
            // 
            this.MidLabel.AutoSize = true;
            this.MidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MidLabel.Location = new System.Drawing.Point(50, 130);
            this.MidLabel.Name = "MidLabel";
            this.MidLabel.Size = new System.Drawing.Size(214, 24);
            this.MidLabel.TabIndex = 3;
            this.MidLabel.Text = "ThankYou And Enjoy:";
            // 
            // MovieLabel1
            // 
            this.MovieLabel1.AutoSize = true;
            this.MovieLabel1.Location = new System.Drawing.Point(326, 141);
            this.MovieLabel1.Name = "MovieLabel1";
            this.MovieLabel1.Size = new System.Drawing.Size(27, 13);
            this.MovieLabel1.TabIndex = 4;
            this.MovieLabel1.Text = "xxxx";
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 233);
            this.Controls.Add(this.MovieLabel1);
            this.Controls.Add(this.MidLabel);
            this.Controls.Add(this.MoneyLabel);
            this.Controls.Add(this.StartLabel);
            this.Controls.Add(this.OKbutton);
            this.Name = "CheckOut";
            this.Text = "CheckOut";
            this.Load += new System.EventHandler(this.CheckOut_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.Label StartLabel;
        private System.Windows.Forms.Label MoneyLabel;
        private System.Windows.Forms.Label MidLabel;
        private System.Windows.Forms.Label MovieLabel1;
    }
}