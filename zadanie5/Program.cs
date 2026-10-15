Console.Write("Podaj ilosc zdrowia: ");
int iloscZdrowia = int.Parse(Console.ReadLine());

Console.Write("Podaj podstawowe obrazenia broni: ");
int podstawoweObrazenia = int.Parse(Console.ReadLine());

Console.Write("Czy bohater ma miksture? : ");
bool posiadaMiksture = bool.Parse(Console.ReadLine());

Console.Write("Wybierz akcje: ");
int wyborAkcji = int.Parse(Console.ReadLine());

if (iloscZdrowia <= 0)
{
    Console.WriteLine("Przegrana");
}

switch (wyborAkcji)
{
    case 1:
        Console.WriteLine($"Obrazenia: {podstawoweObrazenia}");
        break;

    case 2:
        if (posiadaMiksture)
        {
            Console.WriteLine("Bohater leczy sie");
        }
        else
        {
            Console.WriteLine("Bohater nie posiada mikstury");
        }
        break;

    case 3:
        Console.WriteLine("Bohater ucieka");
        break;

    default:
        Console.WriteLine("Nieznana akcja");
        break;
}

if (iloscZdrowia>0 && iloscZdrowia<20)
{
    Console.WriteLine("Ostrzezenie: niski stan zdrowia");
}