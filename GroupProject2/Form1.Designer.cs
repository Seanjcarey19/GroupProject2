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
    private void InitializeComponent() {
        labelTitle = new System.Windows.Forms.Label();
        labelHeight = new System.Windows.Forms.Label();
        labelFeet = new System.Windows.Forms.Label();
        labelInches = new System.Windows.Forms.Label();
        labelWeightPrompt = new System.Windows.Forms.Label();
        labelOutput = new System.Windows.Forms.Label();
        numericUpDownFeet = new System.Windows.Forms.NumericUpDown();
        numericUpDownInches = new System.Windows.Forms.NumericUpDown();
        textBoxWeight = new System.Windows.Forms.TextBox();
        textBoxResult = new System.Windows.Forms.TextBox();
        buttonCalculate = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)numericUpDownFeet).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDownInches).BeginInit();
        SuspendLayout();
        // 
        // labelTitle
        // 
        labelTitle.Font = new System.Drawing.Font("Segoe UI", 20F);
        labelTitle.Location = new System.Drawing.Point(325, 9);
        labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        labelTitle.Name = "labelTitle";
        labelTitle.Size = new System.Drawing.Size(275, 59);
        labelTitle.TabIndex = 0;
        labelTitle.Text = "BMI Calculator";
        // 
        // labelHeight
        // 
        labelHeight.Location = new System.Drawing.Point(244, 189);
        labelHeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        labelHeight.Name = "labelHeight";
        labelHeight.Size = new System.Drawing.Size(87, 49);
        labelHeight.TabIndex = 1;
        labelHeight.Text = "Height";
        // 
        // labelFeet
        // 
        labelFeet.Location = new System.Drawing.Point(152, 245);
        labelFeet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        labelFeet.Name = "labelFeet";
        labelFeet.Size = new System.Drawing.Size(68, 37);
        labelFeet.TabIndex = 2;
        labelFeet.Text = "Feet:";
        // 
        // labelInches
        // 
        labelInches.Location = new System.Drawing.Point(332, 251);
        labelInches.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        labelInches.Name = "labelInches";
        labelInches.Size = new System.Drawing.Size(78, 31);
        labelInches.TabIndex = 3;
        labelInches.Text = "Inches:";
        // 
        // labelWeightPrompt
        // 
        labelWeightPrompt.Location = new System.Drawing.Point(513, 251);
        labelWeightPrompt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        labelWeightPrompt.Name = "labelWeightPrompt";
        labelWeightPrompt.Size = new System.Drawing.Size(132, 41);
        labelWeightPrompt.TabIndex = 4;
        labelWeightPrompt.Text = "Weight(lbs):";
        // 
        // labelOutput
        // 
        labelOutput.Location = new System.Drawing.Point(401, 458);
        labelOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        labelOutput.Name = "labelOutput";
        labelOutput.Size = new System.Drawing.Size(67, 27);
        labelOutput.TabIndex = 5;
        labelOutput.Text = "BMI:";
        // 
        // numericUpDownFeet
        // 
        numericUpDownFeet.Location = new System.Drawing.Point(152, 295);
        numericUpDownFeet.Margin = new System.Windows.Forms.Padding(2);
        numericUpDownFeet.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
        numericUpDownFeet.Name = "numericUpDownFeet";
        numericUpDownFeet.Size = new System.Drawing.Size(116, 35);
        numericUpDownFeet.TabIndex = 6;
        // 
        // numericUpDownInches
        // 
        numericUpDownInches.Location = new System.Drawing.Point(332, 294);
        numericUpDownInches.Margin = new System.Windows.Forms.Padding(2);
        numericUpDownInches.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
        numericUpDownInches.Name = "numericUpDownInches";
        numericUpDownInches.Size = new System.Drawing.Size(116, 35);
        numericUpDownInches.TabIndex = 7;
        // 
        // textBoxWeight
        // 
        textBoxWeight.Location = new System.Drawing.Point(532, 294);
        textBoxWeight.Margin = new System.Windows.Forms.Padding(2);
        textBoxWeight.Name = "textBoxWeight";
        textBoxWeight.Size = new System.Drawing.Size(68, 35);
        textBoxWeight.TabIndex = 8;
        textBoxWeight.KeyPress += textBoxWeight_KeyPress;
        // 
        // textBoxResult
        // 
        textBoxResult.Location = new System.Drawing.Point(110, 501);
        textBoxResult.Margin = new System.Windows.Forms.Padding(2);
        textBoxResult.Name = "textBoxResult";
        textBoxResult.Size = new System.Drawing.Size(695, 35);
        textBoxResult.TabIndex = 9;
        textBoxResult.KeyPress += textBoxResult_KeyPress;
        // 
        // buttonCalculate
        // 
        buttonCalculate.Location = new System.Drawing.Point(364, 386);
        buttonCalculate.Margin = new System.Windows.Forms.Padding(2);
        buttonCalculate.Name = "buttonCalculate";
        buttonCalculate.Size = new System.Drawing.Size(139, 44);
        buttonCalculate.TabIndex = 10;
        buttonCalculate.Text = "Convert";
        buttonCalculate.UseVisualStyleBackColor = true;
        buttonCalculate.Click += buttonCalculate_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(935, 655);
        Controls.Add(buttonCalculate);
        Controls.Add(textBoxResult);
        Controls.Add(textBoxWeight);
        Controls.Add(numericUpDownInches);
        Controls.Add(numericUpDownFeet);
        Controls.Add(labelOutput);
        Controls.Add(labelWeightPrompt);
        Controls.Add(labelInches);
        Controls.Add(labelFeet);
        Controls.Add(labelHeight);
        Controls.Add(labelTitle);
        Margin = new System.Windows.Forms.Padding(2);
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)numericUpDownFeet).EndInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDownInches).EndInit();
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

    private System.Windows.Forms.NumericUpDown numericUpDownFeet;
    private System.Windows.Forms.NumericUpDown numericUpDownInches;
    private System.Windows.Forms.TextBox textBoxWeight;
    private System.Windows.Forms.TextBox textBoxResult;

    #endregion
}
