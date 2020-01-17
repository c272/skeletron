namespace AQASkeletronPlus.GUI
{
    partial class SettingsMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.okButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startingRepBox = new System.Windows.Forms.NumericUpDown();
            this.dailyCostBox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.fuelCostBox = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.baseDeliveryCostBox = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.startingRepBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyCostBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelCostBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDeliveryCostBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Granular simulation settings can be altered through creating a \r\n\"settings.ini\" f" +
    "ile in the same directory as the program. You can\r\nsee all the available setting" +
    "s on the Wiki/Docs, at this link:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(102, 198);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(133, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Skeletron+ Documentation";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.docsLinkClicked);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(127, 221);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(83, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "Save";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Gothic Std B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(86, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Basic Settings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Starting Reputation:";
            // 
            // startingRepBox
            // 
            this.startingRepBox.Location = new System.Drawing.Point(44, 70);
            this.startingRepBox.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.startingRepBox.Name = "startingRepBox";
            this.startingRepBox.Size = new System.Drawing.Size(120, 20);
            this.startingRepBox.TabIndex = 5;
            // 
            // dailyCostBox
            // 
            this.dailyCostBox.DecimalPlaces = 2;
            this.dailyCostBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.dailyCostBox.Location = new System.Drawing.Point(179, 70);
            this.dailyCostBox.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            131072});
            this.dailyCostBox.Name = "dailyCostBox";
            this.dailyCostBox.Size = new System.Drawing.Size(120, 20);
            this.dailyCostBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Starting Daily Cost:";
            // 
            // fuelCostBox
            // 
            this.fuelCostBox.DecimalPlaces = 2;
            this.fuelCostBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.fuelCostBox.Location = new System.Drawing.Point(44, 115);
            this.fuelCostBox.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            131072});
            this.fuelCostBox.Name = "fuelCostBox";
            this.fuelCostBox.Size = new System.Drawing.Size(120, 20);
            this.fuelCostBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Starting Fuel Cost:";
            // 
            // baseDeliveryCostBox
            // 
            this.baseDeliveryCostBox.DecimalPlaces = 2;
            this.baseDeliveryCostBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.baseDeliveryCostBox.Location = new System.Drawing.Point(179, 115);
            this.baseDeliveryCostBox.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            131072});
            this.baseDeliveryCostBox.Name = "baseDeliveryCostBox";
            this.baseDeliveryCostBox.Size = new System.Drawing.Size(120, 20);
            this.baseDeliveryCostBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Starting Base Delivery Cost:";
            // 
            // SettingsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 255);
            this.Controls.Add(this.baseDeliveryCostBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fuelCostBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dailyCostBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.startingRepBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsMenu";
            this.Text = "AQA SKPE - Settings";
            ((System.ComponentModel.ISupportInitialize)(this.startingRepBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyCostBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelCostBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDeliveryCostBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown startingRepBox;
        private System.Windows.Forms.NumericUpDown dailyCostBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown fuelCostBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown baseDeliveryCostBox;
        private System.Windows.Forms.Label label6;
    }
}