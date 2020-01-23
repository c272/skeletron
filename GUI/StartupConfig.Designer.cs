namespace AQASkeletronPlus.GUI
{
    partial class StartupConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartupConfig));
            this.simWidth = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.simHeight = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.simHouses = new System.Windows.Forms.NumericUpDown();
            this.goBtn = new System.Windows.Forms.Button();
            this.balancedModeCb = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.simWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simHouses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // simWidth
            // 
            this.simWidth.Location = new System.Drawing.Point(16, 190);
            this.simWidth.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.simWidth.Name = "simWidth";
            this.simWidth.Size = new System.Drawing.Size(200, 20);
            this.simWidth.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Simulation Width:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Simulation Height:";
            // 
            // simHeight
            // 
            this.simHeight.Location = new System.Drawing.Point(16, 240);
            this.simHeight.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.simHeight.Name = "simHeight";
            this.simHeight.Size = new System.Drawing.Size(200, 20);
            this.simHeight.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Number of Houses:";
            // 
            // simHouses
            // 
            this.simHouses.Location = new System.Drawing.Point(16, 292);
            this.simHouses.Maximum = new decimal(new int[] {
            2250000,
            0,
            0,
            0});
            this.simHouses.Name = "simHouses";
            this.simHouses.Size = new System.Drawing.Size(200, 20);
            this.simHouses.TabIndex = 8;
            // 
            // goBtn
            // 
            this.goBtn.Location = new System.Drawing.Point(16, 346);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(200, 23);
            this.goBtn.TabIndex = 10;
            this.goBtn.Text = "Go";
            this.goBtn.UseVisualStyleBackColor = true;
            this.goBtn.Click += new System.EventHandler(this.goBtn_Click);
            // 
            // balancedModeCb
            // 
            this.balancedModeCb.AutoSize = true;
            this.balancedModeCb.Checked = true;
            this.balancedModeCb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.balancedModeCb.Location = new System.Drawing.Point(42, 327);
            this.balancedModeCb.Name = "balancedModeCb";
            this.balancedModeCb.Size = new System.Drawing.Size(147, 17);
            this.balancedModeCb.TabIndex = 11;
            this.balancedModeCb.Text = "Enable \"Balanced Mode\"";
            this.balancedModeCb.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 154);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // StartupConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 384);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.balancedModeCb);
            this.Controls.Add(this.goBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.simHouses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.simHeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.simWidth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StartupConfig";
            this.Text = "AQA SKPE - Startup";
            ((System.ComponentModel.ISupportInitialize)(this.simWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simHouses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown simWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown simHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown simHouses;
        private System.Windows.Forms.Button goBtn;
        private System.Windows.Forms.CheckBox balancedModeCb;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}