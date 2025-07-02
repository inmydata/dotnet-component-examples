using inmydata.WindowsForms.Package;

namespace dotnet
{
  /// <summary>
  /// Represents a form for displaying an AI chat visualisation using the AnalyticsControl.
  /// Configures the control with the specified tenant and chart ID.
  /// </summary>
  public partial class AIChatVisualisation : Form
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="AIChatVisualisation"/> class.
    /// Sets up the AnalyticsControl with the provided tenant and AI chat chart ID.
    /// </summary>
    /// <param name="tenant">The tenant identifier for the visualisation context.</param>
    /// <param name="chartId">The unique identifier for the AI chat chart to display.</param>
    public AIChatVisualisation(string tenant, string chartId)
    {
      InitializeComponent(); 
      analyticsControl.Tenant = tenant;
      analyticsControl.ContentType = AnalyticsControl.ContentTypeEnum.AIChatVisualisation;
      analyticsControl.AIChatChartID = chartId;
    }

    /// <summary>
    /// Handles the load event for the form.
    /// Loads the AI chat visualisation view in the AnalyticsControl.
    /// </summary>
    private void AIChatVisualisation_Load(object sender, EventArgs e)
    {
      analyticsControl.LoadView();
    }
  }
}
