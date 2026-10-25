namespace ZbW.ProgrammingFoundationShort.Lessons.Module01.Auftrag2_Temperaturrechner;

// ============================================================
// AUFTRAG 2 – Temperaturrechner (⭐⭐ Mittel | ~30 Min.)
//
// Konvertiere Celsius ↔ Fahrenheit in einer WinForms-App.
//
// Anforderungen:
//   - Zwei TextBoxen (Celsius / Fahrenheit), je ein Button
//   - Formeln:  F = C × 9/5 + 32
//               C = (F − 32) × 5/9
//   - Ungültige Eingaben mit double.TryParse abfangen
//   - const double AbsoluteZero = -273.15 definieren
//     → Eingabe unter AbsoluteZero: Warnung anzeigen
// ============================================================

public partial class TemperaturrechnerForm : Form
{
  // TODO 1: Konstante für den absoluten Nullpunkt definieren
  private const double AbsoluteZero = -273.15;

  public TemperaturrechnerForm()
  {
    InitializeComponent();
  }

  // ── Celsius → Fahrenheit ────────────────────────────────────
  private void CmdCelsiusToFahrenheit_Click(object sender, EventArgs e)
  {
    double celsius;

    if (double.TryParse(TxtCelsius.Text, out celsius))
    {
      if (celsius < AbsoluteZero)
      {
        MessageBox.Show("Eingabe unter AbsoluteZero");
      }
    }
    else
    {
      MessageBox.Show("Ungültige Eingabe");
      TxtFahrenheit.Clear();
      return;
    }
    double fahrenheit = celsius * 9.0 / 5.0 + 32;
    TxtFahrenheit.Text = $"{fahrenheit:F2}";
  }

  // ── Fahrenheit → Celsius ────────────────────────────────────
  private void CmdFahrenheitToCelsius_Click(object sender, EventArgs e)
  {
    double celsius;
    double fahrenheit;

    if (double.TryParse(TxtFahrenheit.Text, out fahrenheit))
    {
      celsius = (fahrenheit - 32) * 5.0 / 9.0;
      if (celsius < AbsoluteZero)
      {
        MessageBox.Show("Eingabe unter AbsoluteZero");
      }
    }
    else
    { 
      MessageBox.Show("Ungültige Eingabe");
      TxtFahrenheit.Clear();
      return;
    }
    TxtCelsius.Text = $"{celsius:F2}";



    // TODO 8: Prüfen ob Ergebnis < AbsoluteZero → Warnung

    // TODO 9: Ergebnis in TxtCelsius anzeigen ($"{celsius:F2}")
  }
}
