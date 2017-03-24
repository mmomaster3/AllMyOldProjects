using System.Collections;

namespace Engine_Brute
{
    public class Globals
    {

        public static string WorkStatus= "";

        public static int CountThreads = 0;

        public static bool SoundOn     = true;

        public static ArrayList Source = new ArrayList();
        public static ArrayList Proxy  = new ArrayList();

        public static string Delimiter = ";";
        public static int TypeProxy    = 1;
        public static int TimeOut      = 5000;

        public static int CountGood    = 0;
        public static int CountBad     = 0;
        public static int Pps          = 0;

    }
}
