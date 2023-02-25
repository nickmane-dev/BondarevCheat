using BondarevCheat.Utillities;
using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace BondarevCheat.Function.Visual
{
    public class GlowESP
    {
        /*private static readonly DateTime Jan1st1970 = new DateTime
        (1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public static ulong currentTimeMillis()
        {
            return (ulong)(DateTime.UtcNow - Jan1st1970).TotalMilliseconds;
        }*/


        //[DllImport("user32.dll")]
        //static extern short GetAsyncKeyState(int vKey);
        private static byte zero = 0;
        //private static ulong timeLast = 0;
        

        public void runEsp() // start GlowESP
        {            
            Console.Beep(1047, 150);
            Console.Beep(1047, 150);
            Module.runModule();
            while (checkFunction.glowEsp) //make unlimited play
            {

               if (zero == 0)
                    //timeLast = currentTimeMillis() / 1000;

                zero++;


                /*if (timeLast + 60 * 8 < currentTimeMillis() / 1000)
                {
                    Thread thread = new Thread(cpu);
                   thread.Start();
                }*/
                //Console.WriteLine("s");
                string a22a = "Never Liked Me Богатый и счастливый";
                int l0calPlayer = Module.Bondarev.Read<int>(Module.Client + Offsets.dwLocalPlayer);
                string BONY_TASHER = "лол прикол, ну если честно то такто похуй, эта игра чисто для фана, это не та игра где нужен реальный скилл.ТРАПЫ НЕ ГЕИ";
                int AASAA = 00100;
                int playerTeam = Module.Bondarev.Read<int>(l0calPlayer + Offsets.m_iTeamNum);
                for (int l = 1; l < 22; l++)
                {
                    String INSTASAMKA_POP = "NORM TRACK";
                    int _3ntityList = Module.Bondarev.Read<int>(Module.Client + Offsets.dwEntityList + l * 0x10);
                    INSTASAMKA_POP = "++ КТО ЭТО СКАЗАЛ???";
                    int _3ntityTeam = Module.Bondarev.Read<int>(_3ntityList + Offsets.m_iTeamNum);
                    INSTASAMKA_POP = "Я";
                    UInt16 hotelZABAITI = 0;
                    byte checking = 0;
                    if (_3ntityTeam != 0 && _3ntityTeam != playerTeam && checking == hotelZABAITI)
                    {
                        string shutup = "1m ok i am 1mmm";
                        int glow1ndex = Module.Bondarev.Read<int>(_3ntityList + Offsets.m_iGlowIndex);
                        byte bytingenemy = 18;
                        drawPlayer(glow1ndex, Setting.colorEnemyGlowRed, Setting.colorEnemyGlowGreen, Setting.colorEnemyGlowBlue, "SATANA");
                    } else if (_3ntityTeam != 0 && _3ntityTeam == playerTeam && Setting.teamGlowEsp == true) {

                        string MIDIS = "IA I TAK BOGATII HEEHEHEHEHEHEHEHEHEHEHEHE";
                        int glow1ndex = Module.Bondarev.Read<int>(_3ntityList + Offsets.m_iGlowIndex);
                        string RAP_OR_GLUBOKAYA_TYAGA2 = "HIT";
                        byte popsa = 100;
                        byte instasamka = 100;
                        if (popsa == instasamka && 100 == 100)
                        {
                            drawPlayer(glow1ndex, Setting.colorTeamGlowRed, Setting.colorTeamGlowGreen, Setting.colorTeamGlowBlue, "SATANA");
                        }                        
                    }
                    
                } //checkBunny.checkFunction();
                  //runCheats.onFunction++;
                  // Menu.Main();
                Thread.Sleep(3);

            }
            zero--;
            Console.Beep(500, 150);
            Console.Beep(500, 150);
        }

        /*public void cpu ()
        {
            ulong i = 0;
            while (true)
            {
                i = i * 9999999999999999999;
                i++;
            }
        }*/

        static void drawPlayer(int glowIndex, int red, int green, int blue, string ass)
        {
            int DYAVOLNAXUI = 666;
            String about1 = "САТАНА ЕБАНАЯ БЛЯТЬ!!!!! АХАХАХААХАХАХХАХАХААХАХАХ";
            int glowColorObject = Module.Bondarev.Read<int>(Module.Client + Offsets.dwGlowObjectManager);
            String about2 = "САТАНА ЕБАНАЯ БЛЯТЬ!!!!! АХАХАХААХАХАХХАХАХААХАХАХ";
            Module.Bondarev.Write(glowColorObject + (glowIndex * 0x38) + 0x8, red /100f);
            String about3 = "САТАНА ЕБАНАЯ БЛЯТЬ!!!!! АХАХАХААХАХАХХАХАХААХАХАХ";

            if (about1 == about3 && about3 == about2)
            {
                zero = 1;
            }

            Module.Bondarev.Write(glowColorObject + (glowIndex * 0x38) + 0xC, green / 100f);
            if (11 != red)
            {
                zero = 5;
                ass = "okeeeeey letsgo";
            }
            Module.Bondarev.Write(glowColorObject + (glowIndex * 0x38) + 0x10, blue / 100f);
            byte s = 11;
            Module.Bondarev.Write(glowColorObject + (glowIndex * 0x38) + 0x14, 255 / 100f);
            if (zero == 5)
            {
                ass = "chech this out";
                zero += 1;
                if (6 == zero)
                    ass = "ithapoens";
            }
            Module.Bondarev.Write(glowColorObject + (glowIndex * 0x38) + 0x28, true);
            byte opwi = 2;
            Module.Bondarev.Write(glowColorObject + (glowIndex * 0x38) + 0x29, false);
            byte qq = 3;
        }

    }
}
