using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class ItemDB
{
    // \n │ 글씨
    public Item a000;
    public Item a001 = new Item("초심자의 검", "모두에게 기본으로 지급되는 검이다", 1, 5);
    public Item a002 = new Item("초심자의 갑옷", "모두에게 기본으로 지급되는 갑옷이다", 2, 5);

    public Item a003 = new Item("중급자 검", "아무래도 초급자 겁보다는 강해보인다", 1, 10);
    public Item a004 = new Item("중급자 갑옷", "아무래도 초급자 갑옷보다는\n │ 강해보인다", 2, 10);

    public Item a005 = new Item("작은 체력 물약", "조금이나마 채력을 채워준다", 3, 2);
    public Item a006 = new Item("체력 물약", "체력을 채워준다", 3, 4);



    public Item a007 = new Item("중급자 갑옷", "아무래도 초급자 갑옷보다는\n │ 강해보인다", 1, 10);
    public Item a008 = new Item("중급자 갑옷", "아무래도 초급자 갑옷보다는\n │ 강해보인다", 1, 10);
    public Item a009 = new Item("중급자 갑옷", "아무래도 초급자 갑옷보다는\n │ 강해보인다", 1, 10);
    public Item a010 = new Item("중급자 갑옷", "아무래도 초급자 갑옷보다는\n │ 강해보인다", 1, 10);
    public Item a011 = new Item("중급자 갑옷", "아무래도 초급자 갑옷보다는\n │ 강해보인다", 1, 10);
    public Item a012 = new Item("중급자 갑옷", "아무래도 초급자 갑옷보다는\n │ 강해보인다", 1, 10);
    public Item a013 = new Item("중급자 갑옷", "아무래도 초급자 갑옷보다는\n │ 강해보인다", 1, 10);

}

 struct Item
{
    public int type;// 1 무기 2 갑옷 3 물약
    public string name;// 이름
    public string explanation;// 설명
    public int function;//기능 값

    public Item(string _name, string _explanation, int _type, int _function)
    {
        name = _name;
        explanation = _explanation;
        type = _type;
        function = _function;
    }
}
