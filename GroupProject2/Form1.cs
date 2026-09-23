namespace GroupProject2;

public partial class Form1 : Form {
    public Form1() {
        InitializeComponent();
    }

    private void buttonCalculate_Click(object sender, EventArgs e) {
        double feet = (double)numericUpDownFeet.Value;
        double inches = (double)numericUpDownInches.Value;

        if (!double.TryParse(textBoxWeight.Text, out double weight) || weight < 0 || weight > 800) {
            textBoxResult.Text = "Enter weight between 0 and 800";
            return;
        }

        double heightInches = feet * 12 + inches;

        double bmi = 703 * weight / (heightInches * heightInches);
        textBoxResult.Text = bmi.ToString();
    }

    private void textBoxWeight_KeyPress(object sender, KeyPressEventArgs e) {
        if (e.KeyChar == (char)Keys.Back)
            return;
        if (e.KeyChar == '.' && !textBoxWeight.Text.Contains('.'))
            return;
        if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"\d+"))
            e.Handled = true;
    }

    private void textBoxResult_KeyPress(object sender, KeyPressEventArgs e) {
        if (e.KeyChar == (char)Keys.Back)
            return;
        else if (e.KeyChar == '.' && !textBoxResult.Text.Contains('.'))
            return;
        else if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"\d+"))
            e.Handled = true;
    }
}
