using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrundläggandeUppgifter
{
    class Funktioner2
    {
        Random r = new Random();

        public void Multiplikation()
        {
            for (int tabell = 1; tabell <= 10; tabell++)
            {
                Console.Write($"\t{tabell}\t");

                for (int tal = 1; tal <= 10; tal++)
                {

                    Console.Write($"{tabell * tal}\t");



                }
                Console.WriteLine($"\n");
            }
        }

        public void TvåArrayer()
        {
            int slumptal = r.Next();
            int temp = 0;

            int[] array1 = new int[5];
            int[] array2 = new int[5];


            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = r.Next(1, 100);
            }

            for (int i = 0; i < array1.Length; i++)
            {

                Console.WriteLine(array1[i]);
            }
            Console.WriteLine();
            Array.Copy(array1, array2, 5);
            //Array.Sort(array2);

            for (int i = 0; i < array2.Length; i++)
            {
                for (int j = 0; j < array2.Length - 1; j++)
                {


                    if (array2[j] > array2[j + 1])
                    {
                        temp = array2[j + 1];
                        array2[j + 1] = array2[j];
                        array2[j] = temp;
                    }
                }
            }
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine(array2[i]
                    );
            }

            Console.WriteLine();
        }
        public void Palidrom()
        {


            Console.WriteLine("ord");
            string mainString = Console.ReadLine();

            string firstHalf = mainString.ToLower().Substring(0, mainString.Length / 2);
            char[] arr = mainString.ToCharArray();

            Array.Reverse(arr);

            string temp = new string(arr);
            string secondHalf = temp.ToLower().Substring(0, temp.Length / 2);

            if (firstHalf.Equals(secondHalf))

                Console.WriteLine("ordet är en palidrom");
            else
            {
                Console.WriteLine("ordet är inte en palidrom\n");
            }
        }


        public void TvåInputs()
        {
            Console.WriteLine("Skriv in tal 1");
            int tal1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Skriv in tal 2");
            int tal2 = Convert.ToInt32(Console.ReadLine());


            for (int i = tal1 + 1; i < tal2; i++)
            {

                Console.WriteLine($"{i.ToString()}\n");

            }
        }
        public void Värden()
        {

            // int userInput = 0;
            //  bool IsEven = userInput % 2 == 0;

            Console.WriteLine("Ange värden med komma mellan");
            String Input = Console.ReadLine();
            String Output = String.Join(",", Input
                .Split(',')
                .Select(x => int.Parse(x))
                .OrderBy(x => x));
            Console.WriteLine(Output);


            string[] words = Input.Split(',');

            int[] ints = words.Select(int.Parse).ToArray();
            // Console.WriteLine(String.Join(",", ints));
            String.Join(",", ints);

            Array.Sort(ints);

            Console.Write("Jämna tal\n");
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] % 2 == 0)
                    Console.WriteLine(ints[i]);
            }
            Console.Write("Udda tal\n");
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] % 2 == 1)
                    Console.WriteLine($"{ints[i]}\n");
            }

        }


        public void AdderaVärden2()
        {
            Console.WriteLine("skriv in en rad separerade");
            string rad = Console.ReadLine();

            string[] ord = rad.Split(',');
            int sum = 0;


            foreach (string o in ord)
            {
                int term = int.Parse(o);
                sum += term;
            }
            Console.WriteLine($"{ sum}\n");
        }

        public void Spel()
        {
            Uppg16 u = new Uppg16();

            Console.WriteLine("Ange spelarnamn");

            u.karaktärNamn = Console.ReadLine();
            Console.WriteLine("Ange spelarnamn2");
            u.motståndarNamn = Console.ReadLine();





            Console.WriteLine($"{u.karaktärNamn} har {u.Styrka}% styrka, { u.Hälsa}  % hälsa och  { u.Tur} % tur");
            Console.WriteLine($"{u.motståndarNamn} har {u.Styrka} { u.Hälsa}  % hälsa och  { u.Tur} % tur");





            //Uppg16 u=new Uppg16();

            //  Console.Write($"Karaktären heter {u.karaktärNamn}, har hälsan {u.Hälsa.ToString()} styrkan {u.Styrka} och tur {u.Tur}\n");
            //   Console.Write($"Motståndaren heter {u.motståndarNamn}har hälsan {u.Hälsa} styrkan {u.Styrka} och tur{u.Tur}");

        }




    }
}
