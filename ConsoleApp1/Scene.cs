using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Scene
{
    public ItemDB itemDB = new ItemDB();
    TextBot bot = new TextBot();    
    Item item = new Item();

    
    public void MainPanel()
    {
        Console.SetCursorPosition(0, 1);
        Console.WriteLine(" ┌─────────────────────────────────────┐ ");
        Console.WriteLine(" │                                     │ ");
        Console.WriteLine(" │                                     │ ");
        Console.WriteLine(" │                                     │ ");
        Console.WriteLine(" │                                     │ ");
        Console.WriteLine(" │                                     │ ");
        Console.WriteLine(" │                                     │ ");
        Console.WriteLine(" │                                     │ ");
        Console.WriteLine(" │                                     │ ");
        Console.WriteLine(" │                                     │ ");
        Console.WriteLine(" │                                     │ ");
        Console.WriteLine(" │                                     │ ");
        Console.WriteLine(" │                                     │ ");
        Console.WriteLine(" │                                     │ ");
        Console.WriteLine(" │                                     │ ");
        Console.WriteLine(" │                                     │ ");
        Console.WriteLine(" │                                     │ ");
        Console.WriteLine(" │                                     │ ");
        Console.WriteLine(" │                                     │ ");
        Console.WriteLine(" └─────────────────────────────────────┘ ");
        Console.WriteLine(" ┌─────────────────────────────────────┐ ");
        Console.WriteLine(" │                                     │ ");
        Console.WriteLine(" │                                     │ ");
        Console.WriteLine(" └─────────────────────────────────────┘ ");
        Console.WriteLine(" ┌─────────────────────────────────────┐ ");
        Console.WriteLine(" │                                     │ ");
        Console.WriteLine(" └─────────────────────────────────────┘ ");
        Console.WriteLine("                                           ");





    }//메인 틀
    public void TitleScene()
    {
        Console.SetCursorPosition(0, 0);
        Console.Write(@"
 ┌─────────────────────────────────────┐ 
 │                                     │ 
 │      ____  _____  __  __  ____      │ 
 │     /    \/   __\/  \/  \/    \     │ 
 │     \-  -/|   __|>-    -<\-  -/     │ 
 │      |__| \_____/\__/\__/ |__|      │ 
 │                                     │ 
 │         _____  _____  _____         │ 
 │        /  _  \/  _  \/   __\        │ 
 │        |  _  <|   __/|  |_ |        │ 
 │        \__|\_/\__/   \_____/        │ 
 │                                     │ 
 │                                     │ 
 │                                     │ 
 │                                     │ 
 │                                     │ 
 │                                     │ 
 │                                     │ 
 │                                     │ 
 └─────────────────────────────────────┘
 ┌─────────────────────────────────────┐
 │     [1]시작하기     [2]종료하기     │
 │                                     │
 └─────────────────────────────────────┘
 ┌─────────────────────────────────────┐
 │                                     │
 └─────────────────────────────────────┘
");


        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.SetCursorPosition(7, 3);
        Console.Write(" ____  _____  __  __  ____");
        Console.SetCursorPosition(7, 4);
        Console.Write("/    \\/   __\\/  \\/  \\/    \\");
        Console.SetCursorPosition(7, 5);
        Console.Write("\\-  -/|   __|>-    -<\\-  -/");
        Console.SetCursorPosition(7, 6);
        Console.Write(" |__| \\_____/\\__/\\__/ |__|");

        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.SetCursorPosition(7, 8);
        Console.Write("    _____  _____  _____");
        Console.SetCursorPosition(7, 9);
        Console.Write("   /  _  \\/  _  \\/   __\\");
        Console.SetCursorPosition(7, 10);
        Console.Write("   |  _  <|   __/|  |_ |");
        Console.SetCursorPosition(7, 11);
        Console.Write("   \\__|\\_/\\__/   \\_____/");
        Console.ResetColor();



        bot.Option(2);
        if (Program.pick == 1)
        {
            
        }
        else if (Program.pick == 2)
        {
            Environment.Exit(0);
        }
    }//타이틀 씬2
    public void NameScene()
    {
        do
        {
            MainPanel();
            bot.Output("용사님! 이름을 알려주세요!");
            Console.SetCursorPosition(3, 26);
            Player.name = Console.ReadLine();
            if (Player.name.Length < 10)
            {
                MainPanel();
                bot.Output("{0}님이 확실한가요?", Player.name);

                Console.SetCursorPosition(0, 22);
                Console.WriteLine(" │     [1]맞습니다     [2]아닙니다     │");

                bot.Option(2);
            }
            else
            {
                Console.SetCursorPosition(3, 28);
                Console.WriteLine("최대 9글자까지 가능합니다");
                Program.pick = 2;
            }
        } while (Program.pick != 1);


    }//이름 묻기 씬
    public void BasicSettingScene()
    {
        int num = 0;
        MainPanel();
        bot.Output("{0}님의 스탯입니다 ", Player.name);
        Thread.Sleep(500);
        Console.Clear();
        MainPanel();
        bot.Output("10개의 스탯 포인트를 잘 분배해  작성해 주세요");

        while (true)
        {

            Console.SetCursorPosition(3, 8);
            Console.Write("체력   :           ");
            Console.SetCursorPosition(3, 10);
            Console.Write("근력   :           ");
            Console.SetCursorPosition(3, 12);
            Console.Write("행운   :           ");

            bot.NumInput(ref num);
            Player.CON += num;
            bot.ClearChat();
            Console.SetCursorPosition(12, 8);
            Console.Write(Player.CON);

            bot.NumInput(ref num);
            Player.STR += num;
            bot.ClearChat();
            Console.SetCursorPosition(12, 10);
            Console.Write(Player.STR);

            bot.NumInput(ref num);
            Player.LUK += num;
            bot.ClearChat();
            Console.SetCursorPosition(12, 12);
            Console.Write(Player.LUK);


            Console.SetCursorPosition(0, 22);
            Console.Write(" │     [1]선택완료     [2]다시하기     │");
            bot.Option(2);
            if (Program.pick == 1)
            {
                if (Player.CON + Player.STR + Player.LUK > 10)
                {

                    Console.SetCursorPosition(3, 28);
                    Console.Write("스탯 포인트가 10개를 초과했습니다");
                    Thread.Sleep(2000);
                }
                else if (Player.CON + Player.STR + Player.LUK == 10)
                {
                    break;
                }
                else if (Player.CON + Player.STR + Player.LUK <= 10)
                {
                    Console.SetCursorPosition(3, 17);
                    Console.Write("용사님! 모든 스탯이 사용되지");
                    Console.SetCursorPosition(3, 18);
                    Console.Write("않았습니다 괜찮으신가요?");
                    bot.Option(2);
                    if (Program.pick == 1)
                    {
                        break;
                    }
                }
            }
            bot.ClearChat();
            Player.CON = 0;
            Player.STR = 0;
            Player.LUK = 0;
        }
        Player.CON += 1;
        Player.HP = Player.CON;
        HP_Outut();
        MainPanel();
        bot.Output("좋습니다 용사님 함께 여정을 떠나시죠");
        Thread.Sleep(500);
        BasicItem();
    }//스탯 설정 씬
    public void MainScene()
    {
        if (Player.HP <= 0)
        {
            HP_Outut();
        }
        else
        {
            HP_Outut();
            SortItems();
            Console.SetCursorPosition(0, 1);
            Console.WriteLine(" ┌─────────────────────────────────────┐ ");
            Console.WriteLine(" │                                     │ ");
            Console.WriteLine(" │                                     │ ");
            Console.WriteLine(" │                                     │ ");
            Console.WriteLine(" │                                     │ ");
            Console.WriteLine(" │                                     │ ");
            Console.WriteLine(" │                                     │ ");
            Console.WriteLine(" │                                     │ ");
            Console.WriteLine(" │                                     │ ");
            Console.WriteLine(" │                                     │ ");
            Console.WriteLine(" │                                     │ ");
            Console.WriteLine(" │                                     │ ");
            Console.WriteLine(" │                                     │ ");
            Console.WriteLine(" │                                     │ ");
            Console.WriteLine(" │                                     │ ");
            Console.WriteLine(" │                                     │ ");
            Console.WriteLine(" │                                     │ ");
            Console.WriteLine(" │                                     │ ");
            Console.WriteLine(" │                                     │ ");
            Console.WriteLine(" └─────────────────────────────────────┘ ");
            Console.WriteLine(" ┌─────────────────────────────────────┐ ");
            Console.WriteLine(" │                                     │ ");
            Console.WriteLine(" │                                     │ ");
            Console.WriteLine(" └─────────────────────────────────────┘ ");
            Console.WriteLine(" ┌─────────────────────────────────────┐ ");
            Console.WriteLine(" │                                     │ ");
            Console.WriteLine(" └─────────────────────────────────────┘ ");
            Console.WriteLine("                                           ");
            Console.SetCursorPosition(0, 0);

            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.SetCursorPosition(3, 2);
            Console.WriteLine("              .___.");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("              |___(");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("              I");
            Console.SetCursorPosition(3, 5);
            Console.WriteLine("             /_\\ ___");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("     .___.   |,|/   \\");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("     |___(   | /_____\\       .___.");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("     I        \\| u  -| _     |___(");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("    / \\    -_-_-_-_--|/ \\    I");
            Console.SetCursorPosition(3, 10);
            Console.WriteLine("   /___\\   \\._._._./-|___\\  / \\");
            Console.SetCursorPosition(3, 11);
            Console.WriteLine("   |_u |    |_   _| -| u_| /___\\");
            Console.SetCursorPosition(3, 12);
            Console.WriteLine("   |_-_-_-_-_-  U_| -|  _| | u_|");
            Console.SetCursorPosition(3, 13);
            Console.WriteLine("   |_\\._._._./   _|-_-_-_-_-_-_|");
            Console.SetCursorPosition(3, 14);
            Console.WriteLine("    \\_|-   -|    _|    ..   -|_|");
            Console.SetCursorPosition(3, 15);
            Console.WriteLine("     \\|-   U|    _| U  ++  U-|/");
            Console.SetCursorPosition(3, 16);
            Console.WriteLine("      |U   -|  U _|   ____  -|");
            Console.SetCursorPosition(3, 17);
            Console.WriteLine("      |- _ -|    _|  /|-|-\\ -|");
            Console.SetCursorPosition(3, 18);
            Console.WriteLine("      |-/#\\-|    _|  |-|-|| -|");
            Console.SetCursorPosition(3, 19);
            Console.WriteLine("   ,__|_H-H_|-----I__I|-|-I__|__,");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(18, 2);
            Console.WriteLine("___.");
            Console.SetCursorPosition(18, 3);
            Console.WriteLine("___(");
            Console.SetCursorPosition(9, 6);
            Console.WriteLine("___.");
            Console.SetCursorPosition(9, 7);
            Console.WriteLine("___(");
            Console.SetCursorPosition(33, 7);
            Console.WriteLine("___.");
            Console.SetCursorPosition(33, 8);
            Console.WriteLine("___(");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(4, 19);
            Console.WriteLine(" ,___");
            Console.SetCursorPosition(10, 19);
            Console.WriteLine("_");
            Console.SetCursorPosition(14, 19);
            Console.WriteLine("_");
            Console.SetCursorPosition(16, 19);
            Console.WriteLine("-----");
            Console.SetCursorPosition(22, 19);
            Console.WriteLine("__");
            Console.SetCursorPosition(30, 19);
            Console.WriteLine("__");
            Console.SetCursorPosition(33,19);
            Console.WriteLine("__,");

            Console.ResetColor();





            Console.SetCursorPosition(7, 22);
            Console.Write("[1]");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("전투시작");
            Console.ResetColor();

            Console.SetCursorPosition(23, 22);
            Console.Write("[2]");
            Console.Write("상점보기");

            Console.SetCursorPosition(7, 23);
            Console.Write("[3]");
            Console.Write("인벤토리");

            Console.SetCursorPosition(23, 23);
            Console.Write("[4]");
            Console.Write("나의정보");


            bot.Option(4);
            switch (Program.pick)
            {
                case 1:
                    Battle();
                    break;
                case 2:
                    Shop();
                    break;
                case 3:
                    Inventory();
                    break;
                case 4:
                    MyInfo();
                    break;
            }
        }
    }//메인 씬
    public void Battle()
    {
        MainPanel();

        Console.SetCursorPosition(0, 22);
        Console.WriteLine(" │     [1]가위         [2]바위         │ ");
        Console.WriteLine(" │     [3]보                           │ ");

        int monsterLevel = new Random().Next(1, 6);
        if (monsterLevel < 5)
        {
            monsterLevel = Player.Level;
        }
        else
        {
            monsterLevel = Player.Level + 1;
        }
        int monsterHP = monsterLevel * 5;
        if (monsterHP > 15)
        {
            monsterHP = 15;
        }

        Console.SetCursorPosition(3, 2);
        Console.WriteLine("(  ㅋДㅋ)");

        bot.Output("덤벼 보시지 ㅋ");
        Console.SetCursorPosition(3, 18);
        Console.Write(" LV.{0} 몬스터", monsterLevel);
        Console.SetCursorPosition(3, 19);
        Console.Write("{ HP }");

        while (monsterHP > 0 && Player.HP > 0)
        {
            int monsterHand = new Random().Next(1, 4);// 1.가위 2.바위 3.보
            Console.SetCursorPosition(9, 19);
            Console.Write("                              ");
            Console.SetCursorPosition(9, 19);
            for (int i = 1; i <= monsterHP; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("♥");
                Console.ResetColor();
            }
            bot.Option(3);
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("                        ");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("                        ");

            Console.SetCursorPosition(12, 8);
            Console.WriteLine("                  ");
            Console.SetCursorPosition(12, 9);
            Console.WriteLine("                  ");
            Console.SetCursorPosition(12, 10);
            Console.WriteLine("                  ");
            Console.SetCursorPosition(12, 11);
            Console.WriteLine("                  ");
            Console.SetCursorPosition(12, 12);
            Console.WriteLine("                  ");
            Console.SetCursorPosition(12, 13);
            Console.WriteLine("                  ");
            if (monsterHand == 1)
            {

                Console.SetCursorPosition(12, 8);
                Console.WriteLine("    _____");
                Console.SetCursorPosition(12, 9);
                Console.WriteLine("___/   __)_______");
                Console.SetCursorPosition(12, 10);
                Console.WriteLine("         ________)");
                Console.SetCursorPosition(12, 11);
                Console.WriteLine("       __________)");
                Console.SetCursorPosition(12, 12);
                Console.WriteLine("      (____)");
                Console.SetCursorPosition(12, 13);
                Console.WriteLine("---.__(___)");

            }
            if (monsterHand == 2)
            {
                Console.SetCursorPosition(12, 8);
                Console.WriteLine("    _____");
                Console.SetCursorPosition(12, 9);
                Console.WriteLine("___/   __)__");
                Console.SetCursorPosition(12, 10);
                Console.WriteLine("      (_____)");
                Console.SetCursorPosition(12, 11);
                Console.WriteLine("      (_____)");
                Console.SetCursorPosition(12, 12);
                Console.WriteLine("      (____)");
                Console.SetCursorPosition(12, 13);
                Console.WriteLine("---.__(___)");
            }
            if (monsterHand == 3)
            {
                Console.SetCursorPosition(12, 8);
                Console.WriteLine("    ________");
                Console.SetCursorPosition(12, 9);
                Console.WriteLine("___/    ____)____");
                Console.SetCursorPosition(12, 10);
                Console.WriteLine("           ______)");
                Console.SetCursorPosition(12, 11);
                Console.WriteLine("          _______)");
                Console.SetCursorPosition(12, 12);
                Console.WriteLine("         _______)");
                Console.SetCursorPosition(12, 13);
                Console.WriteLine("---.__________)");
            }
            if (Program.pick == monsterHand)
            {
                Console.SetCursorPosition(3, 2);
                Console.WriteLine("(   -Д- )");

                bot.Output("크윽 아쉽군..");
            }
            else if (Program.pick == 1 && monsterHand == 3 || Program.pick == 2 && monsterHand == 1 || Program.pick == 3 && monsterHand == 2)
            {
                Console.SetCursorPosition(3, 2);
                Console.WriteLine("(  ‘Д’)");

                monsterHP -= Player.ATK + Player.STR;
                bot.Output("살살 때려!!");

                if (monsterHP < 0)
                {
                    Console.SetCursorPosition(12, 8);
                    Console.WriteLine("                  ");
                    Console.SetCursorPosition(12, 9);
                    Console.WriteLine("                  ");
                    Console.SetCursorPosition(12, 10);
                    Console.WriteLine("                  ");
                    Console.SetCursorPosition(12, 11);
                    Console.WriteLine("                  ");
                    Console.SetCursorPosition(12, 12);
                    Console.WriteLine("                  ");
                    Console.SetCursorPosition(12, 13);
                    Console.WriteLine("                  ");
                    Console.SetCursorPosition(3, 2);
                    Console.WriteLine("(   - _- )");

                    bot.Output("크윽.. 좋은 싸움이였다...");
                    Player.Kill += 1;
                    Console.SetCursorPosition(9, 19);
                    Console.Write("                              ");

                    Player.Gold += 50;
                    if (Player.Kill == 5)
                    {
                        Player.Kill = 0;
                        LevelUP();
                    }
                }
            }
            else
            {
                Console.SetCursorPosition(3, 2);
                Console.WriteLine("(  ㅋДㅋ)");

                bot.Output("잘 좀 해보라고 형씨 ㅋㅋ");
                Thread.Sleep(500);
                if (Player.Use[1].function > 0)
                {
                    Player.Use[1].function -= monsterLevel;
                    Player.DEF -= monsterLevel;
                    if (Player.DEF < 0)
                    {
                        Player.DEF = 0;
                    }
                    if (Player.Use[1].function <= 0)
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            if (Player.inventory[i].name == Player.Use[1].name)
                            {
                                Player.DEF = 0;
                                Player.Use[1] = itemDB.a000;
                                Player.inventory[i] = itemDB.a000;
                                break;
                            }
                        }
                    }
                }
                else
                {
                    Player.HP -= monsterLevel;
                    HP_Outut();
                }
            }
        }
        if (Player.HP > 0)
        {
            Console.SetCursorPosition(0, 22);
            Console.WriteLine(" │     [1]계속하기      [2]돌아가기    │ ");
            Console.WriteLine(" │                                     │ ");
            bot.Option(2);
        }
        if (Program.pick == 1 && Player.HP > 0)
        {
            Battle();
        }
        if (Program.pick == 2 && Player.HP > 0)
        {
            MainScene();
        }
    }//전투 씬
    public void Shop()
    {
        int cursor = 0;
        bool isOut = false;

        ShopItem();

        Console.SetCursorPosition(0,1);
        Console.SetCursorPosition(0, 1);
        Console.WriteLine(" ┌─────────────────────────────────────┐ ");
        Console.WriteLine(" │                                     │ ");
        Console.WriteLine(" │                                     │ ");
        Console.WriteLine(" │                                     │ ");
        Console.WriteLine(" │                                     │ ");
        Console.WriteLine(" │                                     │ ");
        Console.WriteLine(" │ ─────────────────────────────────── │ ");
        Console.WriteLine(" │                                     │ ");
        Console.WriteLine(" │                                     │ ");
        Console.WriteLine(" │                                     │ ");
        Console.WriteLine(" │                                     │ ");
        Console.WriteLine(" │                                     │ ");
        Console.WriteLine(" │                                     │ ");
        Console.WriteLine(" │                                     │ ");
        Console.WriteLine(" │                                     │ ");
        Console.WriteLine(" │                                     │ ");
        Console.WriteLine(" │                                     │ ");
        Console.WriteLine(" │                                     │ ");
        Console.WriteLine(" │                                     │ ");
        Console.WriteLine(" └─────────────────────────────────────┘ ");
        Console.WriteLine(" ┌─────────────────────────────────────┐ ");
        Console.WriteLine(" │     [1]▼           [2]▲           │ ");
        Console.WriteLine(" │     [3]자세히보기   [4]나가기       │ ");
        Console.WriteLine(" └─────────────────────────────────────┘ ");
        Console.WriteLine(" ┌─────────────────────────────────────┐ ");
        Console.WriteLine(" │                                     │ ");
        Console.WriteLine(" └─────────────────────────────────────┘ ");
        Console.WriteLine("                                           "); ;

        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.SetCursorPosition(7, 2);
        Console.Write(" _____  __ __  _____  _____");
        Console.SetCursorPosition(7, 3);
        Console.Write("/  ___>/  |  \\/  _  \\/  _  \\");
        Console.SetCursorPosition(7, 4);
        Console.Write("|___  ||  _  ||  |  ||   __/");
        Console.SetCursorPosition(7, 5);
        Console.Write("<_____/\\__|__/\\_____/\\__/");
        Console.ResetColor();

        Console.SetCursorPosition(10, 10);
        Console.WriteLine("가격");

        Console.SetCursorPosition(10, 8);

        Console.Write("보유중인 골드 : ");

        Console.ForegroundColor = ConsoleColor.DarkYellow;

        Console.WriteLine("{0}G", Player.Gold);

        Console.SetCursorPosition(10, 12);
        Console.WriteLine("{0}G",Player.shop[0].price);

        Console.SetCursorPosition(10, 14);
        Console.WriteLine("{0}G",Player.shop[1].price);
        
        Console.SetCursorPosition(10, 16);
        Console.WriteLine("{0}G",Player.shop[2].price);

        Console.SetCursorPosition(10, 18);
        Console.WriteLine("{0}G",Player.shop[3].price);
        Console.ResetColor();

        Console.SetCursorPosition(20, 10);
        Console.WriteLine("이름");

        for (int i = 0; i < 4; i++)
        {
            Console.SetCursorPosition(20, 12 + (i * 2));
            Console.WriteLine(Player.shop[i].name);
        }

        do
        {
            Console.SetCursorPosition(6, 12 + cursor);
            Console.WriteLine(">");
            bot.Option(4);
            Console.SetCursorPosition(6, 12 + cursor);
            Console.WriteLine(" ");
            switch (Program.pick)
            {
                case 1:
                    cursor += 2;
                    if (cursor > 7)
                    {
                        cursor = 0;
                    }
                    break;
                case 2:
                    cursor -= 2;
                    if (cursor < 0)
                    {
                        cursor = 6;
                    }
                    break;
                case 3:
                    ShopItemInfo(cursor / 2);
                    isOut = true;
                    break;
                case 4:
                    MainScene();
                    isOut = true;
                    break;
            }

        } while (!isOut);
    }//상점 씬
    public void Inventory()
    {
        SortItems();
        MainPanel();
        Console.SetCursorPosition(3, 3);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("             Inventory");
        Console.ResetColor();
        Console.SetCursorPosition(3, 5);
        Console.WriteLine("───────────────────────────────────");
        int cursor = 0;
        int count = 0;
        bool isOut = false;
        Console.SetCursorPosition(6, 6);
        Console.Write("보유중인 골드 : ");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("{0}G", Player.Gold);
        Console.ResetColor();

        for (int i = 0; i < Player.inventory.Length; i++)
        {
            if (Player.inventory[i].name != null)
            {
                count++;
                Console.SetCursorPosition(6, 8 + (i));
                Console.WriteLine(Player.inventory[i].name);

            }
        }
        Console.SetCursorPosition(6, 19);
        Console.WriteLine("{0}개 더 담을 수 있습니다", 10 - count);
        Console.SetCursorPosition(0, 22);

        Console.Write(" │     [1]▼           [2]▲           │");
        Console.SetCursorPosition(0, 23);
        Console.Write(" │     [3]자세히보기   [4]나가기       │");
        do
        {
            Console.SetCursorPosition(4, 8 + cursor);
            Console.WriteLine(">");
            bot.Option(4);
            Console.SetCursorPosition(4, 8 + cursor);
            Console.WriteLine(" ");
            switch (Program.pick) 
            {
                case 1:
                    cursor += 1;
                    if (cursor >= count)
                    {
                        cursor = 0;
                    }
                    break;
                case 2:
                    cursor -= 1;
                    if (cursor < 0)
                    {
                        cursor = count - 1;
                    }
                    break;
                case 3:
                    ItemInfo(cursor);
                    isOut = true;
                    break;
                case 4:
                    MainScene();
                    isOut = true;
                    break;
            }
        } while (!isOut);

    }//인벤토리 씬 
    public void MyInfo()
    {
        Console.SetCursorPosition(0, 1);
        Console.WriteLine(@" ┌─────────────────────────────────────┐ 
 │                                     │ 
 │       ___  _____  _____  _____      │ 
 │      /   \/  _  \/   __\/  _  \     │ 
 │      |   ||  |  ||   __||  |  |     │ 
 │      \___/\__|__/\__/   \_____/     │ 
 │                                     │ 
 │                                     │ 
 │                                     │ 
 │                                     │ 
 │                                     │ 
 │                                     │ 
 │                                     │ 
 │                                     │ 
 │                                     │ 
 │                                     │ 
 │                                     │ 
 │                                     │ 
 │                                     │ 
 └─────────────────────────────────────┘
 ┌─────────────────────────────────────┐
 │             [1]나가기               │
 │                                     │
 └─────────────────────────────────────┘
 ┌─────────────────────────────────────┐
 │                                     │
 └─────────────────────────────────────┘");

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.SetCursorPosition(8, 3);
        Console.WriteLine(" ___  _____  _____  _____");
        Console.SetCursorPosition(8, 4);
        Console.WriteLine("/   \\/  _  \\/   __\\/  _  \\");
        Console.SetCursorPosition(8, 5);
        Console.WriteLine("|   ||  |  ||   __||  |  |");
        Console.SetCursorPosition(8, 6);
        Console.WriteLine("\\___/\\__|__/\\__/   \\_____/");
        Console.ResetColor();


        Console.SetCursorPosition(12, 9);
        Console.WriteLine(" 이름  : {0}", Player.name);

        Console.SetCursorPosition(12, 10);
        Console.WriteLine(" 레벨  : LV.{0}", Player.Level);

        Console.SetCursorPosition(12, 11);
        Console.Write(" 골드  : ");
        Console.SetCursorPosition(19, 11);
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("{0}G", Player.Gold);
        Console.ResetColor();

        Console.SetCursorPosition(12, 12);
        Console.WriteLine(" 체력  : {0}", Player.CON);

        Console.SetCursorPosition(12, 13);
        Console.WriteLine("  힘   : {0}", Player.STR + Player.ATK);

        Console.SetCursorPosition(12, 14);
        Console.WriteLine("방어력 : {0}", Player.DEF);

        Console.SetCursorPosition(12, 15);
        Console.WriteLine(" 행운  : {0}", Player.LUK);

        if (Player.Use[0].name != null)
        {
            Console.SetCursorPosition(12, 17);
            Console.WriteLine(" 무기  : {0}", Player.Use[0].name);
        }
        else
        {
            Console.SetCursorPosition(12, 17);
            Console.WriteLine(" 무기  : 없음");
        }

        if (Player.Use[1].name != null)
        {
            Console.SetCursorPosition(12, 18);
            Console.WriteLine(" 갑옷  : {0}", Player.Use[1].name);
        }
        else
        {
            Console.SetCursorPosition(12, 18);
            Console.WriteLine(" 갑옷  : 없음");
        }

        bot.Option(1);
        if (Program.pick == 1)
        {
            MainScene();
        }
    }//내 정보 씬
    public void ItemInfo(int num)
    {
        MainPanel();
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("이름 : {0}", Player.inventory[num].name);
        Console.SetCursorPosition(3, 4);
        Console.Write("아이템 타입 : ");
        if (Player.inventory[num].type == 1)
        {
            Console.WriteLine("무기");
            Console.SetCursorPosition(3, 6);
            Console.Write("공격력 : ");
        }
        if (Player.inventory[num].type == 2)
        {
            Console.WriteLine("갑옷");
            Console.SetCursorPosition(3, 6);
            Console.Write("방어력 : ");
        }
        if (Player.inventory[num].type == 3)
        {
            Console.WriteLine("물약");
            Console.SetCursorPosition(3, 6);
            Console.Write("치유력 : ");
        }
        Console.SetCursorPosition(3, 8);
        Console.Write("팬매 가격 : {0}G",Player.inventory[num].price / 2 );

        Console.SetCursorPosition(3, 10);
        Console.WriteLine("설명 :");
        Console.SetCursorPosition(3, 11);
        Console.WriteLine("{0}", Player.inventory[num].explanation);

        Console.SetCursorPosition(0, 22);
        Console.WriteLine(" │     [1]사용         [2]버리기       │");
        Console.SetCursorPosition(0, 23);
        Console.WriteLine(" │     [3]판매하기     [4]나가기       │");
        bot.Option(4);
        if (Program.pick == 1)
        {
            if (Player.inventory[num].type == 3)
            {
                Player.HP += Player.inventory[num].function;
                if (Player.HP + Player.inventory[num].function > Player.CON)
                {
                    Player.HP = Player.CON;
                }
                HP_Outut();
                Player.inventory[num] = itemDB.a000;
            }
            else if(Player.inventory[num].type == 2)
            {
                Player.Use[1] = Player.inventory[num];
                Player.DEF = Player.Use[1].function;
            }
            else
            {
                Player.Use[0] = Player.inventory[num];
                Player.ATK = Player.Use[0].function;
            }
        }
        if (Program.pick == 2)
        {
            Player.inventory[num] = itemDB.a000;
        }
        if (Program.pick == 3)
        {
            Player.Gold += Player.inventory[num].price / 2;
            Player.inventory[num] = itemDB.a000;
        }
        if (Program.pick == 4)
        {

        }
        Inventory();
    }//아이템 정보
    public void ShopItemInfo(int num)
    {
        MainPanel();
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("이름 : {0}", Player.shop[num].name);
        Console.SetCursorPosition(3, 4);
        Console.Write("아이템 타입 : ");
        if (Player.shop[num].type == 1)
        {
            Console.WriteLine("무기");
            Console.SetCursorPosition(3, 6);
            Console.Write("공격력 : ");
        }
        if (Player.shop[num].type == 2)
        {
            Console.WriteLine("갑옷");
            Console.SetCursorPosition(3, 6);
            Console.Write("방어력 : ");
        }
        if (Player.shop[num].type == 3)
        {
            Console.WriteLine("물약");
            Console.SetCursorPosition(3, 6);
            Console.Write("치유력 : ");
        }
        Console.WriteLine("{0}", Player.shop[num].function);
        Console.SetCursorPosition(3, 8);
        Console.WriteLine("설명 :");
        Console.SetCursorPosition(3, 9);
        Console.WriteLine("{0}", Player.shop[num].explanation);

        Console.SetCursorPosition(0, 22);
        Console.WriteLine(" │     [1]구매하기     [2]나가기       │");
        do
        {
            bot.Option(2);
            if (Program.pick == 1)
            {
                if (Player.shop[num].price <= Player.Gold)
                {

                    if (Player.inventory[9].name == null)
                    {
                        Player.Gold -= Player.shop[num].price;
                        bot.ClearChat();
                        Console.SetCursorPosition(3, 28);
                        Console.WriteLine("구매가 완료 되었습니다");
                        Player.inventory[9] = Player.shop[num];
                        SortItems();
                    }
                    else
                    {
                        Console.SetCursorPosition(3, 28);
                        Console.WriteLine("가방에 공간이 부족합니다");
                    }
                }
                else
                {
                    bot.ClearChat();
                    Console.SetCursorPosition(3, 28);
                    Console.WriteLine("골드가 부족합니다");
                }
            }
            else
            {
                Shop();
                break;
            }
        } while (true);
    }//상점 아이템 정보
    public void BasicItem()
    {
        Player.inventory[8] = itemDB.a001;
        Player.inventory[9] = itemDB.a002;
    }//아이템 기본 지급
    public void SortItems()
    {
        for (int i = 0 ;i < 9 ; i++)
        {
            if (Player.inventory[i].name == null)
            {
                for (int j = i + 1; j <= 9; j++)
                {
                    if (Player.inventory[j].name != null)
                    {
                        Player.inventory[i] = Player.inventory[j];
                        Player.inventory[j] = itemDB.a000;
                        j = 10;
                    }
                }
            }

        }
    }//인벤토리 정렬
    public void ShopItem()
    {
        if (Player.Level < 5)
        {
            Player.shop[0] = itemDB.a003;
            Player.shop[1] = itemDB.a004;
            Player.shop[2] = itemDB.a005;
            Player.shop[3] = itemDB.a006;
        }
    }//레벨별 상점 정보
    public void HP_Outut()
    {
        //♥♥♥♥♡
        Console.SetCursorPosition(2, 0);
        Console.Write("[HP]");
        Console.SetCursorPosition(6, 0);
        for (int i = 0; i < Player.CON; i++)
        {
            {
                Console.Write("♡");
            }
        }
        Console.SetCursorPosition(6, 0);
        for (int i = 0; i < Player.HP; i++)
        {
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("♥");
                Console.ResetColor();
            }
        }
        if (Player.HP <= 0)
        {
            Die();
        }
    }//현재 HP 보여줌
    public void Die()
    {
        Console.SetCursorPosition(0,1);
        Console.WriteLine(@" ┌─────────────────────────────────────┐ 
 │                                     │ 
 │      _____  __ __  _____  _____     │ 
 │     /  _  \/  |  \/   __\/  _  \    │ 
 │     |  |  |\  |  /|   __||  _  <    │ 
 │     \_____/ \___/ \_____/\__|\_/    │ 
 │                                     │ 
 │                                     │ 
 │                                     │ 
 │                                     │ 
 │                                     │ 
 │                                     │ 
 │                                     │ 
 │                                     │ 
 │                                     │ 
 │                                     │ 
 │                                     │ 
 │                                     │ 
 │                                     │ 
 └─────────────────────────────────────┘
 ┌─────────────────────────────────────┐
 │     [1]다시하기     [2]종료하기     │
 │                                     │
 └─────────────────────────────────────┘
 ┌─────────────────────────────────────┐
 │                                     │
 └─────────────────────────────────────┘");

        Console.ForegroundColor= ConsoleColor.DarkRed;
        Console.SetCursorPosition(7, 3);
        Console.Write(" _____  __ __  _____  _____ ");
        Console.SetCursorPosition(7, 4);
        Console.Write("/  _  \\/  |  \\/   __\\/  _  \\");
        Console.SetCursorPosition(7, 5);
        Console.Write("|  |  |\\  |  /|   __||  _  <");
        Console.SetCursorPosition(7, 6);
        Console.Write("\\_____/ \\___/ \\_____/\\__|\\_/");
        Console.ResetColor();

        bot.Option(2);
        if(Program.pick == 1)
        {
            Player.inventory[0] = itemDB.a000;
            Player.inventory[1] = itemDB.a000;
            Player.inventory[2] = itemDB.a000;
            Player.inventory[3] = itemDB.a000;
            Player.inventory[4] = itemDB.a000;
            Player.inventory[5] = itemDB.a000;
            Player.inventory[6] = itemDB.a000;
            Player.inventory[7] = itemDB.a000;
            Player.inventory[8] = itemDB.a000;
            Player.inventory[9] = itemDB.a000;

            Player.Gold = 100;

            Player.Use[0] = itemDB.a000;
            Player.Use[1] = itemDB.a000;

            Player.CON = 0;
            Player.STR = 0;
            Player.LUK = 0;
        }
        else if (Program.pick == 2)
        {
            Program.over = true;
            Environment.Exit(0);
        }
    }//Over
    public void LevelUP()
    {
        MainPanel();

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.SetCursorPosition(4, 2);
        Console.Write(" ____   _____  __ __  _____  ____  ");
        Console.SetCursorPosition(4, 3);
        Console.Write("/  _/  /   __\\/  |  \\/   __\\/  _/ ");
        Console.SetCursorPosition(4, 4);
        Console.Write("|  |---|   __|\\  |  /|   __||  |---");
        Console.SetCursorPosition(4, 5);
        Console.Write("\\_____/\\_____/ \\___/ \\_____/\\_____/");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.SetCursorPosition(14, 6);
        Console.Write(" __ __  _____ ");
        Console.SetCursorPosition(14, 7);
        Console.Write("/  |  \\/  _  \\ ");
        Console.SetCursorPosition(14, 8);
        Console.Write("|  |  ||   __/");
        Console.SetCursorPosition(14, 9);
        Console.Write("\\_____/\\__/  ");
        Console.ResetColor();

        Console.SetCursorPosition(17, 14);
        Console.Write("[1]체력");

        Console.SetCursorPosition(17, 16);
        Console.Write("[2]근력");

        Console.SetCursorPosition(17, 18);
        Console.Write("[3]행운");

        Console.SetCursorPosition(5, 12);
        Console.Write("스탯 포인트를 하나 획득 했습니다");

        Console.SetCursorPosition(0, 22);
        Console.WriteLine(" │     [1]체력         [2]근력         │");
        Console.WriteLine(" │     [3]행운                         │");
        bot.Option(3);
        if(Program.pick == 1)
        {
            Player.CON += 1;
            Player.HP += 1;
        }
        if (Program.pick == 2)
        {
            Player.STR += 1;
        }
        if (Program.pick == 3)
        {
            Player.LUK += 1;
        }
        Player.Level += 1;
        HP_Outut();
    }//레벨업
}
