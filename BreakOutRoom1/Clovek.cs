namespace BreakOutRoom1
{


    //Upravte tridu Clovek tak, aby konstruktor vyhodil vyjimku, pokud jmeno neni platne (null nebo prazdny string)
    //nebo pokud tel cislo neni validni (zkontrolujte pocet cislic). Tip: Delku cisla zjistite zavolanim telCislo.ToString().Length.
    //Do metody Main doplnte blok try-catch, ktery uzivatele upozorni, pokud udela chybu
    //Muzete pouzit obecnou tridu Exception, nebo lepe specifickou ArgumentException

    internal class Clovek
    {
        public string Jmeno;
        public int TelCislo;

        public Clovek(string jmeno, int telCislo)
        {
            Jmeno = jmeno;
            if (string.IsNullOrWhiteSpace(Jmeno))
            {
                throw new Exception("Text nesmie byt null ani whitespace.");
            }
            return;


            TelCislo = telCislo;
            if (telCislo.ToString().Length != 9)
            {
                throw new Exception("Text nesmie byt null ani whitespace.");
            }

        }


        public string VypisJmenoACislo()
        {
            return $"{Jmeno}: {TelCislo}";
        }
    }


}
