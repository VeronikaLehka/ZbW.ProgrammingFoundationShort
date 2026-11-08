namespace ZbW.ProgrammingFoundationShort.Lessons.Module03.Auftrag2_PasswortValidator;

// ============================================================
// AUFTRAG 2 – PasswortValidator (⭐⭐ Mittel | ~30 Min.)
//
// Validiert ein Passwort und fordert erneute Eingabe per do-while.
//
// Anforderungen:
//   - do-while-Schleife: solange Passwort ungültig
//   - gültig: mindestens 8 Zeichen UND mindestens eine Ziffer
//   - Ziffer mit foreach über die Zeichen + char.IsDigit(...) suchen
//   - Fehlermeldung: was fehlt
// ============================================================

public static class PasswortValidator
{
  public static void Start()
  {
    // TODO 1: string passwort; bool gueltig;
    //         do { ... } while (!gueltig);
    string passwort;
    bool gueltig = true;

    // TODO 2: In der Schleife Passwort einlesen (Console.ReadLine() ?? "")
    do
    {
      Console.Write("Passwort eingeben: ");
      passwort = Console.ReadLine() ?? "";

      // TODO 3: bool hatZiffer = false;
      //         foreach (char zeichen in passwort) → char.IsDigit(zeichen) prüfen

      bool hatZiffer = false;
      foreach (char zeichen in passwort)
      {
        if (char.IsDigit(zeichen))
        {
          hatZiffer = true;
          break;
        }
      }

      gueltig = hatZiffer && passwort.Length >= 8;

      // TODO 4: gueltig berechnen und konkrete Fehlermeldung ausgeben
      if (!gueltig)
      {
        Console.WriteLine("Ungültiges Passwort");

        if(passwort.Length < 8)
        {
          Console.WriteLine("Bitte mindestens 8 Zeichen eingeben.");
        }

        if (hatZiffer == false)
        {
          Console.WriteLine("Mindestens 1 Zahl erforderlich.");
        }
      }
    } while (gueltig != true );

    // TODO 5: Nach der Schleife Erfolgsmeldung ausgeben
    Console.WriteLine("Willkommen!");
  }
}
