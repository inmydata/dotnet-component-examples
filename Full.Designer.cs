namespace dotnet
{
    partial class Full
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      analyticsControl = new inmydata.WindowsForms.Package.AnalyticsControl();
      SuspendLayout();
      // 
      // analyticsControl
      // 
      analyticsControl.AIChatChartID = null;
      analyticsControl.BackColor = SystemColors.Control;
      analyticsControl.ContentType = inmydata.WindowsForms.Package.AnalyticsControl.ContentTypeEnum.Full;
      analyticsControl.Dock = DockStyle.Fill;
      analyticsControl.ID = null;
      analyticsControl.InsightChartID = null;
      analyticsControl.Location = new Point(0, 0);
      analyticsControl.Margin = new Padding(4, 3, 4, 3);
      analyticsControl.Name = "analyticsControl";
      analyticsControl.Question = null;
      analyticsControl.Server = "inmydata.com";
      analyticsControl.ShowToolbar = false;
      analyticsControl.ShowTools = false;
      analyticsControl.ShowToolToggle = false;
      analyticsControl.Size = new Size(1304, 775);
      analyticsControl.Subject = null;
      analyticsControl.TabIndex = 0;
      analyticsControl.Tenant = "demo";
      analyticsControl.VisReadOnly = false;
      // 
      // Full
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(1304, 775);
      Controls.Add(analyticsControl);
      Name = "Full";
      ShowInTaskbar = false;
      Text = "Full UI";
      Load += Full_Load;
      ResumeLayout(false);
    }

    #endregion

    private inmydata.WindowsForms.Package.AnalyticsControl analyticsControl;
  }
}
