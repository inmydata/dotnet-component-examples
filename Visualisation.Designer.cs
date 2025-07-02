namespace dotnet
{
  partial class Visualisation
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
      analyticsControl = new inmydata.WindowsForms.Package.AnalyticsControl();
      menuStrip1 = new MenuStrip();
      optionsToolStripMenuItem = new ToolStripMenuItem();
      showToolbarToolStripMenuItem = new ToolStripMenuItem();
      showToolsToolStripMenuItem = new ToolStripMenuItem();
      showToolsToggleToolStripMenuItem = new ToolStripMenuItem();
      readOnlyToolStripMenuItem = new ToolStripMenuItem();
      suppressDrillDownsToolStripMenuItem = new ToolStripMenuItem();
      menuStrip1.SuspendLayout();
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
      analyticsControl.Location = new Point(0, 24);
      analyticsControl.Margin = new Padding(4, 3, 4, 3);
      analyticsControl.Name = "analyticsControl";
      analyticsControl.Question = null;
      analyticsControl.Server = "inmydata.com";
      analyticsControl.ShowToolbar = false;
      analyticsControl.ShowTools = false;
      analyticsControl.ShowToolToggle = false;
      analyticsControl.Size = new Size(1263, 704);
      analyticsControl.Subject = null;
      analyticsControl.SuppressDrilldown = true;
      analyticsControl.TabIndex = 0;
      analyticsControl.Tenant = null;
      analyticsControl.VisReadOnly = false;
      analyticsControl.Drilldown += analyticsControl_Drilldown;
      analyticsControl.Load += analyticsControl_Load;
      // 
      // menuStrip1
      // 
      menuStrip1.Items.AddRange(new ToolStripItem[] { optionsToolStripMenuItem });
      menuStrip1.Location = new Point(0, 0);
      menuStrip1.Name = "menuStrip1";
      menuStrip1.Size = new Size(1263, 24);
      menuStrip1.TabIndex = 1;
      menuStrip1.Text = "menuStrip1";
      // 
      // optionsToolStripMenuItem
      // 
      optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { showToolbarToolStripMenuItem, showToolsToolStripMenuItem, showToolsToggleToolStripMenuItem, readOnlyToolStripMenuItem, suppressDrillDownsToolStripMenuItem });
      optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
      optionsToolStripMenuItem.Size = new Size(61, 20);
      optionsToolStripMenuItem.Text = "Options";
      // 
      // showToolbarToolStripMenuItem
      // 
      showToolbarToolStripMenuItem.CheckOnClick = true;
      showToolbarToolStripMenuItem.Name = "showToolbarToolStripMenuItem";
      showToolbarToolStripMenuItem.Size = new Size(184, 22);
      showToolbarToolStripMenuItem.Text = "Show Toolbar";
      showToolbarToolStripMenuItem.CheckedChanged += showToolbarToolStripMenuItem_CheckedChanged;
      // 
      // showToolsToolStripMenuItem
      // 
      showToolsToolStripMenuItem.CheckOnClick = true;
      showToolsToolStripMenuItem.Name = "showToolsToolStripMenuItem";
      showToolsToolStripMenuItem.Size = new Size(184, 22);
      showToolsToolStripMenuItem.Text = "Show Tools";
      showToolsToolStripMenuItem.CheckedChanged += showToolsToolStripMenuItem_CheckedChanged;
      // 
      // showToolsToggleToolStripMenuItem
      // 
      showToolsToggleToolStripMenuItem.CheckOnClick = true;
      showToolsToggleToolStripMenuItem.Name = "showToolsToggleToolStripMenuItem";
      showToolsToggleToolStripMenuItem.Size = new Size(184, 22);
      showToolsToggleToolStripMenuItem.Text = "Show Tools Toggle";
      showToolsToggleToolStripMenuItem.CheckStateChanged += showToolsToggleToolStripMenuItem_CheckStateChanged;
      // 
      // readOnlyToolStripMenuItem
      // 
      readOnlyToolStripMenuItem.CheckOnClick = true;
      readOnlyToolStripMenuItem.Name = "readOnlyToolStripMenuItem";
      readOnlyToolStripMenuItem.Size = new Size(184, 22);
      readOnlyToolStripMenuItem.Text = "Read Only";
      readOnlyToolStripMenuItem.CheckedChanged += readOnlyToolStripMenuItem_CheckedChanged;
      // 
      // suppressDrillDownsToolStripMenuItem
      // 
      suppressDrillDownsToolStripMenuItem.CheckOnClick = true;
      suppressDrillDownsToolStripMenuItem.Name = "suppressDrillDownsToolStripMenuItem";
      suppressDrillDownsToolStripMenuItem.Size = new Size(184, 22);
      suppressDrillDownsToolStripMenuItem.Text = "Suppress Drill Downs";
      suppressDrillDownsToolStripMenuItem.CheckedChanged += suppressDrillDownsToolStripMenuItem_CheckedChanged;
      // 
      // Visualisation
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(1263, 728);
      Controls.Add(analyticsControl);
      Controls.Add(menuStrip1);
      MainMenuStrip = menuStrip1;
      Name = "Visualisation";
      Text = "Visualisation";
      menuStrip1.ResumeLayout(false);
      menuStrip1.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private inmydata.WindowsForms.Package.AnalyticsControl analyticsControl;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem optionsToolStripMenuItem;
    private ToolStripMenuItem showToolbarToolStripMenuItem;
    private ToolStripMenuItem showToolsToolStripMenuItem;
    private ToolStripMenuItem showToolsToggleToolStripMenuItem;
    private ToolStripMenuItem readOnlyToolStripMenuItem;
    private ToolStripMenuItem suppressDrillDownsToolStripMenuItem;
  }
}