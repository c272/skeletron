namespace AQASkeletronPlus.GUI
{
    partial class AboutMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.architectureLbl = new System.Windows.Forms.Label();
            this.releaseLbl = new System.Windows.Forms.Label();
            this.revisionLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, -18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "A rewrite of the AQA Skeleton Program.\r\nOriginal simulation (c) AQA.\r\nMap GUI cus" +
    "tom written for SKPE.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.architectureLbl);
            this.groupBox1.Controls.Add(this.releaseLbl);
            this.groupBox1.Controls.Add(this.revisionLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 73);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Build Information";
            // 
            // architectureLbl
            // 
            this.architectureLbl.AutoSize = true;
            this.architectureLbl.Location = new System.Drawing.Point(6, 50);
            this.architectureLbl.Name = "architectureLbl";
            this.architectureLbl.Size = new System.Drawing.Size(70, 13);
            this.architectureLbl.TabIndex = 2;
            this.architectureLbl.Text = "Architecture: ";
            // 
            // releaseLbl
            // 
            this.releaseLbl.AutoSize = true;
            this.releaseLbl.Location = new System.Drawing.Point(6, 34);
            this.releaseLbl.Name = "releaseLbl";
            this.releaseLbl.Size = new System.Drawing.Size(49, 13);
            this.releaseLbl.TabIndex = 1;
            this.releaseLbl.Text = "Release:";
            // 
            // revisionLbl
            // 
            this.revisionLbl.AutoSize = true;
            this.revisionLbl.Location = new System.Drawing.Point(6, 18);
            this.revisionLbl.Name = "revisionLbl";
            this.revisionLbl.Size = new System.Drawing.Size(54, 13);
            this.revisionLbl.TabIndex = 0;
            this.revisionLbl.Text = "Revision: ";
            // 
            // AboutMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 271);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutMenu";
            this.Text = "AQA SKPE - About";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label releaseLbl;
        private System.Windows.Forms.Label revisionLbl;
        private System.Windows.Forms.Label architectureLbl;
    }
}