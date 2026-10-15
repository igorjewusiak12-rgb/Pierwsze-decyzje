Console.Write("Podaj wiek: ");
int wiek = int.Parse(Console.ReadLine());

if (wiek<0)
{
    Console.WriteLine("niepoprawny wiek");
}
else if (wiek>=0 && wiek<=12)
{
    Console.WriteLine("dziecko");
}
else if (wiek>=13 && wiek<=17)
{
    Console.WriteLine("nastolatek");
}
else if (wiek>=18 && wiek<=64)
{
    Console.WriteLine("osoba dorosla");
}
else
{
    Console.WriteLine("senior");
}
