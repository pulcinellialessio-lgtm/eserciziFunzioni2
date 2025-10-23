namespace eserciziFunzioni2
{
    internal class Program
    {
        static bool sommaNumeriSpeciali(int Num)
        {
            if (Num % 3 == 0)
            {
                if (Num % 9 != 0)
                {
                    return true;
                }
            }

            return false;
        }
        static int sommaSpeciali()
        {
            int S = 0;

            for (int i = 0; i < 50; i++)
            {
                if (sommaNumeriSpeciali(i) == true)
                {
                    S = S + i;
                }
            }

            return S;
        }
        static int Fattoriale(int n)
        {
            int F = 1;

            for (int i = 1; i <= n; i++)
            {

                F = F * i;

            }
            return F;
        }
        static bool Fattoriale2(int numero)
        {
            if (numero % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static int sommaFattoriale()
        {
            int S = 0;

            for (int i = 1; i <= 10; i++)
            {
                if (Fattoriale2(i) == true)
                {
                    S = S + Fattoriale(i);
                }
            }
            return S;
        }
        static int sommaQuadrati()
        {
            int Somma = 0, e = 0;

            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 != 0)
                {
                    e = i * i;
                    Somma = Somma + e;
                }
            }
            return Somma;
        }
        static int differenza()
        {
            int Differenza = 0;

            Differenza = sommaFattoriale() - sommaQuadrati();

            return Differenza;
        }
        static bool ControlloPasw(string p)
        {
            if (p == "9857")
            {
                return true;
            }
            return false;
        }
        static bool contolloAccesso(string nome)
        {

            if (nome == "Marco" || nome == "Sara" || nome == "Tommaso")
            {
                return true;
            }
            return false;
        }
        static double calcoloPrezzo(int prezzo)
        {
           float sconto = 0;
            if (prezzo > 200)
            {
                sconto = prezzo * 30 / 100;
            }
            return sconto;
        }
        static double prezzoFinale(int prezzo)
        {
            double prezzoScontato = 0;
            prezzoScontato = prezzo - calcoloPrezzo(prezzo);
      
            return prezzoScontato;
        }
        static void Main(string[] args)
        {
            int r = sommaSpeciali();
            Console.WriteLine(r);

            int m = differenza();
            Console.WriteLine(m);

            Console.WriteLine("Dimmi in nome per l'accesso");
            string nome = Console.ReadLine();

            Console.WriteLine("Dimmi la pasword per l'accesso di 4 numeri");
            string p = Console.ReadLine();

            if (contolloAccesso(nome) == true && ControlloPasw(p) == true)
            {
                Console.WriteLine("Accesso concesso");
            }
            else
            {
                Console.WriteLine("Accesso negato");
            }

            Console.WriteLine("Dimmi il prezzo del prodotto");
            int prezzo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("il prezzo finale è " + prezzoFinale(prezzo));

        }
    }
}
