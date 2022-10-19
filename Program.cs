using EvidencePojisteni;

var evidence = new Evidence();
bool pokracovat = true;
while (pokracovat == true)
{
    Console.WriteLine("Vyberte si akci:");
    Console.WriteLine("1 - Přidat nového pojištěnce");
    Console.WriteLine("2 - Vypsat všechny pojištěnce");
    Console.WriteLine("3 - Vyhledat pojištěného");
    Console.WriteLine("4 - Konec");
    string vstup = Console.ReadLine();
    int volba;
    if (int.TryParse(vstup, out volba) && volba > 0 && volba < 5)
    {
        switch (volba) //Hlavní menu
        {
            case 1:
                evidence.PridejPojistence();
                break;
            case 2:
                evidence.VypisPojistence();
                break;
            case 3:
                evidence.VyhledatPojistence();
                break;
            case 4:
                pokracovat = false; //Ukončí program
                break;
        }
    }
    else
    {
        Console.WriteLine("Neplatná akce, zvolte prosím číslo 1-4");
    }
}