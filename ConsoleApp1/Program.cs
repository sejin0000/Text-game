using System;
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
        Console.SetCursorPosition(3, 11);
        Console.WriteLine(":..    .....   .:");
        Console.SetCursorPosition(3, 12);
        Console.WriteLine("':::..:::::::.:::");
        Console.SetCursorPosition(3, 13);
        Console.WriteLine("  '':::ㅇ:::ㅇ:: ");
        Console.SetCursorPosition(3, 14);
        Console.WriteLine("    .::::::::    ");
        Console.SetCursorPosition(3, 15);
        Console.WriteLine(" .::::::  ::::   ");
        Console.SetCursorPosition(3, 16);
        Console.WriteLine(":::::::::. ''    ");
        Console.SetCursorPosition(3, 17);
        Console.WriteLine("::::::::::::.    ");
        Console.SetCursorPosition(3, 18);
        Console.WriteLine("::::::::::::::   ");
        do
        {
            scene.TitleScene();
            scene.NameScene();
            scene.BasicSettingScene();
            scene.MainScene();
        } while (!over);
    }
}