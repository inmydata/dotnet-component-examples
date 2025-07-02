using inmydata.WindowsForms.Package;

namespace dotnet
{
  /// <summary>
  /// Represents a form for displaying insights using the AnalyticsControl.
  /// Configures the control for the specified tenant and handles insight opening events.
  /// </summary>
  public partial class Insights : Form
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="Insights"/> class.
    /// Sets up the AnalyticsControl with the provided tenant and configures it for insights display.
    /// </summary>
    /// <param name="tenant">The tenant identifier for the insights context.</param>
    public Insights(string tenant)
    {
      InitializeComponent();
      analyticsControl.Tenant = tenant;
      analyticsControl.ContentType = AnalyticsControl.ContentTypeEnum.Insights;
    }

    /// <summary>
    /// Handles the load event for the AnalyticsControl.
    /// Loads the insights view.
    /// </summary>
    private void analyticsControl_Load(object sender, EventArgs e)
    {
      analyticsControl.LoadView();
    }

    /// <summary>
    /// Handles the event when an insight is opened in the AnalyticsControl.
    /// Opens a new <see cref="InsightsVisualisation"/> form for the selected insight chart.
    /// </summary>
    /// <param name="sender">The event source.</param>
    /// <param name="e">The event data containing the insight chart ID.</param>
    private void analyticsControl_InsightOpened(object sender, InsightsEventArgs e)
    {
      var insightsViz = new InsightsVisualisation(analyticsControl.Tenant, e.InsightChartID);
      insightsViz.Show();
    }
  }
}
