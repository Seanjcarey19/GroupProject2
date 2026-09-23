namespace GroupProject2;

partial class Form1 {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
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
        labelTitle = new Label();
        labelHeight = new Label();
        labelFeet = new Label();
        labelInches = new Label();
        labelWeightPrompt = new Label();
        labelOutput = new Label();
        textBoxFeet = new TextBox();
        textBoxInches = new TextBox();
        textBoxWeight = new TextBox();
        textBoxResult = new TextBox();
        buttonCalculate = new Button();
        SuspendLayout();
        // 
        // labelTitle
        // 
        labelTitle.Font = new Font("Segoe UI", 20F);
        labelTitle.Location = new Point(152, 9);
        labelTitle.Margin = new Padding(2, 0, 2, 0);
        labelTitle.Name = "labelTitle";
        labelTitle.Size = new Size(275, 59);
        labelTitle.TabIndex = 0;
        labelTitle.Text = "BMI Calculator";
        // 
        // labelHeight
        // 
        labelHeight.Location = new Point(168, 57);
        labelHeight.Margin = new Padding(2, 0, 2, 0);
        labelHeight.Name = "labelHeight";
        labelHeight.Size = new Size(68, 20);
        labelHeight.TabIndex = 1;
        labelHeight.Text = "Height";
        // 
        // labelFeet
        // 
        labelFeet.Location = new Point(168, 84);
        labelFeet.Margin = new Padding(2, 0, 2, 0);
        labelFeet.Name = "labelFeet";
        labelFeet.Size = new Size(68, 26);
        labelFeet.TabIndex = 2;
        labelFeet.Text = "Feet:";
        // 
        // labelInches
        // 
        labelInches.Location = new Point(167, 141);
        labelInches.Margin = new Padding(2, 0, 2, 0);
        labelInches.Name = "labelInches";
        labelInches.Size = new Size(69, 28);
        labelInches.TabIndex = 3;
        labelInches.Text = "Inches:";
        // 
        // labelWeightPrompt
        // 
        labelWeightPrompt.Location = new Point(295, 60);
        labelWeightPrompt.Margin = new Padding(2, 0, 2, 0);
        labelWeightPrompt.Name = "labelWeightPrompt";
        labelWeightPrompt.Size = new Size(93, 29);
        labelWeightPrompt.TabIndex = 4;
        labelWeightPrompt.Text = "Weight(lbs):";
        // 
        // labelOutput
        // 
        labelOutput.Location = new Point(219, 277);
        labelOutput.Margin = new Padding(2, 0, 2, 0);
        labelOutput.Name = "labelOutput";
        labelOutput.Size = new Size(67, 27);
        labelOutput.TabIndex = 5;
        labelOutput.Text = "BMI:";
        // 
        // textBoxFeet
        // 
        textBoxFeet.Location = new Point(168, 112);
        textBoxFeet.Margin = new Padding(2);
        textBoxFeet.Name = "textBoxFeet";
        textBoxFeet.Size = new Size(68, 27);
        textBoxFeet.TabIndex = 6;
        textBoxFeet.KeyPress += textBoxFeet_KeyPress;
        // 
        // textBoxInches
        // 
        textBoxInches.Location = new Point(167, 171);
        textBoxInches.Margin = new Padding(2);
        textBoxInches.Name = "textBoxInches";
        textBoxInches.Size = new Size(68, 27);
        textBoxInches.TabIndex = 7;
        textBoxInches.KeyPress += textBoxInches_KeyPress;
        // 
        // textBoxWeight
        // 
        textBoxWeight.Location = new Point(295, 91);
        textBoxWeight.Margin = new Padding(2);
        textBoxWeight.Name = "textBoxWeight";
        textBoxWeight.Size = new Size(68, 27);
        textBoxWeight.TabIndex = 8;
        textBoxWeight.KeyPress += textBoxWeight_KeyPress;
        // 
        // textBoxResult
        // 
        textBoxResult.Location = new Point(218, 306);
        textBoxResult.Margin = new Padding(2);
        textBoxResult.Name = "textBoxResult";
        textBoxResult.Size = new Size(68, 27);
        textBoxResult.TabIndex = 9;
        textBoxResult.KeyPress += textBoxResult_KeyPress;
        // 
        // buttonCalculate
        // 
        buttonCalculate.Location = new Point(184, 231);
        buttonCalculate.Margin = new Padding(2);
        buttonCalculate.Name = "buttonCalculate";
        buttonCalculate.Size = new Size(139, 44);
        buttonCalculate.TabIndex = 10;
        buttonCalculate.Text = "Convert";
        buttonCalculate.UseVisualStyleBackColor = true;
        buttonCalculate.Click += buttonCalculate_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(533, 433);
        Controls.Add(buttonCalculate);
        Controls.Add(textBoxResult);
        Controls.Add(textBoxWeight);
        Controls.Add(textBoxInches);
        Controls.Add(textBoxFeet);
        Controls.Add(labelOutput);
        Controls.Add(labelWeightPrompt);
        Controls.Add(labelInches);
        Controls.Add(labelFeet);
        Controls.Add(labelHeight);
        Controls.Add(labelTitle);
        Margin = new Padding(2);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button buttonCalculate;

    private System.Windows.Forms.Label labelTitle;
    private System.Windows.Forms.Label labelHeight;
    private System.Windows.Forms.Label labelFeet;
    private System.Windows.Forms.Label labelInches;
    private System.Windows.Forms.Label labelWeightPrompt;
    private System.Windows.Forms.Label labelOutput;

    private System.Windows.Forms.TextBox textBoxFeet;
    private System.Windows.Forms.TextBox textBoxInches;
    private System.Windows.Forms.TextBox textBoxWeight;
    private System.Windows.Forms.TextBox textBoxResult;

    #endregion
}
