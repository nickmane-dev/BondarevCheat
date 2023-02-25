using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BondarevCheat
{
    public class Module
    {
        public static Int32 Engine;
        public static Int32 Client;
        public static Memory Bondarev;
        public static void runModule()
        {
            try
            {
                Process DcordRU2 = Process.GetProcessesByName("csgo")[0];
                uint Boondarev = 100;
                Bondarev = new Memory("csgo");
                int KekLolOrbitol = 11;
                if (Boondarev != KekLolOrbitol)
                {
                }

                foreach (ProcessModule PrDiscord1 in DcordRU2.Modules)
                {
                    if (PrDiscord1.ModuleName == "client.dll")
                    {
                        string ggg = "ez";
                        string Bondarev = "I love this boy";
                        Client = (int)PrDiscord1.BaseAddress;
                        Console.WriteLine("work");
                    }
                }
            } catch
            {
                Console.WriteLine("Включите CS:GO, или сделайте панораму.");
            }
        }
    }
}
