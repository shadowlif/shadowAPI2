﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace shadowAPI2TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            shadowAPI2.API.Init();

            System.Threading.Thread.Sleep(5000);
            bool state = true;

            shadowAPI2.Chat.SendChat("UTF8: äüéö <= Gehts? :>");
            while(true)
            {
                System.Threading.Thread.Sleep(3500);
            }

            //shadowAPI2.Chat.SendChat("/b Test");
            //shadowAPI2.Chat.SendChat("/b Test", 2);
            //shadowAPI2.Chat.SendChat("Test");
        }
    }
}
