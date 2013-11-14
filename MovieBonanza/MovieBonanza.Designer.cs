namespace MovieBonanza
{
    partial class MovieBonanza
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
            this.MoviesLabel = new System.Windows.Forms.Label();
            this.MovieGroupBox = new System.Windows.Forms.GroupBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MovieListBox = new System.Windows.Forms.ListBox();
            this.MovieGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MoviesLabel
            // 
            this.MoviesLabel.AutoSize = true;
            this.MoviesLabel.Location = new System.Drawing.Point(35, 24);
            this.MoviesLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.MoviesLabel.Name = "MoviesLabel";
            this.MoviesLabel.Size = new System.Drawing.Size(132, 20);
            this.MoviesLabel.TabIndex = 2;
            this.MoviesLabel.Text = "Available Movie";
            // 
            // MovieGroupBox
            // 
            this.MovieGroupBox.Controls.Add(this.NextButton);
            this.MovieGroupBox.Controls.Add(this.PriceTextBox);
            this.MovieGroupBox.Controls.Add(this.CategoryTextBox);
            this.MovieGroupBox.Controls.Add(this.TitleTextBox);
            this.MovieGroupBox.Controls.Add(this.PriceLabel);
            this.MovieGroupBox.Controls.Add(this.CategoryLabel);
            this.MovieGroupBox.Controls.Add(this.TitleLabel);
            this.MovieGroupBox.Controls.Add(this.pictureBox1);
            this.MovieGroupBox.Location = new System.Drawing.Point(287, 47);
            this.MovieGroupBox.Name = "MovieGroupBox";
            this.MovieGroupBox.Size = new System.Drawing.Size(545, 228);
            this.MovieGroupBox.TabIndex = 3;
            this.MovieGroupBox.TabStop = false;
            this.MovieGroupBox.Text = "Movie Info";
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(444, 176);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(82, 35);
            this.NextButton.TabIndex = 7;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(38, 185);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.ReadOnly = true;
            this.PriceTextBox.Size = new System.Drawing.Size(215, 26);
            this.PriceTextBox.TabIndex = 6;
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Location = new System.Drawing.Point(38, 120);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.ReadOnly = true;
            this.CategoryTextBox.Size = new System.Drawing.Size(215, 26);
            this.CategoryTextBox.TabIndex = 5;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(38, 60);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.ReadOnly = true;
            this.TitleTextBox.Size = new System.Drawing.Size(215, 26);
            this.TitleTextBox.TabIndex = 4;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(34, 161);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(49, 20);
            this.PriceLabel.TabIndex = 3;
            this.PriceLabel.Text = "Price";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(34, 96);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(81, 20);
            this.CategoryLabel.TabIndex = 2;
            this.CategoryLabel.Text = "Category";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(34, 37);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(94, 20);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Movie Title";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(369, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 103);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MovieListBox
            // 
            this.MovieListBox.FormattingEnabled = true;
            this.MovieListBox.ItemHeight = 20;
            this.MovieListBox.Items.AddRange(new object[] {
            "Cedar Rapids",
            "Company\tMen",
            "Death Race 2",
            "Footloose",
            "Gnomeo and Juliet",
            "I am Number Four",
            "Just Go With It",
            "No Strings Attached",
            "Real Steel",
            "Sanctum",
            "Season of the Witch ",
            "The Dilemma",
            "The Eagle",
            "The Green\tHornet",
            "The Mechanic",
            "The Other\tWoman",
            "The Rite",
            "The Roommate",
            "The Way Back",
            "Waiting for Forever"});
            this.MovieListBox.Location = new System.Drawing.Point(12, 60);
            this.MovieListBox.Name = "MovieListBox";
            this.MovieListBox.Size = new System.Drawing.Size(222, 224);
            this.MovieListBox.Sorted = true;
            this.MovieListBox.TabIndex = 4;
            this.MovieListBox.SelectedIndexChanged += new System.EventHandler(this.MovieListBox_SelectedIndexChanged);
            // 
            // MovieBonanza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 294);
            this.ControlBox = false;
            this.Controls.Add(this.MovieListBox);
            this.Controls.Add(this.MovieGroupBox);
            this.Controls.Add(this.MoviesLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MovieBonanza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Bonanza";
            this.MovieGroupBox.ResumeLayout(false);
            this.MovieGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MoviesLabel;
        private System.Windows.Forms.GroupBox MovieGroupBox;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox MovieListBox;
    }
}