namespace GroupProject2;

public partial class Form1 : Form {
    public Form1() {
        InitializeComponent();
        textBoxInches.KeyPress += new KeyPressEventHandler(textBoxInches_KeyPress);
    }

    private void buttonCalculate_Click(object sender, EventArgs e) {
        if (!double.TryParse(textBoxFeet.Text, out double feet) || feet < 0 || feet > 10) {
            textBoxResult.Text = "Enter feet between 0 and 10";
            return;
        }

        if (!double.TryParse(textBoxInches.Text, out double inches) || inches < 0 || inches > 12) {
            textBoxResult.Text = "Enter inches between 0 and 12";
            return;
        }

        if (!double.TryParse(textBoxWeight.Text, out double weight) || weight < 0 || weight > 800) {
            textBoxResult.Text = "Enter weight between 0 and 800";
            return;
        }

        double heightInches = feet * 12 + inches;
        double bmi = 703 * weight / (heightInches * heightInches);
        textBoxResult.Text = bmi.ToString();
    }

    private void textBoxFeet_KeyPress(object sender, KeyPressEventArgs e) {
        if (e.KeyChar == (char)Keys.Back)
            return;
        if (e.KeyChar == '.' && !textBoxFeet.Text.Contains('.'))
            return;
        if (e.KeyChar == '0' && textBoxFeet.SelectionStart == 0)
            e.Handled = true;
        else if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
            e.Handled = true;
    }

    private void textBoxInches_KeyPress(object sender, KeyPressEventArgs e) {
        if (e.KeyChar == (char)Keys.Back)
            return;
        if (e.KeyChar == '.' && !textBoxInches.Text.Contains('.'))
            return;
        if (e.KeyChar == '0' && !textBoxInches.Text.Contains('0'))
            return;
        if (e.KeyChar == '0' && textBoxInches.SelectionStart == 0)
            e.Handled = true;
        else if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
            e.Handled = true;
    }

    private void textBoxWeight_KeyPress(object sender, KeyPressEventArgs e) {
        if (e.KeyChar == (char)Keys.Back)
            return;
        if (e.KeyChar == '.' && !textBoxWeight.Text.Contains('.'))
            return;
        if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
            e.Handled = true;
    }

    private void textBoxResult_KeyPress(object sender, KeyPressEventArgs e) {
        if (e.KeyChar == (char)Keys.Back)
            return;
        else if (e.KeyChar == '.' && !textBoxResult.Text.Contains('.'))
            return;
        else if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
            e.Handled = true;
    }
}
