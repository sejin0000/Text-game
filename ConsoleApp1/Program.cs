﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Reflection.Metadata;
using System.Threading;
using System.Xml.Linq;
class Program
{
    public static bool over = false;
    public static int pick;

    static void Main()
    {
        Scene scene = new Scene();  
        TextBot text = new TextBot();
        Console.SetWindowSize(42, 32);
        Console.Title = "TXET.rpg";

        do
        {
            scene.TitleScene();
            scene.NameScene();
            scene.BasicSettingScene();
            scene.MainScene();
        } while (!over);
    }
}