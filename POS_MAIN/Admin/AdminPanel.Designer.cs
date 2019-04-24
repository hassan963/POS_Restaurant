namespace Admin
{
    partial class AdminPanel
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
            this.pnlAdminPanel = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnuser = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlAdminPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAdminPanel
            // 
            this.pnlAdminPanel.Controls.Add(this.btnExit);
            this.pnlAdminPanel.Controls.Add(this.btnMenu);
            this.pnlAdminPanel.Controls.Add(this.btnuser);
            this.pnlAdminPanel.Location = new System.Drawing.Point(3, 6);
            this.pnlAdminPanel.Name = "pnlAdminPanel";
            this.pnlAdminPanel.Size = new System.Drawing.Size(793, 440);
            this.pnlAdminPanel.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(454, 123);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(129, 60);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnuser
            // 
            this.btnuser.Location = new System.Drawing.Point(132, 123);
            this.btnuser.Name = "btnuser";
            this.btnuser.Size = new System.Drawing.Size(129, 60);
            this.btnuser.TabIndex = 0;
            this.btnuser.Text = "Users";
            this.btnuser.UseVisualStyleBackColor = true;
            this.btnuser.Click += new System.EventHandler(this.btnuser_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(45, 326);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 60);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlAdminPanel);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.pnlAdminPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAdminPanel;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnuser;
        private System.Windows.Forms.Button btnExit;
    }
}