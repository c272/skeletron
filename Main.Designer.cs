namespace AQASkeletronPlus
{
    partial class Main
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
            this.mapGroupBox = new System.Windows.Forms.GroupBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.advanceDaysBtn = new System.Windows.Forms.Button();
            this.amtDaysAdvance = new System.Windows.Forms.NumericUpDown();
            this.showVisitsCB = new System.Windows.Forms.CheckBox();
            this.zoomTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.showCompanyNamesCB = new System.Windows.Forms.CheckBox();
            this.map = new AQASkeletronPlus.MapPanel();
            this.mapGroupBox.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amtDaysAdvance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.map)).BeginInit();
            this.SuspendLayout();
            // 
            // mapGroupBox
            // 
            this.mapGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapGroupBox.Controls.Add(this.mainPanel);
            this.mapGroupBox.Location = new System.Drawing.Point(12, 45);
            this.mapGroupBox.Name = "mapGroupBox";
            this.mapGroupBox.Size = new System.Drawing.Size(1119, 492);
            this.mapGroupBox.TabIndex = 0;
            this.mapGroupBox.TabStop = false;
            this.mapGroupBox.Text = "Map";
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.Controls.Add(this.map);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(3, 16);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1113, 473);
            this.mainPanel.TabIndex = 0;
            // 
            // advanceDaysBtn
            // 
            this.advanceDaysBtn.Location = new System.Drawing.Point(12, 12);
            this.advanceDaysBtn.Name = "advanceDaysBtn";
            this.advanceDaysBtn.Size = new System.Drawing.Size(144, 23);
            this.advanceDaysBtn.TabIndex = 1;
            this.advanceDaysBtn.Text = "Advance [DAYS] days.";
            this.advanceDaysBtn.UseVisualStyleBackColor = true;
            this.advanceDaysBtn.Click += new System.EventHandler(this.advanceDaysBtn_Click);
            // 
            // amtDaysAdvance
            // 
            this.amtDaysAdvance.Location = new System.Drawing.Point(160, 14);
            this.amtDaysAdvance.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.amtDaysAdvance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amtDaysAdvance.Name = "amtDaysAdvance";
            this.amtDaysAdvance.Size = new System.Drawing.Size(41, 20);
            this.amtDaysAdvance.TabIndex = 2;
            this.amtDaysAdvance.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // showVisitsCB
            // 
            this.showVisitsCB.AutoSize = true;
            this.showVisitsCB.Location = new System.Drawing.Point(212, 8);
            this.showVisitsCB.Name = "showVisitsCB";
            this.showVisitsCB.Size = new System.Drawing.Size(80, 17);
            this.showVisitsCB.TabIndex = 3;
            this.showVisitsCB.Text = "Show Visits";
            this.showVisitsCB.UseVisualStyleBackColor = true;
            this.showVisitsCB.CheckedChanged += new System.EventHandler(this.showVisitsChanged);
            // 
            // zoomTrackBar
            // 
            this.zoomTrackBar.LargeChange = 1;
            this.zoomTrackBar.Location = new System.Drawing.Point(298, 4);
            this.zoomTrackBar.Maximum = 5;
            this.zoomTrackBar.Minimum = 1;
            this.zoomTrackBar.Name = "zoomTrackBar";
            this.zoomTrackBar.Size = new System.Drawing.Size(324, 45);
            this.zoomTrackBar.TabIndex = 4;
            this.zoomTrackBar.Value = 1;
            this.zoomTrackBar.ValueChanged += new System.EventHandler(this.zoomChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(442, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zoom";
            // 
            // showCompanyNamesCB
            // 
            this.showCompanyNamesCB.AutoSize = true;
            this.showCompanyNamesCB.Location = new System.Drawing.Point(212, 27);
            this.showCompanyNamesCB.Name = "showCompanyNamesCB";
            this.showCompanyNamesCB.Size = new System.Drawing.Size(89, 17);
            this.showCompanyNamesCB.TabIndex = 5;
            this.showCompanyNamesCB.Text = "Show Names";
            this.showCompanyNamesCB.UseVisualStyleBackColor = true;
            this.showCompanyNamesCB.CheckedChanged += new System.EventHandler(this.showNamesChanged);
            // 
            // map
            // 
            this.map.Location = new System.Drawing.Point(0, 0);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(2000, 2000);
            this.map.TabIndex = 0;
            this.map.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 549);
            this.Controls.Add(this.showCompanyNamesCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zoomTrackBar);
            this.Controls.Add(this.showVisitsCB);
            this.Controls.Add(this.amtDaysAdvance);
            this.Controls.Add(this.advanceDaysBtn);
            this.Controls.Add(this.mapGroupBox);
            this.Name = "Main";
            this.Text = "AQA Skeleton Program Emulator - Main";
            this.mapGroupBox.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.amtDaysAdvance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.map)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox mapGroupBox;
        private System.Windows.Forms.Panel mainPanel;
        private MapPanel map;
        private System.Windows.Forms.Button advanceDaysBtn;
        private System.Windows.Forms.NumericUpDown amtDaysAdvance;
        private System.Windows.Forms.CheckBox showVisitsCB;
        private System.Windows.Forms.TrackBar zoomTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox showCompanyNamesCB;
    }
}

