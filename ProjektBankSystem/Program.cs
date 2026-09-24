namespace ProjektBankSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            int antalförsök = 1;
            
            while (true)
            {
               

                Console.WriteLine("Välkomen till den påhittade banken! Vänligen skriv in dinna inlognigsuppgifter så kan du vi börja.");
                //string InputPasword = Console.ReadLine();
                //string TestParsword = "1234";
                int inlognig = AnvändarnaLogin();
               
                if (inlognig <= 4)
                {
                    antalförsök = 1;
                    Console.WriteLine("Bank");

                        Meny();
                    

                }
                else if (antalförsök == 3)
                {

                    Console.WriteLine("förmånga fel försök");
                    break;
                }

                else 
                {
                    antalförsök++;
                    Console.WriteLine("lösenorde eller användra namn felaktigt");
                    Console.WriteLine("Du har "+ (4 - antalförsök) + " försök kvar");
                }
            
                

            }


            static void Meny() 
            {

                Console.WriteLine("1.Se dina konton och saldo ");
                Console.WriteLine("2.Överföring mellan konton ");
                Console.WriteLine("3.Ta ut pengar ");
                Console.WriteLine("4.Logga ut");
                
                string ValiMenyn = "0";
                while (ValiMenyn != "4")
                {
                    ValiMenyn = Console.ReadLine();

                    switch (ValiMenyn)
                    {

                        case "1": Console.WriteLine("!"); break;
                        case "2": Console.WriteLine("!!"); break;
                        case "3": Console.WriteLine("!!!"); break;
                        case "4": Console.WriteLine("Du är utloggad");  break;
                        default: Console.WriteLine("Måste vara 1 till 4, inte mer eller mindre."); break;

                    }

                }
            
            }

            static int AnvändarnaLogin() 
            {

                string[] Users = {"Nigerisk Prins", "Gunila Dakilla", "Ann Alhgren", "Pepe The Frog", "Kim Nysim" };
                string[] Passwords = { "1234", "Sesam öppna dig", "2345","kek" ,"2002" };
                //Console.WriteLine(Users[1]);
                //Console.WriteLine(Passwords[1]);
                Console.WriteLine("Användar");
                string UserLoggin = Console.ReadLine();
                Console.WriteLine("Lösenord");
                string RightPassword= Console.ReadLine();

                int Key = 100;

                if (Passwords[0] == RightPassword && UserLoggin == Users[0]) 
                {  
                    Console.WriteLine("Välkomen in!");
                    Key = 1;
                }

                else if (Passwords[1] == RightPassword && UserLoggin == Users[1]) 
                {
                    Key = 2;

                }
                else if (Passwords[2] == RightPassword && UserLoggin == Users[2])
                {
                    Key = 3;

                }
                else if (Passwords[3] == RightPassword && UserLoggin == Users[3])
                {
                    Key = 4;

                }
                else if (Passwords[4] == RightPassword && UserLoggin == Users[4])
                {
                    Key = 5;

                }
                else 
                { 
                }
                return Key;    
            
            }

           static int NigeriskPrinsMoney() 
            {

                int sparkapital = 1000000;
            
            return sparkapital;
            }

        }
    }
}
