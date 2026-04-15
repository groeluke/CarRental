/*Luke Groesbeck
Spring 2026
RCET 2265
Project Car Rental
Computer Fundamentals and Introduction to Programming
https://github.com/groeluke/CarRental.git
*/
namespace CarRental
{
    public partial class CarRental : Form
    {
        public CarRental()
        {
            InitializeComponent();
            SetDefaults();
        }
        //Custom methods-------------------------------------------------------

        void SetDefaults()
        {
            CustomerNameTextBox.Clear();
            AddressTextBox.Clear();
            CityTextBox.Clear();
            StateTextBox.Clear();
            ZipCodeTextBox.Clear();
            BeginningReadingTextBox.Clear();
            EndingReadingTextBox.Clear();
            NumberOfDaysTextBox.Clear();
            DistanceDrivenInMilesTextBox.Clear();
            MileageChargeTextBox.Clear();
            DayChargeTextBox.Clear();
            MinusDiscountTextBox.Clear();
            YouOweTextBox.Clear();
            MilesRadioButton.Checked = true;
            KilometersRadioButton.Checked = false;
            AAADiscountCheckBox.Checked = false;
            SeniorDiscountCheckBox.Checked = false;
        }

        bool AllFeildsValid()
        {
            bool _valid = true;
            return _valid;
        }

        private double GetMilesDriven()
        {
            double beginning = double.Parse(BeginningReadingTextBox.Text);
            double ending = double.Parse(EndingReadingTextBox.Text);
            double miles = ending - beginning;

            if (KilometersRadioButton.Checked)
                miles = KilometersToMiles(miles);

            return miles;
        }

        private double KilometersToMiles(double kilometers)
        {
            return kilometers * 0.62;
        }

        private double CalculateDailyCharge(int days)
        {
            return days * 15.00;
        }

        private double CalculateMileageCharge(double miles)
        {
            if (miles <= 200) return 0.0;

            double charge = 0.0;

            // 201 - 500 miles @ $0.12
            if (miles > 200)
            {
                double milesInMiddle = Math.Min(miles - 200, 300); // max 300 miles in this tier
                charge += milesInMiddle * 0.12;
            }

            // Over 500 miles @ $0.10
            if (miles > 500)
            {
                charge += (miles - 500) * 0.10;
            }

            return charge;
        }

        private double CalculateTotalDiscount(double baseCharge)
        {
            double discount = 0.0;

            if (AAADiscountCheckBox.Checked)
                discount += 0.05;

            if (SeniorDiscountCheckBox.Checked)
                discount += 0.03;

            return baseCharge * discount;
        }

        //Event handlers-------------------------------------------------------
        private void CalculateButton_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            CustomerNameTextBox.Clear();
            AddressTextBox.Clear();
            CityTextBox.Clear();
            StateTextBox.Clear();
            ZipCodeTextBox.Clear();
            BeginningReadingTextBox.Clear();
            EndingReadingTextBox.Clear();
            NumberOfDaysTextBox.Clear();
            MilesRadioButton.Checked = true;
            KilometersRadioButton.Checked = false;
            AAADiscountCheckBox.Checked = false;
            SeniorDiscountCheckBox.Checked = false;
        }

        bool AllFieldsValid()
        {
            bool valid = true;
            // Implement validation logic here
            return valid;
        }

        private void SummaryButton_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void MilesRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void KilometersRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AAADiscountCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SeniorDiscountCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
