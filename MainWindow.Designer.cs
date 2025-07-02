namespace dotnet
{
  partial class MainWindow
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
      gbTenant = new GroupBox();
      gbDashboard = new GroupBox();
      llDashboardID = new LinkLabel();
      txtDashboardId = new TextBox();
      lblDashboardId = new Label();
      btnDashboard = new Button();
      gbVis = new GroupBox();
      llVizId = new LinkLabel();
      btnVisualisation = new Button();
      txtVisId = new TextBox();
      lblVisId = new Label();
      txtTenant = new TextBox();
      btnInsights = new Button();
      btnAIChat = new Button();
      btnFull = new Button();
      gbTenant.SuspendLayout();
      gbDashboard.SuspendLayout();
      gbVis.SuspendLayout();
      SuspendLayout();
      // 
      // gbTenant
      // 
      gbTenant.Controls.Add(gbDashboard);
      gbTenant.Controls.Add(gbVis);
      gbTenant.Controls.Add(txtTenant);
      gbTenant.Controls.Add(btnInsights);
      gbTenant.Controls.Add(btnAIChat);
      gbTenant.Controls.Add(btnFull);
      gbTenant.Dock = DockStyle.Fill;
      gbTenant.Location = new Point(0, 0);
      gbTenant.Name = "gbTenant";
      gbTenant.Size = new Size(800, 443);
      gbTenant.TabIndex = 12;
      gbTenant.TabStop = false;
      gbTenant.Text = "Tenant";
      // 
      // gbDashboard
      // 
      gbDashboard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      gbDashboard.BackColor = SystemColors.Control;
      gbDashboard.Controls.Add(llDashboardID);
      gbDashboard.Controls.Add(txtDashboardId);
      gbDashboard.Controls.Add(lblDashboardId);
      gbDashboard.Controls.Add(btnDashboard);
      gbDashboard.Location = new Point(12, 295);
      gbDashboard.Name = "gbDashboard";
      gbDashboard.Size = new Size(781, 140);
      gbDashboard.TabIndex = 23;
      gbDashboard.TabStop = false;
      gbDashboard.Text = "Dashboard";
      // 
      // llDashboardID
      // 
      llDashboardID.AutoSize = true;
      llDashboardID.Location = new Point(17, 111);
      llDashboardID.Name = "llDashboardID";
      llDashboardID.Size = new Size(206, 15);
      llDashboardID.TabIndex = 25;
      llDashboardID.TabStop = true;
      llDashboardID.Text = "How do I find the ID of my dashboard";
      llDashboardID.LinkClicked += llVizId_LinkClicked;
      // 
      // txtDashboardId
      // 
      txtDashboardId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      txtDashboardId.Location = new Point(16, 44);
      txtDashboardId.Name = "txtDashboardId";
      txtDashboardId.Size = new Size(759, 23);
      txtDashboardId.TabIndex = 23;
      txtDashboardId.Text = "a4019f2a-11f5-4e6c-8543-f4be336f365b";
      // 
      // lblDashboardId
      // 
      lblDashboardId.AutoSize = true;
      lblDashboardId.Location = new Point(17, 24);
      lblDashboardId.Name = "lblDashboardId";
      lblDashboardId.Size = new Size(77, 15);
      lblDashboardId.TabIndex = 22;
      lblDashboardId.Text = "Dashboard Id";
      // 
      // btnDashboard
      // 
      btnDashboard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      btnDashboard.Location = new Point(13, 74);
      btnDashboard.Name = "btnDashboard";
      btnDashboard.Size = new Size(761, 23);
      btnDashboard.TabIndex = 24;
      btnDashboard.Text = "Show Dashboard";
      btnDashboard.UseVisualStyleBackColor = true;
      btnDashboard.Click += btnDashboard_Click;
      // 
      // gbVis
      // 
      gbVis.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      gbVis.BackColor = SystemColors.Control;
      gbVis.Controls.Add(llVizId);
      gbVis.Controls.Add(btnVisualisation);
      gbVis.Controls.Add(txtVisId);
      gbVis.Controls.Add(lblVisId);
      gbVis.Location = new Point(11, 144);
      gbVis.Name = "gbVis";
      gbVis.Size = new Size(782, 145);
      gbVis.TabIndex = 22;
      gbVis.TabStop = false;
      gbVis.Text = "Visualisation";
      // 
      // llVizId
      // 
      llVizId.AutoSize = true;
      llVizId.Location = new Point(18, 107);
      llVizId.Name = "llVizId";
      llVizId.Size = new Size(220, 15);
      llVizId.TabIndex = 22;
      llVizId.TabStop = true;
      llVizId.Text = "How do I find the ID of my visualisation?";
      llVizId.LinkClicked += llVizId_LinkClicked;
      // 
      // btnVisualisation
      // 
      btnVisualisation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      btnVisualisation.Location = new Point(14, 71);
      btnVisualisation.Name = "btnVisualisation";
      btnVisualisation.Size = new Size(762, 23);
      btnVisualisation.TabIndex = 21;
      btnVisualisation.Text = "Show Visualisation";
      btnVisualisation.UseVisualStyleBackColor = true;
      btnVisualisation.Click += btnVisualisation_Click;
      // 
      // txtVisId
      // 
      txtVisId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      txtVisId.Location = new Point(16, 41);
      txtVisId.Name = "txtVisId";
      txtVisId.Size = new Size(760, 23);
      txtVisId.TabIndex = 20;
      txtVisId.Text = "29a70f82-1f9e-4d69-95bb-445957ab7990";
      // 
      // lblVisId
      // 
      lblVisId.AutoSize = true;
      lblVisId.Location = new Point(17, 21);
      lblVisId.Name = "lblVisId";
      lblVisId.Size = new Size(87, 15);
      lblVisId.TabIndex = 19;
      lblVisId.Text = "Visualisation ID";
      // 
      // txtTenant
      // 
      txtTenant.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      txtTenant.Location = new Point(11, 22);
      txtTenant.Name = "txtTenant";
      txtTenant.Size = new Size(782, 23);
      txtTenant.TabIndex = 12;
      txtTenant.Text = "demo";
      // 
      // btnInsights
      // 
      btnInsights.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      btnInsights.Location = new Point(9, 114);
      btnInsights.Name = "btnInsights";
      btnInsights.Size = new Size(784, 23);
      btnInsights.TabIndex = 15;
      btnInsights.Text = "Show Insights";
      btnInsights.UseVisualStyleBackColor = true;
      btnInsights.Click += btnInsights_Click;
      // 
      // btnAIChat
      // 
      btnAIChat.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      btnAIChat.Location = new Point(9, 85);
      btnAIChat.Name = "btnAIChat";
      btnAIChat.Size = new Size(784, 23);
      btnAIChat.TabIndex = 14;
      btnAIChat.Text = "Show Copilot";
      btnAIChat.UseVisualStyleBackColor = true;
      btnAIChat.Click += btnAIChat_Click;
      // 
      // btnFull
      // 
      btnFull.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      btnFull.Location = new Point(9, 56);
      btnFull.Name = "btnFull";
      btnFull.Size = new Size(784, 23);
      btnFull.TabIndex = 13;
      btnFull.Text = "Show Full UI";
      btnFull.UseVisualStyleBackColor = true;
      btnFull.Click += btnFull_Click;
      // 
      // MainWindow
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 443);
      Controls.Add(gbTenant);
      MinimumSize = new Size(816, 482);
      Name = "MainWindow";
      Text = "inmydata components demo";
      gbTenant.ResumeLayout(false);
      gbTenant.PerformLayout();
      gbDashboard.ResumeLayout(false);
      gbDashboard.PerformLayout();
      gbVis.ResumeLayout(false);
      gbVis.PerformLayout();
      ResumeLayout(false);
    }

    #endregion
    private GroupBox gbTenant;
    private GroupBox gbDashboard;
    private TextBox txtDashboardId;
    private Label lblDashboardId;
    private Button btnDashboard;
    private GroupBox gbVis;
    private Button btnVisualisation;
    private TextBox txtVisId;
    private Label lblVisId;
    private TextBox txtTenant;
    private Button btnInsights;
    private Button btnAIChat;
    private Button btnFull;
    private LinkLabel llVizId;
    private LinkLabel llDashboardID;
  }
}