using inmydata.WindowsForms.Package;

namespace dotnet
{
  /// <summary>
  /// Represents a form for displaying AI chat analytics using the AnalyticsControl.
  /// Configures the control for the specified tenant and handles events to show related AI chat visualisations.
  /// </summary>
  public partial class AIChat : Form
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="AIChat"/> class.
    /// Sets up the AnalyticsControl with the provided tenant and configures it for AI chat analytics.
    /// </summary>
    /// <param name="tenant">The tenant identifier for the analytics context.</param>
    public AIChat(string tenant)
    {
      InitializeComponent();
      analyticsControl.Tenant = tenant;
      analyticsControl.ContentType = AnalyticsControl.ContentTypeEnum.AIChat;
    }

    /// <summary>
    /// Handles the load event for the form.
    /// Loads the AI chat analytics view in the AnalyticsControl.
    /// </summary>
    private void AIChat_Load(object sender, EventArgs e)
    {
      analyticsControl.LoadView();
    }

    /// <summary>
    /// Handles the event when the AnalyticsControl requests to show AI chat charts.
    /// Opens a new <see cref="AIChatVisualisation"/> form for each chart ID provided in the event arguments.
    /// </summary>
    /// <param name="sender">The event source.</param>
    /// <param name="e">The event data containing the list of AI chat chart IDs.</param>
    private void analyticsControl_AIChatShowCharts(object sender, AIChatShowChartEventArgs e)
    {
      foreach (string id in e.AIChatChartIDs) {
        var aiChatViz = new AIChatVisualisation(analyticsControl.Tenant, id);
        aiChatViz.Show();
      }
    }
  }
}
