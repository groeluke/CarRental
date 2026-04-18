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

            // customer Information cannot be blank if it is blank change color to light yellow
            if (CustomerNameTextBox.Text != "")
            {
                CustomerNameTextBox.BackColor = Color.White;
            }
            else
            {
                CustomerNameTextBox.BackColor = Color.LightYellow;
                isValid = false;
            }

            if (AddressTextBox.Text != "")
            {
                AddressTextBox.BackColor = Color.White;
            }
            else
            {
                AddressTextBox.BackColor = Color.LightYellow;
                isValid = false;
            }

            if (CityTextBox.Text != "")
            {
                CityTextBox.BackColor = Color.White;
            }
            else
            {
                CityTextBox.BackColor = Color.LightYellow;
                isValid = false;
            }

            if (StateTextBox.Text != "")
            {
                StateTextBox.BackColor = Color.White;
            }
            else
            {
                StateTextBox.BackColor = Color.LightYellow;
                isValid = false;
            }

            if (ZipCodeTextBox.Text != "")
            {
                ZipCodeTextBox.BackColor = Color.White;
            }
            else
            {
                ZipCodeTextBox.BackColor = Color.LightYellow;
                isValid = false;
            }

            try
            {
                if (int.Parse(BeginningReadingTextBox.Text) >= 0 &&
                    int.Parse(BeginningReadingTextBox.Text) < 
                    (int.Parse(EndingReadingTextBox.Text)))
                {
                    BeginningReadingTextBox.BackColor = Color.White;
                }
                else
                {
                    BeginningReadingTextBox.BackColor = Color.LightYellow;
                    isValid = false;
                }
            }
            catch (Exception)
            {
                BeginningReadingTextBox.BackColor = Color.LightYellow;
                isValid = false;
            }

            try
            {
                if (int.Parse(EndingReadingTextBox.Text) >= 0)
                {
                    EndingReadingTextBox.BackColor = Color.White;
                }
                else
                {
                    EndingReadingTextBox.BackColor = Color.LightYellow;
                    isValid = false;
                }
            }
            catch (Exception)
            {
                EndingReadingTextBox.BackColor = Color.LightYellow;
                isValid = false;
            }

            try
            {
                if (int.Parse(NumberOfDaysTextBox.Text) >= 1 &&
                    int.Parse(NumberOfDaysTextBox.Text) <= 45)
                {
                    NumberOfDaysTextBox.BackColor = Color.White;
                }
                else
                {
                    NumberOfDaysTextBox.BackColor = Color.LightYellow;
                    isValid = false;
                }
            }
            catch (Exception)
            {
                NumberOfDaysTextBox.BackColor = Color.LightYellow;
                isValid = false;
            }
            return isValid;
            // check if all the fields are valid, if not change the background color
            // to light yellow
        }

        private bool ErrorInputMessages()
        {
            bool isValid = true;
            string errorMessage = "";

            if (CustomerNameTextBox.Text == "")
            {
                errorMessage += "Please enter a valid customer name.\n";
            }
            if (AddressTextBox.Text == "")
            {
                errorMessage += "Please enter a valid address.\n";
            }
            if (CityTextBox.Text == "")
            {
                errorMessage += "Please enter a valid city.\n";
            }
            if (StateTextBox.Text == "")
            {
                errorMessage += "Please enter a valid state.\n";
            }
            if (ZipCodeTextBox.Text == "")
            {
                errorMessage += "Please enter a valid zip code.\n";
            }

            try
            {
                if (int.Parse(BeginningReadingTextBox.Text) < 0 || 
                    int.Parse(BeginningReadingTextBox.Text) 
                    > (int.Parse(EndingReadingTextBox.Text)))
                {
                    errorMessage += "Please enter a valid beginning odometer reading" +
                        "that is less than or equal to the ending odometer reading.\n";
                }
            }
            catch (Exception)
            {
                errorMessage += "Please enter a valid beginning odometer reading that " +
                    "is less than or equal to the ending odometer reading.\n";
            }

            try
            {

                if (int.Parse(EndingReadingTextBox.Text) < 0)
                {
                    errorMessage += "Please enter a valid ending odometer reading.\n";
                }

            }
            catch (Exception)
            {
                errorMessage += "Please enter a valid ending odometer reading.\n";
            }

            try
            {
                if (int.Parse(NumberOfDaysTextBox.Text) < 1 
                    || int.Parse(NumberOfDaysTextBox.Text) > 45)
                {
                    errorMessage += "Please enter a valid number of days (1-45).\n";
                }
            }
            catch (Exception)
            {
                errorMessage += "Please enter a valid number of days (1-45).\n";
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage);
            }

            return isValid;
            // check if all the fields are valid, if not display a message box with the errors
        }

        double GetMilesDriven()
        {
            double beginning = double.Parse(BeginningReadingTextBox.Text);
            double ending = double.Parse(EndingReadingTextBox.Text);
            double miles = ending - beginning;

            if (KilometersRadioButton.Checked)
                miles = KilometersToMiles(miles);

            return miles;
            // calculate the miles driven based on the beginning and ending
            // odometer readings, if kilometers is selected, convert the miles
            // to miles using the kilometers to miles conversion method
        }

        double KilometersToMiles(double kilometers)
        {
            return kilometers * 0.621;
            // convertion of kilometers to miles, 1 kilometer = 0.621 miles
        }

        double CalculateDailyCharge(int days)
        {
            return days * 15.00;
            // calculate the daily charge based off the number of days
            // max of 45 days and $15 per day
        }

        double CalculateMileageCharge(double miles)
        {
            if (miles <= 200) return 0.0;

            double charge = 0.0;

            if (miles > 200)
            {
                double milesInMiddle = Math.Min(miles - 200, 300); 
                charge += milesInMiddle * 0.12;
            }

            if (miles > 500)
            {
                charge += (miles - 500) * 0.10;
            }

            return charge;
            // calculate the mileage charge based on the miles driven and the 
            // mileage charge per distance driven, 201 - 500 miles @ $0.12
            // Over 500 miles @ $0.10
        }

        double CalculateDiscount(double baseCharge)
        {
            double discount = 0.0;

            if (AAADiscountCheckBox.Checked)
                discount += 0.05;

            if (SeniorDiscountCheckBox.Checked)
                discount += 0.03;

            return baseCharge * discount;
            // calculate the total discount based on the selected discounts
            // and return the total discount amount to be subtracted from the base charge
            // AAA discount is 5% and senior discount is 3%
        }

        //Event handlers-------------------------------------------------------
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            AllFieldsValid();
            ErrorInputMessages();

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
            // enable the summary button after the first calculation
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
            // cleaer all the textboxes and reset all the options to default values
        }

        private void SummaryButton_Click(object sender, EventArgs e)
        {
            string summary = $"Total Customers: {totalCustomers}\n" +
                             $"Total Miles Driven: {totalMilesDriven:F1} mi\n" +
                             $"Total Charges: {totalCharges:C}";
            MessageBox.Show(summary, "Summary", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            // display a message box with the summary of total customers,
            // total miles driven, and total charges
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", 
                "Exit Confirmation", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            // confirm with the user if they want to exit the application
            // if they click yes, close the application, if they click no, 
            // send them back to the application
        }
    }
}
