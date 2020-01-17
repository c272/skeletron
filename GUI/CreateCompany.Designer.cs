namespace AQASkeletronPlus.GUI
{
    partial class CreateCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateCompany));
            this.nameText = new System.Windows.Forms.TextBox();
            this.startingBalance = new System.Windows.Forms.NumericUpDown();
            this.startingOutlets = new System.Windows.Forms.NumericUpDown();
            this.companyType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.startingBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startingOutlets)).BeginInit();
            this.SuspendLayout();
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(13, 56);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(183, 20);
            this.nameText.TabIndex = 0;
            // 
            // startingBalance
            // 
            this.startingBalance.DecimalPlaces = 2;
            this.startingBalance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.startingBalance.Location = new System.Drawing.Point(13, 100);
            this.startingBalance.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.startingBalance.Name = "startingBalance";
            this.startingBalance.Size = new System.Drawing.Size(183, 20);
            this.startingBalance.TabIndex = 1;
            // 
            // startingOutlets
            // 
            this.startingOutlets.Location = new System.Drawing.Point(14, 189);
            this.startingOutlets.Name = "startingOutlets";
            this.startingOutlets.Size = new System.Drawing.Size(182, 20);
            this.startingOutlets.TabIndex = 2;
            // 
            // companyType
            // 
            this.companyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.companyType.FormattingEnabled = true;
            this.companyType.Location = new System.Drawing.Point(13, 144);
            this.companyType.Name = "companyType";
            this.companyType.Size = new System.Drawing.Size(183, 21);
            this.companyType.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Starting Balance:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Starting Outlets:";
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(57, 217);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(89, 23);
            this.okBtn.TabIndex = 8;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Create Company";
            // 
            // CreateCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 247);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.companyType);
            this.Controls.Add(this.startingOutlets);
            this.Controls.Add(this.startingBalance);
            this.Controls.Add(this.nameText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateCompany";
            this.Text = "AQA SKPE - Create Company";
            ((System.ComponentModel.ISupportInitialize)(this.startingBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startingOutlets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.NumericUpDown startingBalance;
        private System.Windows.Forms.NumericUpDown startingOutlets;
        private System.Windows.Forms.ComboBox companyType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Label label5;
    }
}