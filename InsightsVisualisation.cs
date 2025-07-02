  using inmydata.WindowsForms.Package;

namespace dotnet
{
  /// <summary>
  /// Represents a form for displaying an insight visualisation using the AnalyticsControl.
  /// Configures the control with the specified tenant and chart ID.
  /// </summary>
  public partial class InsightsVisualisation : Form
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="InsightsVisualisation"/> class.
    /// Sets up the AnalyticsControl with the provided tenant and insight chart ID.
    /// </summary>
    /// <param name="tenant">The tenant identifier for the visualisation context.</param>
    /// <param name="chartId">The unique identifier for the insight chart to display.</param>
    public InsightsVisualisation(string tenant, string chartId)
    {
      InitializeComponent();
      analyticsControl.Tenant = tenant;
      analyticsControl.ContentType = AnalyticsControl.ContentTypeEnum.InsightVisualisation;
      analyticsControl.InsightChartID = chartId;
    }

    /// <summary>
    /// Handles the load event for the AnalyticsControl.
    /// Loads the insight visualisation view.
    /// </summary>
    private void analyticsControl_Load(object sender, EventArgs e)
    {
      analyticsControl.LoadView();
    }
  }
}
