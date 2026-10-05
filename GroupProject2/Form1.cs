namespace GroupProject2;

public partial class Form1 : Form {
    public Form1() {
        InitializeComponent();
    }

    private void buttonCalculate_Click(object sender, EventArgs e) {
        double feet = (double)numericUpDownFeet.Value;
        double inches = (double)numericUpDownInches.Value;

        if (double.TryParse(textBoxWeight.Text, out double weight) && weight > 0 && weight <= 800) {
            double heightInches = feet * 12 + inches;
            if (heightInches <= 0) {
                MessageBox.Show("Invalid input.");
                return;
            }

            double bmi = 703 * weight / (heightInches * heightInches);
            textBoxResult.Text = bmi.ToString("0.##");

            if (bmi < 18.5) {
                txtCategory.Text = "You are underweight";
            }
            else if (bmi < 25) {
                txtCategory.Text = "You are in healthy weight";
            }
            else if (bmi < 30) {
                txtCategory.Text = "You are overweight";
            }
            else {
                txtCategory.Text = "You are in the obesity category";
            }
        }
        else {
            textBoxResult.Text = "Enter weight between 0 and 800";
            txtCategory.Text = "";
            MessageBox.Show("Invalid input.");
        }
    }

    private void textBoxWeight_KeyPress(object sender, KeyPressEventArgs e) {
        if (e.KeyChar == (char)Keys.Back)
            return;
        if (e.KeyChar == '.' && !textBoxWeight.Text.Contains('.'))
            return;
        if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"\d+"))
            e.Handled = true;
    }
}
