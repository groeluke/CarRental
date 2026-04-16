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
        private int totalCustomers = 0;
        private double totalMilesDriven = 0;
        private double totalCharges = 0;
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

        bool AllFieldsValid(out string errorMessage)
        {
            errorMessage = "";

            // Customer Information - cannot be blank
            if (string.IsNullOrWhiteSpace(CustomerNameTextBox.Text))
            {
                CustomerNameTextBox.BackColor = Color.LightYellow;
                errorMessage += "Customer Name is required";
            }
            else
            {
                CustomerNameTextBox.BackColor = Color.White;
            }
            if (string.IsNullOrWhiteSpace(AddressTextBox.Text))
            {
                AddressTextBox.BackColor = Color.LightYellow;
                errorMessage += "Address is required";
            }
            if (string.IsNullOrWhiteSpace(CityTextBox.Text))
            {
                CityTextBox.BackColor = Color.LightYellow;
                errorMessage += "City is required";
            }
            else
            {
                CityTextBox.BackColor = Color.White;
            }
            if (string.IsNullOrWhiteSpace(StateTextBox.Text))
            {
                StateTextBox.BackColor = Color.LightYellow;
                errorMessage += "State is required";
            }
            else
            {
                StateTextBox.BackColor = Color.White;
            }
            if (string.IsNullOrWhiteSpace(ZipCodeTextBox.Text))
            {
                ZipCodeTextBox.BackColor = Color.LightYellow;
                errorMessage += "Zip Code is required";
            }
            else
            {
                ZipCodeTextBox.BackColor = Color.White;
            }

            // Odometer Readings
            if (double.TryParse(BeginningReadingTextBox.Text, out double begin))
            {
                BeginningReadingTextBox.BackColor = Color.LightYellow;
                errorMessage += "Beginning odometer must be a valid number";
            }
            else    
            {
                BeginningReadingTextBox.BackColor = Color.White;
            }

            if (double.TryParse(EndingReadingTextBox.Text, out double end))
            {
                EndingReadingTextBox.BackColor = Color.LightYellow;
                errorMessage += "Ending odometer must be a valid number";
            }
            else
            {
                EndingReadingTextBox.BackColor = Color.White;
            }
            if (begin >= end)
            {
                    BeginningReadingTextBox.BackColor = Color.LightYellow;
                    EndingReadingTextBox.BackColor = Color.LightYellow;
                errorMessage += "Ending odometer must be greater than Beginning odometer";
            }
            else
            {
                BeginningReadingTextBox.BackColor = Color.White;
                EndingReadingTextBox.BackColor = Color.White;
            }

            // Number of Days
            if (int.TryParse(NumberOfDaysTextBox.Text, out int days))
            {
                NumberOfDaysTextBox.BackColor = Color.LightYellow;
                errorMessage += "Number of days must be a valid number";
            }
            else
            {
                NumberOfDaysTextBox.BackColor = Color.White;
            }
            if (days < 1 || days > 45)
            {
                NumberOfDaysTextBox.BackColor = Color.LightYellow;
                errorMessage += "Number of days must be between 1 and 45";
            }
            else
            {
                NumberOfDaysTextBox.BackColor = Color.White;
            }

            return string.IsNullOrEmpty(errorMessage);
            // check all the fields for valid input, if any are invalid,
            // build an error message and return false, if all are valid return true
        }

        private double GetMilesDriven()
        {
            double beginning = double.Parse(BeginningReadingTextBox.Text);
            double ending = double.Parse(EndingReadingTextBox.Text);
            double miles = ending - beginning;
            // if kilometers is selected, convert miles to kilometers

            if (KilometersRadioButton.Checked)
                miles = KilometersToMiles(miles);

            return miles;
        }

        private double KilometersToMiles(double kilometers)
        {
            return kilometers * 0.621;
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

        private double CalculateDiscount(double baseCharge)
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
            if (AllFieldsValid(out string errorMessage))
            {
                MessageBox.Show("The following errors were found:\n" + errorMessage,
                                "Invalid Input", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

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
