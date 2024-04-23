namespace BreakOutRoom1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  BreakOutRoom1();
           //  Hodina();

            Console.WriteLine("Program na vytvareni telefonniho seznamu");
            Console.WriteLine("========================================");
            Console.Write("Zadejte jmeno: ");
            string jmeno = Console.ReadLine();
            Console.Write("Zadejte telefonni cislo: ");
            string cislo = Console.ReadLine();

            Clovek prvniClovek = new Clovek(jmeno, int.Parse(cislo));
            prvniClovek.VypisJmenoACislo();

            Console.ReadLine();
        }

        private static void Hodina()
        {
            double cislo1 = 10.0;
            double cislo2 = 0.0;
            Console.WriteLine($"Vysledok delenia je {cislo1 / cislo2}");
            BezpecneDelenie podel = new BezpecneDelenie();

            try
            {
                podel.PodelCisla(cislo1, cislo2);
            }
            catch (Exception vynimka)
            {
                Console.WriteLine(vynimka);
            }

            /*
            Console.WriteLine("Zadaj prve cislo");
            string vstup = Console.ReadLine();
           // int cislo1 = 0;
            try 
            {
                cislo1 = int.Parse(vstup);

            }
            catch (Exception vynimka)
            {
                Console.WriteLine("Nezadal si spravny vstup.");
                Console.WriteLine(vynimka);
                Console.WriteLine(vynimka.Message);
                Console.ReadLine();
                return;
            }
            catch (FormatException vynimka)
            {
                Console.WriteLine("Nezadal si spravny format.");
                Console.WriteLine(vynimka);
                Console.ReadLine();
                return;
            }
            catch (OverflowException vynimka)
            {
                Console.WriteLine("Nezadal si spravny vstup.");
                Console.WriteLine(vynimka);
                return;
            }

            // int cislo1 = Int32.Parse(Console.ReadLine);

            Console.WriteLine("Zadaj druhe cislo");
            vstup = Console.ReadLine();
            int cislo2 = int.Parse(vstup);
            Console.WriteLine($"Vysledok delenia je {cislo1/cislo2}");
*/
        }

        private static void BreakOutRoom1()
        {
            Console.WriteLine("Hello, World!");
            //spocitat dni do dovolene. SPyata sa na den, mesiac, rok
            // potom sa spytat kolko dni zbyva do dovolene
            //
            Console.WriteLine("Kedy odchadzas na dovolenku?");
            Console.WriteLine("Zadaj den:");
            int den = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadaj mesiac:");
            int mesiac = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadaj rok:");
            int rok = int.Parse(Console.ReadLine());

            DateTime odjazdNaDovolenku = new DateTime(rok, mesiac, den);
            TimeSpan zbyvajuceDni = odjazdNaDovolenku - DateTime.Now;

            Console.WriteLine($"Do dovolenky ostava {zbyvajuceDni.Days} dni.");
        }
    }
}
