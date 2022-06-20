namespace AirportApp
{
    partial class AdminRacesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminRacesForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonRaces = new System.Windows.Forms.Button();
            this.buttonFlights = new System.Windows.Forms.Button();
            this.buttonPlanes = new System.Windows.Forms.Button();
            this.buttonNavHome = new System.Windows.Forms.Button();
            this.buttonStaff = new System.Windows.Forms.Button();
            this.buttonUsers = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAllowedModels = new System.Windows.Forms.Button();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.numericUpDownNumber = new System.Windows.Forms.NumericUpDown();
            this.textBoxDestination = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDeparute = new System.Windows.Forms.TextBox();
            this.airportDataSet = new AirportApp.AirportDataSet();
            this.raceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raceTableAdapter = new AirportApp.AirportDataSetTableAdapters.RaceTableAdapter();
            this.tableAdapterManager = new AirportApp.AirportDataSetTableAdapters.TableAdapterManager();
            this.raceBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.raceDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.raceBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogOut = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceBindingNavigator)).BeginInit();
            this.raceBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogOut)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Bisque;
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66717F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66675F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66717F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.6655F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66675F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.buttonRaces, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonFlights, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonPlanes, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonNavHome, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonStaff, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxProfile, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxLogOut, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonUsers, 5, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(904, 57);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // buttonRaces
            // 
            this.buttonRaces.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRaces.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRaces.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonRaces.FlatAppearance.BorderSize = 3;
            this.buttonRaces.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.buttonRaces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRaces.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRaces.Location = new System.Drawing.Point(333, 3);
            this.buttonRaces.Name = "buttonRaces";
            this.buttonRaces.Size = new System.Drawing.Size(104, 51);
            this.buttonRaces.TabIndex = 8;
            this.buttonRaces.Text = "Races";
            this.buttonRaces.UseVisualStyleBackColor = true;
            this.buttonRaces.Click += new System.EventHandler(this.buttonRaces_Click);
            // 
            // buttonFlights
            // 
            this.buttonFlights.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFlights.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFlights.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonFlights.FlatAppearance.BorderSize = 3;
            this.buttonFlights.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.buttonFlights.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFlights.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFlights.Location = new System.Drawing.Point(443, 3);
            this.buttonFlights.Name = "buttonFlights";
            this.buttonFlights.Size = new System.Drawing.Size(104, 51);
            this.buttonFlights.TabIndex = 7;
            this.buttonFlights.Text = "Flights";
            this.buttonFlights.UseVisualStyleBackColor = true;
            this.buttonFlights.Click += new System.EventHandler(this.buttonFlights_Click);
            // 
            // buttonPlanes
            // 
            this.buttonPlanes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlanes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPlanes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonPlanes.FlatAppearance.BorderSize = 3;
            this.buttonPlanes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.buttonPlanes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlanes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlanes.Location = new System.Drawing.Point(223, 3);
            this.buttonPlanes.Name = "buttonPlanes";
            this.buttonPlanes.Size = new System.Drawing.Size(104, 51);
            this.buttonPlanes.TabIndex = 6;
            this.buttonPlanes.Text = "Planes";
            this.buttonPlanes.UseVisualStyleBackColor = true;
            this.buttonPlanes.Click += new System.EventHandler(this.buttonPlanes_Click);
            // 
            // buttonNavHome
            // 
            this.buttonNavHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNavHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNavHome.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonNavHome.FlatAppearance.BorderSize = 3;
            this.buttonNavHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.buttonNavHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNavHome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNavHome.Location = new System.Drawing.Point(3, 3);
            this.buttonNavHome.Name = "buttonNavHome";
            this.buttonNavHome.Size = new System.Drawing.Size(104, 51);
            this.buttonNavHome.TabIndex = 4;
            this.buttonNavHome.Text = "Home";
            this.buttonNavHome.UseVisualStyleBackColor = true;
            this.buttonNavHome.Click += new System.EventHandler(this.buttonNavHome_Click);
            // 
            // buttonStaff
            // 
            this.buttonStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStaff.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonStaff.FlatAppearance.BorderSize = 3;
            this.buttonStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.buttonStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStaff.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStaff.Location = new System.Drawing.Point(113, 3);
            this.buttonStaff.Name = "buttonStaff";
            this.buttonStaff.Size = new System.Drawing.Size(104, 51);
            this.buttonStaff.TabIndex = 0;
            this.buttonStaff.Text = "Staff";
            this.buttonStaff.UseVisualStyleBackColor = true;
            this.buttonStaff.Click += new System.EventHandler(this.buttonStaff_Click);
            // 
            // buttonUsers
            // 
            this.buttonUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonUsers.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonUsers.FlatAppearance.BorderSize = 3;
            this.buttonUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.buttonUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsers.Location = new System.Drawing.Point(553, 3);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(104, 51);
            this.buttonUsers.TabIndex = 10;
            this.buttonUsers.Text = "Users";
            this.buttonUsers.UseVisualStyleBackColor = true;
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsers_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.buttonCreate, 0, 11);
            this.tableLayoutPanel2.Controls.Add(this.buttonAllowedModels, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.buttonFilter, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDownNumber, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBoxDestination, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxDeparute, 0, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 57);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 12;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00024F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00024F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00024F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00024F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00024F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00024F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999604F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999604F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00024F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.9991F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 552);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // buttonAllowedModels
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.buttonAllowedModels, 2);
            this.buttonAllowedModels.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAllowedModels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAllowedModels.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonAllowedModels.FlatAppearance.BorderSize = 3;
            this.buttonAllowedModels.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.buttonAllowedModels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAllowedModels.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAllowedModels.Location = new System.Drawing.Point(15, 433);
            this.buttonAllowedModels.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.buttonAllowedModels.Name = "buttonAllowedModels";
            this.buttonAllowedModels.Size = new System.Drawing.Size(170, 41);
            this.buttonAllowedModels.TabIndex = 21;
            this.buttonAllowedModels.Text = "Allowed models";
            this.buttonAllowedModels.UseVisualStyleBackColor = true;
            this.buttonAllowedModels.Click += new System.EventHandler(this.buttonAllowedModels_Click);
            // 
            // buttonFilter
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.buttonFilter, 2);
            this.buttonFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFilter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonFilter.FlatAppearance.BorderSize = 3;
            this.buttonFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.buttonFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFilter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFilter.Location = new System.Drawing.Point(15, 362);
            this.buttonFilter.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(170, 41);
            this.buttonFilter.TabIndex = 20;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // numericUpDownNumber
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.numericUpDownNumber, 2);
            this.numericUpDownNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownNumber.Location = new System.Drawing.Point(40, 105);
            this.numericUpDownNumber.Margin = new System.Windows.Forms.Padding(40, 3, 40, 3);
            this.numericUpDownNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownNumber.Name = "numericUpDownNumber";
            this.numericUpDownNumber.Size = new System.Drawing.Size(120, 30);
            this.numericUpDownNumber.TabIndex = 19;
            // 
            // textBoxDestination
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.textBoxDestination, 2);
            this.textBoxDestination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDestination.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDestination.Location = new System.Drawing.Point(10, 309);
            this.textBoxDestination.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.textBoxDestination.MaximumSize = new System.Drawing.Size(250, 30);
            this.textBoxDestination.Name = "textBoxDestination";
            this.textBoxDestination.Size = new System.Drawing.Size(180, 30);
            this.textBoxDestination.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label6, 2);
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 51);
            this.label6.TabIndex = 14;
            this.label6.Text = "Destination point";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label5, 2);
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 51);
            this.label5.TabIndex = 12;
            this.label5.Text = "Departure point";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 51);
            this.label1.TabIndex = 6;
            this.label1.Text = "Info about";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label2, 2);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 51);
            this.label2.TabIndex = 7;
            this.label2.Text = "Race number";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // textBoxDeparute
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.textBoxDeparute, 2);
            this.textBoxDeparute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxDeparute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDeparute.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDeparute.Location = new System.Drawing.Point(10, 207);
            this.textBoxDeparute.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.textBoxDeparute.MaximumSize = new System.Drawing.Size(250, 30);
            this.textBoxDeparute.Name = "textBoxDeparute";
            this.textBoxDeparute.Size = new System.Drawing.Size(180, 30);
            this.textBoxDeparute.TabIndex = 13;
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
            // raceBindingNavigator
            // 
            this.raceBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.raceBindingNavigator.BindingSource = this.raceBindingSource;
            this.raceBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.raceBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.raceBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.raceBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.raceBindingNavigatorSaveItem});
            this.raceBindingNavigator.Location = new System.Drawing.Point(200, 57);
            this.raceBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.raceBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.raceBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.raceBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.raceBindingNavigator.Name = "raceBindingNavigator";
            this.raceBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.raceBindingNavigator.Size = new System.Drawing.Size(704, 31);
            this.raceBindingNavigator.TabIndex = 7;
            this.raceBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // raceDataGridView
            // 
            this.raceDataGridView.AutoGenerateColumns = false;
            this.raceDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.raceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.raceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.raceDataGridView.DataSource = this.raceBindingSource;
            this.raceDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.raceDataGridView.Location = new System.Drawing.Point(200, 88);
            this.raceDataGridView.Name = "raceDataGridView";
            this.raceDataGridView.RowHeadersWidth = 51;
            this.raceDataGridView.RowTemplate.Height = 24;
            this.raceDataGridView.Size = new System.Drawing.Size(704, 521);
            this.raceDataGridView.TabIndex = 7;
            // 
            // buttonCreate
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.buttonCreate, 2);
            this.buttonCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCreate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCreate.FlatAppearance.BorderSize = 3;
            this.buttonCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.buttonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreate.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreate.Location = new System.Drawing.Point(15, 504);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(170, 43);
            this.buttonCreate.TabIndex = 22;
            this.buttonCreate.Text = "Create race";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.FillWeight = 38.50267F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DeparturePoint";
            this.dataGridViewTextBoxColumn2.FillWeight = 112.2995F;
            this.dataGridViewTextBoxColumn2.HeaderText = "DeparturePoint";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DestinationPoint";
            this.dataGridViewTextBoxColumn3.FillWeight = 112.2995F;
            this.dataGridViewTextBoxColumn3.HeaderText = "DestinationPoint";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DepartureTime";
            this.dataGridViewTextBoxColumn4.FillWeight = 112.2995F;
            this.dataGridViewTextBoxColumn4.HeaderText = "DepartureTime";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "LandingTime";
            this.dataGridViewTextBoxColumn5.FillWeight = 112.2995F;
            this.dataGridViewTextBoxColumn5.HeaderText = "LandingTime";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "RaceNumber";
            this.dataGridViewTextBoxColumn6.FillWeight = 112.2995F;
            this.dataGridViewTextBoxColumn6.HeaderText = "RaceNumber";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // raceBindingNavigatorSaveItem
            // 
            this.raceBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.raceBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("raceBindingNavigatorSaveItem.Image")));
            this.raceBindingNavigatorSaveItem.Name = "raceBindingNavigatorSaveItem";
            this.raceBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.raceBindingNavigatorSaveItem.Text = "Save Data";
            this.raceBindingNavigatorSaveItem.Click += new System.EventHandler(this.raceBindingNavigatorSaveItem_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxProfile.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxProfile.Image = global::AirportApp.Properties.Resources.profile1;
            this.pictureBoxProfile.InitialImage = global::AirportApp.Properties.Resources.profile1;
            this.pictureBoxProfile.Location = new System.Drawing.Point(663, 3);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(91, 51);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfile.TabIndex = 3;
            this.pictureBoxProfile.TabStop = false;
            this.pictureBoxProfile.Click += new System.EventHandler(this.pictureBoxProfile_Click);
            // 
            // pictureBoxLogOut
            // 
            this.pictureBoxLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLogOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLogOut.Image = global::AirportApp.Properties.Resources.logout_img;
            this.pictureBoxLogOut.Location = new System.Drawing.Point(760, 3);
            this.pictureBoxLogOut.Name = "pictureBoxLogOut";
            this.pictureBoxLogOut.Size = new System.Drawing.Size(141, 51);
            this.pictureBoxLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogOut.TabIndex = 9;
            this.pictureBoxLogOut.TabStop = false;
            this.pictureBoxLogOut.Click += new System.EventHandler(this.pictureBoxLogOut_Click);
            // 
            // AdminRacesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(904, 609);
            this.Controls.Add(this.raceDataGridView);
            this.Controls.Add(this.raceBindingNavigator);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminRacesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   Manage races";
            this.Load += new System.EventHandler(this.AdminRacesForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceBindingNavigator)).EndInit();
            this.raceBindingNavigator.ResumeLayout(false);
            this.raceBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonRaces;
        private System.Windows.Forms.Button buttonFlights;
        private System.Windows.Forms.Button buttonPlanes;
        private System.Windows.Forms.Button buttonNavHome;
        private System.Windows.Forms.Button buttonStaff;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.PictureBox pictureBoxLogOut;
        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonAllowedModels;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.NumericUpDown numericUpDownNumber;
        private System.Windows.Forms.TextBox textBoxDestination;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDeparute;
        private AirportDataSet airportDataSet;
        private System.Windows.Forms.BindingSource raceBindingSource;
        private AirportDataSetTableAdapters.RaceTableAdapter raceTableAdapter;
        private AirportDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator raceBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton raceBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView raceDataGridView;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}