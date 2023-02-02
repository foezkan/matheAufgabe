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
        Console.WriteLine("Der eingegebene Wert hat kein Zahlenformat.");

    }
}




Stopwatch stopwatch = new Stopwatch();



//void wieViel()
//{
//    Console.WriteLine("----------------------------------------------------");
//    Console.WriteLine("Bitte schreiben Sie, wie viele Sie rechnen möchten");

//    string rechnungenZahlS = Console.ReadLine();

//    if (int.TryParse(rechnungenZahlS, out rechnungenZahlI))
//    {

//    }
//    else
//    {
//        Console.WriteLine("Der eingegebene Wert hat kein Zahlenformat.");
//        wieViel();
//    }
//}

Random neueZahl = new Random();
zufällig = neueZahl.Next(0,3);
stopwatch.Start();
for (int i = 0; i < rechnungenZahlI; i++)
{

    zufällig = neueZahl.Next(0, 3);
    switch (zufällig)
    {
        case 0: // +
            zahl1 = neueZahl.Next(0, 101);
            zahl2 = neueZahl.Next(0, 101);
            ergebnis = zahl1 + zahl2;
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Bitte schreiben Sie das Ergebnis der Operation unten");
            Console.Write(zahl1 + "+" + zahl2 + "=");

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
                Console.WriteLine("Bisher haben Sie {0} richtige, {1} falsche Antwort gegeben.", richtigeAntwort, falscheAntwort);
            
    }
            else
            {
                Console.WriteLine("Der eingegebene Wert hat kein Zahlenformat.");
                Console.WriteLine("Bitte versuchen Sie es erneut.");
                goto case 0;
            }
            break;
        case 1:// -
            zahl1 = neueZahl.Next(0, 101);
            zahl2 = neueZahl.Next(0, 101);
            ergebnis = zahl1 - zahl2;
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Bitte schreiben Sie das Ergebnis der Operation unten");
            Console.Write(zahl1 + "-" + zahl2 + "=");

            geschätzterWertS = Console.ReadLine();

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
                Console.WriteLine("Bisher haben Sie {0} richtige, {1} falsche Antwort gegeben.", richtigeAntwort, falscheAntwort);
            }
            else
            {
                Console.WriteLine("Der eingegebene Wert hat kein Zahlenformat.");
                Console.WriteLine("Bitte versuchen Sie es erneut.");
                goto case 1;
            }
            break;

        case 2: // *
            zahl1 = neueZahl.Next(0, 13);
            zahl2 = neueZahl.Next(0, 13);
            ergebnis = zahl1 * zahl2;
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Bitte schreiben Sie das Ergebnis der Operation unten");
            Console.Write(zahl1 + "x" + zahl2 + "=");

            geschätzterWertS = Console.ReadLine();

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
                Console.WriteLine("Bisher haben Sie {0} richtige, {1} falsche Antwort gegeben.", richtigeAntwort, falscheAntwort);
            }
            else
            {
                Console.WriteLine("Der eingegebene Wert hat kein Zahlenformat.");
                Console.WriteLine("Bitte versuchen Sie es erneut.");
                goto case 2;
            }
            break;

    }
}
    stopwatch.Stop();
    Console.WriteLine("--------------------------------------");
    Console.WriteLine("Zeitaufwand: {0}", stopwatch.Elapsed.TotalSeconds);
    Console.WriteLine("---------------------------------------");








