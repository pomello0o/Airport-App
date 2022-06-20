namespace AirportApp
{
    partial class PlanesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanesForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonRaces = new System.Windows.Forms.Button();
            this.buttonFlights = new System.Windows.Forms.Button();
            this.buttonPlanes = new System.Windows.Forms.Button();
            this.buttonNavHome = new System.Windows.Forms.Button();
            this.buttonStaff = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogOut = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDownHours = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLoad = new System.Windows.Forms.NumericUpDown();
            this.panelHours = new System.Windows.Forms.Panel();
            this.radioButtonEqHours = new System.Windows.Forms.RadioButton();
            this.radioButtonLessHours = new System.Windows.Forms.RadioButton();
            this.radioButtonMoreHours = new System.Windows.Forms.RadioButton();
            this.labelHours = new System.Windows.Forms.Label();
            this.panelLoad = new System.Windows.Forms.Panel();
            this.radioButtonEqLoad = new System.Windows.Forms.RadioButton();
            this.radioButtonLessLoad = new System.Windows.Forms.RadioButton();
            this.radioButtonMoreLoad = new System.Windows.Forms.RadioButton();
            this.labelLoad = new System.Windows.Forms.Label();
            this.labelPlaces = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.panelPlaces = new System.Windows.Forms.Panel();
            this.radioButtonEq = new System.Windows.Forms.RadioButton();
            this.radioButtonLess = new System.Windows.Forms.RadioButton();
            this.radioButtonMore = new System.Windows.Forms.RadioButton();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.numericUpDownPlaces = new System.Windows.Forms.NumericUpDown();
            this.airportDataSet1 = new AirportApp.AirportDataSet1();
            this.planesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.planesTableAdapter = new AirportApp.AirportDataSet1TableAdapters.PlanesTableAdapter();
            this.tableAdapterManager = new AirportApp.AirportDataSet1TableAdapters.TableAdapterManager();
            this.planesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogOut)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLoad)).BeginInit();
            this.panelHours.SuspendLayout();
            this.panelLoad.SuspendLayout();
            this.panelPlaces.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesDataGridView)).BeginInit();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(986, 57);
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
            this.buttonRaces.Location = new System.Drawing.Point(510, 3);
            this.buttonRaces.Name = "buttonRaces";
            this.buttonRaces.Size = new System.Drawing.Size(163, 51);
            this.buttonRaces.TabIndex = 7;
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
            this.buttonFlights.Location = new System.Drawing.Point(679, 3);
            this.buttonFlights.Name = "buttonFlights";
            this.buttonFlights.Size = new System.Drawing.Size(163, 51);
            this.buttonFlights.TabIndex = 6;
            this.buttonFlights.Text = "Fligths";
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
            this.buttonPlanes.Location = new System.Drawing.Point(341, 3);
            this.buttonPlanes.Name = "buttonPlanes";
            this.buttonPlanes.Size = new System.Drawing.Size(163, 51);
            this.buttonPlanes.TabIndex = 5;
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
            this.buttonNavHome.Size = new System.Drawing.Size(163, 51);
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
            this.buttonStaff.Location = new System.Drawing.Point(172, 3);
            this.buttonStaff.Name = "buttonStaff";
            this.buttonStaff.Size = new System.Drawing.Size(163, 51);
            this.buttonStaff.TabIndex = 0;
            this.buttonStaff.Text = "Staff";
            this.buttonStaff.UseVisualStyleBackColor = true;
            this.buttonStaff.Click += new System.EventHandler(this.buttonStaff_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::AirportApp.Properties.Resources.profile1;
            this.pictureBox1.InitialImage = global::AirportApp.Properties.Resources.profile1;
            this.pictureBox1.Location = new System.Drawing.Point(848, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBoxLogOut
            // 
            this.pictureBoxLogOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLogOut.Image = global::AirportApp.Properties.Resources.logout_img;
            this.pictureBoxLogOut.Location = new System.Drawing.Point(945, 3);
            this.pictureBoxLogOut.Name = "pictureBoxLogOut";
            this.pictureBoxLogOut.Size = new System.Drawing.Size(38, 51);
            this.pictureBoxLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogOut.TabIndex = 8;
            this.pictureBoxLogOut.TabStop = false;
            this.pictureBoxLogOut.Click += new System.EventHandler(this.pictureBoxLogOut_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.numericUpDownHours, 0, 11);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDownLoad, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.panelHours, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.labelHours, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.panelLoad, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.labelLoad, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.labelPlaces, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelModel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxModel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.panelPlaces, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.buttonFilter, 0, 12);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDownPlaces, 0, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 57);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 13;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692735F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692736F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692736F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692736F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692736F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692736F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692736F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692736F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.691967F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.691967F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.691967F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692736F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.689467F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 638);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // numericUpDownHours
            // 
            this.numericUpDownHours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownHours.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownHours.Location = new System.Drawing.Point(3, 542);
            this.numericUpDownHours.Margin = new System.Windows.Forms.Padding(3, 3, 50, 3);
            this.numericUpDownHours.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownHours.MaximumSize = new System.Drawing.Size(250, 0);
            this.numericUpDownHours.Name = "numericUpDownHours";
            this.numericUpDownHours.Size = new System.Drawing.Size(147, 30);
            this.numericUpDownHours.TabIndex = 21;
            // 
            // numericUpDownLoad
            // 
            this.numericUpDownLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownLoad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownLoad.Location = new System.Drawing.Point(3, 395);
            this.numericUpDownLoad.Margin = new System.Windows.Forms.Padding(3, 3, 50, 3);
            this.numericUpDownLoad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownLoad.MaximumSize = new System.Drawing.Size(250, 0);
            this.numericUpDownLoad.Name = "numericUpDownLoad";
            this.numericUpDownLoad.Size = new System.Drawing.Size(147, 30);
            this.numericUpDownLoad.TabIndex = 20;
            // 
            // panelHours
            // 
            this.panelHours.Controls.Add(this.radioButtonEqHours);
            this.panelHours.Controls.Add(this.radioButtonLessHours);
            this.panelHours.Controls.Add(this.radioButtonMoreHours);
            this.panelHours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHours.Location = new System.Drawing.Point(3, 493);
            this.panelHours.Name = "panelHours";
            this.panelHours.Size = new System.Drawing.Size(194, 43);
            this.panelHours.TabIndex = 16;
            // 
            // radioButtonEqHours
            // 
            this.radioButtonEqHours.AutoSize = true;
            this.radioButtonEqHours.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonEqHours.Location = new System.Drawing.Point(134, 3);
            this.radioButtonEqHours.Name = "radioButtonEqHours";
            this.radioButtonEqHours.Size = new System.Drawing.Size(43, 27);
            this.radioButtonEqHours.TabIndex = 2;
            this.radioButtonEqHours.TabStop = true;
            this.radioButtonEqHours.Text = "=";
            this.radioButtonEqHours.UseVisualStyleBackColor = true;
            // 
            // radioButtonLessHours
            // 
            this.radioButtonLessHours.AutoSize = true;
            this.radioButtonLessHours.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonLessHours.Location = new System.Drawing.Point(67, 3);
            this.radioButtonLessHours.Name = "radioButtonLessHours";
            this.radioButtonLessHours.Size = new System.Drawing.Size(43, 27);
            this.radioButtonLessHours.TabIndex = 1;
            this.radioButtonLessHours.TabStop = true;
            this.radioButtonLessHours.Text = "<";
            this.radioButtonLessHours.UseVisualStyleBackColor = true;
            // 
            // radioButtonMoreHours
            // 
            this.radioButtonMoreHours.AutoSize = true;
            this.radioButtonMoreHours.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMoreHours.Location = new System.Drawing.Point(4, 3);
            this.radioButtonMoreHours.Name = "radioButtonMoreHours";
            this.radioButtonMoreHours.Size = new System.Drawing.Size(43, 27);
            this.radioButtonMoreHours.TabIndex = 0;
            this.radioButtonMoreHours.TabStop = true;
            this.radioButtonMoreHours.Text = ">";
            this.radioButtonMoreHours.UseVisualStyleBackColor = true;
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHours.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHours.Location = new System.Drawing.Point(3, 441);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(194, 49);
            this.labelHours.TabIndex = 15;
            this.labelHours.Text = "Hours worked";
            this.labelHours.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panelLoad
            // 
            this.panelLoad.Controls.Add(this.radioButtonEqLoad);
            this.panelLoad.Controls.Add(this.radioButtonLessLoad);
            this.panelLoad.Controls.Add(this.radioButtonMoreLoad);
            this.panelLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLoad.Location = new System.Drawing.Point(3, 346);
            this.panelLoad.Name = "panelLoad";
            this.panelLoad.Size = new System.Drawing.Size(194, 43);
            this.panelLoad.TabIndex = 13;
            // 
            // radioButtonEqLoad
            // 
            this.radioButtonEqLoad.AutoSize = true;
            this.radioButtonEqLoad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonEqLoad.Location = new System.Drawing.Point(134, 3);
            this.radioButtonEqLoad.Name = "radioButtonEqLoad";
            this.radioButtonEqLoad.Size = new System.Drawing.Size(43, 27);
            this.radioButtonEqLoad.TabIndex = 2;
            this.radioButtonEqLoad.TabStop = true;
            this.radioButtonEqLoad.Text = "=";
            this.radioButtonEqLoad.UseVisualStyleBackColor = true;
            // 
            // radioButtonLessLoad
            // 
            this.radioButtonLessLoad.AutoSize = true;
            this.radioButtonLessLoad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonLessLoad.Location = new System.Drawing.Point(67, 3);
            this.radioButtonLessLoad.Name = "radioButtonLessLoad";
            this.radioButtonLessLoad.Size = new System.Drawing.Size(43, 27);
            this.radioButtonLessLoad.TabIndex = 1;
            this.radioButtonLessLoad.TabStop = true;
            this.radioButtonLessLoad.Text = "<";
            this.radioButtonLessLoad.UseVisualStyleBackColor = true;
            // 
            // radioButtonMoreLoad
            // 
            this.radioButtonMoreLoad.AutoSize = true;
            this.radioButtonMoreLoad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMoreLoad.Location = new System.Drawing.Point(4, 3);
            this.radioButtonMoreLoad.Name = "radioButtonMoreLoad";
            this.radioButtonMoreLoad.Size = new System.Drawing.Size(43, 27);
            this.radioButtonMoreLoad.TabIndex = 0;
            this.radioButtonMoreLoad.TabStop = true;
            this.radioButtonMoreLoad.Text = ">";
            this.radioButtonMoreLoad.UseVisualStyleBackColor = true;
            // 
            // labelLoad
            // 
            this.labelLoad.AutoSize = true;
            this.labelLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLoad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoad.Location = new System.Drawing.Point(3, 294);
            this.labelLoad.Name = "labelLoad";
            this.labelLoad.Size = new System.Drawing.Size(194, 49);
            this.labelLoad.TabIndex = 12;
            this.labelLoad.Text = "Load capacity";
            this.labelLoad.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelPlaces
            // 
            this.labelPlaces.AutoSize = true;
            this.labelPlaces.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPlaces.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlaces.Location = new System.Drawing.Point(3, 147);
            this.labelPlaces.Name = "labelPlaces";
            this.labelPlaces.Size = new System.Drawing.Size(194, 49);
            this.labelPlaces.TabIndex = 9;
            this.labelPlaces.Text = "Places number";
            this.labelPlaces.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 49);
            this.label1.TabIndex = 6;
            this.label1.Text = "Info about";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelModel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModel.Location = new System.Drawing.Point(3, 49);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(194, 49);
            this.labelModel.TabIndex = 7;
            this.labelModel.Text = "Model Name";
            this.labelModel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxModel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxModel.Location = new System.Drawing.Point(3, 101);
            this.textBoxModel.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.textBoxModel.MaximumSize = new System.Drawing.Size(250, 30);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(177, 30);
            this.textBoxModel.TabIndex = 8;
            // 
            // panelPlaces
            // 
            this.panelPlaces.Controls.Add(this.radioButtonEq);
            this.panelPlaces.Controls.Add(this.radioButtonLess);
            this.panelPlaces.Controls.Add(this.radioButtonMore);
            this.panelPlaces.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPlaces.Location = new System.Drawing.Point(3, 199);
            this.panelPlaces.Name = "panelPlaces";
            this.panelPlaces.Size = new System.Drawing.Size(194, 43);
            this.panelPlaces.TabIndex = 10;
            // 
            // radioButtonEq
            // 
            this.radioButtonEq.AutoSize = true;
            this.radioButtonEq.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonEq.Location = new System.Drawing.Point(134, 3);
            this.radioButtonEq.Name = "radioButtonEq";
            this.radioButtonEq.Size = new System.Drawing.Size(43, 27);
            this.radioButtonEq.TabIndex = 2;
            this.radioButtonEq.TabStop = true;
            this.radioButtonEq.Text = "=";
            this.radioButtonEq.UseVisualStyleBackColor = true;
            // 
            // radioButtonLess
            // 
            this.radioButtonLess.AutoSize = true;
            this.radioButtonLess.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonLess.Location = new System.Drawing.Point(67, 3);
            this.radioButtonLess.Name = "radioButtonLess";
            this.radioButtonLess.Size = new System.Drawing.Size(43, 27);
            this.radioButtonLess.TabIndex = 1;
            this.radioButtonLess.TabStop = true;
            this.radioButtonLess.Text = "<";
            this.radioButtonLess.UseVisualStyleBackColor = true;
            // 
            // radioButtonMore
            // 
            this.radioButtonMore.AutoSize = true;
            this.radioButtonMore.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMore.Location = new System.Drawing.Point(4, 3);
            this.radioButtonMore.Name = "radioButtonMore";
            this.radioButtonMore.Size = new System.Drawing.Size(43, 27);
            this.radioButtonMore.TabIndex = 0;
            this.radioButtonMore.TabStop = true;
            this.radioButtonMore.Text = ">";
            this.radioButtonMore.UseVisualStyleBackColor = true;
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
            this.buttonFilter.Location = new System.Drawing.Point(20, 593);
            this.buttonFilter.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(160, 40);
            this.buttonFilter.TabIndex = 18;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // numericUpDownPlaces
            // 
            this.numericUpDownPlaces.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownPlaces.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownPlaces.Location = new System.Drawing.Point(3, 248);
            this.numericUpDownPlaces.Margin = new System.Windows.Forms.Padding(3, 3, 50, 3);
            this.numericUpDownPlaces.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownPlaces.MaximumSize = new System.Drawing.Size(250, 0);
            this.numericUpDownPlaces.Name = "numericUpDownPlaces";
            this.numericUpDownPlaces.Size = new System.Drawing.Size(147, 30);
            this.numericUpDownPlaces.TabIndex = 19;
            // 
            // airportDataSet1
            // 
            this.airportDataSet1.DataSetName = "AirportDataSet1";
            this.airportDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // planesBindingSource
            // 
            this.planesBindingSource.DataMember = "Planes";
            this.planesBindingSource.DataSource = this.airportDataSet1;
            // 
            // planesTableAdapter
            // 
            this.planesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = AirportApp.AirportDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // planesDataGridView
            // 
            this.planesDataGridView.AllowUserToAddRows = false;
            this.planesDataGridView.AllowUserToDeleteRows = false;
            this.planesDataGridView.AutoGenerateColumns = false;
            this.planesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.planesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.planesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.planesDataGridView.DataSource = this.planesBindingSource;
            this.planesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.planesDataGridView.Location = new System.Drawing.Point(200, 57);
            this.planesDataGridView.Name = "planesDataGridView";
            this.planesDataGridView.ReadOnly = true;
            this.planesDataGridView.RowHeadersWidth = 51;
            this.planesDataGridView.RowTemplate.Height = 24;
            this.planesDataGridView.Size = new System.Drawing.Size(786, 638);
            this.planesDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PlacesNumber";
            this.dataGridViewTextBoxColumn2.HeaderText = "PlacesNumber";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LoadCapacity";
            this.dataGridViewTextBoxColumn3.HeaderText = "LoadCapacity";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "HoursWorked";
            this.dataGridViewTextBoxColumn4.HeaderText = "HoursWorked";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "BoardNumber";
            this.dataGridViewTextBoxColumn5.HeaderText = "BoardNumber";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // PlanesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(986, 695);
            this.Controls.Add(this.planesDataGridView);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlanesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   Planes";
            this.Load += new System.EventHandler(this.PlanesForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogOut)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLoad)).EndInit();
            this.panelHours.ResumeLayout(false);
            this.panelHours.PerformLayout();
            this.panelLoad.ResumeLayout(false);
            this.panelLoad.PerformLayout();
            this.panelPlaces.ResumeLayout(false);
            this.panelPlaces.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonNavHome;
        private System.Windows.Forms.Button buttonStaff;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonPlanes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Panel panelHours;
        private System.Windows.Forms.RadioButton radioButtonEqHours;
        private System.Windows.Forms.RadioButton radioButtonLessHours;
        private System.Windows.Forms.RadioButton radioButtonMoreHours;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Panel panelLoad;
        private System.Windows.Forms.RadioButton radioButtonEqLoad;
        private System.Windows.Forms.RadioButton radioButtonLessLoad;
        private System.Windows.Forms.RadioButton radioButtonMoreLoad;
        private System.Windows.Forms.Label labelLoad;
        private System.Windows.Forms.Label labelPlaces;
        private System.Windows.Forms.Panel panelPlaces;
        private System.Windows.Forms.RadioButton radioButtonEq;
        private System.Windows.Forms.RadioButton radioButtonLess;
        private System.Windows.Forms.RadioButton radioButtonMore;
        private System.Windows.Forms.Button buttonFilter;
        private AirportDataSet1 airportDataSet1;
        private System.Windows.Forms.BindingSource planesBindingSource;
        private AirportDataSet1TableAdapters.PlanesTableAdapter planesTableAdapter;
        private AirportDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView planesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.NumericUpDown numericUpDownPlaces;
        private System.Windows.Forms.NumericUpDown numericUpDownHours;
        private System.Windows.Forms.NumericUpDown numericUpDownLoad;
        private System.Windows.Forms.Button buttonRaces;
        private System.Windows.Forms.Button buttonFlights;
        private System.Windows.Forms.PictureBox pictureBoxLogOut;
    }
}