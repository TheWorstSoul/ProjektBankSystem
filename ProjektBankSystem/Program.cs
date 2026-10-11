namespace ProjektBankSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Felix Grähs SUT26

            int antalförsök = 1;

            /*Här har vi alla arrayer som innehåller användarnas olika bankkonton, 
             * jag har gjort så att den är en uppochner vänd pyramid eftersom då har alla olika antal konton. 
             * De är också i början så att de inte resetas när man loggar ut.*/

            float[] PrivatKonto = [5000, 2000, 100000, 77, 550];
            float[] sparkapital = [10000, 100000, 10000000, 880];
            float[] Fond = [700000, 2000, 4000];
            float[] Kul = [30000, 10];
            float[] Femte = [9000000];

            while (true)
            {


                /*När du loggar in kommer du till en annan bit av koden via en metod och jag förklarar mer om den vid dess del. 
             * Det viktiga här däremot är beroende på vem som loggar in, 
             * kommer man att få ett nummer mellan 0 till 4, 
             * detta nummer kommer senare att användas i de redan existerande arrayerna för att bestämma vems konton som kommer att visas.*/

                Console.WriteLine("Välkomen till den påhittade banken! Vänligen skriv in dinna inlognigsuppgifter så kan du vi börja.");
                int inlognig = AnvändarnaLogin();



                if (inlognig <= 5)
                {
                    antalförsök = 1;


                    string ValiMenyn = "0";

                    while (ValiMenyn != "4")
                    {

                        /*Sedan kommer man till menyn där man kan välja mellan 1 och 4. 
                         * Om du väljer 1,2 eller 3 kommer du vara kvar i en while loop, 
                         * medan om du väljer 4 slutar loopen. 
                         * Det är därför 4 är valet att logga ut.*/

                        Console.WriteLine("1.Se dina konton och saldo ");
                        Console.WriteLine("2.Överföring mellan konton ");
                        Console.WriteLine("3.Ta ut pengar ");
                        Console.WriteLine("4.Logga ut");

                        ValiMenyn = Console.ReadLine();

                        switch (ValiMenyn)
                        {


                            case "1":

                                /*Första valet är 1 vilket bara visar dina konton. 
                                 * Jag la till if inlognig <= 3 för att se till att den bara skriver ut kontona som finns. 
                                 * Detta handlar mest om att det ska se lite snyggt ut, 
                                 * mer än att vara optimalt. I slutet har vi en metod som tar tillbaka en till huvudmenyn, 
                                 * fast inte alls det enda den koden gör är att stoppa en från att komma tillbaka till huvudmenyn tills man har tyckt enter.*/

                                Console.WriteLine("Kont 1: " + PrivatKonto[inlognig] + "Kr");

                                if (inlognig <= 3)
                                {
                                    Console.WriteLine("Kont 2: " + sparkapital[inlognig] + "Kr");
                                }
                                if (inlognig <= 2)
                                {
                                    Console.WriteLine("Kont 3: " + Fond[inlognig] + "Kr");
                                }
                                if (inlognig <= 1)
                                {

                                    Console.WriteLine("Kont 4: " + Kul[inlognig] + "Kr");

                                }

                                if (inlognig == 0)
                                {

                                    Console.WriteLine("Kont 5: " + Femte[inlognig] + "Kr");

                                }

                                TillBackaTillHuvudmenyn();

                                break;

                            case "2":

                                Console.WriteLine();

                                Console.Write("Vilket konto vill du ta ifrån (använd siffror): || 1: Privatkonto ||");

                                /*Sedan i början av case 2 vilket är om man väljer 2 i menyn i början, har jag gjort samma sak som i case 1 för att detta ska se lite bättre ut. 
                                 * I de båda fallen finns inte inlognig <= 4 eftersom 4 är det högsta numret i arrayen och därav alltid synas ändå och därav är det onödigt att ha en till if. 
                                 * Att göra det snyggt syftar jag på att inte skriva konton som inte finns. 
                                 * Vilket hade varit mindre krävande att bara ha en text som ber en att välja ett konto ut av fem. 
                                 * Problemet däremot är att då står det att du kan välja ett konto som faktiskt inte finns för just den användaren. */

                                if (inlognig <= 3)
                                {

                                    Console.Write(" 2: Sparkapital ||");

                                }

                                if (inlognig <= 2)
                                {

                                    Console.Write(" 3: Found ||");

                                }

                                if (inlognig <= 1)
                                {

                                    Console.Write(" 4: Kulkontot ||");

                                }

                                if (inlognig == 0)
                                {

                                    Console.Write(" 5: InternatioinelFinaskontot ||");

                                }

                                Console.WriteLine();

                                /*Vid float val refererar vi till en annan metod som vars jobb är enbart att få koden att inte krascha, 
                                 * den fungerar genom att antingen går numret som användaren skriver in igenom eller så blir numret 0. 
                                 * När det kommer till val kommer 0 bara att avsluta detta case medan om det är i ConveteradTransaktion - 
                                 * kommer det att gå igenom men det kommer inte göra någon skadad eftersom den kommer att ta 0 - 
                                 * från ett konto och dra av 0 från ett annat vilket kommer att inte göra någon skada. 
                                 * Anledningen till att alla är float är för att man ska kunna ha decimaler om man skulle vilja det.*/


                                float val = CovertedMoney();

                                Console.WriteLine("Hur mycket vill du överföra");
                                float ConveteradTransaktion = CovertedMoney();

                                /*Jag valde att ha en try och cacth eftersom det hade varit mindre kod än att skriva fler if för scenarier - 
                                 * när användaren skriver in något som är utanför arrayen. 
                                 * Nu vet jag inte om try and cacth är mindre krävande än det jag först tänkte men det är mindre kod att skriva - 
                                 * och det får mig att använda något relativt nytt (för mig).*/

                                try
                                {

                                    /*Jag valde att ha while här eftersom jag vill kunna avbryta koden när jag vill eftersom kodens jobb här är att - 
                                     * överföra en summa från ett konto till ett annat, 
                                    * och här kan det ske en massa olika scenarier som måste stoppas. 
                                    * Det första som jag stoppar är att man inte kan skriva att man vill ta ut ett negativt tal eftersom - 
                                    * ett negativt tal i denna situation skulle ha resultatet att man skapar pengar från ingenstans. 
                                     * Eftersom det blir två minustecken på rad, vilket blir positivt.*/

                                    while (true)
                                    {
                                        if (ConveteradTransaktion < 0)
                                        {

                                            Console.WriteLine("Går inte");
                                            break;

                                        }
                                        if (val == 1)
                                        {

                                            /*En annan sak som koden stoppar är att man inte kan skriva ett nummer som är större än vad som finns på kontot. 
                                             * Jag stoppade detta genom att koden avbryts om talet är större än vad som finns på kontot.*/

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
                                        /*Här skriver den ut vad kontona ser ut efter man har överfört pengarna. 
                                         * De två switchstaserna som är baserade på de två tidigare valen.*/

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
                                            case "5": Console.WriteLine("Femte: " + Femte[inlognig]); break;

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

                                Console.Write("Vilket konto vill du ta ifrån (använd siffror): || 1: Privatkonto ||");

                                /*Här skriver jag ut kontona på samma sätt som innan.*/

                                if (inlognig <= 3)
                                {

                                    Console.Write(" 2: Sparkapital ||");

                                }

                                if (inlognig <= 2)
                                {

                                    Console.Write(" 3: Found ||");

                                }

                                if (inlognig <= 1)
                                {

                                    Console.Write(" 4: Kulkontot ||");

                                }

                                if (inlognig == 0)
                                {

                                    Console.Write(" 5: InternatioinelFinaskontot ||");

                                }

                                Console.WriteLine();

                                string val2 = Console.ReadLine();
                                Console.WriteLine("Hur mycket vill du ta ut?");
                                float Deposit = CovertedMoney();

                                /*Härskarlösenordet är nein!!! eftersom jag bara behövde det att vara bara vad som helst som inte var något än de existerande lösenorden, 
                                 * för att ironiskt nog ändras till ett av de existerande lösenord. 
                                 * Baserat på vilken användare som loggade in, är det switch satsen avgör vilket lösenord det blir.*/

                                string HärskarLösenordet = "NEIN!!!";

                                switch (inlognig)
                                {

                                    case 0: HärskarLösenordet = "kek"; break;
                                    case 1: HärskarLösenordet = "1234"; break;
                                    case 2: HärskarLösenordet = "Sesam öppna dig"; break;
                                    case 3: HärskarLösenordet = "2345"; break;
                                    case 4: HärskarLösenordet = "2002"; break;

                                }

                                Console.WriteLine("Skriv in ditt lösenord");

                                string Lösenord2 = Console.ReadLine();
                                while (true)
                                /*Om lösenorden stämmer överens så kommer man till en if som gör absolut ingenting alls, 
                                 * den som jobb är bara att finnas så att koden kan köra vanligt därefter. 
                                 * Men if behövs så att jag sedan kan ha else vilket vars jobb är att avbryta koden, 
                                 * och om den inte skulle göra det, gör den om deposit till 0 så inget kommer att hända i vilket fall som helst. 
                                 * Skulle nog bara behöva en av dem men det spelar ingen större roll.*/
                                {
                                    if (Lösenord2 == HärskarLösenordet)
                                    {

                                    }

                                    else
                                    {
                                        Deposit = 0;
                                        Console.WriteLine("fel lösenord");
                                        break;

                                    }

                                    /*Även här har vi en try och en catch, 
                                     * dess jobb är enbart att se till att man inte skriver något som är utanför arrayen.*/
                                    try
                                    {

                                        switch (val2)
                                        {

                                            case "1":


                                                if (Deposit <= PrivatKonto[inlognig] && Deposit > 0)
                                                {

                                                    PrivatKonto[inlognig] = PrivatKonto[inlognig] - Deposit;
                                                    Console.WriteLine(PrivatKonto[inlognig]);
                                                }
                                                else
                                                {

                                                    Console.WriteLine("Går inte");

                                                }
                                                break;

                                            case "2":

                                                if (Deposit <= sparkapital[inlognig] && Deposit > 0)
                                                {

                                                    sparkapital[inlognig] = sparkapital[inlognig] - Deposit;
                                                    Console.WriteLine(sparkapital[inlognig]);
                                                }
                                                else
                                                {

                                                    Console.WriteLine("Går inte");

                                                }

                                                break;

                                            case "3":

                                                if (Deposit <= Fond[inlognig] && Deposit > 0)
                                                {

                                                    Fond[inlognig] = Fond[inlognig] - Deposit;
                                                    Console.WriteLine(Fond[inlognig]);
                                                }
                                                else
                                                {

                                                    Console.WriteLine("Går inte");

                                                }

                                                break;
                                            case "4":

                                                if (Deposit <= Kul[inlognig] && Deposit > 0)
                                                {

                                                    Kul[inlognig] = Kul[inlognig] - Deposit;
                                                    Console.WriteLine(Kul[inlognig]);
                                                }
                                                else
                                                {

                                                    Console.WriteLine("Går inte");

                                                }

                                                break;

                                            case "5":

                                                if (Deposit <= Femte[inlognig] && Deposit > 0)
                                                {

                                                    Femte[inlognig] = Femte[inlognig] - Deposit;

                                                    Console.WriteLine(Femte[inlognig]);
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
                                        Console.WriteLine("går inte");
                                        break;

                                    }

                                    break;
                                }

                                break;

                            /*Det fjärde och sista caset är till för att logga ut. 
                             * Förklarade lite lätt hur den fungerade där uppe.*/
                            case "4": Console.WriteLine("Du är utloggad"); break;
                            default: Console.WriteLine("Måste vara 1 till 4, inte mer eller mindre."); break;

                        }

                    }
                }
                /*Detta är biten där om du försöker logga in för många gånger kommer antalet - 
                 * försök öka med 1 tills det kommer upp till 3 och då avbryts koden. 
                 * Antalet försök resetas till 1 varje gång man lyckas logga in.*/
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


            /*Här är bitten som sköter inloggningen. 
             * Den fungerar genom att jag har gjort två arrayer och sedan när man skriver in användarnamn och lösenord
             * ser den om de matchar med de två arrayerna och ger sedan ett nummer som sedan skickas tillbaka i koden, 
             * som avgör vem som är inloggad. Man skulle kunna göra om de två arrayarna till en tvådimensionell array men -
             * det har jag inte gjort eftersom jag har varit upptagen med annat. Denna biten av koden refereras bara en gång, 
             * men jag gillar att dela upp koden eftersom “jag tycker att” den blir mer hanterbar.*/

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
                    Console.WriteLine("Välkomen in!");
                    Key = 1;

                }
                else if (Passwords[2] == RightPassword && UserLoggin == Users[2])
                {
                    Console.WriteLine("Välkomen in!");
                    Key = 2;

                }
                else if (Passwords[3] == RightPassword && UserLoggin == Users[3])
                {
                    Console.WriteLine("Välkomen in!");
                    Key = 3;

                }
                else if (Passwords[4] == RightPassword && UserLoggin == Users[4])
                {
                    Console.WriteLine("Välkomen in!");
                    Key = 4;

                }

                return Key;

            }

            /*CovertedMoney började ut som bara något som jag använde när jag skulle överföra pengarna från ett konto till ett annat, 
             * eftersom jag inte ville att den skulle krascha så gjorde jag denna. 
             * Men jag märkte att man skulle kunna använda den vid flera tillfällen så jag gjorde om den till sin egen metod. 
             * Vilket har lett till att dennes namn inte riktigt passar längre. Hur som helst den fungerar genom att användaren får skriva i vad som helst, 
             * men bara nummer kommer att komma igenom. 
             * Om användaren skriver in något som inte är ett nummer kommer den att göras om till 0 vilket fungerar bra i de flesta fall. */
            static float CovertedMoney()
            {

                string transaktion = Console.ReadLine();

                bool Heltal;
                float ConveteradTransaktion;
                Heltal = float.TryParse(transaktion, out ConveteradTransaktion);

                return ConveteradTransaktion;

            }

            /*Har redan förklarat denna men allt den gör är att stoppa en från att komma till huvudmenyn. 
             * Men den är enkel så jag gör det igen. Jag har gjort en string som innehåller Hamster, 
             * detta är bara för att den måste innehålla vad som helst som inte är “”, 
             * för att det är det som jag gav som villkor för att lämna while loopen, vilket man bara kommer åt om man trycker på enter. */
            static void TillBackaTillHuvudmenyn()
            {

                string LämnaLoop = "Hamster";

                while (LämnaLoop != "")
                {

                    Console.WriteLine("Tryck enter för att komma tillbaka till huvudmeny");
                    LämnaLoop = Console.ReadLine();

                }

                

            }

        }

    }
}


        
    

