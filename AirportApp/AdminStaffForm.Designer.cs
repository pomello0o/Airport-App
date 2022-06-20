namespace AirportApp
{
    partial class AdminStaffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminStaffForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonRaces = new System.Windows.Forms.Button();
            this.buttonFlights = new System.Windows.Forms.Button();
            this.buttonPlanes = new System.Windows.Forms.Button();
            this.buttonNavHome = new System.Windows.Forms.Button();
            this.buttonStaff = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogOut = new System.Windows.Forms.PictureBox();
            this.buttonUsers = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxCommander = new System.Windows.Forms.CheckBox();
            this.checkBoxStewardess = new System.Windows.Forms.CheckBox();
            this.checkBoxPilot = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.airportDataSet = new AirportApp.AirportDataSet();
            this.crewMemberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crewMemberTableAdapter = new AirportApp.AirportDataSetTableAdapters.CrewMemberTableAdapter();
            this.tableAdapterManager = new AirportApp.AirportDataSetTableAdapters.TableAdapterManager();
            this.crewMemberBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.crewMemberBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.crewMemberDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogOut)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crewMemberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crewMemberBindingNavigator)).BeginInit();
            this.crewMemberBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crewMemberDataGridView)).BeginInit();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(936, 57);
            this.tableLayoutPanel1.TabIndex = 2;
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
            this.buttonRaces.Location = new System.Drawing.Point(366, 3);
            this.buttonRaces.Name = "buttonRaces";
            this.buttonRaces.Size = new System.Drawing.Size(115, 51);
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
            this.buttonFlights.Location = new System.Drawing.Point(487, 3);
            this.buttonFlights.Name = "buttonFlights";
            this.buttonFlights.Size = new System.Drawing.Size(115, 51);
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
            this.buttonPlanes.Location = new System.Drawing.Point(245, 3);
            this.buttonPlanes.Name = "buttonPlanes";
            this.buttonPlanes.Size = new System.Drawing.Size(115, 51);
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
            this.buttonNavHome.Size = new System.Drawing.Size(115, 51);
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
            this.buttonStaff.Location = new System.Drawing.Point(124, 3);
            this.buttonStaff.Name = "buttonStaff";
            this.buttonStaff.Size = new System.Drawing.Size(115, 51);
            this.buttonStaff.TabIndex = 0;
            this.buttonStaff.Text = "Staff";
            this.buttonStaff.UseVisualStyleBackColor = true;
            this.buttonStaff.Click += new System.EventHandler(this.buttonStaff_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxProfile.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxProfile.Image = global::AirportApp.Properties.Resources.profile1;
            this.pictureBoxProfile.InitialImage = global::AirportApp.Properties.Resources.profile1;
            this.pictureBoxProfile.Location = new System.Drawing.Point(729, 3);
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
            this.pictureBoxLogOut.Location = new System.Drawing.Point(826, 3);
            this.pictureBoxLogOut.Name = "pictureBoxLogOut";
            this.pictureBoxLogOut.Size = new System.Drawing.Size(107, 51);
            this.pictureBoxLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogOut.TabIndex = 9;
            this.pictureBoxLogOut.TabStop = false;
            this.pictureBoxLogOut.Click += new System.EventHandler(this.pictureBoxLogOut_Click);
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
            this.buttonUsers.Location = new System.Drawing.Point(608, 3);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(115, 51);
            this.buttonUsers.TabIndex = 10;
            this.buttonUsers.Text = "Users";
            this.buttonUsers.UseVisualStyleBackColor = true;
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsers_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxCommander, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxStewardess, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxPilot, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonFilter, 0, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 57);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 500);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(30, 425);
            this.button1.Margin = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.button1.MaximumSize = new System.Drawing.Size(200, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 65);
            this.button1.TabIndex = 7;
            this.button1.Text = "Create staff member";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxCommander
            // 
            this.checkBoxCommander.AutoSize = true;
            this.checkBoxCommander.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxCommander.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxCommander.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCommander.Location = new System.Drawing.Point(3, 86);
            this.checkBoxCommander.Name = "checkBoxCommander";
            this.checkBoxCommander.Size = new System.Drawing.Size(194, 77);
            this.checkBoxCommander.TabIndex = 2;
            this.checkBoxCommander.Text = "Commanders";
            this.checkBoxCommander.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxCommander.UseVisualStyleBackColor = true;
            // 
            // checkBoxStewardess
            // 
            this.checkBoxStewardess.AutoSize = true;
            this.checkBoxStewardess.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxStewardess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxStewardess.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxStewardess.Location = new System.Drawing.Point(3, 252);
            this.checkBoxStewardess.Name = "checkBoxStewardess";
            this.checkBoxStewardess.Size = new System.Drawing.Size(194, 77);
            this.checkBoxStewardess.TabIndex = 3;
            this.checkBoxStewardess.Text = "Stewardesses";
            this.checkBoxStewardess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxStewardess.UseVisualStyleBackColor = true;
            // 
            // checkBoxPilot
            // 
            this.checkBoxPilot.AutoSize = true;
            this.checkBoxPilot.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxPilot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxPilot.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPilot.Location = new System.Drawing.Point(3, 169);
            this.checkBoxPilot.Name = "checkBoxPilot";
            this.checkBoxPilot.Size = new System.Drawing.Size(194, 77);
            this.checkBoxPilot.TabIndex = 4;
            this.checkBoxPilot.Text = "Pilots";
            this.checkBoxPilot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxPilot.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 83);
            this.label1.TabIndex = 5;
            this.label1.Text = "Manage";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFilter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonFilter.FlatAppearance.BorderSize = 3;
            this.buttonFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.buttonFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFilter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFilter.Location = new System.Drawing.Point(30, 342);
            this.buttonFilter.Margin = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.buttonFilter.MaximumSize = new System.Drawing.Size(200, 75);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(140, 63);
            this.buttonFilter.TabIndex = 6;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // airportDataSet
            // 
            this.airportDataSet.DataSetName = "AirportDataSet";
            this.airportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // crewMemberBindingSource
            // 
            this.crewMemberBindingSource.DataMember = "CrewMember";
            this.crewMemberBindingSource.DataSource = this.airportDataSet;
            // 
            // crewMemberTableAdapter
            // 
            this.crewMemberTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AllowedCrewMemberModelTableAdapter = null;
            this.tableAdapterManager.AllowedRaceModelTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CrewMemberTableAdapter = this.crewMemberTableAdapter;
            this.tableAdapterManager.CrewTableAdapter = null;
            this.tableAdapterManager.FlightTableAdapter = null;
            this.tableAdapterManager.ModelTableAdapter = null;
            this.tableAdapterManager.PlaneTableAdapter = null;
            this.tableAdapterManager.RaceTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AirportApp.AirportDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // crewMemberBindingNavigator
            // 
            this.crewMemberBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.crewMemberBindingNavigator.BindingSource = this.crewMemberBindingSource;
            this.crewMemberBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.crewMemberBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.crewMemberBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.crewMemberBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.crewMemberBindingNavigatorSaveItem});
            this.crewMemberBindingNavigator.Location = new System.Drawing.Point(200, 57);
            this.crewMemberBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.crewMemberBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.crewMemberBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.crewMemberBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.crewMemberBindingNavigator.Name = "crewMemberBindingNavigator";
            this.crewMemberBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.crewMemberBindingNavigator.Size = new System.Drawing.Size(736, 27);
            this.crewMemberBindingNavigator.TabIndex = 4;
            this.crewMemberBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // crewMemberBindingNavigatorSaveItem
            // 
            this.crewMemberBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.crewMemberBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("crewMemberBindingNavigatorSaveItem.Image")));
            this.crewMemberBindingNavigatorSaveItem.Name = "crewMemberBindingNavigatorSaveItem";
            this.crewMemberBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.crewMemberBindingNavigatorSaveItem.Text = "Save Data";
            this.crewMemberBindingNavigatorSaveItem.Click += new System.EventHandler(this.crewMemberBindingNavigatorSaveItem_Click);
            // 
            // crewMemberDataGridView
            // 
            this.crewMemberDataGridView.AutoGenerateColumns = false;
            this.crewMemberDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.crewMemberDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.crewMemberDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.crewMemberDataGridView.DataSource = this.crewMemberBindingSource;
            this.crewMemberDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crewMemberDataGridView.Location = new System.Drawing.Point(200, 84);
            this.crewMemberDataGridView.Name = "crewMemberDataGridView";
            this.crewMemberDataGridView.RowHeadersWidth = 51;
            this.crewMemberDataGridView.RowTemplate.Height = 24;
            this.crewMemberDataGridView.Size = new System.Drawing.Size(736, 473);
            this.crewMemberDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Surname";
            this.dataGridViewTextBoxColumn2.HeaderText = "Surname";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Role";
            this.dataGridViewTextBoxColumn4.HeaderText = "Role";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Birthday";
            this.dataGridViewTextBoxColumn5.HeaderText = "Birthday";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn6.HeaderText = "Address";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // AdminStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(936, 557);
            this.Controls.Add(this.crewMemberDataGridView);
            this.Controls.Add(this.crewMemberBindingNavigator);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminStaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   Manage staff";
            this.Load += new System.EventHandler(this.AdminStaffForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogOut)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crewMemberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crewMemberBindingNavigator)).EndInit();
            this.crewMemberBindingNavigator.ResumeLayout(false);
            this.crewMemberBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crewMemberDataGridView)).EndInit();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox checkBoxCommander;
        private System.Windows.Forms.CheckBox checkBoxStewardess;
        private System.Windows.Forms.CheckBox checkBoxPilot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Button button1;
        private AirportDataSet airportDataSet;
        private System.Windows.Forms.BindingSource crewMemberBindingSource;
        private AirportDataSetTableAdapters.CrewMemberTableAdapter crewMemberTableAdapter;
        private AirportDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator crewMemberBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton crewMemberBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView crewMemberDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button buttonUsers;
    }
}