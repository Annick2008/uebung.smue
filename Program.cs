using uebung.smue;

Auto a1 = new Auto();
a1.Marke = "BMW";
a1.Modell = "M5 Competition";
a1.Hoehe = 2.56;
a1.Laenge = 4.89;
a1.AutoOffen();
a1.AutoZu();
a1.AutoOffen();

if(a1.AutoOffenZu ==  true)
{
    Console.WriteLine("Das Auto ist gerade aufgesperrt.");
}
else
{
    Console.WriteLine("Das Auto ist gerade zugesperrt.");
}

Console.WriteLine("Die Marke und das Modell des Autos heißen {0} {1}. Die Höhe ist {2} cm und die Breite ist " +
    "{3} cm", a1.Marke, a1.Modell, a1.Hoehe, a1.Laenge);
