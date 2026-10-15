Console.WriteLine("Podaj ilosc punktow zycia: ");
int punktyZycia = int.Parse(Console.ReadLine());

Console.WriteLine("Czy bohater ma klucz? : ");
bool maKlucz = bool.Parse(Console.ReadLine());

Console.WriteLine("Czy bohater zna haslo? : ");
bool znaHaslo = bool.Parse(Console.ReadLine());

if (punktyZycia <= 0)
{
    Console.WriteLine("Bohater nie moze wejsc, poniewaz nie zyje.");
}
else if (punktyZycia > 0)
{
    if (maKlucz || znaHaslo)
    {
        Console.WriteLine("Bohater moze wejsc.");
    }
    else
    {
        Console.WriteLine("Bohater nie moze wejsc.");
    }
}
