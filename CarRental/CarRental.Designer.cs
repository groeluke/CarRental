namespace CarRental
{
    partial class CarRental
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            CalculateButton = new Button();
            ClearButton = new Button();
            SummaryButton = new Button();
            ExitButton = new Button();
            MilesRadioButton = new RadioButton();
            KilometersRadioButton = new RadioButton();
            OdometerGroupBox = new GroupBox();
            DiscountsGroupBox = new GroupBox();
            SeniorDiscountCheckBox = new CheckBox();
            AAADiscountCheckBox = new CheckBox();
            CustomerNameLabel = new Label();
            AddressLabel = new Label();
            CityLabel = new Label();
            StateLabel = new Label();
            ZipCodeLabel = new Label();
            CustomerNameTextBox = new TextBox();
            AddressTextBox = new TextBox();
            CityTextBox = new TextBox();
            StateTextBox = new TextBox();
            ZipCodeTextBox = new TextBox();
            BeginningReadingTextBox = new TextBox();
            BeginningOdometerReadingLabel = new Label();
            EndingReadingTextBox = new TextBox();
            EndingOdometerReadingLabel = new Label();
            NumberOfDaysTextBox = new TextBox();
            NumberOfDaysLabel = new Label();
            MainToolTip = new ToolTip(components);
            DistanceDrivenInMilesLabel = new Label();
            MileageChargeLabel = new Label();
            DayChargeLabel = new Label();
            MinusDiscountLabel = new Label();
            YouOweLabel = new Label();
            DistanceDrivenInMilesTextBox = new TextBox();
            MileageChargeTextBox = new TextBox();
            DayChargeTextBox = new TextBox();
            MinusDiscountTextBox = new TextBox();
            YouOweTextBox = new TextBox();
            OdometerGroupBox.SuspendLayout();
            DiscountsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(178, 530);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(112, 34);
            CalculateButton.TabIndex = 0;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(322, 530);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(112, 34);
            ClearButton.TabIndex = 1;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // SummaryButton
            // 
            SummaryButton.Location = new Point(462, 530);
            SummaryButton.Name = "SummaryButton";
            SummaryButton.Size = new Size(112, 34);
            SummaryButton.TabIndex = 2;
            SummaryButton.Text = "Summary";
            SummaryButton.UseVisualStyleBackColor = true;
            SummaryButton.Click += SummaryButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(603, 530);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(112, 34);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // MilesRadioButton
            // 
            MilesRadioButton.AutoSize = true;
            MilesRadioButton.Location = new Point(19, 50);
            MilesRadioButton.Name = "MilesRadioButton";
            MilesRadioButton.Size = new Size(78, 29);
            MilesRadioButton.TabIndex = 4;
            MilesRadioButton.TabStop = true;
            MilesRadioButton.Text = "Miles";
            MilesRadioButton.UseVisualStyleBackColor = true;
            MilesRadioButton.CheckedChanged += MilesRadioButton_CheckedChanged;
            // 
            // KilometersRadioButton
            // 
            KilometersRadioButton.AutoSize = true;
            KilometersRadioButton.Location = new Point(19, 85);
            KilometersRadioButton.Name = "KilometersRadioButton";
            KilometersRadioButton.Size = new Size(120, 29);
            KilometersRadioButton.TabIndex = 5;
            KilometersRadioButton.TabStop = true;
            KilometersRadioButton.Text = "Kilometers";
            KilometersRadioButton.UseVisualStyleBackColor = true;
            KilometersRadioButton.CheckedChanged += KilometersRadioButton_CheckedChanged;
            // 
            // OdometerGroupBox
            // 
            OdometerGroupBox.Controls.Add(KilometersRadioButton);
            OdometerGroupBox.Controls.Add(MilesRadioButton);
            OdometerGroupBox.Location = new Point(76, 357);
            OdometerGroupBox.Name = "OdometerGroupBox";
            OdometerGroupBox.Size = new Size(348, 150);
            OdometerGroupBox.TabIndex = 8;
            OdometerGroupBox.TabStop = false;
            OdometerGroupBox.Text = "Is Odometer In Miles Or Kilometers?";
            // 
            // DiscountsGroupBox
            // 
            DiscountsGroupBox.Controls.Add(SeniorDiscountCheckBox);
            DiscountsGroupBox.Controls.Add(AAADiscountCheckBox);
            DiscountsGroupBox.Location = new Point(475, 349);
            DiscountsGroupBox.Name = "DiscountsGroupBox";
            DiscountsGroupBox.Size = new Size(329, 150);
            DiscountsGroupBox.TabIndex = 9;
            DiscountsGroupBox.TabStop = false;
            DiscountsGroupBox.Text = "Enter Any Discounts";
            // 
            // SeniorDiscountCheckBox
            // 
            SeniorDiscountCheckBox.AutoSize = true;
            SeniorDiscountCheckBox.Location = new Point(21, 85);
            SeniorDiscountCheckBox.Name = "SeniorDiscountCheckBox";
            SeniorDiscountCheckBox.Size = new Size(212, 29);
            SeniorDiscountCheckBox.TabIndex = 1;
            SeniorDiscountCheckBox.Text = "Senior Citizen Dicount";
            SeniorDiscountCheckBox.UseVisualStyleBackColor = true;
            SeniorDiscountCheckBox.CheckedChanged += SeniorDiscountCheckBox_CheckedChanged;
            // 
            // AAADiscountCheckBox
            // 
            AAADiscountCheckBox.AutoSize = true;
            AAADiscountCheckBox.Location = new Point(21, 50);
            AAADiscountCheckBox.Name = "AAADiscountCheckBox";
            AAADiscountCheckBox.Size = new Size(221, 29);
            AAADiscountCheckBox.TabIndex = 0;
            AAADiscountCheckBox.Text = "AAA Member Discount";
            AAADiscountCheckBox.UseVisualStyleBackColor = true;
            AAADiscountCheckBox.CheckedChanged += AAADiscountCheckBox_CheckedChanged;
            // 
            // CustomerNameLabel
            // 
            CustomerNameLabel.AutoSize = true;
            CustomerNameLabel.Location = new Point(26, 25);
            CustomerNameLabel.Name = "CustomerNameLabel";
            CustomerNameLabel.Size = new Size(141, 25);
            CustomerNameLabel.TabIndex = 10;
            CustomerNameLabel.Text = "Customer Name";
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Location = new Point(26, 66);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(77, 25);
            AddressLabel.TabIndex = 11;
            AddressLabel.Text = "Address";
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(26, 107);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(42, 25);
            CityLabel.TabIndex = 12;
            CityLabel.Text = "City";
            // 
            // StateLabel
            // 
            StateLabel.AutoSize = true;
            StateLabel.Location = new Point(26, 152);
            StateLabel.Name = "StateLabel";
            StateLabel.Size = new Size(51, 25);
            StateLabel.TabIndex = 13;
            StateLabel.Text = "State";
            // 
            // ZipCodeLabel
            // 
            ZipCodeLabel.AutoSize = true;
            ZipCodeLabel.Location = new Point(26, 194);
            ZipCodeLabel.Name = "ZipCodeLabel";
            ZipCodeLabel.Size = new Size(84, 25);
            ZipCodeLabel.TabIndex = 14;
            ZipCodeLabel.Text = "Zip Code";
            // 
            // CustomerNameTextBox
            // 
            CustomerNameTextBox.Location = new Point(279, 22);
            CustomerNameTextBox.Name = "CustomerNameTextBox";
            CustomerNameTextBox.Size = new Size(150, 31);
            CustomerNameTextBox.TabIndex = 15;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(279, 63);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(150, 31);
            AddressTextBox.TabIndex = 16;
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(279, 104);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(150, 31);
            CityTextBox.TabIndex = 17;
            // 
            // StateTextBox
            // 
            StateTextBox.Location = new Point(279, 149);
            StateTextBox.Name = "StateTextBox";
            StateTextBox.Size = new Size(150, 31);
            StateTextBox.TabIndex = 18;
            // 
            // ZipCodeTextBox
            // 
            ZipCodeTextBox.Location = new Point(279, 191);
            ZipCodeTextBox.Name = "ZipCodeTextBox";
            ZipCodeTextBox.Size = new Size(150, 31);
            ZipCodeTextBox.TabIndex = 19;
            // 
            // BeginningReadingTextBox
            // 
            BeginningReadingTextBox.Location = new Point(279, 234);
            BeginningReadingTextBox.Name = "BeginningReadingTextBox";
            BeginningReadingTextBox.Size = new Size(150, 31);
            BeginningReadingTextBox.TabIndex = 21;
            // 
            // BeginningOdometerReadingLabel
            // 
            BeginningOdometerReadingLabel.AutoSize = true;
            BeginningOdometerReadingLabel.Location = new Point(26, 240);
            BeginningOdometerReadingLabel.Name = "BeginningOdometerReadingLabel";
            BeginningOdometerReadingLabel.Size = new Size(247, 25);
            BeginningOdometerReadingLabel.TabIndex = 20;
            BeginningOdometerReadingLabel.Text = "Beginning Odometer Reading";
            // 
            // EndingReadingTextBox
            // 
            EndingReadingTextBox.Location = new Point(279, 275);
            EndingReadingTextBox.Name = "EndingReadingTextBox";
            EndingReadingTextBox.Size = new Size(150, 31);
            EndingReadingTextBox.TabIndex = 23;
            // 
            // EndingOdometerReadingLabel
            // 
            EndingOdometerReadingLabel.AutoSize = true;
            EndingOdometerReadingLabel.Location = new Point(26, 281);
            EndingOdometerReadingLabel.Name = "EndingOdometerReadingLabel";
            EndingOdometerReadingLabel.Size = new Size(223, 25);
            EndingOdometerReadingLabel.TabIndex = 22;
            EndingOdometerReadingLabel.Text = "Ending Odometer Reading";
            // 
            // NumberOfDaysTextBox
            // 
            NumberOfDaysTextBox.Location = new Point(279, 314);
            NumberOfDaysTextBox.Name = "NumberOfDaysTextBox";
            NumberOfDaysTextBox.Size = new Size(150, 31);
            NumberOfDaysTextBox.TabIndex = 25;
            // 
            // NumberOfDaysLabel
            // 
            NumberOfDaysLabel.AutoSize = true;
            NumberOfDaysLabel.Location = new Point(26, 320);
            NumberOfDaysLabel.Name = "NumberOfDaysLabel";
            NumberOfDaysLabel.Size = new Size(146, 25);
            NumberOfDaysLabel.TabIndex = 24;
            NumberOfDaysLabel.Text = "Number Of Days";
            // 
            // DistanceDrivenInMilesLabel
            // 
            DistanceDrivenInMilesLabel.AutoSize = true;
            DistanceDrivenInMilesLabel.Location = new Point(462, 28);
            DistanceDrivenInMilesLabel.Name = "DistanceDrivenInMilesLabel";
            DistanceDrivenInMilesLabel.Size = new Size(201, 25);
            DistanceDrivenInMilesLabel.TabIndex = 26;
            DistanceDrivenInMilesLabel.Text = "Distance Driven In Miles";
            // 
            // MileageChargeLabel
            // 
            MileageChargeLabel.AutoSize = true;
            MileageChargeLabel.Location = new Point(462, 63);
            MileageChargeLabel.Name = "MileageChargeLabel";
            MileageChargeLabel.Size = new Size(135, 25);
            MileageChargeLabel.TabIndex = 27;
            MileageChargeLabel.Text = "Mileage Charge";
            // 
            // DayChargeLabel
            // 
            DayChargeLabel.AutoSize = true;
            DayChargeLabel.Location = new Point(462, 104);
            DayChargeLabel.Name = "DayChargeLabel";
            DayChargeLabel.Size = new Size(104, 25);
            DayChargeLabel.TabIndex = 28;
            DayChargeLabel.Text = "Day Charge";
            // 
            // MinusDiscountLabel
            // 
            MinusDiscountLabel.AutoSize = true;
            MinusDiscountLabel.Location = new Point(462, 149);
            MinusDiscountLabel.Name = "MinusDiscountLabel";
            MinusDiscountLabel.Size = new Size(135, 25);
            MinusDiscountLabel.TabIndex = 29;
            MinusDiscountLabel.Text = "Minus Discount";
            // 
            // YouOweLabel
            // 
            YouOweLabel.AutoSize = true;
            YouOweLabel.Location = new Point(462, 191);
            YouOweLabel.Name = "YouOweLabel";
            YouOweLabel.Size = new Size(82, 25);
            YouOweLabel.TabIndex = 30;
            YouOweLabel.Text = "You Owe";
            // 
            // DistanceDrivenInMilesTextBox
            // 
            DistanceDrivenInMilesTextBox.Location = new Point(669, 22);
            DistanceDrivenInMilesTextBox.Name = "DistanceDrivenInMilesTextBox";
            DistanceDrivenInMilesTextBox.Size = new Size(189, 31);
            DistanceDrivenInMilesTextBox.TabIndex = 31;
            // 
            // MileageChargeTextBox
            // 
            MileageChargeTextBox.Location = new Point(669, 63);
            MileageChargeTextBox.Name = "MileageChargeTextBox";
            MileageChargeTextBox.Size = new Size(189, 31);
            MileageChargeTextBox.TabIndex = 32;
            // 
            // DayChargeTextBox
            // 
            DayChargeTextBox.Location = new Point(669, 104);
            DayChargeTextBox.Name = "DayChargeTextBox";
            DayChargeTextBox.Size = new Size(189, 31);
            DayChargeTextBox.TabIndex = 33;
            // 
            // MinusDiscountTextBox
            // 
            MinusDiscountTextBox.Location = new Point(669, 146);
            MinusDiscountTextBox.Name = "MinusDiscountTextBox";
            MinusDiscountTextBox.Size = new Size(189, 31);
            MinusDiscountTextBox.TabIndex = 34;
            // 
            // YouOweTextBox
            // 
            YouOweTextBox.Location = new Point(669, 188);
            YouOweTextBox.Name = "YouOweTextBox";
            YouOweTextBox.Size = new Size(189, 31);
            YouOweTextBox.TabIndex = 35;
            // 
            // CarRental
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 576);
            Controls.Add(YouOweTextBox);
            Controls.Add(MinusDiscountTextBox);
            Controls.Add(DayChargeTextBox);
            Controls.Add(MileageChargeTextBox);
            Controls.Add(DistanceDrivenInMilesTextBox);
            Controls.Add(YouOweLabel);
            Controls.Add(MinusDiscountLabel);
            Controls.Add(DayChargeLabel);
            Controls.Add(MileageChargeLabel);
            Controls.Add(DistanceDrivenInMilesLabel);
            Controls.Add(NumberOfDaysTextBox);
            Controls.Add(NumberOfDaysLabel);
            Controls.Add(EndingReadingTextBox);
            Controls.Add(EndingOdometerReadingLabel);
            Controls.Add(BeginningReadingTextBox);
            Controls.Add(BeginningOdometerReadingLabel);
            Controls.Add(ZipCodeTextBox);
            Controls.Add(StateTextBox);
            Controls.Add(CityTextBox);
            Controls.Add(AddressTextBox);
            Controls.Add(CustomerNameTextBox);
            Controls.Add(ZipCodeLabel);
            Controls.Add(StateLabel);
            Controls.Add(CityLabel);
            Controls.Add(AddressLabel);
            Controls.Add(CustomerNameLabel);
            Controls.Add(DiscountsGroupBox);
            Controls.Add(OdometerGroupBox);
            Controls.Add(ExitButton);
            Controls.Add(SummaryButton);
            Controls.Add(ClearButton);
            Controls.Add(CalculateButton);
            Name = "CarRental";
            Text = "Car Rental";
            OdometerGroupBox.ResumeLayout(false);
            OdometerGroupBox.PerformLayout();
            DiscountsGroupBox.ResumeLayout(false);
            DiscountsGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CalculateButton;
        private Button ClearButton;
        private Button SummaryButton;
        private Button ExitButton;
        private RadioButton MilesRadioButton;
        private RadioButton KilometersRadioButton;
        private GroupBox OdometerGroupBox;
        private GroupBox DiscountsGroupBox;
        private CheckBox SeniorDiscountCheckBox;
        private CheckBox AAADiscountCheckBox;
        private Label CustomerNameLabel;
        private Label AddressLabel;
        private Label CityLabel;
        private Label StateLabel;
        private Label ZipCodeLabel;
        private TextBox CustomerNameTextBox;
        private TextBox AddressTextBox;
        private TextBox CityTextBox;
        private TextBox StateTextBox;
        private TextBox ZipCodeTextBox;
        private TextBox BeginningReadingTextBox;
        private Label BeginningOdometerReadingLabel;
        private TextBox EndingReadingTextBox;
        private Label EndingOdometerReadingLabel;
        private TextBox NumberOfDaysTextBox;
        private Label NumberOfDaysLabel;
        private ToolTip MainToolTip;
        private Label DistanceDrivenInMilesLabel;
        private Label MileageChargeLabel;
        private Label DayChargeLabel;
        private Label MinusDiscountLabel;
        private Label YouOweLabel;
        private TextBox DistanceDrivenInMilesTextBox;
        private TextBox MileageChargeTextBox;
        private TextBox DayChargeTextBox;
        private TextBox MinusDiscountTextBox;
        private TextBox YouOweTextBox;
    }
}
