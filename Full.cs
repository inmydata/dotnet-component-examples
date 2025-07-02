using inmydata.WindowsForms.Package;

namespace dotnet
{
  /// <summary>
  /// Represents a form for displaying the full analytics view using the AnalyticsControl.
  /// Configures the control for the specified tenant and sets the content type to Full.
  /// </summary>
  public partial class Full : Form
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="Full"/> class.
    /// Sets up the AnalyticsControl with the provided tenant and configures it for the full analytics view.
    /// </summary>
    /// <param name="tenant">The tenant identifier for the analytics context.</param>
    public Full(string tenant)
    {
      InitializeComponent();
      analyticsControl.Tenant = tenant;
      analyticsControl.ContentType = AnalyticsControl.ContentTypeEnum.Full;
    }

    /// <summary>
    /// Handles the load event for the form.
    /// Loads the full analytics view in the AnalyticsControl.
    /// </summary>
    private void Full_Load(object sender, EventArgs e)
    {
      analyticsControl.LoadView();
    }
  }
}
