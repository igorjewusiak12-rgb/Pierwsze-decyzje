Console.Write("Imie: ");
string imie = Console.ReadLine();

Console.Write("Ilosc zdrowia: ");
int iloscZdrowia = int.Parse(Console.ReadLine());

Console.Write("Poziom: ");
int poziom = int.Parse(Console.ReadLine());

Console.Write("Liczba mikstur: ");
int liczbaMikstur = int.Parse(Console.ReadLine());

Console.Write("Obrazenia: ");
int obrazenia = int.Parse(Console.ReadLine());

Console.Write("Mapa: ");
bool czyMapa = bool.Parse(Console.ReadLine());



Console.WriteLine("+====KARTA BOHATERA====+");
Console.WriteLine($"Imie: {imie}");
Console.WriteLine($"HP: {iloscZdrowia}");
Console.WriteLine($"Poziom: {poziom}");
Console.WriteLine($"DMG: {obrazenia}");
Console.WriteLine($"Liczba mikstur: {liczbaMikstur}");
Console.WriteLine($"Posiada mape: {czyMapa}");
Console.WriteLine("+=======================+");

Console.WriteLine("+====WYBOR AKCJI====+");
Console.WriteLine("1 - Wyrusz w podroz");
Console.WriteLine("2 - Ulecz sie");
Console.WriteLine("3 - Ulepsz swoje obrazenia");
Console.WriteLine("+===================+");

Console.Write("Wybierz akcje: ");
int wyborAkcji = int.Parse(Console.ReadLine());

switch (wyborAkcji)
{
    case 1:
        if (czyMapa && poziom >= 5)
        {
            Console.WriteLine("+============================+");
            Console.WriteLine("Twoj bohater wyrusza w podroz");
            Console.WriteLine("+============================+");

        }
        else if (czyMapa && poziom < 5)
        {
            Console.WriteLine("+=====================================================+");
            Console.WriteLine("Musisz miec przynajmniej 5 poziom by wyruszyc w podroz");
            Console.WriteLine("+=====================================================+");
        }
        else if (czyMapa == false)
        {
            Console.WriteLine("+========================================+");
            Console.WriteLine("Musisz posiadac mape by wyruszyc w podroz");
            Console.WriteLine("+========================================+");  
        }
        break;

    case 2:
        if (liczbaMikstur > 0 )
        {
            Console.WriteLine("+=======================+");
            Console.WriteLine("Twoj bohater uleczyl sie!");
            Console.WriteLine("-1 mikstura");
            liczbaMikstur = liczbaMikstur -1;
            Console.WriteLine("+=======================+");
        }
        else
        {
            Console.WriteLine("+===================+");
            Console.WriteLine("Nie posiadasz mikstur");
            Console.WriteLine("+===================+");
        }
        break;

    case 3:
        if (poziom>0)
        {
            Console.WriteLine("+=========================+");
            Console.WriteLine("Ulepszyles swoje obrazenia!");
            Console.WriteLine("-1 poziom");
            Console.WriteLine("+1 obrazenia");
            poziom = poziom -1;
            obrazenia = obrazenia + 1; 
            Console.WriteLine("+=========================+");
        }
        else
        {
            Console.WriteLine("+=========================================+");
            Console.WriteLine("Nie posiadasz wystarczajacej ilosci poziomu");
            Console.WriteLine("+=========================================+");
        }
        break;

    default:
        Console.WriteLine("+===================+");
        Console.WriteLine("Nie ma takiej akcji");
        Console.WriteLine("+===================+");
        break;

}
 