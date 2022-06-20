namespace AirportApp
{
    partial class AdminFlightsPickCrewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminFlightsPickCrewForm));
            this.label3 = new System.Windows.Forms.Label();
            this.commanderComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCommanderName = new System.Windows.Forms.TextBox();
            this.textBoxCommanderSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerCommanderBirthday = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCommanderAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPilotAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerPilotBirthday = new System.Windows.Forms.DateTimePicker();
            this.textBoxPilotSurname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPilotName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pilotComboBox = new System.Windows.Forms.ComboBox();
            this.textBoxStewardess1Address = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePickerStewardess1Birthday = new System.Windows.Forms.DateTimePicker();
            this.textBoxStewardess1Surname = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxStewardess1Name = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.stewardess1ComboBox = new System.Windows.Forms.ComboBox();
            this.textBoxStewardess2Address = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dateTimePickerStewardess2Birthday = new System.Windows.Forms.DateTimePicker();
            this.textBoxStewardess2Surname = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxStewardess2Name = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.stewardess2ComboBox = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonCrew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 23);
            this.label3.TabIndex = 69;
            this.label3.Text = "Choose commander:";
            // 
            // commanderComboBox
            // 
            this.commanderComboBox.DisplayMember = "RaceNumber";
            this.commanderComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commanderComboBox.FormattingEnabled = true;
            this.commanderComboBox.Location = new System.Drawing.Point(300, 69);
            this.commanderComboBox.Name = "commanderComboBox";
            this.commanderComboBox.Size = new System.Drawing.Size(169, 31);
            this.commanderComboBox.TabIndex = 68;
            this.commanderComboBox.ValueMember = "RaceNumber";
            this.commanderComboBox.SelectedIndexChanged += new System.EventHandler(this.commanderComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 70;
            this.label1.Text = "Name";
            // 
            // textBoxCommanderName
            // 
            this.textBoxCommanderName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCommanderName.Location = new System.Drawing.Point(60, 157);
            this.textBoxCommanderName.Name = "textBoxCommanderName";
            this.textBoxCommanderName.ReadOnly = true;
            this.textBoxCommanderName.Size = new System.Drawing.Size(200, 30);
            this.textBoxCommanderName.TabIndex = 71;
            // 
            // textBoxCommanderSurname
            // 
            this.textBoxCommanderSurname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCommanderSurname.Location = new System.Drawing.Point(307, 157);
            this.textBoxCommanderSurname.Name = "textBoxCommanderSurname";
            this.textBoxCommanderSurname.ReadOnly = true;
            this.textBoxCommanderSurname.Size = new System.Drawing.Size(200, 30);
            this.textBoxCommanderSurname.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 72;
            this.label2.Text = "Surname";
            // 
            // dateTimePickerCommanderBirthday
            // 
            this.dateTimePickerCommanderBirthday.CalendarFont = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerCommanderBirthday.Enabled = false;
            this.dateTimePickerCommanderBirthday.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerCommanderBirthday.Location = new System.Drawing.Point(98, 313);
            this.dateTimePickerCommanderBirthday.Name = "dateTimePickerCommanderBirthday";
            this.dateTimePickerCommanderBirthday.Size = new System.Drawing.Size(371, 27);
            this.dateTimePickerCommanderBirthday.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(239, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 23);
            this.label4.TabIndex = 75;
            this.label4.Text = "Birthday";
            // 
            // textBoxCommanderAddress
            // 
            this.textBoxCommanderAddress.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCommanderAddress.Location = new System.Drawing.Point(153, 244);
            this.textBoxCommanderAddress.Name = "textBoxCommanderAddress";
            this.textBoxCommanderAddress.ReadOnly = true;
            this.textBoxCommanderAddress.Size = new System.Drawing.Size(259, 30);
            this.textBoxCommanderAddress.TabIndex = 77;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(239, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 23);
            this.label5.TabIndex = 76;
            this.label5.Text = "Address";
            // 
            // textBoxPilotAddress
            // 
            this.textBoxPilotAddress.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPilotAddress.Location = new System.Drawing.Point(684, 244);
            this.textBoxPilotAddress.Name = "textBoxPilotAddress";
            this.textBoxPilotAddress.ReadOnly = true;
            this.textBoxPilotAddress.Size = new System.Drawing.Size(259, 30);
            this.textBoxPilotAddress.TabIndex = 87;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(770, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 23);
            this.label6.TabIndex = 86;
            this.label6.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(770, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 23);
            this.label7.TabIndex = 85;
            this.label7.Text = "Birthday";
            // 
            // dateTimePickerPilotBirthday
            // 
            this.dateTimePickerPilotBirthday.CalendarFont = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerPilotBirthday.Enabled = false;
            this.dateTimePickerPilotBirthday.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerPilotBirthday.Location = new System.Drawing.Point(629, 313);
            this.dateTimePickerPilotBirthday.Name = "dateTimePickerPilotBirthday";
            this.dateTimePickerPilotBirthday.Size = new System.Drawing.Size(371, 27);
            this.dateTimePickerPilotBirthday.TabIndex = 84;
            // 
            // textBoxPilotSurname
            // 
            this.textBoxPilotSurname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPilotSurname.Location = new System.Drawing.Point(838, 157);
            this.textBoxPilotSurname.Name = "textBoxPilotSurname";
            this.textBoxPilotSurname.ReadOnly = true;
            this.textBoxPilotSurname.Size = new System.Drawing.Size(200, 30);
            this.textBoxPilotSurname.TabIndex = 83;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(885, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 23);
            this.label8.TabIndex = 82;
            this.label8.Text = "Surname";
            // 
            // textBoxPilotName
            // 
            this.textBoxPilotName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPilotName.Location = new System.Drawing.Point(591, 157);
            this.textBoxPilotName.Name = "textBoxPilotName";
            this.textBoxPilotName.ReadOnly = true;
            this.textBoxPilotName.Size = new System.Drawing.Size(200, 30);
            this.textBoxPilotName.TabIndex = 81;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(653, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 23);
            this.label9.TabIndex = 80;
            this.label9.Text = "Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(680, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 23);
            this.label10.TabIndex = 79;
            this.label10.Text = "Choose pilot:";
            // 
            // pilotComboBox
            // 
            this.pilotComboBox.DisplayMember = "RaceNumber";
            this.pilotComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pilotComboBox.FormattingEnabled = true;
            this.pilotComboBox.Location = new System.Drawing.Point(831, 69);
            this.pilotComboBox.Name = "pilotComboBox";
            this.pilotComboBox.Size = new System.Drawing.Size(169, 31);
            this.pilotComboBox.TabIndex = 78;
            this.pilotComboBox.ValueMember = "RaceNumber";
            this.pilotComboBox.SelectedIndexChanged += new System.EventHandler(this.pilotComboBox_SelectedIndexChanged);
            // 
            // textBoxStewardess1Address
            // 
            this.textBoxStewardess1Address.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStewardess1Address.Location = new System.Drawing.Point(153, 582);
            this.textBoxStewardess1Address.Name = "textBoxStewardess1Address";
            this.textBoxStewardess1Address.ReadOnly = true;
            this.textBoxStewardess1Address.Size = new System.Drawing.Size(259, 30);
            this.textBoxStewardess1Address.TabIndex = 97;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(239, 556);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 23);
            this.label11.TabIndex = 96;
            this.label11.Text = "Address";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(239, 625);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 23);
            this.label12.TabIndex = 95;
            this.label12.Text = "Birthday";
            // 
            // dateTimePickerStewardess1Birthday
            // 
            this.dateTimePickerStewardess1Birthday.CalendarFont = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStewardess1Birthday.Enabled = false;
            this.dateTimePickerStewardess1Birthday.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStewardess1Birthday.Location = new System.Drawing.Point(98, 651);
            this.dateTimePickerStewardess1Birthday.Name = "dateTimePickerStewardess1Birthday";
            this.dateTimePickerStewardess1Birthday.Size = new System.Drawing.Size(371, 27);
            this.dateTimePickerStewardess1Birthday.TabIndex = 94;
            // 
            // textBoxStewardess1Surname
            // 
            this.textBoxStewardess1Surname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStewardess1Surname.Location = new System.Drawing.Point(307, 495);
            this.textBoxStewardess1Surname.Name = "textBoxStewardess1Surname";
            this.textBoxStewardess1Surname.ReadOnly = true;
            this.textBoxStewardess1Surname.Size = new System.Drawing.Size(200, 30);
            this.textBoxStewardess1Surname.TabIndex = 93;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(354, 469);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 23);
            this.label13.TabIndex = 92;
            this.label13.Text = "Surname";
            // 
            // textBoxStewardess1Name
            // 
            this.textBoxStewardess1Name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStewardess1Name.Location = new System.Drawing.Point(60, 495);
            this.textBoxStewardess1Name.Name = "textBoxStewardess1Name";
            this.textBoxStewardess1Name.ReadOnly = true;
            this.textBoxStewardess1Name.Size = new System.Drawing.Size(200, 30);
            this.textBoxStewardess1Name.TabIndex = 91;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(122, 469);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 23);
            this.label14.TabIndex = 90;
            this.label14.Text = "Name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(56, 410);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(230, 23);
            this.label15.TabIndex = 89;
            this.label15.Text = "Choose first stewardess:";
            // 
            // stewardess1ComboBox
            // 
            this.stewardess1ComboBox.DisplayMember = "RaceNumber";
            this.stewardess1ComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stewardess1ComboBox.FormattingEnabled = true;
            this.stewardess1ComboBox.Location = new System.Drawing.Point(307, 407);
            this.stewardess1ComboBox.Name = "stewardess1ComboBox";
            this.stewardess1ComboBox.Size = new System.Drawing.Size(169, 31);
            this.stewardess1ComboBox.TabIndex = 88;
            this.stewardess1ComboBox.ValueMember = "RaceNumber";
            this.stewardess1ComboBox.SelectedIndexChanged += new System.EventHandler(this.stewardess1ComboBox_SelectedIndexChanged);
            // 
            // textBoxStewardess2Address
            // 
            this.textBoxStewardess2Address.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStewardess2Address.Location = new System.Drawing.Point(684, 587);
            this.textBoxStewardess2Address.Name = "textBoxStewardess2Address";
            this.textBoxStewardess2Address.ReadOnly = true;
            this.textBoxStewardess2Address.Size = new System.Drawing.Size(259, 30);
            this.textBoxStewardess2Address.TabIndex = 107;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(770, 561);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 23);
            this.label16.TabIndex = 106;
            this.label16.Text = "Address";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(770, 630);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 23);
            this.label17.TabIndex = 105;
            this.label17.Text = "Birthday";
            // 
            // dateTimePickerStewardess2Birthday
            // 
            this.dateTimePickerStewardess2Birthday.CalendarFont = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStewardess2Birthday.Enabled = false;
            this.dateTimePickerStewardess2Birthday.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStewardess2Birthday.Location = new System.Drawing.Point(629, 656);
            this.dateTimePickerStewardess2Birthday.Name = "dateTimePickerStewardess2Birthday";
            this.dateTimePickerStewardess2Birthday.Size = new System.Drawing.Size(371, 27);
            this.dateTimePickerStewardess2Birthday.TabIndex = 104;
            // 
            // textBoxStewardess2Surname
            // 
            this.textBoxStewardess2Surname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStewardess2Surname.Location = new System.Drawing.Point(838, 500);
            this.textBoxStewardess2Surname.Name = "textBoxStewardess2Surname";
            this.textBoxStewardess2Surname.ReadOnly = true;
            this.textBoxStewardess2Surname.Size = new System.Drawing.Size(200, 30);
            this.textBoxStewardess2Surname.TabIndex = 103;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(885, 474);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 23);
            this.label18.TabIndex = 102;
            this.label18.Text = "Surname";
            // 
            // textBoxStewardess2Name
            // 
            this.textBoxStewardess2Name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStewardess2Name.Location = new System.Drawing.Point(591, 500);
            this.textBoxStewardess2Name.Name = "textBoxStewardess2Name";
            this.textBoxStewardess2Name.ReadOnly = true;
            this.textBoxStewardess2Name.Size = new System.Drawing.Size(200, 30);
            this.textBoxStewardess2Name.TabIndex = 101;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(653, 474);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 23);
            this.label19.TabIndex = 100;
            this.label19.Text = "Name";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(587, 410);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(260, 23);
            this.label20.TabIndex = 99;
            this.label20.Text = "Choose second stewardess:";
            // 
            // stewardess2ComboBox
            // 
            this.stewardess2ComboBox.DisplayMember = "RaceNumber";
            this.stewardess2ComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stewardess2ComboBox.FormattingEnabled = true;
            this.stewardess2ComboBox.Location = new System.Drawing.Point(869, 407);
            this.stewardess2ComboBox.Name = "stewardess2ComboBox";
            this.stewardess2ComboBox.Size = new System.Drawing.Size(169, 31);
            this.stewardess2ComboBox.TabIndex = 98;
            this.stewardess2ComboBox.ValueMember = "RaceNumber";
            this.stewardess2ComboBox.SelectedIndexChanged += new System.EventHandler(this.stewardess2ComboBox_SelectedIndexChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCancel.FlatAppearance.BorderSize = 3;
            this.buttonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(418, 729);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(141, 67);
            this.buttonCancel.TabIndex = 109;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonCrew
            // 
            this.buttonCrew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCrew.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCrew.FlatAppearance.BorderSize = 3;
            this.buttonCrew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.buttonCrew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCrew.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrew.Location = new System.Drawing.Point(591, 729);
            this.buttonCrew.Name = "buttonCrew";
            this.buttonCrew.Size = new System.Drawing.Size(141, 67);
            this.buttonCrew.TabIndex = 108;
            this.buttonCrew.Text = "Pick crew";
            this.buttonCrew.UseVisualStyleBackColor = true;
            this.buttonCrew.Click += new System.EventHandler(this.buttonCrew_Click);
            // 
            // AdminFlightsPickCrewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1085, 808);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonCrew);
            this.Controls.Add(this.textBoxStewardess2Address);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dateTimePickerStewardess2Birthday);
            this.Controls.Add(this.textBoxStewardess2Surname);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBoxStewardess2Name);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.stewardess2ComboBox);
            this.Controls.Add(this.textBoxStewardess1Address);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dateTimePickerStewardess1Birthday);
            this.Controls.Add(this.textBoxStewardess1Surname);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxStewardess1Name);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.stewardess1ComboBox);
            this.Controls.Add(this.textBoxPilotAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePickerPilotBirthday);
            this.Controls.Add(this.textBoxPilotSurname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxPilotName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pilotComboBox);
            this.Controls.Add(this.textBoxCommanderAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerCommanderBirthday);
            this.Controls.Add(this.textBoxCommanderSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCommanderName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.commanderComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminFlightsPickCrewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   Pick crew";
            this.Load += new System.EventHandler(this.AdminFlightsPickCrewForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox commanderComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCommanderName;
        private System.Windows.Forms.TextBox textBoxCommanderSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerCommanderBirthday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCommanderAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPilotAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerPilotBirthday;
        private System.Windows.Forms.TextBox textBoxPilotSurname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPilotName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox pilotComboBox;
        private System.Windows.Forms.TextBox textBoxStewardess1Address;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePickerStewardess1Birthday;
        private System.Windows.Forms.TextBox textBoxStewardess1Surname;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxStewardess1Name;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox stewardess1ComboBox;
        private System.Windows.Forms.TextBox textBoxStewardess2Address;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dateTimePickerStewardess2Birthday;
        private System.Windows.Forms.TextBox textBoxStewardess2Surname;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxStewardess2Name;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox stewardess2ComboBox;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonCrew;
    }
}