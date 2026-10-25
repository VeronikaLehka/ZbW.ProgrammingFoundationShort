namespace WinFormsApp1
{
  partial class Form1
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
      LblWeight = new Label();
      LblHeight = new Label();
      TxtWeight = new TextBox();
      TxtHeight = new TextBox();
      LblKg = new Label();
      LblM = new Label();
      CmdCalc = new Button();
      LblResult = new Label();
      SuspendLayout();
      // 
      // LblWeight
      // 
      LblWeight.AutoSize = true;
      LblWeight.Location = new Point(51, 59);
      LblWeight.Name = "LblWeight";
      LblWeight.Size = new Size(65, 20);
      LblWeight.TabIndex = 0;
      LblWeight.Text = "Gewicht:";
      // 
      // LblHeight
      // 
      LblHeight.AutoSize = true;
      LblHeight.Location = new Point(49, 110);
      LblHeight.Name = "LblHeight";
      LblHeight.Size = new Size(60, 20);
      LblHeight.TabIndex = 1;
      LblHeight.Text = "Grösse: ";
      // 
      // TxtWeight
      // 
      TxtWeight.Location = new Point(159, 62);
      TxtWeight.Name = "TxtWeight";
      TxtWeight.Size = new Size(125, 27);
      TxtWeight.TabIndex = 2;
      // 
      // TxtHeight
      // 
      TxtHeight.Location = new Point(159, 107);
      TxtHeight.Name = "TxtHeight";
      TxtHeight.Size = new Size(125, 27);
      TxtHeight.TabIndex = 3;
      // 
      // LblKg
      // 
      LblKg.AutoSize = true;
      LblKg.Location = new Point(316, 62);
      LblKg.Name = "LblKg";
      LblKg.Size = new Size(25, 20);
      LblKg.TabIndex = 4;
      LblKg.Text = "kg";
      // 
      // LblM
      // 
      LblM.AutoSize = true;
      LblM.Location = new Point(319, 114);
      LblM.Name = "LblM";
      LblM.Size = new Size(22, 20);
      LblM.TabIndex = 5;
      LblM.Text = "m";
      // 
      // CmdCalc
      // 
      CmdCalc.Location = new Point(159, 179);
      CmdCalc.Name = "CmdCalc";
      CmdCalc.Size = new Size(150, 36);
      CmdCalc.TabIndex = 6;
      CmdCalc.Text = "BMI Berechnen";
      CmdCalc.UseVisualStyleBackColor = true;
      CmdCalc.Click += CmdCalc_Click;
      // 
      // LblResult
      // 
      LblResult.AutoSize = true;
      LblResult.Location = new Point(51, 272);
      LblResult.Name = "LblResult";
      LblResult.Size = new Size(12, 20);
      LblResult.TabIndex = 7;
      LblResult.Text = ".";
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 450);
      Controls.Add(LblResult);
      Controls.Add(CmdCalc);
      Controls.Add(LblM);
      Controls.Add(LblKg);
      Controls.Add(TxtHeight);
      Controls.Add(TxtWeight);
      Controls.Add(LblHeight);
      Controls.Add(LblWeight);
      Name = "Form1";
      Text = "BMI-Rechner";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label LblWeight;
    private Label LblHeight;
    private TextBox TxtWeight;
    private TextBox TxtHeight;
    private Label LblKg;
    private Label LblM;
    private Button CmdCalc;
    private Label LblResult;
  }
}
