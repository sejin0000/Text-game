class Snake
{
    int b;
    int map = 10;
    static void Main(string[] args)
    {
        A a = new A();

        a.Main();
    }
}

class A
{

    int length = 1;

    bool mapItem = false;
    bool over = false;

    char itemImage = '\u25cf';
    char isnakeImage = '□';

    //▣□
    List<int> snake_x = new List<int>();
    List<int> snake_y = new List<int>();

    Vector2 itemVec;
    Vector2 nextVec;


    public void Main()
    {
        nextVec.x = 1;
        nextVec.y = 0;
        snake_x.Add(1);
        snake_y.Add(1);

        while (!over)
        {
            Thread.Sleep(400);
            ClickCheck();
            Console.Clear();
            MakeMap();
            MakeItem();
            SnakeBady();
            Snake();
            collider();
        }
        OverPanel();
    }
    void ClickCheck()
    {
        if (Console.KeyAvailable)
        {
            var key = Console.ReadKey(true).Key;

            if (key == ConsoleKey.UpArrow && nextVec.y != 1)
            {
                nextVec.y = -1; nextVec.x = 0;
            }
            if (key == ConsoleKey.DownArrow && nextVec.y != -1)
            {
                nextVec.y = 1; nextVec.x = 0;
            }
            if (key == ConsoleKey.LeftArrow && nextVec.x != 1)
            {
                nextVec.x = -1; nextVec.y = 0;
            }
            if (key == ConsoleKey.RightArrow && nextVec.x != -1)
            {
                nextVec.x = 1; nextVec.y = 0;
            }
        }
    }//입력 확인
    void MakeMap()
    {
        //▣
        //□
        Console.WriteLine("▣▣▣▣▣▣▣▣▣▣▣▣");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("▣");
            Console.SetCursorPosition(22, i);
            Console.WriteLine("▣");
        }
        Console.WriteLine("▣▣▣▣▣▣▣▣▣▣▣▣");
    }//맵 그림
    void MakeItem()
    {
        if (!mapItem)
        {
            itemVec.x = new Random().Next(1, 10);
            itemVec.y = new Random().Next(1, 10);
            mapItem = true;
        }
        Draw(itemVec.x, itemVec.y, itemImage);
    }//아이템 제작
    void Snake()
    {
        snake_x[0] += nextVec.x;
        snake_y[0] += nextVec.y;
        for (int i = 0; i < length; i++)
        {
            Draw(snake_x[i], snake_y[i], isnakeImage);
        }
    }//뱀 제작
    void SnakeBady()
    {
        for (int i = length - 1; i > 0; i--)
        {
            snake_x[i] = snake_x[i - 1];
            snake_y[i] = snake_y[i - 1];
        }
    }//뱀 몸 움직임
    void MakeSnake()
    {
        snake_x.Add(1);
        snake_y.Add(1);
        snake_x[length - 1] = snake_x[length - 2];
        snake_y[length - 1] = snake_y[length - 2];

    }//뱀 꼬리 제작
    void Draw(int x, int y, char image)
    {
        Console.SetCursorPosition(x * 2, y);
        Console.WriteLine(image);
    }//아이템과 뱀을 맵에 그려줌
    void collider()
    {
        for (int i = 0; i < length; i++)
        {
            //벽과 닿았는 가?
            if (snake_x[i] == 0 || snake_x[i] == 11 || snake_y[i] == 0 || snake_y[i] == 11)
            {
                over = true; break;
            }
            //아이템과 닿았는 가?
            if (itemVec.x == snake_x[i] && itemVec.y == snake_y[i])
            {
                mapItem = false;
                MakeItem();
                length++;
                MakeSnake();
            }
            if (i > 1 && snake_x[i] == snake_x[0] && snake_y[i] == snake_y[0])
            {
                over = true; break;
            }
        }
    }//물체가 닿았는지 확인
    void OverPanel()
    {
        Console.SetCursorPosition(5, 4);
        Console.WriteLine("┌───────────┐");
        Console.SetCursorPosition(5, 5);
        Console.WriteLine("│ GMAE OVER │");
        Console.SetCursorPosition(5, 6);
        Console.WriteLine("│           │");
        Console.SetCursorPosition(5, 7);
        Console.WriteLine("└───────────┘");
        Console.SetCursorPosition(1, 11);
    }//게임 오버 패널

    struct Vector2
    {
        public int x;
        public int y;
    }//구조체
}