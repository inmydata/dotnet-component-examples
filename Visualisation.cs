using inmydata.WindowsForms.Package;
using System.Text;

namespace dotnet
{
  /// <summary>
  /// Represents a Windows Form for displaying and interacting with a data visualisation.
  /// Configures and hosts an AnalyticsControl, allowing the user to toggle various display and interaction options.
  /// </summary>
  public partial class Visualisation : Form
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="Visualisation"/> form.
    /// Sets up the AnalyticsControl with the specified tenant and visualisation ID,
    /// and applies initial settings based on the state of toolbar and tool menu items.
    /// </summary>
    /// <param name="tenant">The tenant identifier for the visualisation context.</param>
    /// <param name="visId">The unique identifier for the visualisation to display.</param>
    public Visualisation(string tenant, string visId)
    {
      InitializeComponent();
      analyticsControl.Tenant = tenant;
      analyticsControl.ContentType = AnalyticsControl.ContentTypeEnum.Visualisation;
      analyticsControl.ID = visId;
      analyticsControl.ShowToolbar = showToolbarToolStripMenuItem.Checked;
      analyticsControl.ShowTools = showToolsToolStripMenuItem.Checked;
      analyticsControl.ShowToolToggle = showToolsToggleToolStripMenuItem.Checked;
      analyticsControl.VisReadOnly = readOnlyToolStripMenuItem.Checked;
      analyticsControl.SuppressDrilldown = suppressDrillDownsToolStripMenuItem.Checked;
    }

    /// <summary>
    /// Handles the load event for the AnalyticsControl.
    /// Loads the visualisation view.
    /// </summary>
    private void analyticsControl_Load(object sender, EventArgs e)
    {
      analyticsControl.LoadView();
    }

    /// <summary>
    /// Handles drilldown events from the AnalyticsControl.
    /// If drilldowns are suppressed, displays the drilldown data in a message box.
    /// </summary>
    private void analyticsControl_Drilldown(object sender, DrillDownEventArgs e)
    {
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
    /// Handles the CheckedChanged event for the Show Toolbar menu item.
    /// Updates the AnalyticsControl to show or hide the toolbar.
    /// </summary>
    private void showToolbarToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
    {
      analyticsControl.ShowToolbar = showToolbarToolStripMenuItem.Checked;
      analyticsControl.RefreshView();
    }

    /// <summary>
    /// Handles the CheckedChanged event for the Show Tools menu item.
    /// Updates the AnalyticsControl to show or hide additional tools.
    /// </summary>
    private void showToolsToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
    {
      analyticsControl.ShowTools = showToolsToolStripMenuItem.Checked;
      analyticsControl.RefreshView();
    }

    /// <summary>
    /// Handles the CheckStateChanged event for the Show Tools Toggle menu item.
    /// Updates the AnalyticsControl to show or hide the tool toggle option.
    /// </summary>
    private void showToolsToggleToolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
    {
      analyticsControl.ShowToolToggle = showToolsToggleToolStripMenuItem.Checked;
      analyticsControl.RefreshView();
    }

    /// <summary>
    /// Handles the CheckedChanged event for the Read Only menu item.
    /// Sets the AnalyticsControl to read-only mode if checked.
    /// </summary>
    private void readOnlyToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
    {
      analyticsControl.VisReadOnly = readOnlyToolStripMenuItem.Checked;
      analyticsControl.RefreshView();
    }

    /// <summary>
    /// Handles the CheckedChanged event for the Suppress Drilldowns menu item.
    /// Enables or disables drilldown suppression in the AnalyticsControl.
    /// </summary>
    private void suppressDrillDownsToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
    {
      analyticsControl.SuppressDrilldown = suppressDrillDownsToolStripMenuItem.Checked;
      analyticsControl.RefreshView();
    }
  }
}
