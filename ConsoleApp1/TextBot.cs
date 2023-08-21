using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

class TextBot
{
    // │     [1]시작하기     [2]종료하기     │
    public void Output(string text)
    {
        int newxtLine = 0;
        int maxtext = 20;
        Console.SetCursorPosition( 3, 3);
        for (int i = 0; i < text.Length; i++)//text.Length 문자열 길이\
        {
            if (maxtext == 0)
            {
                newxtLine++;
                Console.WriteLine("");
                Console.SetCursorPosition(3, 3 + newxtLine);
                maxtext = 20;
            }
            string text1 = text.Substring(i, 1);// 문자 하나하나 잘라줌   
            Console.Write(text1);//자른 문자 출력해줌
            Thread.Sleep(100);
            maxtext--;
        }
        Console.WriteLine("");
        Console.SetCursorPosition(3, 26);
    }//문자 출력
    public void Output(string text, string text2)
    {
        string newText = text.Replace("{0}", text2);//매개 변수 합쳐주는 코드
        int nextLine = 0;
        int maxtext = 20;
        Console.SetCursorPosition(3, 3);
        for (int i = 0; i < newText.Length; i++)//text.Length 문자열 길이\
        {
            if (maxtext == 0)
            {
                nextLine++;
                Console.WriteLine("");
                Console.SetCursorPosition(3, 3 + nextLine);
                maxtext = 20;
            }
            string text1 = newText.Substring(i, 1);// 문자 하나하나 잘라줌   
            Console.Write(text1);//자른 문자 출력해줌
            Thread.Sleep(100);
            maxtext--;
        }
        Console.WriteLine("");
        Console.SetCursorPosition(3, 26);
    }//문자 출력
    public void Option(int _pick)
    {
        int num;
        bool number_check = false;
        do
        {
            Console.SetCursorPosition(0, 26);
            Console.Write(" │                                     │");
            Console.SetCursorPosition(3, 26);
            string a = Console.ReadLine();
            if (int.TryParse(a, out num) && num <= _pick && num > 0)
            {
                Program.pick = num;
                number_check = true;
            }
            else
            {
                Console.SetCursorPosition(0, 26);
                Console.Write(" │                                     │");
                Console.SetCursorPosition(3, 28);
                Console.WriteLine("잘못된 입력입니다");

            }

        } while (!number_check);


    }//선택 목록
    public void NumInput(ref int num)
    {
        bool isNum = false;
        do
        {
            Console.SetCursorPosition(3, 26);
            string input = Console.ReadLine();
            if(int.TryParse(input,out num) && num >= 0)
            {
                isNum = true;
            }
            else
            {
                Console.SetCursorPosition(3, 28);
                Console.WriteLine("잘못된 입력입니다");
            }
        } while (!isNum);
    }//숫자만 받기
    public void ClearChat()
    {
        Console.SetCursorPosition(3,26);
        Console.WriteLine("│                                   │");
        Console.SetCursorPosition(3, 28);
        Console.WriteLine("                                       ");
    }//플레이어 chat창 지우기
}