namespace AQASkeletronPlus.GUI
{
    partial class ModifyCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyCompany));
            this.nameLbl = new System.Windows.Forms.Label();
            this.openOutletBtn = new System.Windows.Forms.Button();
            this.closeOutletBtn = new System.Windows.Forms.Button();
            this.expandOutletBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nameLbl.Location = new System.Drawing.Point(12, 9);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(148, 24);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Company Name";
            // 
            // openOutletBtn
            // 
            this.openOutletBtn.Location = new System.Drawing.Point(16, 41);
            this.openOutletBtn.Name = "openOutletBtn";
            this.openOutletBtn.Size = new System.Drawing.Size(274, 23);
            this.openOutletBtn.TabIndex = 1;
            this.openOutletBtn.Text = "Open New Outlet";
            this.openOutletBtn.UseVisualStyleBackColor = true;
            this.openOutletBtn.Click += new System.EventHandler(this.openOutletBtn_Click);
            // 
            // closeOutletBtn
            // 
            this.closeOutletBtn.Location = new System.Drawing.Point(16, 70);
            this.closeOutletBtn.Name = "closeOutletBtn";
            this.closeOutletBtn.Size = new System.Drawing.Size(274, 23);
            this.closeOutletBtn.TabIndex = 2;
            this.closeOutletBtn.Text = "Close Outlet";
            this.closeOutletBtn.UseVisualStyleBackColor = true;
            this.closeOutletBtn.Click += new System.EventHandler(this.closeOutletBtn_Click);
            // 
            // expandOutletBtn
            // 
            this.expandOutletBtn.Location = new System.Drawing.Point(16, 99);
            this.expandOutletBtn.Name = "expandOutletBtn";
            this.expandOutletBtn.Size = new System.Drawing.Size(274, 23);
            this.expandOutletBtn.TabIndex = 3;
            this.expandOutletBtn.Text = "Expand Outlet";
            this.expandOutletBtn.UseVisualStyleBackColor = true;
            this.expandOutletBtn.Click += new System.EventHandler(this.expandOutletBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(113, 128);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 4;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // ModifyCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 161);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.expandOutletBtn);
            this.Controls.Add(this.closeOutletBtn);
            this.Controls.Add(this.openOutletBtn);
            this.Controls.Add(this.nameLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ModifyCompany";
            this.Text = "AQA SKPE - Modify Company";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Button openOutletBtn;
        private System.Windows.Forms.Button closeOutletBtn;
        private System.Windows.Forms.Button expandOutletBtn;
        private System.Windows.Forms.Button okBtn;
    }
}