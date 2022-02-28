using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrundläggandeUppgifter
{
    public class Uppg16 { 
    Random m = new Random();

    /*
   private static readonly  Random random = new Random();
    private static readonly object syncLock = new object();

    public static int RandomNumber(int min, int max)
        {
        lock (syncLock)
        {
            return random.Next(min, max);
        }
    }*/


    public String karaktärNamn { get; set; }
    public String motståndarNamn { get; set; }


    public int Hälsa { get { return m.Next(1, 100); } }
    public int Styrka { get { return m.Next(1, 100); } }
    public int Tur { get { return m.Next(1, 100); } }

    public Uppg16() { }


    public Uppg16(string kNamn, string mNamn)
    {
        this.karaktärNamn = kNamn;
        this.motståndarNamn = mNamn;


    }


}
}



