namespace Pencil
{
    partial class ListPencils
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
            this.gridView = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.addCompanyBtn = new System.Windows.Forms.Button();
            this.addPencilBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView
            // 
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            this.gridView.Location = new System.Drawing.Point(12, 61);
            this.gridView.Name = "gridView";
            this.gridView.Size = new System.Drawing.Size(776, 377);
            this.gridView.TabIndex = 0;
            this.gridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForLinkValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForLinkValue = true;
            // 
            // addCompanyBtn
            // 
            this.addCompanyBtn.Location = new System.Drawing.Point(12, 21);
            this.addCompanyBtn.Name = "addCompanyBtn";
            this.addCompanyBtn.Size = new System.Drawing.Size(122, 23);
            this.addCompanyBtn.TabIndex = 1;
            this.addCompanyBtn.Text = "Add Company";
            this.addCompanyBtn.UseVisualStyleBackColor = true;
            this.addCompanyBtn.Click += new System.EventHandler(this.AddCompanyBtn_Click);
            // 
            // addPencilBtn
            // 
            this.addPencilBtn.Location = new System.Drawing.Point(140, 21);
            this.addPencilBtn.Name = "addPencilBtn";
            this.addPencilBtn.Size = new System.Drawing.Size(127, 23);
            this.addPencilBtn.TabIndex = 2;
            this.addPencilBtn.Text = "Add Pencil";
            this.addPencilBtn.UseVisualStyleBackColor = true;
            this.addPencilBtn.Click += new System.EventHandler(this.AddPencilBtn_Click);
            // 
            // ListPencils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addPencilBtn);
            this.Controls.Add(this.addCompanyBtn);
            this.Controls.Add(this.gridView);
            this.Name = "ListPencils";
            this.Text = "ListPencils";
            this.Load += new System.EventHandler(this.ListPencils_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
        private System.Windows.Forms.Button addCompanyBtn;
        private System.Windows.Forms.Button addPencilBtn;
    }
}