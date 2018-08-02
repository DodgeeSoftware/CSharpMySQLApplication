namespace CSharpMySQLApplication
{
    partial class MainWindow
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
            this.AboutButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.ShowCustomersButton = new System.Windows.Forms.Button();
            this.RemoveCustomerButton = new System.Windows.Forms.Button();
            this.FindCustomerButton = new System.Windows.Forms.Button();
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AboutButton
            // 
            this.AboutButton.Location = new System.Drawing.Point(118, 70);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(90, 23);
            this.AboutButton.TabIndex = 11;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(12, 70);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(100, 23);
            this.QuitButton.TabIndex = 10;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // ShowCustomersButton
            // 
            this.ShowCustomersButton.Location = new System.Drawing.Point(118, 41);
            this.ShowCustomersButton.Name = "ShowCustomersButton";
            this.ShowCustomersButton.Size = new System.Drawing.Size(90, 23);
            this.ShowCustomersButton.TabIndex = 9;
            this.ShowCustomersButton.Text = "ShowCustomers";
            this.ShowCustomersButton.UseVisualStyleBackColor = true;
            this.ShowCustomersButton.Click += new System.EventHandler(this.ShowCustomersButton_Click);
            // 
            // RemoveCustomerButton
            // 
            this.RemoveCustomerButton.Location = new System.Drawing.Point(12, 41);
            this.RemoveCustomerButton.Name = "RemoveCustomerButton";
            this.RemoveCustomerButton.Size = new System.Drawing.Size(100, 23);
            this.RemoveCustomerButton.TabIndex = 8;
            this.RemoveCustomerButton.Text = "Remove Customer";
            this.RemoveCustomerButton.UseVisualStyleBackColor = true;
            this.RemoveCustomerButton.Click += new System.EventHandler(this.RemoveCustomerButton_Click);
            // 
            // FindCustomerButton
            // 
            this.FindCustomerButton.Location = new System.Drawing.Point(118, 12);
            this.FindCustomerButton.Name = "FindCustomerButton";
            this.FindCustomerButton.Size = new System.Drawing.Size(90, 23);
            this.FindCustomerButton.TabIndex = 7;
            this.FindCustomerButton.Text = "Find Customer";
            this.FindCustomerButton.UseVisualStyleBackColor = true;
            this.FindCustomerButton.Click += new System.EventHandler(this.FindCustomerButton_Click);
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.Location = new System.Drawing.Point(12, 12);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(100, 23);
            this.AddCustomerButton.TabIndex = 6;
            this.AddCustomerButton.Text = "Add Customer";
            this.AddCustomerButton.UseVisualStyleBackColor = true;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 103);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.ShowCustomersButton);
            this.Controls.Add(this.RemoveCustomerButton);
            this.Controls.Add(this.FindCustomerButton);
            this.Controls.Add(this.AddCustomerButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button ShowCustomersButton;
        private System.Windows.Forms.Button RemoveCustomerButton;
        private System.Windows.Forms.Button FindCustomerButton;
        private System.Windows.Forms.Button AddCustomerButton;
    }
}