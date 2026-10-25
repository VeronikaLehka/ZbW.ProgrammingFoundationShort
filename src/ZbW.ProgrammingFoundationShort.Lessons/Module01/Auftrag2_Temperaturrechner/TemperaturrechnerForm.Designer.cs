namespace ZbW.ProgrammingFoundationShort.Lessons.Module01.Auftrag2_Temperaturrechner;

partial class TemperaturrechnerForm
{
  private System.ComponentModel.IContainer components = null;

  protected override void Dispose(bool disposing)
  {
    if (disposing && (components != null))
      components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    LblCelsius = new Label();
    TxtCelsius = new TextBox();
    CmdCelsiusToFahrenheit = new Button();
    LblFahrenheit = new Label();
    CmdFahrenheitToCelsius = new Button();
    TxtFahrenheit = new TextBox();
    SuspendLayout();
    // 
    // LblCelsius
    // 
    LblCelsius.AutoSize = true;
    LblCelsius.Location = new Point(14, 27);
    LblCelsius.Name = "LblCelsius";
    LblCelsius.Size = new Size(57, 20);
    LblCelsius.TabIndex = 0;
    LblCelsius.Text = "Celsius:";
    // 
    // TxtCelsius
    // 
    TxtCelsius.Location = new Point(137, 23);
    TxtCelsius.Margin = new Padding(3, 4, 3, 4);
    TxtCelsius.Name = "TxtCelsius";
    TxtCelsius.Size = new Size(137, 27);
    TxtCelsius.TabIndex = 1;
    // 
    // CmdCelsiusToFahrenheit
    // 
    CmdCelsiusToFahrenheit.Location = new Point(297, 21);
    CmdCelsiusToFahrenheit.Margin = new Padding(3, 4, 3, 4);
    CmdCelsiusToFahrenheit.Name = "CmdCelsiusToFahrenheit";
    CmdCelsiusToFahrenheit.Size = new Size(160, 33);
    CmdCelsiusToFahrenheit.TabIndex = 2;
    CmdCelsiusToFahrenheit.Text = "→ Fahrenheit";
    CmdCelsiusToFahrenheit.Click += CmdCelsiusToFahrenheit_Click;
    // 
    // LblFahrenheit
    // 
    LblFahrenheit.AutoSize = true;
    LblFahrenheit.Location = new Point(14, 80);
    LblFahrenheit.Name = "LblFahrenheit";
    LblFahrenheit.Size = new Size(80, 20);
    LblFahrenheit.TabIndex = 3;
    LblFahrenheit.Text = "Fahrenheit:";
    // 
    // CmdFahrenheitToCelsius
    // 
    CmdFahrenheitToCelsius.Location = new Point(297, 75);
    CmdFahrenheitToCelsius.Margin = new Padding(3, 4, 3, 4);
    CmdFahrenheitToCelsius.Name = "CmdFahrenheitToCelsius";
    CmdFahrenheitToCelsius.Size = new Size(160, 33);
    CmdFahrenheitToCelsius.TabIndex = 5;
    CmdFahrenheitToCelsius.Text = "→ Celsius";
    CmdFahrenheitToCelsius.Click += CmdFahrenheitToCelsius_Click;
    // 
    // TxtFahrenheit
    // 
    TxtFahrenheit.Location = new Point(137, 76);
    TxtFahrenheit.Margin = new Padding(3, 4, 3, 4);
    TxtFahrenheit.Name = "TxtFahrenheit";
    TxtFahrenheit.Size = new Size(137, 27);
    TxtFahrenheit.TabIndex = 4;
    // 
    // TemperaturrechnerForm
    // 
    AutoScaleDimensions = new SizeF(8F, 20F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(491, 133);
    Controls.Add(LblCelsius);
    Controls.Add(TxtCelsius);
    Controls.Add(CmdCelsiusToFahrenheit);
    Controls.Add(LblFahrenheit);
    Controls.Add(TxtFahrenheit);
    Controls.Add(CmdFahrenheitToCelsius);
    Margin = new Padding(3, 4, 3, 4);
    Name = "TemperaturrechnerForm";
    Text = "Temperaturrechner – Auftrag 2";
    ResumeLayout(false);
    PerformLayout();
  }

  private Label LblCelsius;
  private TextBox TxtCelsius;
  private Button CmdCelsiusToFahrenheit;
  private Label LblFahrenheit;
  private Button CmdFahrenheitToCelsius;
  private TextBox TxtFahrenheit;
}
