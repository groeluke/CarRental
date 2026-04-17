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
        int totalCustomers = 0;
        int totalMilesDriven = 0;
        double totalCharges = 0;
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
            SummaryButton.Enabled = false;
            CustomerNameTextBox.Focus();
            // set all to default values, clear textboxes, select other options
        }

        bool AllFieldsValid()
        {
            bool isValid = true;

            // Customer Information - cannot be blank
            if (CustomerNameTextBox.Text == "")
            {
                CustomerNameTextBox.BackColor = Color.LightYellow;
            }
            else
            {
                CustomerNameTextBox.BackColor = Color.White;
            }
            if (AddressTextBox.Text == "")
            {
                AddressTextBox.BackColor = Color.LightYellow;
            }
            if (CityTextBox.Text == "")
            {
                CityTextBox.BackColor = Color.LightYellow;
            }
            else
            {
                CityTextBox.BackColor = Color.White;
            }
            if (StateTextBox.Text == "")
            {
                StateTextBox.BackColor = Color.LightYellow;
            }
            else
            {
                StateTextBox.BackColor = Color.White;
            }
            if (ZipCodeTextBox.Text == "")
            {
                ZipCodeTextBox.BackColor = Color.LightYellow;
            }
            else
            {
                ZipCodeTextBox.BackColor = Color.White;
            }

            if (BeginningReadingTextBox.Text == "")
            {
                BeginningReadingTextBox.BackColor = Color.LightYellow;
            }
            else    
            {
                BeginningReadingTextBox.BackColor = Color.White;
            }

            if (EndingReadingTextBox.Text == "")
            {
                EndingReadingTextBox.BackColor = Color.LightYellow;
            }
            else
            {
                EndingReadingTextBox.BackColor = Color.White;
            }

            if (NumberOfDaysTextBox.Text == "")
            {
                NumberOfDaysTextBox.BackColor = Color.LightYellow;
            }
            else
            {
                NumberOfDaysTextBox.BackColor = Color.White;
            }
            return isValid;
            // check if all the fields are valid, if not change the background color
            // to light yellow

        }

        void ErrorFieldsValid()
        {
            string errorMessage = "";

        }
        double GetMilesDriven()
        {
            double beginning = double.Parse(BeginningReadingTextBox.Text);
            double ending = double.Parse(EndingReadingTextBox.Text);
            double miles = ending - beginning;
            // if kilometers is selected, convert miles to kilometers

            if (KilometersRadioButton.Checked)
                miles = KilometersToMiles(miles);

            return miles;
        }

        double KilometersToMiles(double kilometers)
        {
            return kilometers * 0.621;
        }

        double CalculateDailyCharge(int days)
        {
            return days * 15.00;
        }

        double CalculateMileageCharge(double miles)
        {
            if (miles <= 200) return 0.0;

            double charge = 0.0;

            // 201 - 500 miles @ $0.12
            if (miles > 200)
            {
                double milesInMiddle = Math.Min(miles - 200, 300); 
                // max 300 miles in this tier
                charge += milesInMiddle * 0.12;
            }

            // Over 500 miles @ $0.10
            if (miles > 500)
            {
                charge += (miles - 500) * 0.10;
            }

            return charge;
        }

        double CalculateDiscount(double baseCharge)
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
            AllFieldsValid();
            ErrorFieldsValid();

            // is all the fields are valid then calculate the charges
            int milesDriven = (int)GetMilesDriven();
            int days = int.Parse(NumberOfDaysTextBox.Text);

            double dailyCharge = CalculateDailyCharge(days);
            double mileageCharge = CalculateMileageCharge(milesDriven);
            double subtotal = dailyCharge + mileageCharge;
            double discount = CalculateDiscount(subtotal);
            double totalDue = subtotal - discount;

            // display the results of the  users inputs and the charges
            DistanceDrivenInMilesTextBox.Text = $"{milesDriven:F1} mi";
            MileageChargeTextBox.Text = mileageCharge.ToString("C");
            DayChargeTextBox.Text = dailyCharge.ToString("C");
            MinusDiscountTextBox.Text = $"{discount:C}";
            YouOweTextBox.Text = totalDue.ToString("C");

            // update summary totals
            totalCustomers++;
            totalMilesDriven += milesDriven;
            totalCharges += totalDue;

            SummaryButton.Enabled = true;
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

        private void SummaryButton_Click(object sender, EventArgs e)
        {
            string summary = $"Total Customers: {totalCustomers}\n" +
                             $"Total Miles Driven: {totalMilesDriven:F1} mi\n" +
                             $"Total Charges: {totalCharges:C}";
            MessageBox.Show(summary, "Summary", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", 
                "Exit Confirmation", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
