using System;
using System.Diagnostics;

int zahl1, zahl2, geschätzterWertI, ergebnis, richtigeAntwort = 0, falscheAntwort = 0, rechnungenZahlI=0;

wieViel();
void wieViel()
{
    Console.WriteLine("----------------------------------------------------");
    Console.WriteLine("Bitte schreiben Sie, wie viele Sie rechnen möchten");

    string rechnungenZahlS = Console.ReadLine();

    if (int.TryParse(rechnungenZahlS, out rechnungenZahlI))
    {

    }
    else
    {
        Console.WriteLine("Der eingegebene Wert hat kein Zahlenformat.");
        wieViel();
    }


}


void neueZahlen()
{
    Random neueZahl = new Random();
    zahl1 = neueZahl.Next(0, 101);
    zahl2 = neueZahl.Next(0, 101);
    ergebnis = zahl1 - zahl2;
    Console.WriteLine("----------------------------------------------------");
    Console.WriteLine("Bitte schreiben Sie das Ergebnis der Operation unten");
    Console.Write(zahl1 + "-" + zahl2 + "=");

    string geschätzterWertS = Console.ReadLine();

    if (int.TryParse(geschätzterWertS, out geschätzterWertI))
    {

    }
    else
    {
        Console.WriteLine("Der eingegebene Wert hat kein Zahlenformat.");
    }


}



Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();

for (int i= 0; i < rechnungenZahlI; i++)
{

    neueZahlen();
    

    if (geschätzterWertI == ergebnis)
    {
        richtigeAntwort++;
        Console.WriteLine("Glückwunsch, richtige antwort");

    }
    else
    {
        falscheAntwort++;
        Console.WriteLine("Leider, falsche Antwort");

    }
    Console.WriteLine("Bisher haben Sie {0} richtige, {1} falsche Antwort gegeben.", richtigeAntwort, falscheAntwort);
}


stopwatch.Stop();
Console.WriteLine("--------------------------------------");
Console.WriteLine("Zeitaufwand: {0}", stopwatch.Elapsed);
Console.WriteLine("---------------------------------------");






