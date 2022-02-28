using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrundläggandeUppgifter
{
    public class Program
    {
        
            static void Main(string[] args)
            {
                Funktioner f = new Funktioner();
                Funktioner2 f2 = new Funktioner2();
                Uppg16 u = new Uppg16();

                string val = "";
                do
                {


                    Console.WriteLine("Välkommen  till programmet\n\n");
                    Console.WriteLine("0. Avsluta programmet");
                    Console.WriteLine("1. Skriva ut Hello World");
                    Console.WriteLine("2. Skriva ut input från användaren?");
                    Console.WriteLine("3. Ändra färg på texten i konsolfönstret");
                    Console.WriteLine("4. Skriva ut dagens datum");
                    Console.WriteLine("5. Skriva ut det största av två värden");
                    Console.WriteLine("6. Gissa ett slumptal");
                    Console.WriteLine("7. Spara en textrad i en fil");
                    Console.WriteLine("8.Läsa in filen från textraden");
                    Console.WriteLine("9. Skicka in ett decimaltal och få roten ur upphöjt till två och upphöjt till 10");
                    Console.WriteLine("10. Skriva ut multiplikationstabell 1-10");
                    Console.WriteLine("11. Skapa två arrayer med slumpmässiga tal");
                    Console.WriteLine("12. Se om ett ord är ett palidrom?");
                    Console.WriteLine("13. Skriv ut siffror mellan 2 tal?");
                    Console.WriteLine("14. Skriva ut udda och jämna värden");
                    Console.WriteLine("15. Skriva in värden som sedan adderas");
                    Console.WriteLine("16. Karaktär och motståndare");
                    Console.WriteLine();

                    Console.WriteLine("Vilken funktionalitet vill du köra?\n");
                    val = Console.ReadLine();



                    if (val == "0")
                    {
                        Console.WriteLine("Programmet avslutas");

                    }


                    if (val == "1")
                    {
                        f.HelloWord();

                    }

                    if (val == "2")
                    {
                        f.Användare();

                    }

                    if (val == "3")
                    {
                        f.Color();

                    }
                    if (val == "4")
                    {
                        f.Datum();

                    }
                    if (val == "5")
                    {
                        f.TvåTal();

                    }
                    if (val == "6")
                    {
                        f.SlumpTal();

                    }
                    if (val == "7")
                    {
                        f.SkrivTillFil();
                    }
                    if (val == "8")
                    {
                        f.LäsInFil();
                    }
                    if (val == "9")
                    {
                        Console.WriteLine(f.MatteTal(6.5m));
                    }
                    if (val == "10")
                    {
                        f2.Multiplikation();
                    }

                    if (val == "11")
                    {
                        f2.TvåArrayer();
                    }
                    if (val == "12")
                    {
                        f2.Palidrom();
                    }
                    if (val == "13")
                    {
                        f2.TvåInputs();
                    }
                    if (val == "14")
                    {
                        f2.Värden();
                    }

                    if (val == "15")
                    {


                        f2.AdderaVärden2();
                    }
                    if (val == "16")
                    {


                        f2.Spel();
                    }
                } while (val != "0");

                Console.ReadLine();


            }
        }
    }





    

