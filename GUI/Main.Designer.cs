namespace AQASkeletronPlus.GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.mapGroupBox = new System.Windows.Forms.GroupBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.advanceDaysBtn = new System.Windows.Forms.Button();
            this.amtDaysAdvance = new System.Windows.Forms.NumericUpDown();
            this.showVisitsCB = new System.Windows.Forms.CheckBox();
            this.zoomTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.showCompanyNamesCB = new System.Windows.Forms.CheckBox();
            this.eventsGroupBox = new System.Windows.Forms.GroupBox();
            this.eventsList = new System.Windows.Forms.ListView();
            this.scrollEventsBack = new System.Windows.Forms.Button();
            this.scrollEventsForward = new System.Windows.Forms.Button();
            this.eventDayLabel = new System.Windows.Forms.Label();
            this.goToLatestEvents = new System.Windows.Forms.Button();
            this.simulationSettingsBtn = new System.Windows.Forms.Button();
            this.simMenuBtn = new System.Windows.Forms.Button();
            this.map = new AQASkeletronPlus.MapPanel();
            this.showStatsCb = new System.Windows.Forms.CheckBox();
            this.mapGroupBox.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amtDaysAdvance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBar)).BeginInit();
            this.eventsGroupBox.SuspendLayout();
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
            this.mapGroupBox.Size = new System.Drawing.Size(1029, 492);
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
            this.mainPanel.Size = new System.Drawing.Size(1023, 473);
            this.mainPanel.TabIndex = 0;
            // 
            // advanceDaysBtn
            // 
            this.advanceDaysBtn.Location = new System.Drawing.Point(12, 12);
            this.advanceDaysBtn.Name = "advanceDaysBtn";
            this.advanceDaysBtn.Size = new System.Drawing.Size(144, 23);
            this.advanceDaysBtn.TabIndex = 1;
            this.advanceDaysBtn.Text = "Advance 1 days.";
            this.advanceDaysBtn.UseVisualStyleBackColor = true;
            this.advanceDaysBtn.Click += new System.EventHandler(this.advanceDaysBtn_Click);
            // 
            // amtDaysAdvance
            // 
            this.amtDaysAdvance.Location = new System.Drawing.Point(160, 14);
            this.amtDaysAdvance.Maximum = new decimal(new int[] {
            365,
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
            this.amtDaysAdvance.ValueChanged += new System.EventHandler(this.advanceDayAmtValueChanged);
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
            this.zoomTrackBar.Location = new System.Drawing.Point(379, 4);
            this.zoomTrackBar.Maximum = 5;
            this.zoomTrackBar.Minimum = 1;
            this.zoomTrackBar.Name = "zoomTrackBar";
            this.zoomTrackBar.Size = new System.Drawing.Size(243, 45);
            this.zoomTrackBar.TabIndex = 4;
            this.zoomTrackBar.Value = 1;
            this.zoomTrackBar.ValueChanged += new System.EventHandler(this.zoomChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(484, 34);
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
            // eventsGroupBox
            // 
            this.eventsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventsGroupBox.Controls.Add(this.eventsList);
            this.eventsGroupBox.Location = new System.Drawing.Point(1047, 8);
            this.eventsGroupBox.Name = "eventsGroupBox";
            this.eventsGroupBox.Size = new System.Drawing.Size(206, 529);
            this.eventsGroupBox.TabIndex = 6;
            this.eventsGroupBox.TabStop = false;
            this.eventsGroupBox.Text = "Event Log";
            // 
            // eventsList
            // 
            this.eventsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventsList.HideSelection = false;
            this.eventsList.Location = new System.Drawing.Point(3, 16);
            this.eventsList.Name = "eventsList";
            this.eventsList.Size = new System.Drawing.Size(200, 510);
            this.eventsList.TabIndex = 0;
            this.eventsList.UseCompatibleStateImageBehavior = false;
            this.eventsList.View = System.Windows.Forms.View.SmallIcon;
            // 
            // scrollEventsBack
            // 
            this.scrollEventsBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scrollEventsBack.Location = new System.Drawing.Point(885, 24);
            this.scrollEventsBack.Name = "scrollEventsBack";
            this.scrollEventsBack.Size = new System.Drawing.Size(31, 23);
            this.scrollEventsBack.TabIndex = 7;
            this.scrollEventsBack.Text = "<";
            this.scrollEventsBack.UseVisualStyleBackColor = true;
            this.scrollEventsBack.Click += new System.EventHandler(this.scrollEventsBack_Click);
            // 
            // scrollEventsForward
            // 
            this.scrollEventsForward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scrollEventsForward.Location = new System.Drawing.Point(922, 24);
            this.scrollEventsForward.Name = "scrollEventsForward";
            this.scrollEventsForward.Size = new System.Drawing.Size(32, 23);
            this.scrollEventsForward.TabIndex = 8;
            this.scrollEventsForward.Text = ">";
            this.scrollEventsForward.UseVisualStyleBackColor = true;
            this.scrollEventsForward.Click += new System.EventHandler(this.scrollEventsForward_Click);
            // 
            // eventDayLabel
            // 
            this.eventDayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.eventDayLabel.AutoSize = true;
            this.eventDayLabel.Location = new System.Drawing.Point(881, 7);
            this.eventDayLabel.Name = "eventDayLabel";
            this.eventDayLabel.Size = new System.Drawing.Size(160, 13);
            this.eventDayLabel.TabIndex = 9;
            this.eventDayLabel.Text = "Viewing events from 0 days ago.";
            // 
            // goToLatestEvents
            // 
            this.goToLatestEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.goToLatestEvents.Location = new System.Drawing.Point(960, 24);
            this.goToLatestEvents.Name = "goToLatestEvents";
            this.goToLatestEvents.Size = new System.Drawing.Size(76, 23);
            this.goToLatestEvents.TabIndex = 10;
            this.goToLatestEvents.Text = "Latest";
            this.goToLatestEvents.UseVisualStyleBackColor = true;
            this.goToLatestEvents.Click += new System.EventHandler(this.goToLatestEvents_Click);
            // 
            // simulationSettingsBtn
            // 
            this.simulationSettingsBtn.Location = new System.Drawing.Point(628, 6);
            this.simulationSettingsBtn.Name = "simulationSettingsBtn";
            this.simulationSettingsBtn.Size = new System.Drawing.Size(123, 39);
            this.simulationSettingsBtn.TabIndex = 11;
            this.simulationSettingsBtn.Text = "System Settings";
            this.simulationSettingsBtn.UseVisualStyleBackColor = true;
            this.simulationSettingsBtn.Click += new System.EventHandler(this.simulationSettingsBtn_Click);
            // 
            // simMenuBtn
            // 
            this.simMenuBtn.Location = new System.Drawing.Point(757, 6);
            this.simMenuBtn.Name = "simMenuBtn";
            this.simMenuBtn.Size = new System.Drawing.Size(118, 39);
            this.simMenuBtn.TabIndex = 12;
            this.simMenuBtn.Text = "Simulation Menu";
            this.simMenuBtn.UseVisualStyleBackColor = true;
            this.simMenuBtn.Click += new System.EventHandler(this.simMenuBtn_Click);
            // 
            // map
            // 
            this.map.DrawNames = false;
            this.map.DrawTracers = false;
            this.map.Location = new System.Drawing.Point(0, 0);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(2000, 2000);
            this.map.TabIndex = 0;
            this.map.TabStop = false;
            // 
            // showStatsCb
            // 
            this.showStatsCb.AutoSize = true;
            this.showStatsCb.Location = new System.Drawing.Point(300, 9);
            this.showStatsCb.Name = "showStatsCb";
            this.showStatsCb.Size = new System.Drawing.Size(80, 17);
            this.showStatsCb.TabIndex = 13;
            this.showStatsCb.Text = "Show Stats";
            this.showStatsCb.UseVisualStyleBackColor = true;
            this.showStatsCb.CheckedChanged += new System.EventHandler(this.showStatsChange);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 549);
            this.Controls.Add(this.showStatsCb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.simMenuBtn);
            this.Controls.Add(this.simulationSettingsBtn);
            this.Controls.Add(this.goToLatestEvents);
            this.Controls.Add(this.eventDayLabel);
            this.Controls.Add(this.scrollEventsForward);
            this.Controls.Add(this.scrollEventsBack);
            this.Controls.Add(this.eventsGroupBox);
            this.Controls.Add(this.showCompanyNamesCB);
            this.Controls.Add(this.showVisitsCB);
            this.Controls.Add(this.amtDaysAdvance);
            this.Controls.Add(this.advanceDaysBtn);
            this.Controls.Add(this.mapGroupBox);
            this.Controls.Add(this.zoomTrackBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1274, 300);
            this.Name = "Main";
            this.Text = "AQA Skeleton Program Emulator - Main";
            this.mapGroupBox.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.amtDaysAdvance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBar)).EndInit();
            this.eventsGroupBox.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox eventsGroupBox;
        private System.Windows.Forms.ListView eventsList;
        private System.Windows.Forms.Button scrollEventsBack;
        private System.Windows.Forms.Button scrollEventsForward;
        private System.Windows.Forms.Label eventDayLabel;
        private System.Windows.Forms.Button goToLatestEvents;
        private System.Windows.Forms.Button simulationSettingsBtn;
        private System.Windows.Forms.Button simMenuBtn;
        private System.Windows.Forms.CheckBox showStatsCb;
    }
}

