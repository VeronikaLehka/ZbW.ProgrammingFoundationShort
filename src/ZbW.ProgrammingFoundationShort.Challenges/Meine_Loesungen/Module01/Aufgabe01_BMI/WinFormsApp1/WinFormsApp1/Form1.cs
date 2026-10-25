namespace WinFormsApp1
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void CmdCalc_Click(object sender, EventArgs e)
    {
      double weight;
      double height;
      double result;
      if (double.TryParse(TxtWeight.Text, out weight) && double.TryParse(TxtHeight.Text, out height))
      {
        result = weight / (height * height);
        LblResult.Text = $"Ihr BMI ist: {result:F2}";
      }
      else
      {
        MessageBox.Show("Bitte gültige Zahlen für Gewicht und Grösse eingeben!","Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}
