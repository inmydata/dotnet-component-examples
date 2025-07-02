using System.Diagnostics;
using System.Windows.Forms;

namespace dotnet
{
  /// <summary>
  /// The main entry form for the application.
  /// Provides buttons to open various feature windows (Full, AIChat, Insights, Visualisation, Dashboard)
  /// using the tenant and (optionally) ID values entered by the user.
  /// </summary>
  public partial class MainWindow : Form
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="MainWindow"/> class.
    /// Sets up the main form and its controls.
    /// </summary>
    public MainWindow()
    {
      InitializeComponent();
    }

    /// <summary>
    /// Handles the click event for the "Full" button.
    /// Opens the Full window using the tenant value from the input field.
    /// </summary>
    private void btnFull_Click(object sender, EventArgs e)
    {
      var full = new Full(txtTenant.Text);
      full.Show();
    }

    /// <summary>
    /// Handles the click event for the "AI Chat" button.
    /// Opens the AIChat window using the tenant value from the input field.
    /// </summary>
    private void btnAIChat_Click(object sender, EventArgs e)
    {
      var aiChat = new AIChat(txtTenant.Text);
      aiChat.Show();
    }

    /// <summary>
    /// Handles the click event for the "Insights" button.
    /// Opens the Insights window using the tenant value from the input field.
    /// </summary>
    private void btnInsights_Click(object sender, EventArgs e)
    {
      var insights = new Insights(txtTenant.Text);
      insights.Show();
    }

    /// <summary>
    /// Handles the click event for the "Visualisation" button.
    /// Opens the Visualisation window using the tenant and visualisation ID values from the input fields.
    /// </summary>
    private void btnVisualisation_Click(object sender, EventArgs e)
    {
      var vis = new Visualisation(txtTenant.Text, txtVisId.Text);
      vis.Show();
    }

    /// <summary>
    /// Handles the click event for the "Dashboard" button.
    /// Opens the Dashboard window using the tenant and dashboard ID values from the input fields.
    /// </summary>
    private void btnDashboard_Click(object sender, EventArgs e)
    {
      var dashboard = new Dashboard(txtTenant.Text, txtDashboardId.Text);
      dashboard.Show();
    }

    private void llVizId_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      ProcessStartInfo psInfo = new ProcessStartInfo
      {
        FileName = "https://developer.inmydata.com/a/solutions/articles/36000577000?portalId=36000061664",
        UseShellExecute = true
      };
      Process.Start(psInfo);
    }
  }
}
