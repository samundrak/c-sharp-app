namespace Pencil
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.qualityTextBox = new System.Windows.Forms.TextBox();
            this.companyComboBox = new System.Windows.Forms.ComboBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPencilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quality";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price";
            // 
            // colorTextBox
            // 
            this.colorTextBox.Location = new System.Drawing.Point(320, 96);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(121, 20);
            this.colorTextBox.TabIndex = 4;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(320, 138);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(121, 20);
            this.priceTextBox.TabIndex = 5;
            // 
            // qualityTextBox
            // 
            this.qualityTextBox.Location = new System.Drawing.Point(320, 178);
            this.qualityTextBox.Name = "qualityTextBox";
            this.qualityTextBox.Size = new System.Drawing.Size(121, 20);
            this.qualityTextBox.TabIndex = 6;
            // 
            // companyComboBox
            // 
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.Location = new System.Drawing.Point(320, 63);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(121, 21);
            this.companyComboBox.TabIndex = 7;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(320, 235);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(121, 23);
            this.submitBtn.TabIndex = 8;
            this.submitBtn.Text = "Add";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gotoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gotoToolStripMenuItem
            // 
            this.gotoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPencilsToolStripMenuItem,
            this.addCompanyToolStripMenuItem});
            this.gotoToolStripMenuItem.Name = "gotoToolStripMenuItem";
            this.gotoToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.gotoToolStripMenuItem.Text = "Goto";
            // 
            // showPencilsToolStripMenuItem
            // 
            this.showPencilsToolStripMenuItem.Name = "showPencilsToolStripMenuItem";
            this.showPencilsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showPencilsToolStripMenuItem.Text = "Show Pencils";
            this.showPencilsToolStripMenuItem.Click += new System.EventHandler(this.ShowPencilsToolStripMenuItem_Click);
            // 
            // addCompanyToolStripMenuItem
            // 
            this.addCompanyToolStripMenuItem.Name = "addCompanyToolStripMenuItem";
            this.addCompanyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addCompanyToolStripMenuItem.Text = "Add Company";
            this.addCompanyToolStripMenuItem.Click += new System.EventHandler(this.AddCompanyToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.companyComboBox);
            this.Controls.Add(this.qualityTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Add Pencil";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox qualityTextBox;
        private System.Windows.Forms.ComboBox companyComboBox;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gotoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPencilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCompanyToolStripMenuItem;
    }
}

