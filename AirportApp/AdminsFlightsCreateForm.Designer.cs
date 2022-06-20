namespace AirportApp
{
    partial class AdminsFlightsCreateForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminsFlightsCreateForm));
            this.airportDataSet = new AirportApp.AirportDataSet();
            this.raceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raceTableAdapter = new AirportApp.AirportDataSetTableAdapters.RaceTableAdapter();
            this.tableAdapterManager = new AirportApp.AirportDataSetTableAdapters.TableAdapterManager();
            this.raceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.raceComboBox = new System.Windows.Forms.ComboBox();
            this.numericUpDownLandingMin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLandingSec = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLandingHours = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDepartureMin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDepartureSec = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDepartureHours = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDestinationPoint = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDeparturePoint = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.modelComboBox = new System.Windows.Forms.ComboBox();
            this.allowedRaceModels = new AirportApp.AllowedRaceModels();
            this.allowedRaceModelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownPlaces = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLoad = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.planeComboBox = new System.Windows.Forms.ComboBox();
            this.textBoxBoard = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDownHours = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLandingMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLandingSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLandingHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepartureMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepartureSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepartureHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allowedRaceModels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allowedRaceModelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).BeginInit();
            this.SuspendLayout();
            // 
            // airportDataSet
            // 
            this.airportDataSet.DataSetName = "AirportDataSet";
            this.airportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // raceBindingSource
            // 
            this.raceBindingSource.DataMember = "Race";
            this.raceBindingSource.DataSource = this.airportDataSet;
            // 
            // raceTableAdapter
            // 
            this.raceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AllowedCrewMemberModelTableAdapter = null;
            this.tableAdapterManager.AllowedRaceModelTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CrewMemberTableAdapter = null;
            this.tableAdapterManager.CrewTableAdapter = null;
            this.tableAdapterManager.FlightTableAdapter = null;
            this.tableAdapterManager.ModelTableAdapter = null;
            this.tableAdapterManager.PlaneTableAdapter = null;
            this.tableAdapterManager.RaceTableAdapter = this.raceTableAdapter;
            this.tableAdapterManager.UpdateOrder = AirportApp.AirportDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // raceBindingSource1
            // 
            this.raceBindingSource1.DataMember = "Race";
            this.raceBindingSource1.DataSource = this.airportDataSet;
            // 
            // raceComboBox
            // 
            this.raceComboBox.DataSource = this.raceBindingSource1;
            this.raceComboBox.DisplayMember = "RaceNumber";
            this.raceComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raceComboBox.FormattingEnabled = true;
            this.raceComboBox.Location = new System.Drawing.Point(269, 44);
            this.raceComboBox.Name = "raceComboBox";
            this.raceComboBox.Size = new System.Drawing.Size(110, 31);
            this.raceComboBox.TabIndex = 35;
            this.raceComboBox.ValueMember = "RaceNumber";
            this.raceComboBox.SelectedIndexChanged += new System.EventHandler(this.raceComboBox_SelectedIndexChanged);
            // 
            // numericUpDownLandingMin
            // 
            this.numericUpDownLandingMin.Enabled = false;
            this.numericUpDownLandingMin.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownLandingMin.Location = new System.Drawing.Point(375, 223);
            this.numericUpDownLandingMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownLandingMin.Name = "numericUpDownLandingMin";
            this.numericUpDownLandingMin.ReadOnly = true;
            this.numericUpDownLandingMin.Size = new System.Drawing.Size(60, 27);
            this.numericUpDownLandingMin.TabIndex = 66;
            // 
            // numericUpDownLandingSec
            // 
            this.numericUpDownLandingSec.Enabled = false;
            this.numericUpDownLandingSec.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownLandingSec.Location = new System.Drawing.Point(445, 223);
            this.numericUpDownLandingSec.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownLandingSec.Name = "numericUpDownLandingSec";
            this.numericUpDownLandingSec.ReadOnly = true;
            this.numericUpDownLandingSec.Size = new System.Drawing.Size(60, 27);
            this.numericUpDownLandingSec.TabIndex = 65;
            // 
            // numericUpDownLandingHours
            // 
            this.numericUpDownLandingHours.Enabled = false;
            this.numericUpDownLandingHours.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownLandingHours.Location = new System.Drawing.Point(298, 223);
            this.numericUpDownLandingHours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownLandingHours.Name = "numericUpDownLandingHours";
            this.numericUpDownLandingHours.ReadOnly = true;
            this.numericUpDownLandingHours.Size = new System.Drawing.Size(60, 27);
            this.numericUpDownLandingHours.TabIndex = 64;
            // 
            // numericUpDownDepartureMin
            // 
            this.numericUpDownDepartureMin.Enabled = false;
            this.numericUpDownDepartureMin.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownDepartureMin.Location = new System.Drawing.Point(134, 223);
            this.numericUpDownDepartureMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownDepartureMin.Name = "numericUpDownDepartureMin";
            this.numericUpDownDepartureMin.ReadOnly = true;
            this.numericUpDownDepartureMin.Size = new System.Drawing.Size(60, 27);
            this.numericUpDownDepartureMin.TabIndex = 63;
            // 
            // numericUpDownDepartureSec
            // 
            this.numericUpDownDepartureSec.Enabled = false;
            this.numericUpDownDepartureSec.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownDepartureSec.Location = new System.Drawing.Point(204, 223);
            this.numericUpDownDepartureSec.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownDepartureSec.Name = "numericUpDownDepartureSec";
            this.numericUpDownDepartureSec.ReadOnly = true;
            this.numericUpDownDepartureSec.Size = new System.Drawing.Size(60, 27);
            this.numericUpDownDepartureSec.TabIndex = 62;
            // 
            // numericUpDownDepartureHours
            // 
            this.numericUpDownDepartureHours.Enabled = false;
            this.numericUpDownDepartureHours.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownDepartureHours.Location = new System.Drawing.Point(57, 223);
            this.numericUpDownDepartureHours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownDepartureHours.Name = "numericUpDownDepartureHours";
            this.numericUpDownDepartureHours.ReadOnly = true;
            this.numericUpDownDepartureHours.Size = new System.Drawing.Size(60, 27);
            this.numericUpDownDepartureHours.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(346, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 23);
            this.label4.TabIndex = 60;
            this.label4.Text = "Landing time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 23);
            this.label5.TabIndex = 59;
            this.label5.Text = "Departure time";
            // 
            // textBoxDestinationPoint
            // 
            this.textBoxDestinationPoint.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDestinationPoint.Location = new System.Drawing.Point(305, 144);
            this.textBoxDestinationPoint.Name = "textBoxDestinationPoint";
            this.textBoxDestinationPoint.ReadOnly = true;
            this.textBoxDestinationPoint.Size = new System.Drawing.Size(200, 30);
            this.textBoxDestinationPoint.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(328, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 23);
            this.label2.TabIndex = 57;
            this.label2.Text = "Destination point";
            // 
            // textBoxDeparturePoint
            // 
            this.textBoxDeparturePoint.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDeparturePoint.Location = new System.Drawing.Point(57, 144);
            this.textBoxDeparturePoint.Name = "textBoxDeparturePoint";
            this.textBoxDeparturePoint.ReadOnly = true;
            this.textBoxDeparturePoint.Size = new System.Drawing.Size(200, 30);
            this.textBoxDeparturePoint.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 23);
            this.label1.TabIndex = 55;
            this.label1.Text = "Departure point";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 23);
            this.label3.TabIndex = 67;
            this.label3.Text = "Choose race:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(550, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 23);
            this.label6.TabIndex = 69;
            this.label6.Text = "Choose plane model:";
            // 
            // modelComboBox
            // 
            this.modelComboBox.DisplayMember = "RaceNumber";
            this.modelComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelComboBox.FormattingEnabled = true;
            this.modelComboBox.Location = new System.Drawing.Point(765, 44);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(209, 31);
            this.modelComboBox.TabIndex = 68;
            this.modelComboBox.ValueMember = "RaceNumber";
            this.modelComboBox.SelectedIndexChanged += new System.EventHandler(this.modelComboBox_SelectedIndexChanged);
            // 
            // allowedRaceModels
            // 
            this.allowedRaceModels.DataSetName = "AllowedRaceModels";
            this.allowedRaceModels.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // allowedRaceModelsBindingSource
            // 
            this.allowedRaceModelsBindingSource.DataSource = this.allowedRaceModels;
            this.allowedRaceModelsBindingSource.Position = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(802, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 23);
            this.label7.TabIndex = 72;
            this.label7.Text = "Load capacity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(605, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 23);
            this.label8.TabIndex = 70;
            this.label8.Text = "Places number";
            // 
            // numericUpDownPlaces
            // 
            this.numericUpDownPlaces.Enabled = false;
            this.numericUpDownPlaces.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownPlaces.Location = new System.Drawing.Point(631, 149);
            this.numericUpDownPlaces.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownPlaces.Name = "numericUpDownPlaces";
            this.numericUpDownPlaces.ReadOnly = true;
            this.numericUpDownPlaces.Size = new System.Drawing.Size(89, 27);
            this.numericUpDownPlaces.TabIndex = 74;
            // 
            // numericUpDownLoad
            // 
            this.numericUpDownLoad.Enabled = false;
            this.numericUpDownLoad.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownLoad.Location = new System.Drawing.Point(825, 149);
            this.numericUpDownLoad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownLoad.Name = "numericUpDownLoad";
            this.numericUpDownLoad.ReadOnly = true;
            this.numericUpDownLoad.Size = new System.Drawing.Size(89, 27);
            this.numericUpDownLoad.TabIndex = 75;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(609, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 23);
            this.label9.TabIndex = 77;
            this.label9.Text = "Choose plane:";
            // 
            // planeComboBox
            // 
            this.planeComboBox.DisplayMember = "RaceNumber";
            this.planeComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planeComboBox.FormattingEnabled = true;
            this.planeComboBox.Location = new System.Drawing.Point(765, 237);
            this.planeComboBox.Name = "planeComboBox";
            this.planeComboBox.Size = new System.Drawing.Size(209, 31);
            this.planeComboBox.TabIndex = 76;
            this.planeComboBox.ValueMember = "RaceNumber";
            this.planeComboBox.SelectedIndexChanged += new System.EventHandler(this.planeComboBox_SelectedIndexChanged);
            // 
            // textBoxBoard
            // 
            this.textBoxBoard.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBoard.Location = new System.Drawing.Point(600, 326);
            this.textBoxBoard.Name = "textBoxBoard";
            this.textBoxBoard.ReadOnly = true;
            this.textBoxBoard.Size = new System.Drawing.Size(200, 30);
            this.textBoxBoard.TabIndex = 79;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(627, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 23);
            this.label10.TabIndex = 78;
            this.label10.Text = "Board number";
            // 
            // numericUpDownHours
            // 
            this.numericUpDownHours.Enabled = false;
            this.numericUpDownHours.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownHours.Location = new System.Drawing.Point(867, 326);
            this.numericUpDownHours.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownHours.Name = "numericUpDownHours";
            this.numericUpDownHours.ReadOnly = true;
            this.numericUpDownHours.Size = new System.Drawing.Size(89, 27);
            this.numericUpDownHours.TabIndex = 81;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(842, 300);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 23);
            this.label11.TabIndex = 80;
            this.label11.Text = "Hours worked";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(169, 300);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(189, 23);
            this.label12.TabIndex = 82;
            this.label12.Text = "Pick departure date:";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDate.Location = new System.Drawing.Point(57, 326);
            this.dateTimePickerDate.MinDate = new System.DateTime(2022, 6, 19, 0, 0, 0, 0);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(448, 30);
            this.dateTimePickerDate.TabIndex = 83;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCreate.FlatAppearance.BorderSize = 3;
            this.buttonCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.buttonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreate.Location = new System.Drawing.Point(604, 405);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(208, 67);
            this.buttonCreate.TabIndex = 84;
            this.buttonCreate.Text = "Create flight and move to crew";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCrew_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCancel.FlatAppearance.BorderSize = 3;
            this.buttonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(431, 405);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(141, 67);
            this.buttonCancel.TabIndex = 85;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // AdminsFlightsCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(986, 500);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.numericUpDownHours);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxBoard);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.planeComboBox);
            this.Controls.Add(this.numericUpDownLoad);
            this.Controls.Add(this.numericUpDownPlaces);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.modelComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownLandingMin);
            this.Controls.Add(this.numericUpDownLandingSec);
            this.Controls.Add(this.numericUpDownLandingHours);
            this.Controls.Add(this.numericUpDownDepartureMin);
            this.Controls.Add(this.numericUpDownDepartureSec);
            this.Controls.Add(this.numericUpDownDepartureHours);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDestinationPoint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDeparturePoint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.raceComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminsFlightsCreateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   Create flight";
            this.Load += new System.EventHandler(this.AdminsFlightsCreateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLandingMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLandingSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLandingHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepartureMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepartureSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepartureHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allowedRaceModels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allowedRaceModelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AirportDataSet airportDataSet;
        private System.Windows.Forms.BindingSource raceBindingSource;
        private AirportDataSetTableAdapters.RaceTableAdapter raceTableAdapter;
        private AirportDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource raceBindingSource1;
        private System.Windows.Forms.ComboBox raceComboBox;
        private System.Windows.Forms.NumericUpDown numericUpDownLandingMin;
        private System.Windows.Forms.NumericUpDown numericUpDownLandingSec;
        private System.Windows.Forms.NumericUpDown numericUpDownLandingHours;
        private System.Windows.Forms.NumericUpDown numericUpDownDepartureMin;
        private System.Windows.Forms.NumericUpDown numericUpDownDepartureSec;
        private System.Windows.Forms.NumericUpDown numericUpDownDepartureHours;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDestinationPoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDeparturePoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox modelComboBox;
        private System.Windows.Forms.BindingSource allowedRaceModelsBindingSource;
        private AllowedRaceModels allowedRaceModels;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownPlaces;
        private System.Windows.Forms.NumericUpDown numericUpDownLoad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox planeComboBox;
        private System.Windows.Forms.TextBox textBoxBoard;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDownHours;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonCancel;
    }
}