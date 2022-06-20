namespace AirportApp
{
    partial class RacesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RacesForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonRaces = new System.Windows.Forms.Button();
            this.buttonFlights = new System.Windows.Forms.Button();
            this.buttonPlanes = new System.Windows.Forms.Button();
            this.buttonNavHome = new System.Windows.Forms.Button();
            this.buttonStaff = new System.Windows.Forms.Button();
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
            this.raceDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogOut = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogOut)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Bisque;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0005F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.00051F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.9985F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0005F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.buttonRaces, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonFlights, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonPlanes, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonNavHome, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonStaff, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxLogOut, 6, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(937, 57);
            this.tableLayoutPanel1.TabIndex = 1;
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
            this.buttonRaces.Location = new System.Drawing.Point(458, 3);
            this.buttonRaces.Name = "buttonRaces";
            this.buttonRaces.Size = new System.Drawing.Size(145, 51);
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
            this.buttonFlights.Location = new System.Drawing.Point(609, 3);
            this.buttonFlights.Name = "buttonFlights";
            this.buttonFlights.Size = new System.Drawing.Size(146, 51);
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
            this.buttonPlanes.Location = new System.Drawing.Point(307, 3);
            this.buttonPlanes.Name = "buttonPlanes";
            this.buttonPlanes.Size = new System.Drawing.Size(145, 51);
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
            this.buttonNavHome.Size = new System.Drawing.Size(146, 51);
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
            this.buttonStaff.Location = new System.Drawing.Point(155, 3);
            this.buttonStaff.Name = "buttonStaff";
            this.buttonStaff.Size = new System.Drawing.Size(146, 51);
            this.buttonStaff.TabIndex = 0;
            this.buttonStaff.Text = "Staff";
            this.buttonStaff.UseVisualStyleBackColor = true;
            this.buttonStaff.Click += new System.EventHandler(this.buttonStaff_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
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
            this.tableLayoutPanel2.RowCount = 10;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00024F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00024F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00024F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00024F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00024F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00024F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999603F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999603F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00024F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 505);
            this.tableLayoutPanel2.TabIndex = 2;
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
            this.buttonAllowedModels.Location = new System.Drawing.Point(15, 449);
            this.buttonAllowedModels.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.buttonAllowedModels.Name = "buttonAllowedModels";
            this.buttonAllowedModels.Size = new System.Drawing.Size(170, 51);
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
            this.buttonFilter.Location = new System.Drawing.Point(15, 376);
            this.buttonFilter.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(170, 43);
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
            this.numericUpDownNumber.Location = new System.Drawing.Point(40, 109);
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
            this.textBoxDestination.Location = new System.Drawing.Point(10, 321);
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
            this.label6.Location = new System.Drawing.Point(3, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 53);
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
            this.label5.Location = new System.Drawing.Point(3, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 53);
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
            this.label1.Size = new System.Drawing.Size(194, 53);
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
            this.label2.Location = new System.Drawing.Point(3, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 53);
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
            this.textBoxDeparute.Location = new System.Drawing.Point(10, 215);
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
            // raceDataGridView
            // 
            this.raceDataGridView.AllowUserToAddRows = false;
            this.raceDataGridView.AllowUserToDeleteRows = false;
            this.raceDataGridView.AutoGenerateColumns = false;
            this.raceDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.raceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.raceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.raceDataGridView.DataSource = this.raceBindingSource;
            this.raceDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.raceDataGridView.Location = new System.Drawing.Point(200, 57);
            this.raceDataGridView.Name = "raceDataGridView";
            this.raceDataGridView.ReadOnly = true;
            this.raceDataGridView.RowHeadersWidth = 51;
            this.raceDataGridView.RowTemplate.Height = 24;
            this.raceDataGridView.Size = new System.Drawing.Size(737, 505);
            this.raceDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "RaceNumber";
            this.dataGridViewTextBoxColumn6.HeaderText = "RaceNumber";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DeparturePoint";
            this.dataGridViewTextBoxColumn2.HeaderText = "DeparturePoint";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DestinationPoint";
            this.dataGridViewTextBoxColumn3.HeaderText = "DestinationPoint";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DepartureTime";
            this.dataGridViewTextBoxColumn4.HeaderText = "DepartureTime";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "LandingTime";
            this.dataGridViewTextBoxColumn5.HeaderText = "LandingTime";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::AirportApp.Properties.Resources.profile1;
            this.pictureBox1.InitialImage = global::AirportApp.Properties.Resources.profile1;
            this.pictureBox1.Location = new System.Drawing.Point(761, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBoxLogOut
            // 
            this.pictureBoxLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLogOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLogOut.Image = global::AirportApp.Properties.Resources.logout_img;
            this.pictureBoxLogOut.Location = new System.Drawing.Point(858, 3);
            this.pictureBoxLogOut.Name = "pictureBoxLogOut";
            this.pictureBoxLogOut.Size = new System.Drawing.Size(76, 51);
            this.pictureBoxLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogOut.TabIndex = 9;
            this.pictureBoxLogOut.TabStop = false;
            this.pictureBoxLogOut.Click += new System.EventHandler(this.pictureBoxLogOut_Click);
            // 
            // RacesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(937, 562);
            this.Controls.Add(this.raceDataGridView);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RacesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   RacesForm";
            this.Load += new System.EventHandler(this.RacesForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private AirportDataSet airportDataSet;
        private System.Windows.Forms.BindingSource raceBindingSource;
        private AirportDataSetTableAdapters.RaceTableAdapter raceTableAdapter;
        private AirportDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView raceDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDestination;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDeparute;
        private System.Windows.Forms.NumericUpDown numericUpDownNumber;
        private System.Windows.Forms.Button buttonAllowedModels;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.PictureBox pictureBoxLogOut;
    }
}