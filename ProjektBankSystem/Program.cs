namespace ProjektBankSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int antalförsök = 1;

            int[] PrivatKonto = [5000, 2000, 100000, 77, 550];
            int[] sparkapital = [10000, 100000, 10000000, 880];
            int[] Fond = [700000, 2000, 4000];
            int[] Kul = [30000, 10];
            int[] Femte = [9000000];

            while (true)
            {


                Console.WriteLine("Välkomen till den påhittade banken! Vänligen skriv in dinna inlognigsuppgifter så kan du vi börja.");
                int inlognig = AnvändarnaLogin();

                if (inlognig <= 5)
                {
                    antalförsök = 1;


                    string ValiMenyn = "0";

                    while (ValiMenyn != "4")
                    {

                        Console.WriteLine("1.Se dina konton och saldo ");
                        Console.WriteLine("2.Överföring mellan konton ");
                        Console.WriteLine("3.Ta ut pengar ");
                        Console.WriteLine("4.Logga ut");

                        ValiMenyn = Console.ReadLine();

                        switch (ValiMenyn)
                        {


                            case "1":


                                Console.WriteLine("Kont 1: " + PrivatKonto[inlognig]);

                                if (inlognig <= 3)
                                {
                                    Console.WriteLine("Kont 2: " + sparkapital[inlognig]);
                                }
                                if (inlognig <= 2)
                                {
                                    Console.WriteLine("Kont 3: " + Fond[inlognig]);
                                }
                                if (inlognig <= 1)
                                {

                                    Console.WriteLine("Kont 4: " + Kul[inlognig]);

                                }

                                if (inlognig == 0)
                                {

                                    Console.WriteLine("Kont 5: " + Femte[inlognig]);

                                }

                                TillBackaTillHuvudmenyn();

                                break;

                            case "2":



                                Console.WriteLine("Vilket konto vill du ta ifrån: Privatkonto || Sparkapital || Found ");
                                int val = CovertedMoney();

                                Console.WriteLine("Hur mycket vill du överföra");
                                int ConveteradTransaktion = CovertedMoney();

                                try
                                {

                                    while (true)
                                    {
                                        if (ConveteradTransaktion < 0)
                                        {

                                            Console.WriteLine("Går inte");
                                            break;

                                        }
                                        if (val == 1)
                                        {


                                            if (ConveteradTransaktion <= PrivatKonto[inlognig])
                                            {

                                                PrivatKonto[inlognig] = PrivatKonto[inlognig] - ConveteradTransaktion;

                                            }

                                            else
                                            {

                                                Console.WriteLine("Går inte");
                                                break;

                                            }
                                        }

                                        if (val == 2)
                                        {


                                            if (ConveteradTransaktion <= sparkapital[inlognig])
                                            {

                                                sparkapital[inlognig] = sparkapital[inlognig] - ConveteradTransaktion;

                                            }

                                            else
                                            {

                                                Console.WriteLine("Går inte");
                                                break;

                                            }
                                        }

                                        if (val == 3)
                                        {


                                            if (ConveteradTransaktion <= Fond[inlognig])
                                            {

                                                Fond[inlognig] = Fond[inlognig] - ConveteradTransaktion;

                                            }

                                            else
                                            {

                                                Console.WriteLine("Går inte");
                                                break;

                                            }
                                        }

                                        if (val == 4)
                                        {


                                            if (ConveteradTransaktion <= Kul[inlognig])
                                            {

                                                Kul[inlognig] = Kul[inlognig] - ConveteradTransaktion;

                                            }

                                            else
                                            {

                                                Console.WriteLine("Går inte");
                                                break;

                                            }
                                        }

                                        if (val == 5)
                                        {


                                            if (ConveteradTransaktion <= Femte[inlognig])
                                            {

                                                Femte[inlognig] = Femte[inlognig] - ConveteradTransaktion;

                                            }

                                            else
                                            {

                                                Console.WriteLine("Går inte");
                                                break;

                                            }
                                        }


                                        else if (val > 5 || val < 0)
                                        {

                                            Console.WriteLine("går inte");
                                            break;
                                        }

                                        Console.WriteLine("Väl till vilket annat konto");
                                        string ValAvKonto = Console.ReadLine();

                                        if (ValAvKonto == "1")
                                        {

                                            PrivatKonto[inlognig] = PrivatKonto[inlognig] + ConveteradTransaktion;

                                        }

                                        else if (ValAvKonto == "2")
                                        {

                                            sparkapital[inlognig] = sparkapital[inlognig] + ConveteradTransaktion;

                                        }
                                        else if (ValAvKonto == "3")
                                        {

                                            Fond[inlognig] = Fond[inlognig] + ConveteradTransaktion;

                                        }
                                        else if (ValAvKonto == "4")
                                        {

                                            Kul[inlognig] = Kul[inlognig] + ConveteradTransaktion;

                                        }
                                        else if (ValAvKonto == "5")
                                        {

                                            Femte[inlognig] = Femte[inlognig] + ConveteradTransaktion;

                                        }
                                        else
                                        {

                                            PrivatKonto[inlognig] = PrivatKonto[inlognig] + ConveteradTransaktion;

                                        }
                                        switch (val)
                                        {

                                            case 1: Console.WriteLine("PrivatKonto: " + PrivatKonto[inlognig]); break;
                                            case 2: Console.WriteLine("Sparkapital: " + sparkapital[inlognig]); break;
                                            case 3: Console.WriteLine("Fond: " + Fond[inlognig]); break;
                                            case 4: Console.WriteLine("Kul: " + Kul[inlognig]); break;
                                            case 5: Console.WriteLine("Femte: " + Femte[inlognig]); break;
                                        }
                                        switch (ValAvKonto)
                                        {

                                            case "1": Console.WriteLine("PrivatKonto: " + PrivatKonto[inlognig]); break;
                                            case "2": Console.WriteLine("Sparkapital: " + sparkapital[inlognig]); break;
                                            case "3": Console.WriteLine("Fond: " + Fond[inlognig]); break;
                                            case "4": Console.WriteLine("Kul: " + Kul[inlognig]); break;
                                            case "5" +
                                            "" +
                                            "":
                                                Console.WriteLine("Femte: " + Femte[inlognig]); break;

                                        }

                                        break;
                                    }




                                    TillBackaTillHuvudmenyn();
                                    break;
                                }
                                catch (IndexOutOfRangeException ex)
                                {
                                    PrivatKonto[inlognig] = PrivatKonto[inlognig] + ConveteradTransaktion;
                                    Console.WriteLine(ex.Message);
                                    break;
                                }

                            case "3":
                                Console.WriteLine("Vilket konto vill du ta ut pengar från?  Privatkonto || Sparkapital || Found ");

                                string val2 = Console.ReadLine();
                                int Deposit = CovertedMoney();

                                try
                                {

                                    switch (val2)
                                    {

                                        case "1":


                                            if (Deposit <= PrivatKonto[inlognig])
                                            {

                                                PrivatKonto[inlognig] = PrivatKonto[inlognig] - Deposit;

                                            }
                                            else
                                            {

                                                Console.WriteLine("Går inte");

                                            }
                                            break;

                                        case "2":

                                            if (Deposit <= sparkapital[inlognig])
                                            {

                                                sparkapital[inlognig] = sparkapital[inlognig] - Deposit;

                                            }
                                            else
                                            {

                                                Console.WriteLine("Går inte");

                                            }

                                            break;

                                        case "3":

                                            if (Deposit <= Fond[inlognig])
                                            {

                                                Fond[inlognig] = Fond[inlognig] - Deposit;

                                            }
                                            else
                                            {

                                                Console.WriteLine("Går inte");

                                            }

                                            break;
                                        case "4":

                                            if (Deposit <= Kul[inlognig])
                                            {

                                                Kul[inlognig] = Kul[inlognig] - Deposit;

                                            }
                                            else
                                            {

                                                Console.WriteLine("Går inte");

                                            }

                                            break;

                                        case "5":

                                            if (Deposit <= Femte[inlognig])
                                            {

                                                Femte[inlognig] = Femte[inlognig] - Deposit;

                                            }
                                            else
                                            {

                                                Console.WriteLine("Går inte");

                                            }

                                            break;

                                    }

                                    TillBackaTillHuvudmenyn();

                                }

                                catch
                                {

                                    break;

                                }

                                break;
                            case "4": Console.WriteLine("Du är utloggad"); break;
                            default: Console.WriteLine("Måste vara 1 till 4, inte mer eller mindre."); break;

                        }

                    }
                }

                else if (antalförsök == 3)
                {

                    Console.WriteLine("För många försök");
                    break;

                }

                else
                {
                    antalförsök++;
                    Console.WriteLine("lösenorde eller användra namn felaktigt");
                    Console.WriteLine("Du har " + (4 - antalförsök) + " försök kvar");
                }



            }



            static int AnvändarnaLogin()
            {

                string[] Users = { "Pepe The Frog", "Nigerisk Prins", "Gunila Dakilla", "Ann Alhgren", "Kim Nysim" };
                string[] Passwords = { "kek", "1234", "Sesam öppna dig", "2345", "2002" };
                Console.WriteLine("Användar");
                string UserLoggin = Console.ReadLine();
                Console.WriteLine("Lösenord");
                string RightPassword = Console.ReadLine();

                int Key = 100;

                if (Passwords[0] == RightPassword && UserLoggin == Users[0])
                {
                    Console.WriteLine("Välkomen in!");
                    Key = 0;
                }

                else if (Passwords[1] == RightPassword && UserLoggin == Users[1])
                {
                    Key = 1;

                }
                else if (Passwords[2] == RightPassword && UserLoggin == Users[2])
                {
                    Key = 2;

                }
                else if (Passwords[3] == RightPassword && UserLoggin == Users[3])
                {
                    Key = 3;

                }
                else if (Passwords[4] == RightPassword && UserLoggin == Users[4])
                {
                    Key = 4;

                }
                else
                {
                }
                return Key;

            }
            static int CovertedMoney()
            {

                string transaktion = Console.ReadLine();

                bool Heltal;
                int ConveteradTransaktion;
                Heltal = int.TryParse(transaktion, out ConveteradTransaktion);

                return ConveteradTransaktion;

            }

            static void TillBackaTillHuvudmenyn()
            {

                string LämnaLoop = "Hammster";

                while (LämnaLoop != "")
                {

                    Console.WriteLine("Tryck enter för att komma tillbaka till huvudmeny");
                    LämnaLoop = Console.ReadLine();

                }


            }



        }
    }
}
