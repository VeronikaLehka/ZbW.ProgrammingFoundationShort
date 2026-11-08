namespace ZbW.ProgrammingFoundationShort.Lessons.Module03.Auftrag1_Zahlenraten;

// ============================================================
// AUFTRAG 1 – Zahlenraten (⭐ Einfach | ~15 Min.)
//
// Das Programm generiert eine Zufallszahl und der Benutzer
// versucht sie zu erraten.
//
// Anforderungen:
//   - Random-Zahl zwischen 1 und 100 generieren
//   - while-Schleife bis geraten
//   - Hinweise: "Zu klein" / "Zu gross"
//   - Versuchszähler und Glückwunsch am Ende
// ============================================================

public static class Zahlenraten
{
  public static void Start()
  {
    // TODO 1: Random-Objekt erstellen, Zufallszahl 1-100 generieren
    var random = new Random();


    // TODO 2: Variablen für Versuchszähler und geraten-Flag
    int counter = 0;
    int geheimzahl = random.Next(1, 101);
    bool istGeraten = false;

    // TODO 3: while-Schleife (!geraten)
    //         - Eingabe lesen
    //         - int.TryParse prüfen
    //         - Hinweis ausgeben (zu klein / zu gross / richtig)
    //         - Versuchszähler erhöhen
    Console.WriteLine("Zahlenraten (1 bis 100)");

    while (!istGeraten)
    {
      Console.WriteLine("Deine Zahl zwischen 1 - 100: ");
      string eingabe = Console.ReadLine() ?? "";

      if (!int.TryParse(eingabe, out int zahl))
      {
        Console.WriteLine("Bitte eine ganze Zahl eingeben.");
        continue;
      }

      counter++;

      if (zahl < geheimzahl)
      {
        Console.WriteLine("Deine Zahl ist kleiner als Geheimzahl.");
        counter++;
      }
      else if (zahl > geheimzahl)
      {
        Console.WriteLine("Deine Zahl ist grösser als Geheimzahl.");
        counter++;
      }
      // TODO 4: Glückwunsch mit Anzahl Versuche ausgeben
      else
      {
        Console.WriteLine($"Glückwunsch! Du hast die Geheimzahl {geheimzahl} in {counter} Versuche erraten. ");
      }
    }
  }
}
