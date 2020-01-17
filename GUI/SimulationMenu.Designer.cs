namespace AQASkeletronPlus.GUI
{
    partial class SimulationMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimulationMenu));
            this.displayHouseholdsBtn = new System.Windows.Forms.Button();
            this.displayCompaniesBtn = new System.Windows.Forms.Button();
            this.runToBalanceTargetBtn = new System.Windows.Forms.Button();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // displayHouseholdsBtn
            // 
            this.displayHouseholdsBtn.Location = new System.Drawing.Point(12, 81);
            this.displayHouseholdsBtn.Name = "displayHouseholdsBtn";
            this.displayHouseholdsBtn.Size = new System.Drawing.Size(227, 23);
            this.displayHouseholdsBtn.TabIndex = 0;
            this.displayHouseholdsBtn.Text = "Display Households";
            this.displayHouseholdsBtn.UseVisualStyleBackColor = true;
            this.displayHouseholdsBtn.Click += new System.EventHandler(this.displayHouseholdsBtn_Click);
            // 
            // displayCompaniesBtn
            // 
            this.displayCompaniesBtn.Location = new System.Drawing.Point(12, 110);
            this.displayCompaniesBtn.Name = "displayCompaniesBtn";
            this.displayCompaniesBtn.Size = new System.Drawing.Size(227, 23);
            this.displayCompaniesBtn.TabIndex = 1;
            this.displayCompaniesBtn.Text = "Display/Edit Companies";
            this.displayCompaniesBtn.UseVisualStyleBackColor = true;
            this.displayCompaniesBtn.Click += new System.EventHandler(this.displayCompaniesBtn_Click);
            // 
            // runToBalanceTargetBtn
            // 
            this.runToBalanceTargetBtn.Location = new System.Drawing.Point(12, 139);
            this.runToBalanceTargetBtn.Name = "runToBalanceTargetBtn";
            this.runToBalanceTargetBtn.Size = new System.Drawing.Size(227, 23);
            this.runToBalanceTargetBtn.TabIndex = 2;
            this.runToBalanceTargetBtn.Text = "Run to Target";
            this.runToBalanceTargetBtn.UseVisualStyleBackColor = true;
            this.runToBalanceTargetBtn.Click += new System.EventHandler(this.runToBalanceTargetBtn_Click);
            // 
            // aboutBtn
            // 
            this.aboutBtn.Location = new System.Drawing.Point(12, 168);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(227, 23);
            this.aboutBtn.TabIndex = 3;
            this.aboutBtn.Text = "About";
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Simulation Menu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Control the state of the simulation from this panel.\r\nEdit companies, run to set " +
    "limits, and more.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SimulationMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 206);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aboutBtn);
            this.Controls.Add(this.runToBalanceTargetBtn);
            this.Controls.Add(this.displayCompaniesBtn);
            this.Controls.Add(this.displayHouseholdsBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SimulationMenu";
            this.Text = "AQA SKPE - Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button displayHouseholdsBtn;
        private System.Windows.Forms.Button displayCompaniesBtn;
        private System.Windows.Forms.Button runToBalanceTargetBtn;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}