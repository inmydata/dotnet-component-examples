using inmydata.WindowsForms.Package;
using System.Text;

namespace dotnet
{
  /// <summary>
  /// Represents a form for displaying a dashboard using the AnalyticsControl.
  /// Configures the control for the specified tenant and dashboard, and provides options to show/hide the toolbar and suppress drilldowns.
  /// </summary>
  public partial class Dashboard : Form
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="Dashboard"/> class.
    /// Sets up the AnalyticsControl with the provided tenant and dashboard ID, and applies initial settings for toolbar and drilldown suppression.
    /// </summary>
    /// <param name="tenant">The tenant identifier for the dashboard context.</param>
    /// <param name="dashboardId">The unique identifier for the dashboard to display.</param>
    public Dashboard(string tenant, string dashboardId)
    {
      InitializeComponent();
      analyticsControl.Tenant = tenant;
      analyticsControl.ContentType = AnalyticsControl.ContentTypeEnum.Dashboard;
      analyticsControl.ID = dashboardId;
      analyticsControl.ShowToolbar = mnuShowToolBar.Checked;
      analyticsControl.SuppressDrilldown = suppressDrillDownsToolStripMenuItem.Checked; 
    }

    /// <summary>
    /// Handles the load event for the AnalyticsControl.
    /// Loads the dashboard view.
    /// </summary>
    private void analyticsControl_Load(object sender, EventArgs e)
    {
      analyticsControl.LoadView();
    }

    /// <summary>
    /// Handles drilldown events from the AnalyticsControl.
    /// If drilldowns are suppressed, displays the drilldown data in a message box.
    /// </summary>
    /// <param name="sender">The event source.</param>
    /// <param name="e">The event data containing drilldown values.</param>
    private void analyticsControl_Drilldown(object sender, DrillDownEventArgs e)
    {
      // If the "Suppress Drilldowns" menu item is checked, show drilldown data in a message box instead of performing the default drilldown action.
      if (suppressDrillDownsToolStripMenuItem.Checked)
      {
        if (e.DataValues == null || e.DataValues.Count == 0)
        {
          MessageBox.Show("No drilldown data available.");
          return;
        }
        var messageBuilder = new StringBuilder();
        foreach (DrillDownDataValues dataValue in e.DataValues)
        {
          messageBuilder.AppendLine($"Column {dataValue.Name} = {dataValue.Value}");
        }
        MessageBox.Show(messageBuilder.ToString(), "Drilldown Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
    }

    /// <summary>
    /// Handles the CheckStateChanged event for the "Show Toolbar" menu item.
    /// Updates the AnalyticsControl to show or hide the toolbar.
    /// </summary>
    private void mnuShowToolBar_CheckStateChanged(object sender, EventArgs e)
    {
      analyticsControl.ShowToolbar = mnuShowToolBar.Checked;
      analyticsControl.RefreshView();
    }

    /// <summary>
    /// Handles the CheckedChanged event for the "Suppress Drilldowns" menu item.
    /// Enables or disables drilldown suppression in the AnalyticsControl.
    /// </summary>
    private void suppressDrillDownsToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
    {
      analyticsControl.SuppressDrilldown = suppressDrillDownsToolStripMenuItem.Checked;
      analyticsControl.RefreshView();
    }
  }
}
