namespace AQASkeletronPlus.GUI
{
    partial class DisplayHouseholds
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
            this.houses = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.okBtn = new System.Windows.Forms.Button();
            this.addHouseBtn = new System.Windows.Forms.Button();
            this.removeHouseBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // houses
            // 
            this.houses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.houses.Location = new System.Drawing.Point(12, 42);
            this.houses.Name = "houses";
            this.houses.Size = new System.Drawing.Size(293, 358);
            this.houses.TabIndex = 0;
            this.houses.UseCompatibleStateImageBehavior = false;
            this.houses.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Household";
            this.columnHeader1.Width = 89;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Position";
            this.columnHeader2.Width = 127;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(12, 435);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(293, 23);
            this.okBtn.TabIndex = 1;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // addHouseBtn
            // 
            this.addHouseBtn.Location = new System.Drawing.Point(12, 406);
            this.addHouseBtn.Name = "addHouseBtn";
            this.addHouseBtn.Size = new System.Drawing.Size(144, 23);
            this.addHouseBtn.TabIndex = 2;
            this.addHouseBtn.Text = "Add";
            this.addHouseBtn.UseVisualStyleBackColor = true;
            this.addHouseBtn.Click += new System.EventHandler(this.addHouseBtn_Click);
            // 
            // removeHouseBtn
            // 
            this.removeHouseBtn.Location = new System.Drawing.Point(160, 406);
            this.removeHouseBtn.Name = "removeHouseBtn";
            this.removeHouseBtn.Size = new System.Drawing.Size(144, 23);
            this.removeHouseBtn.TabIndex = 3;
            this.removeHouseBtn.Text = "Remove";
            this.removeHouseBtn.UseVisualStyleBackColor = true;
            this.removeHouseBtn.Click += new System.EventHandler(this.removeHouseBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Households";
            // 
            // DisplayHouseholds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 469);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeHouseBtn);
            this.Controls.Add(this.addHouseBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.houses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DisplayHouseholds";
            this.Text = "DisplayHouseholds";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView houses;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button addHouseBtn;
        private System.Windows.Forms.Button removeHouseBtn;
        private System.Windows.Forms.Label label1;
    }
}