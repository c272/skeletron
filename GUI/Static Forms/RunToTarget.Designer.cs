﻿namespace AQASkeletronPlus.GUI
{
    partial class RunToTarget
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RunToTarget));
            this.minBal = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.goBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maxBal = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.minBal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxBal)).BeginInit();
            this.SuspendLayout();
            // 
            // minBal
            // 
            this.minBal.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.minBal.Location = new System.Drawing.Point(16, 88);
            this.minBal.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.minBal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.minBal.Name = "minBal";
            this.minBal.Size = new System.Drawing.Size(242, 20);
            this.minBal.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Runs a simulation up to given parameters.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Gothic Std B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Run to Target";
            // 
            // goBtn
            // 
            this.goBtn.Location = new System.Drawing.Point(66, 160);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(128, 23);
            this.goBtn.TabIndex = 3;
            this.goBtn.Text = "Go!";
            this.goBtn.UseVisualStyleBackColor = true;
            this.goBtn.Click += new System.EventHandler(this.goBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Minimum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Maximum:";
            // 
            // maxBal
            // 
            this.maxBal.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.maxBal.Location = new System.Drawing.Point(15, 131);
            this.maxBal.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.maxBal.Name = "maxBal";
            this.maxBal.Size = new System.Drawing.Size(242, 20);
            this.maxBal.TabIndex = 5;
            // 
            // RunToTarget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 199);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maxBal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.goBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minBal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RunToTarget";
            this.Text = "AQA SKPE - Run to Target";
            ((System.ComponentModel.ISupportInitialize)(this.minBal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxBal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown minBal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button goBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown maxBal;
    }
}