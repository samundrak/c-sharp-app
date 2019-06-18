namespace Pencil
{
    partial class AddCompany
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
            this.companyTextBox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPencilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPencilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company Name";
            // 
            // companyTextBox
            // 
            this.companyTextBox.Location = new System.Drawing.Point(315, 114);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.Size = new System.Drawing.Size(286, 20);
            this.companyTextBox.TabIndex = 1;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(315, 152);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gotoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gotoToolStripMenuItem
            // 
            this.gotoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPencilToolStripMenuItem,
            this.showPencilToolStripMenuItem});
            this.gotoToolStripMenuItem.Name = "gotoToolStripMenuItem";
            this.gotoToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.gotoToolStripMenuItem.Text = "Goto";
            // 
            // addPencilToolStripMenuItem
            // 
            this.addPencilToolStripMenuItem.Name = "addPencilToolStripMenuItem";
            this.addPencilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addPencilToolStripMenuItem.Text = "Add Pencil";
            this.addPencilToolStripMenuItem.Click += new System.EventHandler(this.AddPencilToolStripMenuItem_Click);
            // 
            // showPencilToolStripMenuItem
            // 
            this.showPencilToolStripMenuItem.Name = "showPencilToolStripMenuItem";
            this.showPencilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showPencilToolStripMenuItem.Text = "Show Pencils";
            this.showPencilToolStripMenuItem.Click += new System.EventHandler(this.ShowPencilToolStripMenuItem_Click);
            // 
            // AddCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.companyTextBox);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AddCompany";
            this.Text = "AddCompany";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox companyTextBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gotoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPencilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPencilToolStripMenuItem;
    }
}