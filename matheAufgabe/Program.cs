// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int zahl1, zahl2, geschätzterWertI, ergebnis, richtigeAntwort = 0, falscheAntwort = 0;


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
for (int i = 0; i < 10; i++)
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







