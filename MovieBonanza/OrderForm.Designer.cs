namespace MovieBonanza
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.MoviegroupBox = new System.Windows.Forms.GroupBox();
            this.CategorytextBox2 = new System.Windows.Forms.TextBox();
            this.TitletextBox2 = new System.Windows.Forms.TextBox();
            this.CategoryLabel2 = new System.Windows.Forms.Label();
            this.Titlelabel2 = new System.Windows.Forms.Label();
            this.LargepictureBox = new System.Windows.Forms.PictureBox();
            this.OrdergroupBox = new System.Windows.Forms.GroupBox();
            this.DVDcheckBox = new System.Windows.Forms.CheckBox();
            this.GrandTotalTextBox = new System.Windows.Forms.TextBox();
            this.SalesTaxTextBox = new System.Windows.Forms.TextBox();
            this.CostTextBox2 = new System.Windows.Forms.TextBox();
            this.SubTotaltextBox = new System.Windows.Forms.TextBox();
            this.Totallabel = new System.Windows.Forms.Label();
            this.SalesTaxLabel = new System.Windows.Forms.Label();
            this.Sublabel = new System.Windows.Forms.Label();
            this.Costlabel = new System.Windows.Forms.Label();
            this.Backbutton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.Streambutton = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.steamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.MoviegroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LargepictureBox)).BeginInit();
            this.OrdergroupBox.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MoviegroupBox
            // 
            this.MoviegroupBox.Controls.Add(this.CategorytextBox2);
            this.MoviegroupBox.Controls.Add(this.TitletextBox2);
            this.MoviegroupBox.Controls.Add(this.CategoryLabel2);
            this.MoviegroupBox.Controls.Add(this.Titlelabel2);
            this.MoviegroupBox.Controls.Add(this.LargepictureBox);
            this.MoviegroupBox.Location = new System.Drawing.Point(13, 48);
            this.MoviegroupBox.Name = "MoviegroupBox";
            this.MoviegroupBox.Size = new System.Drawing.Size(346, 344);
            this.MoviegroupBox.TabIndex = 2;
            this.MoviegroupBox.TabStop = false;
            this.MoviegroupBox.Text = "Movie Selected";
            // 
            // CategorytextBox2
            // 
            this.CategorytextBox2.Location = new System.Drawing.Point(42, 84);
            this.CategorytextBox2.Name = "CategorytextBox2";
            this.CategorytextBox2.Size = new System.Drawing.Size(237, 20);
            this.CategorytextBox2.TabIndex = 4;
            // 
            // TitletextBox2
            // 
            this.TitletextBox2.Location = new System.Drawing.Point(42, 37);
            this.TitletextBox2.Name = "TitletextBox2";
            this.TitletextBox2.Size = new System.Drawing.Size(237, 20);
            this.TitletextBox2.TabIndex = 3;
            // 
            // CategoryLabel2
            // 
            this.CategoryLabel2.AutoSize = true;
            this.CategoryLabel2.Location = new System.Drawing.Point(39, 69);
            this.CategoryLabel2.Name = "CategoryLabel2";
            this.CategoryLabel2.Size = new System.Drawing.Size(49, 13);
            this.CategoryLabel2.TabIndex = 2;
            this.CategoryLabel2.Text = "Category";
            // 
            // Titlelabel2
            // 
            this.Titlelabel2.AutoSize = true;
            this.Titlelabel2.Location = new System.Drawing.Point(39, 20);
            this.Titlelabel2.Name = "Titlelabel2";
            this.Titlelabel2.Size = new System.Drawing.Size(27, 13);
            this.Titlelabel2.TabIndex = 1;
            this.Titlelabel2.Text = "Title";
            // 
            // LargepictureBox
            // 
            this.LargepictureBox.Location = new System.Drawing.Point(39, 110);
            this.LargepictureBox.Name = "LargepictureBox";
            this.LargepictureBox.Size = new System.Drawing.Size(253, 213);
            this.LargepictureBox.TabIndex = 0;
            this.LargepictureBox.TabStop = false;
            // 
            // OrdergroupBox
            // 
            this.OrdergroupBox.Controls.Add(this.DVDcheckBox);
            this.OrdergroupBox.Controls.Add(this.GrandTotalTextBox);
            this.OrdergroupBox.Controls.Add(this.SalesTaxTextBox);
            this.OrdergroupBox.Controls.Add(this.CostTextBox2);
            this.OrdergroupBox.Controls.Add(this.SubTotaltextBox);
            this.OrdergroupBox.Controls.Add(this.Totallabel);
            this.OrdergroupBox.Controls.Add(this.SalesTaxLabel);
            this.OrdergroupBox.Controls.Add(this.Sublabel);
            this.OrdergroupBox.Controls.Add(this.Costlabel);
            this.OrdergroupBox.Location = new System.Drawing.Point(385, 48);
            this.OrdergroupBox.Name = "OrdergroupBox";
            this.OrdergroupBox.Size = new System.Drawing.Size(389, 260);
            this.OrdergroupBox.TabIndex = 3;
            this.OrdergroupBox.TabStop = false;
            this.OrdergroupBox.Text = "Your Order";
            // 
            // DVDcheckBox
            // 
            this.DVDcheckBox.AutoSize = true;
            this.DVDcheckBox.Location = new System.Drawing.Point(35, 237);
            this.DVDcheckBox.Name = "DVDcheckBox";
            this.DVDcheckBox.Size = new System.Drawing.Size(127, 17);
            this.DVDcheckBox.TabIndex = 8;
            this.DVDcheckBox.Text = "Order The DVD (10$)";
            this.DVDcheckBox.UseVisualStyleBackColor = true;
            // 
            // GrandTotalTextBox
            // 
            this.GrandTotalTextBox.Location = new System.Drawing.Point(75, 202);
            this.GrandTotalTextBox.Name = "GrandTotalTextBox";
            this.GrandTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.GrandTotalTextBox.TabIndex = 7;
            // 
            // SalesTaxTextBox
            // 
            this.SalesTaxTextBox.Location = new System.Drawing.Point(75, 161);
            this.SalesTaxTextBox.Name = "SalesTaxTextBox";
            this.SalesTaxTextBox.Size = new System.Drawing.Size(100, 20);
            this.SalesTaxTextBox.TabIndex = 6;
            // 
            // CostTextBox2
            // 
            this.CostTextBox2.Location = new System.Drawing.Point(75, 53);
            this.CostTextBox2.Name = "CostTextBox2";
            this.CostTextBox2.Size = new System.Drawing.Size(100, 20);
            this.CostTextBox2.TabIndex = 5;
            // 
            // SubTotaltextBox
            // 
            this.SubTotaltextBox.Location = new System.Drawing.Point(75, 100);
            this.SubTotaltextBox.Name = "SubTotaltextBox";
            this.SubTotaltextBox.Size = new System.Drawing.Size(100, 20);
            this.SubTotaltextBox.TabIndex = 4;
            // 
            // Totallabel
            // 
            this.Totallabel.AutoSize = true;
            this.Totallabel.Location = new System.Drawing.Point(72, 184);
            this.Totallabel.Name = "Totallabel";
            this.Totallabel.Size = new System.Drawing.Size(63, 13);
            this.Totallabel.TabIndex = 3;
            this.Totallabel.Text = "Grand Total";
            this.Totallabel.Click += new System.EventHandler(this.Totallabel_Click);
            // 
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.AutoSize = true;
            this.SalesTaxLabel.Location = new System.Drawing.Point(72, 145);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Size = new System.Drawing.Size(83, 13);
            this.SalesTaxLabel.TabIndex = 2;
            this.SalesTaxLabel.Text = "Sales Tax (13%)";
            // 
            // Sublabel
            // 
            this.Sublabel.AutoSize = true;
            this.Sublabel.Location = new System.Drawing.Point(72, 84);
            this.Sublabel.Name = "Sublabel";
            this.Sublabel.Size = new System.Drawing.Size(53, 13);
            this.Sublabel.TabIndex = 1;
            this.Sublabel.Text = "Sub Total";
            // 
            // Costlabel
            // 
            this.Costlabel.AutoSize = true;
            this.Costlabel.Location = new System.Drawing.Point(72, 37);
            this.Costlabel.Name = "Costlabel";
            this.Costlabel.Size = new System.Drawing.Size(28, 13);
            this.Costlabel.TabIndex = 0;
            this.Costlabel.Text = "Cost";
            // 
            // Backbutton
            // 
            this.Backbutton.Location = new System.Drawing.Point(395, 341);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(97, 40);
            this.Backbutton.TabIndex = 4;
            this.Backbutton.Text = "Back";
            this.Backbutton.UseVisualStyleBackColor = true;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(527, 341);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(88, 39);
            this.Cancelbutton.TabIndex = 5;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // Streambutton
            // 
            this.Streambutton.Location = new System.Drawing.Point(649, 341);
            this.Streambutton.Name = "Streambutton";
            this.Streambutton.Size = new System.Drawing.Size(88, 40);
            this.Streambutton.TabIndex = 6;
            this.Streambutton.Text = "Steam";
            this.Streambutton.UseVisualStyleBackColor = true;
            this.Streambutton.Click += new System.EventHandler(this.Streambutton_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip2.Size = new System.Drawing.Size(814, 25);
            this.menuStrip2.TabIndex = 7;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.cancelToolStripMenuItem,
            this.steamToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 19);
            this.toolStripMenuItem1.Text = "&File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.cancelToolStripMenuItem.Text = "Cancel";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // steamToolStripMenuItem
            // 
            this.steamToolStripMenuItem.Name = "steamToolStripMenuItem";
            this.steamToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.steamToolStripMenuItem.Text = "Steam";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(44, 19);
            this.toolStripMenuItem2.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // printForm1
            // 
            this.printForm1.DocumentName = "document";
            this.printForm1.Form = this;
            this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
            this.printForm1.PrintFileName = null;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 404);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.Streambutton);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.Backbutton);
            this.Controls.Add(this.OrdergroupBox);
            this.Controls.Add(this.MoviegroupBox);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.Activated += new System.EventHandler(this.OrderForm_Activated);
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.MoviegroupBox.ResumeLayout(false);
            this.MoviegroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LargepictureBox)).EndInit();
            this.OrdergroupBox.ResumeLayout(false);
            this.OrdergroupBox.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox MoviegroupBox;
        private System.Windows.Forms.TextBox CategorytextBox2;
        private System.Windows.Forms.TextBox TitletextBox2;
        private System.Windows.Forms.Label CategoryLabel2;
        private System.Windows.Forms.Label Titlelabel2;
        private System.Windows.Forms.PictureBox LargepictureBox;
        private System.Windows.Forms.GroupBox OrdergroupBox;
        private System.Windows.Forms.TextBox GrandTotalTextBox;
        private System.Windows.Forms.TextBox SalesTaxTextBox;
        private System.Windows.Forms.TextBox CostTextBox2;
        private System.Windows.Forms.TextBox SubTotaltextBox;
        private System.Windows.Forms.Label Totallabel;
        private System.Windows.Forms.Label SalesTaxLabel;
        private System.Windows.Forms.Label Sublabel;
        private System.Windows.Forms.Label Costlabel;
        private System.Windows.Forms.Button Backbutton;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Button Streambutton;
        private System.Windows.Forms.CheckBox DVDcheckBox;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem steamToolStripMenuItem;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
    }
}