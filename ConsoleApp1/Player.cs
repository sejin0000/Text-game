using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
static class Player
{

    public static string name = "플레이어";// 이름

    // 기본 스탯
    public static int Level = 1;
    public static int Kill = 0;


    public static int HP = 1;// 현재 채력
    public static int CON = 1;// 최대 체력
    public static int STR;// 근력
    public static int LUK;// 행운
    public static int Gold = 100;

    public static int ATK;//공격력
    public static int DEF;//방어력

    public static Item[] Use = new Item[2];//창착중인 아이템 0 무기 1갑옷
     
    public static Item[] inventory = new Item[10];// 인벤토리
    public static Item[] shop = new Item[5]; // 상점 목록
}