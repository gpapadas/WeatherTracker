namespace WeatherTracker.Forms
{
    partial class fMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.notifyWeather = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLocation = new System.Windows.Forms.Label();
            this.pictureEditWeatherCondition = new System.Windows.Forms.PictureBox();
            this.grpUnits = new System.Windows.Forms.GroupBox();
            this.labelControl5 = new System.Windows.Forms.Label();
            this.lblPressure = new System.Windows.Forms.Label();
            this.labelControl4 = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.labelControl2 = new System.Windows.Forms.Label();
            this.lblUnitsTemperature = new System.Windows.Forms.Label();
            this.labelControl1 = new System.Windows.Forms.Label();
            this.lblUnitSpeed = new System.Windows.Forms.Label();
            this.grpWind = new System.Windows.Forms.GroupBox();
            this.labelControl8 = new System.Windows.Forms.Label();
            this.labelControl10 = new System.Windows.Forms.Label();
            this.labelControl12 = new System.Windows.Forms.Label();
            this.lblWindSpeed = new System.Windows.Forms.Label();
            this.lblDirection = new System.Windows.Forms.Label();
            this.grpAtmosphere = new System.Windows.Forms.GroupBox();
            this.labelControl6 = new System.Windows.Forms.Label();
            this.lblAtmoRising = new System.Windows.Forms.Label();
            this.lblAtmoPressure = new System.Windows.Forms.Label();
            this.labelControl9 = new System.Windows.Forms.Label();
            this.lblVisibility = new System.Windows.Forms.Label();
            this.labelControl13 = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.labelControl15 = new System.Windows.Forms.Label();
            this.grpConditions = new System.Windows.Forms.GroupBox();
            this.labelControl17 = new System.Windows.Forms.Label();
            this.labelControl19 = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.labelControl21 = new System.Windows.Forms.Label();
            this.labelControl23 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblConditions = new System.Windows.Forms.Label();
            this.grpAstronomy = new System.Windows.Forms.GroupBox();
            this.lblSunset = new System.Windows.Forms.Label();
            this.labelControl14 = new System.Windows.Forms.Label();
            this.lblSunrise = new System.Windows.Forms.Label();
            this.labelControl24 = new System.Windows.Forms.Label();
            this.grpGeography = new System.Windows.Forms.GroupBox();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.labelControl7 = new System.Windows.Forms.Label();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.labelControl22 = new System.Windows.Forms.Label();
            this.grpForecast1 = new System.Windows.Forms.GroupBox();
            this.lblForecast1Code = new System.Windows.Forms.Label();
            this.labelControl29 = new System.Windows.Forms.Label();
            this.lblForecast1Conditions = new System.Windows.Forms.Label();
            this.labelControl11 = new System.Windows.Forms.Label();
            this.lblForecast1High = new System.Windows.Forms.Label();
            this.labelControl18 = new System.Windows.Forms.Label();
            this.lblForecast1Low = new System.Windows.Forms.Label();
            this.labelControl25 = new System.Windows.Forms.Label();
            this.lblForecast1Date = new System.Windows.Forms.Label();
            this.labelControl27 = new System.Windows.Forms.Label();
            this.groupControl1 = new System.Windows.Forms.GroupBox();
            this.lblForecast2Code = new System.Windows.Forms.Label();
            this.labelControl31 = new System.Windows.Forms.Label();
            this.lblForecast2Conditions = new System.Windows.Forms.Label();
            this.labelControl33 = new System.Windows.Forms.Label();
            this.lblForecast2High = new System.Windows.Forms.Label();
            this.labelControl35 = new System.Windows.Forms.Label();
            this.lblForecast2Low = new System.Windows.Forms.Label();
            this.labelControl37 = new System.Windows.Forms.Label();
            this.lblForecast2Date = new System.Windows.Forms.Label();
            this.labelControl39 = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.xtraTabControl1 = new System.Windows.Forms.TabControl();
            this.labelControl16 = new System.Windows.Forms.Label();
            this.labelControl3 = new System.Windows.Forms.Label();
            this.lblChill = new System.Windows.Forms.Label();
            this.labeControl3 = new System.Windows.Forms.Label();
            this.cmsNotify.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditWeatherCondition)).BeginInit();
            this.grpUnits.SuspendLayout();
            this.grpWind.SuspendLayout();
            this.grpAtmosphere.SuspendLayout();
            this.grpConditions.SuspendLayout();
            this.grpAstronomy.SuspendLayout();
            this.grpGeography.SuspendLayout();
            this.grpForecast1.SuspendLayout();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyWeather
            // 
            this.notifyWeather.ContextMenuStrip = this.cmsNotify;
            this.notifyWeather.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyWeather.Icon")));
            this.notifyWeather.Text = "Weather Tracker";
            this.notifyWeather.Visible = true;
            this.notifyWeather.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyWeather_MouseDoubleClick);
            // 
            // cmsNotify
            // 
            this.cmsNotify.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmsNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout,
            this.toolStripSeparator1,
            this.tsmiRefresh,
            this.toolStripSeparator2,
            this.tsmiOptions,
            this.toolStripSeparator3,
            this.tsmiOpen,
            this.tsmiExit});
            this.cmsNotify.Name = "cmsNotify";
            this.cmsNotify.ShowImageMargin = false;
            this.cmsNotify.Size = new System.Drawing.Size(160, 132);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(159, 22);
            this.tsmiAbout.Text = "About...";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(156, 6);
            // 
            // tsmiRefresh
            // 
            this.tsmiRefresh.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tsmiRefresh.Name = "tsmiRefresh";
            this.tsmiRefresh.Size = new System.Drawing.Size(159, 22);
            this.tsmiRefresh.Text = "Refresh Weather Info";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(156, 6);
            // 
            // tsmiOptions
            // 
            this.tsmiOptions.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tsmiOptions.Name = "tsmiOptions";
            this.tsmiOptions.Size = new System.Drawing.Size(159, 22);
            this.tsmiOptions.Text = "Options...";
            this.tsmiOptions.Click += new System.EventHandler(this.tsmiOptions_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(156, 6);
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.Size = new System.Drawing.Size(159, 22);
            this.tsmiOpen.Text = "Open...";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(159, 22);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // lblLocation
            // 
            this.lblLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLocation.Location = new System.Drawing.Point(0, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(1095, 25);
            this.lblLocation.TabIndex = 1;
            this.lblLocation.Text = "lblLocation";
            // 
            // pictureEditWeatherCondition
            // 
            this.pictureEditWeatherCondition.Location = new System.Drawing.Point(3, 3);
            this.pictureEditWeatherCondition.Name = "pictureEditWeatherCondition";
            this.pictureEditWeatherCondition.Size = new System.Drawing.Size(111, 100);
            this.pictureEditWeatherCondition.TabIndex = 2;
            this.pictureEditWeatherCondition.TabStop = false;
            // 
            // grpUnits
            // 
            this.grpUnits.Controls.Add(this.labelControl5);
            this.grpUnits.Controls.Add(this.lblPressure);
            this.grpUnits.Controls.Add(this.labelControl4);
            this.grpUnits.Controls.Add(this.lblDistance);
            this.grpUnits.Controls.Add(this.labelControl2);
            this.grpUnits.Controls.Add(this.lblUnitsTemperature);
            this.grpUnits.Controls.Add(this.labelControl1);
            this.grpUnits.Location = new System.Drawing.Point(498, 52);
            this.grpUnits.Name = "grpUnits";
            this.grpUnits.Size = new System.Drawing.Size(199, 105);
            this.grpUnits.TabIndex = 3;
            this.grpUnits.TabStop = false;
            this.grpUnits.Text = "Μονάδες";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(22, 81);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(50, 13);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Ταχύτητα:";
            // 
            // lblPressure
            // 
            this.lblPressure.Location = new System.Drawing.Point(88, 65);
            this.lblPressure.Name = "lblPressure";
            this.lblPressure.Size = new System.Drawing.Size(52, 13);
            this.lblPressure.TabIndex = 5;
            this.lblPressure.Text = "lblPressure";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(42, 64);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(30, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Πίεση:";
            // 
            // lblDistance
            // 
            this.lblDistance.Location = new System.Drawing.Point(88, 46);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(51, 13);
            this.lblDistance.TabIndex = 3;
            this.lblDistance.Text = "lblDistance";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(20, 46);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Απόσταση:";
            // 
            // lblUnitsTemperature
            // 
            this.lblUnitsTemperature.Location = new System.Drawing.Point(88, 27);
            this.lblUnitsTemperature.Name = "lblUnitsTemperature";
            this.lblUnitsTemperature.Size = new System.Drawing.Size(96, 13);
            this.lblUnitsTemperature.TabIndex = 1;
            this.lblUnitsTemperature.Text = "lblUnitsTemperature";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Θερμοκρασία:";
            // 
            // lblUnitSpeed
            // 
            this.lblUnitSpeed.Location = new System.Drawing.Point(72, 65);
            this.lblUnitSpeed.Name = "lblUnitSpeed";
            this.lblUnitSpeed.Size = new System.Drawing.Size(40, 13);
            this.lblUnitSpeed.TabIndex = 7;
            this.lblUnitSpeed.Text = "lblSpeed";
            // 
            // grpWind
            // 
            this.grpWind.Controls.Add(this.labelControl8);
            this.grpWind.Controls.Add(this.lblUnitSpeed);
            this.grpWind.Controls.Add(this.labelControl10);
            this.grpWind.Controls.Add(this.labelControl12);
            this.grpWind.Location = new System.Drawing.Point(703, 52);
            this.grpWind.Name = "grpWind";
            this.grpWind.Size = new System.Drawing.Size(166, 105);
            this.grpWind.TabIndex = 8;
            this.grpWind.TabStop = false;
            this.grpWind.Text = "’νεμος";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(17, 65);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(50, 13);
            this.labelControl8.TabIndex = 4;
            this.labelControl8.Text = "Ταχύτητα:";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(5, 46);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(62, 13);
            this.labelControl10.TabIndex = 2;
            this.labelControl10.Text = "Κατεύθυνση:";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(31, 27);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(36, 13);
            this.labelControl12.TabIndex = 0;
            this.labelControl12.Text = "Ψύχρα:";
            // 
            // lblWindSpeed
            // 
            this.lblWindSpeed.Location = new System.Drawing.Point(187, 150);
            this.lblWindSpeed.Name = "lblWindSpeed";
            this.lblWindSpeed.Size = new System.Drawing.Size(74, 14);
            this.lblWindSpeed.TabIndex = 5;
            this.lblWindSpeed.Text = "lblWindSpeed";
            // 
            // lblDirection
            // 
            this.lblDirection.Location = new System.Drawing.Point(102, 147);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(79, 14);
            this.lblDirection.TabIndex = 3;
            this.lblDirection.Text = "lblDirection";
            // 
            // grpAtmosphere
            // 
            this.grpAtmosphere.Controls.Add(this.labelControl6);
            this.grpAtmosphere.Location = new System.Drawing.Point(708, 420);
            this.grpAtmosphere.Name = "grpAtmosphere";
            this.grpAtmosphere.Size = new System.Drawing.Size(186, 105);
            this.grpAtmosphere.TabIndex = 8;
            this.grpAtmosphere.TabStop = false;
            this.grpAtmosphere.Text = "Ατμόσφαιρα";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(40, 81);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(32, 13);
            this.labelControl6.TabIndex = 6;
            this.labelControl6.Text = "Rising:";
            // 
            // lblAtmoRising
            // 
            this.lblAtmoRising.Location = new System.Drawing.Point(195, 185);
            this.lblAtmoRising.Name = "lblAtmoRising";
            this.lblAtmoRising.Size = new System.Drawing.Size(71, 14);
            this.lblAtmoRising.TabIndex = 7;
            this.lblAtmoRising.Text = "lblAtmoRising";
            // 
            // lblAtmoPressure
            // 
            this.lblAtmoPressure.Location = new System.Drawing.Point(102, 185);
            this.lblAtmoPressure.Name = "lblAtmoPressure";
            this.lblAtmoPressure.Size = new System.Drawing.Size(87, 14);
            this.lblAtmoPressure.TabIndex = 5;
            this.lblAtmoPressure.Text = "lblAtmoPressure";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(63, 184);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(33, 14);
            this.labelControl9.TabIndex = 4;
            this.labelControl9.Text = "Πίεση:";
            // 
            // lblVisibility
            // 
            this.lblVisibility.Location = new System.Drawing.Point(102, 166);
            this.lblVisibility.Name = "lblVisibility";
            this.lblVisibility.Size = new System.Drawing.Size(52, 14);
            this.lblVisibility.TabIndex = 3;
            this.lblVisibility.Text = "lblVisibility";
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(30, 165);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(66, 14);
            this.labelControl13.TabIndex = 2;
            this.labelControl13.Text = "Ορατότητα:";
            // 
            // lblHumidity
            // 
            this.lblHumidity.Location = new System.Drawing.Point(102, 128);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(58, 14);
            this.lblHumidity.TabIndex = 1;
            this.lblHumidity.Text = "lblHumidity";
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(48, 127);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(48, 14);
            this.labelControl15.TabIndex = 0;
            this.labelControl15.Text = "Υγρασία:";
            // 
            // grpConditions
            // 
            this.grpConditions.Controls.Add(this.labelControl17);
            this.grpConditions.Controls.Add(this.labelControl19);
            this.grpConditions.Controls.Add(this.lblCode);
            this.grpConditions.Controls.Add(this.labelControl21);
            this.grpConditions.Controls.Add(this.labelControl23);
            this.grpConditions.Location = new System.Drawing.Point(498, 163);
            this.grpConditions.Name = "grpConditions";
            this.grpConditions.Size = new System.Drawing.Size(199, 105);
            this.grpConditions.TabIndex = 9;
            this.grpConditions.TabStop = false;
            this.grpConditions.Text = "Καιρικές Συνθήκες";
            // 
            // labelControl17
            // 
            this.labelControl17.Location = new System.Drawing.Point(22, 81);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(60, 13);
            this.labelControl17.TabIndex = 6;
            this.labelControl17.Text = "Ημερομηνία:";
            // 
            // labelControl19
            // 
            this.labelControl19.Location = new System.Drawing.Point(15, 65);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(67, 13);
            this.labelControl19.TabIndex = 4;
            this.labelControl19.Text = "Θερμοκρασία:";
            // 
            // lblCode
            // 
            this.lblCode.Location = new System.Drawing.Point(88, 46);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(35, 13);
            this.lblCode.TabIndex = 3;
            this.lblCode.Text = "lblCode";
            // 
            // labelControl21
            // 
            this.labelControl21.Location = new System.Drawing.Point(39, 46);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(43, 13);
            this.labelControl21.TabIndex = 2;
            this.labelControl21.Text = "Κώδικας:";
            // 
            // labelControl23
            // 
            this.labelControl23.Location = new System.Drawing.Point(32, 27);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(50, 13);
            this.labelControl23.TabIndex = 0;
            this.labelControl23.Text = "Συνθήκες:";
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(281, 3);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(54, 18);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "lblDate";
            // 
            // lblConditions
            // 
            this.lblConditions.Location = new System.Drawing.Point(135, 64);
            this.lblConditions.Name = "lblConditions";
            this.lblConditions.Size = new System.Drawing.Size(222, 18);
            this.lblConditions.TabIndex = 1;
            this.lblConditions.Text = "lblConditions";
            // 
            // grpAstronomy
            // 
            this.grpAstronomy.Controls.Add(this.lblSunset);
            this.grpAstronomy.Controls.Add(this.labelControl14);
            this.grpAstronomy.Controls.Add(this.lblSunrise);
            this.grpAstronomy.Controls.Add(this.labelControl24);
            this.grpAstronomy.Location = new System.Drawing.Point(702, 163);
            this.grpAstronomy.Name = "grpAstronomy";
            this.grpAstronomy.Size = new System.Drawing.Size(166, 105);
            this.grpAstronomy.TabIndex = 9;
            this.grpAstronomy.TabStop = false;
            this.grpAstronomy.Text = "Αστρονομία";
            // 
            // lblSunset
            // 
            this.lblSunset.Location = new System.Drawing.Point(73, 46);
            this.lblSunset.Name = "lblSunset";
            this.lblSunset.Size = new System.Drawing.Size(43, 13);
            this.lblSunset.TabIndex = 3;
            this.lblSunset.Text = "lblSunset";
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(38, 46);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(29, 13);
            this.labelControl14.TabIndex = 2;
            this.labelControl14.Text = "Δύση:";
            // 
            // lblSunrise
            // 
            this.lblSunrise.Location = new System.Drawing.Point(73, 27);
            this.lblSunrise.Name = "lblSunrise";
            this.lblSunrise.Size = new System.Drawing.Size(45, 13);
            this.lblSunrise.TabIndex = 1;
            this.lblSunrise.Text = "lblSunrise";
            // 
            // labelControl24
            // 
            this.labelControl24.Location = new System.Drawing.Point(21, 27);
            this.labelControl24.Name = "labelControl24";
            this.labelControl24.Size = new System.Drawing.Size(46, 13);
            this.labelControl24.TabIndex = 0;
            this.labelControl24.Text = "Ανατολή:";
            // 
            // grpGeography
            // 
            this.grpGeography.Controls.Add(this.lblLongitude);
            this.grpGeography.Controls.Add(this.labelControl7);
            this.grpGeography.Controls.Add(this.lblLatitude);
            this.grpGeography.Controls.Add(this.labelControl22);
            this.grpGeography.Location = new System.Drawing.Point(498, 420);
            this.grpGeography.Name = "grpGeography";
            this.grpGeography.Size = new System.Drawing.Size(186, 105);
            this.grpGeography.TabIndex = 10;
            this.grpGeography.TabStop = false;
            this.grpGeography.Text = "Γεωγραφία";
            // 
            // lblLongitude
            // 
            this.lblLongitude.Location = new System.Drawing.Point(112, 46);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(57, 13);
            this.lblLongitude.TabIndex = 3;
            this.lblLongitude.Text = "lblLongitude";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(10, 46);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(95, 13);
            this.labelControl7.TabIndex = 2;
            this.labelControl7.Text = "Γεωγραφικό μήκος:";
            // 
            // lblLatitude
            // 
            this.lblLatitude.Location = new System.Drawing.Point(112, 27);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(49, 13);
            this.lblLatitude.TabIndex = 1;
            this.lblLatitude.Text = "lblLatitude";
            // 
            // labelControl22
            // 
            this.labelControl22.Location = new System.Drawing.Point(5, 27);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(100, 13);
            this.labelControl22.TabIndex = 0;
            this.labelControl22.Text = "Γεωγραφικό πλάτος:";
            // 
            // grpForecast1
            // 
            this.grpForecast1.Controls.Add(this.lblForecast1Code);
            this.grpForecast1.Controls.Add(this.labelControl29);
            this.grpForecast1.Controls.Add(this.lblForecast1Conditions);
            this.grpForecast1.Controls.Add(this.labelControl11);
            this.grpForecast1.Controls.Add(this.lblForecast1High);
            this.grpForecast1.Controls.Add(this.labelControl18);
            this.grpForecast1.Controls.Add(this.lblForecast1Low);
            this.grpForecast1.Controls.Add(this.labelControl25);
            this.grpForecast1.Controls.Add(this.lblForecast1Date);
            this.grpForecast1.Controls.Add(this.labelControl27);
            this.grpForecast1.Location = new System.Drawing.Point(498, 274);
            this.grpForecast1.Name = "grpForecast1";
            this.grpForecast1.Size = new System.Drawing.Size(199, 128);
            this.grpForecast1.TabIndex = 10;
            this.grpForecast1.TabStop = false;
            this.grpForecast1.Text = "Πρόβλεψη μιας ημέρας";
            // 
            // lblForecast1Code
            // 
            this.lblForecast1Code.Location = new System.Drawing.Point(88, 103);
            this.lblForecast1Code.Name = "lblForecast1Code";
            this.lblForecast1Code.Size = new System.Drawing.Size(83, 13);
            this.lblForecast1Code.TabIndex = 11;
            this.lblForecast1Code.Text = "lblForecast1Code";
            // 
            // labelControl29
            // 
            this.labelControl29.Location = new System.Drawing.Point(39, 103);
            this.labelControl29.Name = "labelControl29";
            this.labelControl29.Size = new System.Drawing.Size(43, 13);
            this.labelControl29.TabIndex = 10;
            this.labelControl29.Text = "Κώδικας:";
            // 
            // lblForecast1Conditions
            // 
            this.lblForecast1Conditions.Location = new System.Drawing.Point(88, 84);
            this.lblForecast1Conditions.Name = "lblForecast1Conditions";
            this.lblForecast1Conditions.Size = new System.Drawing.Size(108, 13);
            this.lblForecast1Conditions.TabIndex = 9;
            this.lblForecast1Conditions.Text = "lblForecast1Conditions";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(32, 84);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(50, 13);
            this.labelControl11.TabIndex = 8;
            this.labelControl11.Text = "Συνθήκες:";
            // 
            // lblForecast1High
            // 
            this.lblForecast1High.Location = new System.Drawing.Point(88, 65);
            this.lblForecast1High.Name = "lblForecast1High";
            this.lblForecast1High.Size = new System.Drawing.Size(79, 13);
            this.lblForecast1High.TabIndex = 5;
            this.lblForecast1High.Text = "lblForecas1tHigh";
            // 
            // labelControl18
            // 
            this.labelControl18.Location = new System.Drawing.Point(10, 65);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(72, 13);
            this.labelControl18.TabIndex = 4;
            this.labelControl18.Text = "Μέγιστη θερμ.:";
            // 
            // lblForecast1Low
            // 
            this.lblForecast1Low.Location = new System.Drawing.Point(88, 46);
            this.lblForecast1Low.Name = "lblForecast1Low";
            this.lblForecast1Low.Size = new System.Drawing.Size(77, 13);
            this.lblForecast1Low.TabIndex = 3;
            this.lblForecast1Low.Text = "lblForecast1Low";
            // 
            // labelControl25
            // 
            this.labelControl25.Location = new System.Drawing.Point(5, 46);
            this.labelControl25.Name = "labelControl25";
            this.labelControl25.Size = new System.Drawing.Size(77, 13);
            this.labelControl25.TabIndex = 2;
            this.labelControl25.Text = "Ελάχιστη θερμ.:";
            // 
            // lblForecast1Date
            // 
            this.lblForecast1Date.Location = new System.Drawing.Point(88, 27);
            this.lblForecast1Date.Name = "lblForecast1Date";
            this.lblForecast1Date.Size = new System.Drawing.Size(81, 13);
            this.lblForecast1Date.TabIndex = 1;
            this.lblForecast1Date.Text = "lblForecast1Date";
            // 
            // labelControl27
            // 
            this.labelControl27.Location = new System.Drawing.Point(22, 27);
            this.labelControl27.Name = "labelControl27";
            this.labelControl27.Size = new System.Drawing.Size(60, 13);
            this.labelControl27.TabIndex = 0;
            this.labelControl27.Text = "Ημερομηνία:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lblForecast2Code);
            this.groupControl1.Controls.Add(this.labelControl31);
            this.groupControl1.Controls.Add(this.lblForecast2Conditions);
            this.groupControl1.Controls.Add(this.labelControl33);
            this.groupControl1.Controls.Add(this.lblForecast2High);
            this.groupControl1.Controls.Add(this.labelControl35);
            this.groupControl1.Controls.Add(this.lblForecast2Low);
            this.groupControl1.Controls.Add(this.labelControl37);
            this.groupControl1.Controls.Add(this.lblForecast2Date);
            this.groupControl1.Controls.Add(this.labelControl39);
            this.groupControl1.Location = new System.Drawing.Point(703, 274);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(202, 128);
            this.groupControl1.TabIndex = 12;
            this.groupControl1.TabStop = false;
            this.groupControl1.Text = "Πρόβλεψη δύο ημερών";
            // 
            // lblForecast2Code
            // 
            this.lblForecast2Code.Location = new System.Drawing.Point(88, 103);
            this.lblForecast2Code.Name = "lblForecast2Code";
            this.lblForecast2Code.Size = new System.Drawing.Size(83, 13);
            this.lblForecast2Code.TabIndex = 16;
            this.lblForecast2Code.Text = "lblForecast2Code";
            // 
            // labelControl31
            // 
            this.labelControl31.Location = new System.Drawing.Point(39, 103);
            this.labelControl31.Name = "labelControl31";
            this.labelControl31.Size = new System.Drawing.Size(43, 13);
            this.labelControl31.TabIndex = 10;
            this.labelControl31.Text = "Κώδικας:";
            // 
            // lblForecast2Conditions
            // 
            this.lblForecast2Conditions.Location = new System.Drawing.Point(88, 84);
            this.lblForecast2Conditions.Name = "lblForecast2Conditions";
            this.lblForecast2Conditions.Size = new System.Drawing.Size(108, 13);
            this.lblForecast2Conditions.TabIndex = 15;
            this.lblForecast2Conditions.Text = "lblForecast2Conditions";
            // 
            // labelControl33
            // 
            this.labelControl33.Location = new System.Drawing.Point(32, 84);
            this.labelControl33.Name = "labelControl33";
            this.labelControl33.Size = new System.Drawing.Size(50, 13);
            this.labelControl33.TabIndex = 8;
            this.labelControl33.Text = "Συνθήκες:";
            // 
            // lblForecast2High
            // 
            this.lblForecast2High.Location = new System.Drawing.Point(88, 65);
            this.lblForecast2High.Name = "lblForecast2High";
            this.lblForecast2High.Size = new System.Drawing.Size(79, 13);
            this.lblForecast2High.TabIndex = 14;
            this.lblForecast2High.Text = "lblForecast2High";
            // 
            // labelControl35
            // 
            this.labelControl35.Location = new System.Drawing.Point(10, 65);
            this.labelControl35.Name = "labelControl35";
            this.labelControl35.Size = new System.Drawing.Size(72, 13);
            this.labelControl35.TabIndex = 4;
            this.labelControl35.Text = "Μέγιστη θερμ.:";
            // 
            // lblForecast2Low
            // 
            this.lblForecast2Low.Location = new System.Drawing.Point(88, 46);
            this.lblForecast2Low.Name = "lblForecast2Low";
            this.lblForecast2Low.Size = new System.Drawing.Size(77, 13);
            this.lblForecast2Low.TabIndex = 13;
            this.lblForecast2Low.Text = "lblForecast2Low";
            // 
            // labelControl37
            // 
            this.labelControl37.Location = new System.Drawing.Point(5, 46);
            this.labelControl37.Name = "labelControl37";
            this.labelControl37.Size = new System.Drawing.Size(77, 13);
            this.labelControl37.TabIndex = 2;
            this.labelControl37.Text = "Ελάχιστη θερμ.:";
            // 
            // lblForecast2Date
            // 
            this.lblForecast2Date.Location = new System.Drawing.Point(88, 27);
            this.lblForecast2Date.Name = "lblForecast2Date";
            this.lblForecast2Date.Size = new System.Drawing.Size(81, 13);
            this.lblForecast2Date.TabIndex = 12;
            this.lblForecast2Date.Text = "lblForecast2Date";
            // 
            // labelControl39
            // 
            this.labelControl39.Location = new System.Drawing.Point(22, 27);
            this.labelControl39.Name = "labelControl39";
            this.labelControl39.Size = new System.Drawing.Size(60, 13);
            this.labelControl39.TabIndex = 0;
            this.labelControl39.Text = "Ημερομηνία:";
            // 
            // lblTemperature
            // 
            this.lblTemperature.Location = new System.Drawing.Point(245, 16);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(112, 23);
            this.lblTemperature.TabIndex = 13;
            this.lblTemperature.Text = "lblTemperature";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(14, 39);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedIndex = 0;
            this.xtraTabControl1.Size = new System.Drawing.Size(369, 486);
            this.xtraTabControl1.TabIndex = 14;
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(54, 146);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(42, 14);
            this.labelControl16.TabIndex = 17;
            this.labelControl16.Text = "’νεμος:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(135, 18);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(104, 18);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "Θερμοκρασία:";
            // 
            // lblChill
            // 
            this.lblChill.Location = new System.Drawing.Point(102, 109);
            this.lblChill.Name = "lblChill";
            this.lblChill.Size = new System.Drawing.Size(31, 14);
            this.lblChill.TabIndex = 15;
            this.lblChill.Text = "lblChill";
            // 
            // labeControl3
            // 
            this.labeControl3.Location = new System.Drawing.Point(3, 108);
            this.labeControl3.Name = "labeControl3";
            this.labeControl3.Size = new System.Drawing.Size(93, 14);
            this.labeControl3.TabIndex = 14;
            this.labeControl3.Text = "Αίσθηση ψύχους:";
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 546);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.grpUnits);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.grpForecast1);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.grpGeography);
            this.Controls.Add(this.grpAstronomy);
            this.Controls.Add(this.grpConditions);
            this.Controls.Add(this.grpAtmosphere);
            this.Controls.Add(this.grpWind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fMain";
            this.ShowInTaskbar = false;
            this.Text = "Weather Tracker";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fMain_FormClosing);
            this.Load += new System.EventHandler(this.fMain_Load);
            this.cmsNotify.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditWeatherCondition)).EndInit();
            this.grpUnits.ResumeLayout(false);
            this.grpWind.ResumeLayout(false);
            this.grpAtmosphere.ResumeLayout(false);
            this.grpConditions.ResumeLayout(false);
            this.grpAstronomy.ResumeLayout(false);
            this.grpGeography.ResumeLayout(false);
            this.grpForecast1.ResumeLayout(false);
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyWeather;
        private System.Windows.Forms.ContextMenuStrip cmsNotify;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiOptions;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.PictureBox pictureEditWeatherCondition;
        private System.Windows.Forms.GroupBox grpUnits;
        private System.Windows.Forms.Label lblUnitsTemperature;
        private System.Windows.Forms.Label labelControl1;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label labelControl2;
        private System.Windows.Forms.Label lblPressure;
        private System.Windows.Forms.Label labelControl4;
        private System.Windows.Forms.Label lblUnitSpeed;
        private System.Windows.Forms.Label labelControl5;
        //private System.Windows.Forms.GroupBox grpWind;
        private System.Windows.Forms.GroupBox grpWind;
        private System.Windows.Forms.Label lblWindSpeed;
        private System.Windows.Forms.Label labelControl8;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.Label labelControl10;
        private System.Windows.Forms.Label labelControl12;
        //private System.Windows.Forms.GroupBox grpAtmosphere;
        private System.Windows.Forms.GroupBox grpAtmosphere;
        private System.Windows.Forms.Label lblAtmoRising;
        private System.Windows.Forms.Label labelControl6;
        private System.Windows.Forms.Label lblAtmoPressure;
        private System.Windows.Forms.Label labelControl9;
        private System.Windows.Forms.Label lblVisibility;
        private System.Windows.Forms.Label labelControl13;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Label labelControl15;
        //private System.Windows.Forms.GroupBox grpConditions;
        private System.Windows.Forms.GroupBox grpConditions;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label labelControl17;
        private System.Windows.Forms.Label labelControl19;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label labelControl21;
        private System.Windows.Forms.Label lblConditions;
        private System.Windows.Forms.Label labelControl23;
        private System.Windows.Forms.GroupBox grpAstronomy;
        private System.Windows.Forms.Label lblSunset;
        private System.Windows.Forms.Label labelControl14;
        private System.Windows.Forms.Label lblSunrise;
        private System.Windows.Forms.Label labelControl24;
        private System.Windows.Forms.GroupBox grpGeography;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.Label labelControl7;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.Label labelControl22;
        private System.Windows.Forms.GroupBox grpForecast1;
        private System.Windows.Forms.Label lblForecast1Code;
        private System.Windows.Forms.Label labelControl29;
        private System.Windows.Forms.Label lblForecast1Conditions;
        private System.Windows.Forms.Label labelControl11;
        private System.Windows.Forms.Label lblForecast1High;
        private System.Windows.Forms.Label labelControl18;
        private System.Windows.Forms.Label lblForecast1Low;
        private System.Windows.Forms.Label labelControl25;
        private System.Windows.Forms.Label lblForecast1Date;
        private System.Windows.Forms.Label labelControl27;
        private System.Windows.Forms.GroupBox groupControl1;
        private System.Windows.Forms.Label labelControl31;
        private System.Windows.Forms.Label labelControl33;
        private System.Windows.Forms.Label labelControl35;
        private System.Windows.Forms.Label labelControl37;
        private System.Windows.Forms.Label labelControl39;
        private System.Windows.Forms.Label lblForecast2Code;
        private System.Windows.Forms.Label lblForecast2Conditions;
        private System.Windows.Forms.Label lblForecast2High;
        private System.Windows.Forms.Label lblForecast2Low;
        private System.Windows.Forms.Label lblForecast2Date;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.TabControl xtraTabControl1;
        private System.Windows.Forms.Label lblChill;
        private System.Windows.Forms.Label labeControl3;
        private System.Windows.Forms.Label labelControl3;
        private System.Windows.Forms.Label labelControl16;
    }
}