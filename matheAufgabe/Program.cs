using System;
using System.Diagnostics;

int s1=0, zahl1, zahl2, zufällig, geschätzterWertI, ergebnis, richtigeAntwort = 0, falscheAntwort = 0, rechnungenZahlI=0;

while (s1 < 1)
{
    Console.WriteLine("----------------------------------------------------");
    Console.WriteLine("Bitte schreiben Sie, wie viele Sie rechnen möchten");

    string rechnungenZahlS = Console.ReadLine();

    if (int.TryParse(rechnungenZahlS, out rechnungenZahlI))
    {
        s1++;
    }
    else
    {
        zahlenFormatErklarung();
    }
}

Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();
Random neueZahl = new Random();
zufällig = neueZahl.Next(0,3);

void zahlenFormatErklarung()
{
    Console.WriteLine("Der eingegebene Wert hat kein Zahlenformat.");
    Console.WriteLine("Bitte versuchen Sie es erneut.");
}
void ergebnisErklarung()

{
    Console.WriteLine("----------------------------------------------------");
    Console.WriteLine("Bitte schreiben Sie das Ergebnis der Operation unten");  
}
void ifMethod()
{
    //EndOfLoop:
    bool inputIsValid = false;
    while (!inputIsValid)
    { 
    string geschätzterWertS = Console.ReadLine();

    if (int.TryParse(geschätzterWertS, out geschätzterWertI))
    {
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
        inputIsValid= true;
        Console.Clear();
        Console.WriteLine("Bisher haben Sie {0} richtige, {1} falsche Antwort gegeben.", richtigeAntwort, falscheAntwort);
    }
    else
    {
        zahlenFormatErklarung();
        //goto EndOfLoop;

    }
}
}
void randomZahl()
{
    zahl1 = neueZahl.Next(0, 101);
    zahl2 = neueZahl.Next(0, 101);

}

for (int i = 0; i < rechnungenZahlI; i++)
    {
        zufällig = neueZahl.Next(0, 3);
    
    switch (zufällig)
        {
            case 0: // +
                randomZahl();
                ergebnis = zahl1 + zahl2;
                ergebnisErklarung();
                Console.Write(zahl1 + "+" + zahl2 + "=");
                ifMethod();
               
            break;


            case 1:// -
                randomZahl();
                ergebnis = zahl1 - zahl2;
                ergebnisErklarung();
                Console.Write(zahl1 + "-" + zahl2 + "=");
                ifMethod();

            break;

            case 2: // *
                zahl1 = neueZahl.Next(0, 13);
                zahl2 = neueZahl.Next(0, 13);
                ergebnis = zahl1 * zahl2;
                ergebnisErklarung();
                Console.Write(zahl1 + "x" + zahl2 + "=");
                ifMethod();
           break;

        }
    }
    stopwatch.Stop();
    Console.WriteLine("--------------------------------------");
    Console.WriteLine("Zeitaufwand: {0}", stopwatch.Elapsed.TotalSeconds);
    Console.WriteLine("---------------------------------------");









