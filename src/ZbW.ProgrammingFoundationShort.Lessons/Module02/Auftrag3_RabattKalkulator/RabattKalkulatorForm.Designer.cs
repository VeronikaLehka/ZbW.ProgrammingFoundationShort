namespace ZbW.ProgrammingFoundationShort.Lessons.Module02.Auftrag3_RabattKalkulator;

partial class RabattKalkulatorForm
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
    LblBetrag = new Label();
    TxtBetrag = new TextBox();
    GrpKundentyp = new GroupBox();
    RadNormal = new RadioButton();
    RadPremium = new RadioButton();
    RadVip = new RadioButton();
    ChkLehrling = new CheckBox();
    CmdBerechnen = new Button();
    LblErgebnis = new Label();
    GrpKundentyp.SuspendLayout();
    SuspendLayout();
    // 
    // LblBetrag
    // 
    LblBetrag.AutoSize = true;
    LblBetrag.Location = new Point(14, 27);
    LblBetrag.Name = "LblBetrag";
    LblBetrag.Size = new Size(97, 20);
    LblBetrag.TabIndex = 0;
    LblBetrag.Text = "Betrag (CHF):";
    // 
    // TxtBetrag
    // 
    TxtBetrag.Location = new Point(149, 23);
    TxtBetrag.Margin = new Padding(3, 4, 3, 4);
    TxtBetrag.Name = "TxtBetrag";
    TxtBetrag.Size = new Size(114, 27);
    TxtBetrag.TabIndex = 1;
    // 
    // GrpKundentyp
    // 
    GrpKundentyp.Controls.Add(RadNormal);
    GrpKundentyp.Controls.Add(RadPremium);
    GrpKundentyp.Controls.Add(RadVip);
    GrpKundentyp.Location = new Point(14, 67);
    GrpKundentyp.Margin = new Padding(3, 4, 3, 4);
    GrpKundentyp.Name = "GrpKundentyp";
    GrpKundentyp.Padding = new Padding(3, 4, 3, 4);
    GrpKundentyp.Size = new Size(251, 127);
    GrpKundentyp.TabIndex = 2;
    GrpKundentyp.TabStop = false;
    GrpKundentyp.Text = "Kundentyp";
    // 
    // RadNormal
    // 
    RadNormal.AutoSize = true;
    RadNormal.Checked = true;
    RadNormal.Location = new Point(11, 27);
    RadNormal.Margin = new Padding(3, 4, 3, 4);
    RadNormal.Name = "RadNormal";
    RadNormal.Size = new Size(114, 24);
    RadNormal.TabIndex = 0;
    RadNormal.TabStop = true;
    RadNormal.Text = "Normal (0%)";
    // 
    // RadPremium
    // 
    RadPremium.AutoSize = true;
    RadPremium.Location = new Point(11, 60);
    RadPremium.Margin = new Padding(3, 4, 3, 4);
    RadPremium.Name = "RadPremium";
    RadPremium.Size = new Size(131, 24);
    RadPremium.TabIndex = 1;
    RadPremium.Text = "Premium (10%)";
    // 
    // RadVip
    // 
    RadVip.AutoSize = true;
    RadVip.Location = new Point(11, 91);
    RadVip.Margin = new Padding(3, 4, 3, 4);
    RadVip.Name = "RadVip";
    RadVip.Size = new Size(93, 24);
    RadVip.TabIndex = 2;
    RadVip.Text = "VIP (20%)";
    // 
    // ChkLehrling
    // 
    ChkLehrling.AutoSize = true;
    ChkLehrling.Location = new Point(14, 207);
    ChkLehrling.Margin = new Padding(3, 4, 3, 4);
    ChkLehrling.Name = "ChkLehrling";
    ChkLehrling.Size = new Size(128, 24);
    ChkLehrling.TabIndex = 3;
    ChkLehrling.Text = "Lehrling (+5%)";
    // 
    // CmdBerechnen
    // 
    CmdBerechnen.Location = new Point(14, 247);
    CmdBerechnen.Margin = new Padding(3, 4, 3, 4);
    CmdBerechnen.Name = "CmdBerechnen";
    CmdBerechnen.Size = new Size(149, 37);
    CmdBerechnen.TabIndex = 4;
    CmdBerechnen.Text = "Berechnen";
    CmdBerechnen.Click += CmdBerechnen_Click;
    // 
    // LblErgebnis
    // 
    LblErgebnis.AutoSize = true;
    LblErgebnis.Location = new Point(14, 300);
    LblErgebnis.Name = "LblErgebnis";
    LblErgebnis.Size = new Size(0, 20);
    LblErgebnis.TabIndex = 5;
    // 
    // RabattKalkulatorForm
    // 
    AutoScaleDimensions = new SizeF(8F, 20F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(411, 419);
    Controls.Add(LblBetrag);
    Controls.Add(TxtBetrag);
    Controls.Add(GrpKundentyp);
    Controls.Add(ChkLehrling);
    Controls.Add(CmdBerechnen);
    Controls.Add(LblErgebnis);
    Margin = new Padding(3, 4, 3, 4);
    Name = "RabattKalkulatorForm";
    Text = "Rabatt-Kalkulator – Auftrag 3";
    GrpKundentyp.ResumeLayout(false);
    GrpKundentyp.PerformLayout();
    ResumeLayout(false);
    PerformLayout();
  }

  private Label LblBetrag;
  private TextBox TxtBetrag;
  private GroupBox GrpKundentyp;
  private RadioButton RadNormal;
  private RadioButton RadPremium;
  private RadioButton RadVip;
  private CheckBox ChkLehrling;
  private Button CmdBerechnen;
  private Label LblErgebnis;
}
