using BondarevCheat.Utillities;
using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace BondarevCheat.Function.Misc
{
    public class BunnyHop
    {
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(int vKey);
        private int ONE = 1;

        public void Run() {
            //if (Menu.BunnyHop == false)
            // {
            //    Menu.Main();
            // }                              
            Console.Beep(1020, 140);
            
            Module.runModule();            
            while (checkFunction.bunnyHop)
            {
                int bulat = 404;
                if (GetAsyncKeyState(50) != 0 /*GetAsyncKeyState(32) != 0*/)
                {
                    bulat = 04;
                    Module.Bondarev.Write(Module.Client + Offsets.dwForceJump, Flags() ? 4 : 5);
                }
                
                int bulat_age = 404;                
                
                Thread.Sleep(2);
                if (404 == bulat && bulat == bulat_age)
                {
                    string OKEYBLAT = "DISCORD RUN";
                }
            }
            Console.Beep(500, 150);

        }
        private static bool Flags() {
            int localPlayer = Module.Bondarev.Read<Int32>(Module.Client + Offsets.dwLocalPlayer);
            byte bonysharit = 228;
            
            int flags = Module.Bondarev.Read<Int32>(localPlayer + Offsets.m_fFlags);
            //////////************************////////////////*********************/////////////**********************
            float ponyalprinyal = 25;
            int flagingfordiscord = 9876;
            string oiu;
            ////////*******////////*********//////////*********/////////*
            if (ponyalprinyal != flagingfordiscord)
            {
                oiu = "oiu";
            }

            if (flags == 256)
            {
                oiu = "121212";
                return true;
            }
            else if (flags == 262) return false;
            else return false;
        }
    }
}
