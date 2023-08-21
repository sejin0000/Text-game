using System;
using System.Collections.Generic;
using System.Linq;
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
        Console.Title = "Txet rpg";


        Console.WriteLine(@"

    _____
___/   __)__
      (_____)
      (_____)
      (____)
---.__(___)

    ________
___/    ____)____
           ______)
          _______)
         _______)
---.__________)

    _____
___/   __)_______
         ________)
       __________)
      (____)
---.__(___)


");

        do
        {
            //scene.TitleScene();
            //scene.NameScene();
            //scene.BasicSettingScene();
            //scene.BasicItem();
            scene.MainScene();
            
        } while (!over);

    }
}