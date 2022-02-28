using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrundläggandeUppgifter
{
    class Funktioner
    {

        public String Namn;
        public String EfterNamn;
        public int Ålder;


        public void HelloWord()
        {
            Console.WriteLine("\"Hello World\"\n");
        }

        public void Användare()
        {
            Console.WriteLine("Förnamn");
            String fNamn = Console.ReadLine();

            Console.WriteLine("Efternamn");
            String eNamn = Console.ReadLine();

            Console.WriteLine("Ålder");
            int år = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{fNamn} {eNamn} {år.ToString()}\n");

        }

        public void Color()
        {
            string svar = "";



            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));

            ConsoleColor currentBackground = Console.BackgroundColor;
            ConsoleColor currentForeground = Console.ForegroundColor;



            foreach (var color in colors)
            {
                if (color == currentBackground) continue;

                Console.ForegroundColor = color;
                Console.WriteLine("   Textfärgen är {0}", color);
            }
            Console.WriteLine("För att ändra tillbaka färgen, enter");
            svar = Console.ReadLine();

            if (svar == "")
            {
                // Restore the foreground color.
                Console.ForegroundColor = currentForeground;



                // Restore the original console colors.
                Console.ResetColor();
                Console.WriteLine("\nUrsprungsfärg\n");

            }



        }
        public void Datum()
        {
            var dateTime = DateTime.Now;
            var onlyDate = dateTime.ToShortDateString();
            Console.WriteLine($"{ onlyDate}\n");
        }

        public void TvåTal()
        {
            Console.WriteLine("Skriv in tal 1");
            int tal1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Skriv in tal 2");
            int tal2 = Convert.ToInt32(Console.ReadLine());


            if (tal1 > tal2)
            {
                Console.WriteLine($"Det första talet med värdet { tal1} är störst");
            }
            else
            {
                Console.WriteLine($"Det andra talet med värdet { tal2} är störst\n");
            }
        }

        public void SlumpTal()
        {

            int antalGissningar = 0;
            Random r = new Random();
            int sTal = r.Next(1, 100);
            int aTal = 0;
            Console.WriteLine($"Gissa på ett tal mellan 1 och 100");
            Console.WriteLine(sTal);
            do
            {

                aTal = Convert.ToInt32(Console.ReadLine());
                antalGissningar++;

                if (aTal == sTal)

                    Console.WriteLine($"Du gissade rätt tal på {antalGissningar} försök");


                else if (aTal > sTal)
                {
                    Console.WriteLine("Gissa på ett lägre tal;");
                }


                else if (aTal < sTal)
                {
                    Console.WriteLine("Gissa på ett högre tal\n");

                }


            } while (aTal != sTal);
        }


        public void SkrivTillFil()
        {
            Console.WriteLine("Skriv en textrad");
            string text = Console.ReadLine();
            File.WriteAllText("textfil.txt", text);
            if (File.Exists("textfil.txt"))
            {
                Console.WriteLine("Filen med texten har sparats\n");

            }
        }

        public void LäsInFil()
        {
            Console.WriteLine("Här är innehållet från textfil.txt;");
            string filInnehåll = File.ReadAllText("textfil.txt");
            Console.WriteLine($"{filInnehåll}\n");
        }
        public decimal MatteTal(decimal tal)
        {

            /*  double d = Convert.ToDouble(tal);
            double rotenUr=(Math.Sqrt(d));
              double upphöjtTillTvå = Math.Pow(rotenUr, 2);
              double upphöjtTillTio = Math.Pow(upphöjtTillTvå, 10);
             decimal f = Convert.ToDecimal(upphöjtTillTio);

              return f;*/

            //Console.WriteLine("Ange ett decimaltal");
            // decimal tal = Convert.ToDecimal(Console.ReadLine());
            decimal d = (decimal)Math.Sqrt((double)tal);



            decimal upphöjtTillTvå = (decimal)Math.Pow((double)d, (double)2.0);
            decimal upphöjtTillTio = (decimal)Math.Pow((double)upphöjtTillTvå, (double)10.0);
            return upphöjtTillTio;



        }


    }
}
