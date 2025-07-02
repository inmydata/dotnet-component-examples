# inmydata Windows Forms Examples (.NET Windows Forms)

This is a .NET Windows Forms example application that provides an interface to explore different types of analytics visualisations using the `inmydata.WindowsForms.Controls` package. Users can load dashboards, full analytics views, AI chat insights, and data visualisations by entering a tenant and optional identifiers.

## Features

- **Main Window Navigation**: Central hub to access all views.
- **Full Analytics View**: Comprehensive analytics for a tenant.
- **AI Chat Analytics & Visualisations**: Drill into AI chat metrics and individual charts.
- **Insights & Insight Visualisations**: Display and explore AI-generated insights.
- **Dashboards**: Tenant-specific dashboards with toolbar and drilldown suppression options.
- **Data Visualisations**: Toggle tools, toolbar, drilldowns, and read-only mode.

## Project Structure

- `MainWindow.cs`: Entry form to navigate to all other analytics modules.
- `Full.cs`: Displays the full analytics interface.
- `AIChat.cs` & `AIChatVisualisation.cs`: Shows AI chat analytics and individual chart views.
- `Insights.cs` & `InsightsVisualisation.cs`: Presents insights and related visual charts.
- `Dashboard.cs`: Loads specific dashboards with optional toolbars and drilldown suppression.
- `Visualisation.cs`: Displays visualisation components with extensive toggles.

## Getting Started

### Prerequisites

- Windows with .NET Framework (compatible with Windows Forms)
- Visual Studio or other IDE with Windows Forms support
- Access to valid inmydata tenant credentials

### Installation

1. Clone or download the repository.
2. Open the solution in Visual Studio.
3. Install the required NuGet package:

   ```bash
   Install-Package inmydata.WindowsForms.Controls
   ```

   or via the NuGet GUI in Visual Studio.

4. Build and run the solution.

### Usage

1. Launch the application.
2. Enter your tenant name (required).
3. Enter additional IDs for:
   - **Dashboard** view: Dashboard ID
   - **Visualisation** view: Visualisation ID
4. Click the corresponding button to launch the selected analytics view.

## Dependencies

- [inmydata.WindowsForms.Controls](https://www.nuget.org/packages/inmydata.WindowsForms.Controls)

## 🧾 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Support

- Developer documentation: [inmydata developer portal](https://developer.inmydata.com)
- For support, contact your inmydata representative.