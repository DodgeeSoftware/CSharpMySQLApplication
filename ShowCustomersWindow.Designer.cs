namespace CSharpMySQLApplication
{
    partial class ShowCustomersWindow
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
            this.DatabaseTableControl = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GivenNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseTableControl)).BeginInit();
            this.SuspendLayout();
            // 
            // DatabaseTableControl
            // 
            this.DatabaseTableControl.AllowUserToAddRows = false;
            this.DatabaseTableControl.AllowUserToDeleteRows = false;
            this.DatabaseTableControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatabaseTableControl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.Title,
            this.GivenNames,
            this.LastName});
            this.DatabaseTableControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatabaseTableControl.Location = new System.Drawing.Point(0, 0);
            this.DatabaseTableControl.Name = "DatabaseTableControl";
            this.DatabaseTableControl.ReadOnly = true;
            this.DatabaseTableControl.RowHeadersVisible = false;
            this.DatabaseTableControl.Size = new System.Drawing.Size(403, 341);
            this.DatabaseTableControl.TabIndex = 0;
            // 
            // CustomerID
            // 
            this.CustomerID.FillWeight = 25F;
            this.CustomerID.HeaderText = "CustomerID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.FillWeight = 25F;
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // GivenNames
            // 
            this.GivenNames.FillWeight = 25F;
            this.GivenNames.HeaderText = "GivenNames";
            this.GivenNames.Name = "GivenNames";
            this.GivenNames.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.FillWeight = 25F;
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // ShowCustomersWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 341);
            this.Controls.Add(this.DatabaseTableControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ShowCustomersWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Customers Window";
            this.Load += new System.EventHandler(this.ShowCustomersWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseTableControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DatabaseTableControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn GivenNames;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
    }
}