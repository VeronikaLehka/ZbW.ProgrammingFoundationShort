namespace ZbW.ProgrammingFoundationShort.Lessons.Module02.Auftrag1_Notenrechner;

// ============================================================
// AUFTRAG 1 – Notenrechner (⭐ Einfach | ~15 Min.)
//
// Berechne eine Note anhand von Punkten mittels if/else-Kette.
//
// Anforderungen:
//   - TxtPunkte: Punktezahl (0–100) einlesen
//   - if/else-Kette:
//       90–100 → Note 6 / "Sehr gut"
//       75–89  → Note 5 / "Gut"
//       60–74  → Note 4 / "Genügend"
//       < 60   → Note 3 / "Ungenügend"
//   - Ergebnis in LblNote und LblBewertung anzeigen
// ============================================================

public partial class NotenrechnerForm : Form
{
  public NotenrechnerForm()
  {
    InitializeComponent();
  }

  private void CmdBerechnen_Click(object sender, EventArgs e)
  {
    // TODO 1: Punkte aus TxtPunkte lesen (int.TryParse)
    //         Bei ungültiger Eingabe: MessageBox anzeigen und return
    int punkte;
    if (!int.TryParse(TxtPunkte.Text, out punkte ))
    {
      MessageBox.Show("Falsche Eingabe!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
      return;
    }

    // TODO 2: if/else-Kette für Noten
    //         90-100 → Note 6 / "Sehr gut"
    //         75-89  → Note 5 / "Gut"
    //         60-74  → Note 4 / "Genügend"
    //         < 60   → Note 3 / "Ungenügend"
    if (punkte>=90)
    {
      LblNote.Text = ("Note 6 ");
      LblBewertung.Text = ("Sehr gut");
      return;
    }
    else if(punkte>=75 && punkte <90)
    {
      LblNote.Text = ("Note 5");
      LblBewertung.Text = ("Gut");
      return;
    }
    else if (punkte >= 60 && punkte < 75)
    {
      LblNote.Text = ("Note 4");
      LblBewertung.Text = ("Genügend");
      return;
    }
    else
    {
      LblNote.Text = ("Note 3");
      LblBewertung.Text = ("Ungenügend");
      return;
    }
    // TODO 3: LblNote.Text und LblBewertung.Text setzen
  }
}
