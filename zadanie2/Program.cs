Console.Write("Podaj kierunek: ");
string kierunek = Console.ReadLine();

switch (kierunek)
{
    case "polnoc":
        Console.WriteLine("Wyruszasz w strone gor");
        break;
    
    case "poludnie":
        Console.WriteLine("Wyruszasz w strone pustyni");
        break;
    
    case "wschod":
        Console.WriteLine("Wyruszasz w strone lasu");
        break;
    
    case "zachod":
        Console.WriteLine("Wyruszasz w strone morza");
        break;

    default:
        Console.WriteLine("Nieznany kierunek");
        break;
}
