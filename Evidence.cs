using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    class Evidence
    {
        List<Pojistenec> pojistenci = new List<Pojistenec>(); //Kolekce pojištěnců
        public void PridejPojistence() //Přidá nového pojištěnce do listu
        {
            Console.WriteLine("Zadejte jméno pojištěného");
            string jmeno = Console.ReadLine();
            Console.WriteLine("Zadejte příjmení");
            string prijmeni = Console.ReadLine();
            Console.WriteLine("Zadejte telefonní číslo");
            int telefon = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte věk");
            int vek = int.Parse(Console.ReadLine());

            Pojistenec pojistenec = new Pojistenec(jmeno, prijmeni, vek, telefon);
            pojistenci.Add(pojistenec);
            Console.WriteLine("Data byla uložena, pokračujte libovolnou klávesou");
        }

        public void VypisPojistence() //Vypíše všechny pojištěnce
        {
            if (pojistenci.Count > 0)
            {
                Console.WriteLine("Výpis pojištěných");
                foreach (Pojistenec pojistenec in pojistenci)
                {
                    Console.WriteLine(pojistenec.Jmeno + "   " + pojistenec.Prijmeni + "   " + pojistenec.Vek + "      " + pojistenec.Telefon);
                }
            }
            else
            {
                Console.WriteLine("V evidenci není žádný pojištěnec");
            }
        }
        public void VyhledatPojistence() //Vyhledá konkrétního pojištěnce
        {
            Console.WriteLine("Zadejte jméno pojištěného");
            string jmeno = Console.ReadLine();
            Console.WriteLine("Zadejte příjmení");
            string prijmeni = Console.ReadLine();
            var vysledek = pojistenci.Where(p => p.Jmeno == jmeno && p.Prijmeni == prijmeni).FirstOrDefault();

            Console.WriteLine(vysledek.ToString());
        }
    }
}
