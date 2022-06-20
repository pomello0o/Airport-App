namespace AirportApp
{
    partial class AdminFlightsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminFlightsForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonRaces = new System.Windows.Forms.Button();
            this.buttonFlights = new System.Windows.Forms.Button();
            this.buttonPlanes = new System.Windows.Forms.Button();
            this.buttonNavHome = new System.Windows.Forms.Button();
            this.buttonStaff = new System.Windows.Forms.Button();
            this.buttonUsers = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxDestination = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDeparture = new System.Windows.Forms.TextBox();
            this.flights = new AirportApp.Flights();
            this.adminFlightsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminFlightsTableAdapter = new AirportApp.FlightsTableAdapters.AdminFlightsTableAdapter();
            this.tableAdapterManager = new AirportApp.FlightsTableAdapters.TableAdapterManager();
            this.adminFlightsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogOut = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminFlightsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminFlightsDataGridView)).BeginInit();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1139, 57);
            this.tableLayoutPanel1.TabIndex = 6;
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
            this.buttonRaces.Location = new System.Drawing.Point(450, 3);
            this.buttonRaces.Name = "buttonRaces";
            this.buttonRaces.Size = new System.Drawing.Size(143, 51);
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
            this.buttonFlights.Location = new System.Drawing.Point(599, 3);
            this.buttonFlights.Name = "buttonFlights";
            this.buttonFlights.Size = new System.Drawing.Size(143, 51);
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
            this.buttonPlanes.Location = new System.Drawing.Point(301, 3);
            this.buttonPlanes.Name = "buttonPlanes";
            this.buttonPlanes.Size = new System.Drawing.Size(143, 51);
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
            this.buttonNavHome.Size = new System.Drawing.Size(143, 51);
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
            this.buttonStaff.Location = new System.Drawing.Point(152, 3);
            this.buttonStaff.Name = "buttonStaff";
            this.buttonStaff.Size = new System.Drawing.Size(143, 51);
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
            this.buttonUsers.Location = new System.Drawing.Point(748, 3);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(143, 51);
            this.buttonUsers.TabIndex = 10;
            this.buttonUsers.Text = "Users";
            this.buttonUsers.UseVisualStyleBackColor = true;
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsers_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.buttonSearch, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.textBoxDestination, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.buttonCreate, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxDeparture, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 57);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50078F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 437);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSearch.FlatAppearance.BorderSize = 3;
            this.buttonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(15, 293);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.buttonSearch.MaximumSize = new System.Drawing.Size(250, 100);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(170, 62);
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxDestination
            // 
            this.textBoxDestination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDestination.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDestination.Location = new System.Drawing.Point(20, 219);
            this.textBoxDestination.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.textBoxDestination.MaximumSize = new System.Drawing.Size(250, 30);
            this.textBoxDestination.Name = "textBoxDestination";
            this.textBoxDestination.Size = new System.Drawing.Size(160, 30);
            this.textBoxDestination.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 72);
            this.label3.TabIndex = 5;
            this.label3.Text = "Destination point";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCreate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCreate.FlatAppearance.BorderSize = 3;
            this.buttonCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.buttonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreate.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreate.Location = new System.Drawing.Point(15, 365);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.buttonCreate.MaximumSize = new System.Drawing.Size(250, 100);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(170, 67);
            this.buttonCreate.TabIndex = 0;
            this.buttonCreate.Text = "Create flight";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 72);
            this.label2.TabIndex = 3;
            this.label2.Text = "Departure point";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // textBoxDeparture
            // 
            this.textBoxDeparture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDeparture.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDeparture.Location = new System.Drawing.Point(20, 75);
            this.textBoxDeparture.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.textBoxDeparture.MaximumSize = new System.Drawing.Size(250, 30);
            this.textBoxDeparture.Name = "textBoxDeparture";
            this.textBoxDeparture.Size = new System.Drawing.Size(160, 30);
            this.textBoxDeparture.TabIndex = 4;
            // 
            // flights
            // 
            this.flights.DataSetName = "Flights";
            this.flights.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminFlightsBindingSource
            // 
            this.adminFlightsBindingSource.DataMember = "AdminFlights";
            this.adminFlightsBindingSource.DataSource = this.flights;
            // 
            // adminFlightsTableAdapter
            // 
            this.adminFlightsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = AirportApp.FlightsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // adminFlightsDataGridView
            // 
            this.adminFlightsDataGridView.AutoGenerateColumns = false;
            this.adminFlightsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.adminFlightsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminFlightsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.adminFlightsDataGridView.DataSource = this.adminFlightsBindingSource;
            this.adminFlightsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminFlightsDataGridView.Location = new System.Drawing.Point(200, 57);
            this.adminFlightsDataGridView.Name = "adminFlightsDataGridView";
            this.adminFlightsDataGridView.RowHeadersWidth = 51;
            this.adminFlightsDataGridView.RowTemplate.Height = 24;
            this.adminFlightsDataGridView.Size = new System.Drawing.Size(939, 437);
            this.adminFlightsDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CrewMemberID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CrewMemberID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FlightID";
            this.dataGridViewTextBoxColumn2.HeaderText = "FlightID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DepartureDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DeparturePoint";
            this.dataGridViewTextBoxColumn4.HeaderText = "Departure";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DestinationPoint";
            this.dataGridViewTextBoxColumn5.HeaderText = "Destination";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn6.HeaderText = "Name";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Surname";
            this.dataGridViewTextBoxColumn7.HeaderText = "Surname";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Role";
            this.dataGridViewTextBoxColumn8.HeaderText = "Role";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Plane model";
            this.dataGridViewTextBoxColumn9.HeaderText = "Plane model";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "BoardNumber";
            this.dataGridViewTextBoxColumn10.HeaderText = "BoardNumber";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxProfile.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxProfile.Image = global::AirportApp.Properties.Resources.profile1;
            this.pictureBoxProfile.InitialImage = global::AirportApp.Properties.Resources.profile1;
            this.pictureBoxProfile.Location = new System.Drawing.Point(897, 3);
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
            this.pictureBoxLogOut.Location = new System.Drawing.Point(994, 3);
            this.pictureBoxLogOut.Name = "pictureBoxLogOut";
            this.pictureBoxLogOut.Size = new System.Drawing.Size(142, 51);
            this.pictureBoxLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogOut.TabIndex = 9;
            this.pictureBoxLogOut.TabStop = false;
            this.pictureBoxLogOut.Click += new System.EventHandler(this.pictureBoxLogOut_Click);
            // 
            // AdminFlightsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1139, 494);
            this.Controls.Add(this.adminFlightsDataGridView);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminFlightsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   Manage flights";
            this.Load += new System.EventHandler(this.AdminFlightsForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminFlightsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminFlightsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogOut)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxDestination;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDeparture;
        private Flights flights;
        private System.Windows.Forms.BindingSource adminFlightsBindingSource;
        private FlightsTableAdapters.AdminFlightsTableAdapter adminFlightsTableAdapter;
        private FlightsTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView adminFlightsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}