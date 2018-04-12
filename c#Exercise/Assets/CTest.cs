using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CTest : MonoBehaviour//c#練習
{

    public class Human //人類
    {
        //屬性
        public string Race;//種族
        public string name;//姓名
        public int age = 0; //年齡
        public int Height = 0;//身高
        public static int PassHeight;//身高標準  static(靜態變數)所有這個Class(Human)的物件都會"共用" 這個靜態變數



        //方法,功能
        public Human(string name)//建構子Overloaded(多載)
        {
            this.name = name;
            this.age = 52;
            Race = "歐洲人";
            Height = 175;
        }
        public Human(string race, int height, string name, int age)//建構子Overloaded(多載) //只要是 method 都有可能會有這樣的性質"Overloaded(多載)"! 不是只有建構子
        {
            this.name = name;
            this.age = age;
            this.Race = race;
            this.Height = height;
        }
        public Human(string name, int age)//建構子Overloaded 建立物件的時候會執行的Method;
        {
            this.name = name;
            this.age = age;
            Race = "亞洲人";
        }
        public void SayMySelf()
        {
            Debug.Log("我是" + this.name + "," + this.age + "歲");
        }
        public string Talk(Human Tohuman)//回傳string類型的值  (對方)
        {
            return "我是" + this.name + "," + "種族:" + this.Race + "身高:" + this.Height + ","
            + this.age + "歲,向身高:" + Tohuman.Height + "," + Tohuman.age + "歲的, " + "種族:"
            + Tohuman.Race + "," + Tohuman.name + ",打招呼";
        }
        public bool PassforMyHeight()
        {
            if (PassHeight > this.Height)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static string SayPassHeight()
        {
            return "及格身高為:" + PassHeight;
        }
        public static string SayThisMethod()
        {
            return "這是靜態Method";
        }
    }
    public static class ABC //任何一個static class 都無法被mew出來(建立物件)
    {
        public static void ABCC()
        {
            Debug.Log("我是靜態Class");
        }
    }
    public class User
    {
        private string UserName;
        private string Password;
        private int hP;
        // Public(任何人能夠觀看及修改的事物)
        // private(只有自己 能夠觀看及修改的事物)
        public User(string UserName, string Password)
        {
            this.UserName = UserName;
            this.Password = Password;
        }
        public string GetPassword()
        {
            return this.Password;
        }
        public string GetUserName()
        {
            return this.UserName;
        }
        //Get & Set 存取器
        //  .........  // 宣告變數(通常是 public)
        //{
        //  get { .... } // 希望變數讀取時執行的程式碼
        //  set { .... } // 希望數值存入時執行的程式碼
        //}
        public string Username
        {
            get { return this.UserName; } //Get會在嘗試"取得"內容變數時呼叫
            set { this.UserName = value; }//Set會在嘗試"存入"數值時呼叫

        }

    }
    class Player //Get & Set 存取器練習用題目
    {

        private int countGold; // 擁有的金子數目，每個金子值 50
        private int countSilver; // 擁有的銀子數目，每個銀子值 25
        private int countCopper; // 擁有的銅的數目，每個銅值 10

        // TODO: 欠缺計算總值的程式碼
        public int TotalValue //結算
        {
            get { return this.countCopper * 10 + this.countSilver * 25 + this.countGold * 50; }
        }

        private int hungerRate; // 飢餓度，必須介於 0~100 之間

        // TODO: 欠缺存取飢餓度(hungerRate) 的程式碼


        public int HungerRate
        {
            get { return hungerRate; }
            set//set內的Value = 來自外部的自身與外部值加起來的值
            {
                if (value >= 100)
                    hungerRate = 100;
                else if (value <= 0)
                    hungerRate = 0;
                else
                    //Debug.Log(value); 
                    //Debug.Log(hungerRate);
                    hungerRate = value;
            }
        }
        public Player()
        {
            this.countGold = 0;
            this.countSilver = 0;
            this.countCopper = 0;
            this.hungerRate = 80;
        }

        public void pickAGold()
        {
            countGold++;
        }

        public void pickASilver()
        {
            countSilver++;
        }

        public void pickACopper()
        {
            countCopper++;
        }

    }
    //繼承性 繼承別的Class屬性及行為方法 
    //指出繼承性可以使程式碼易於維護 
    //衍生類別(Drived Class)//基礎類別(Base Class)

    public class Moster : Creature//繼承 基礎類別(Base Class)

    {
        private int Attack;
        public Moster(int Atk, string name, int hp)
        {
            this.name = name;
            this.Attack = Atk;
            this.hp = hp;

        }
        // public int AttAck
        // {
        //     get { return this.Attack; }
        //     set
        //     {
        //         this.Attack = value;
        //     }
        // }
        public int SetAttAck
        {
            get { return this.Attack; }
            set
            {
                this.Attack = value;
            }
        }
        public void AttAck(Creature C) //攻擊對象的生物(基底類別)
        {
            C.InJured(this.Attack);
        }
        public string SayMyname()
        {
            return Say() + this.name;
        }

    }
    public class Bot : Creature
    {
        private int Attack;
        public Bot(int Atk, string name, int hp)
        {
            this.name = name;
            this.Attack = Atk;
            this.hp = hp;
        }
        public override string Walk()   //override 複寫於基礎類別 
        {
            return this.name + "開始大步規律的向前走";
        }
        public string SayMyname()
        {
            return Say() + this.name;
        }
    }
    void Start()
    {
        //Human Shuibian = new Human("陳水扁", 58);
        // Human ChiaWei = new Human("林家緯", 25);
        Human Shuibian = new Human("亞洲人", 160, "陳水扁", 58);
        Human ChiaWei = new Human("亞洲人", 180, "林家緯", 25);
        //ChiaWei.SayMySelf();

        Human Kobe = new Human("北美洲人", 198, "摳逼不萊恩特", 39);


        Human JKRowLing = new Human("JK羅琳");

        Human.PassHeight = 200;




        Kobe.SayMySelf();
        JKRowLing.SayMySelf();

        Debug.Log(ChiaWei.Talk(Shuibian));
        Debug.Log(Shuibian.Talk(ChiaWei));
        Debug.Log(Kobe.Talk(ChiaWei));
        Debug.Log(JKRowLing.Talk(Kobe));


        Debug.Log(Human.SayPassHeight());

        Debug.Log(ChiaWei.name + "的身高是否及格:" + ChiaWei.PassforMyHeight());

        Human.PassHeight = 170;
        Debug.Log(Human.SayPassHeight());
        Debug.Log(ChiaWei.name + "的身高是否及格:" + ChiaWei.PassforMyHeight());

        ABC.ABCC();//靜態Class
        Debug.Log(Human.SayThisMethod());//這個Class裡面的靜態method

        User MyUser = new User("林家緯", "1233334");
        Debug.Log(MyUser.GetUserName());
        Debug.Log(MyUser.GetPassword());

        Debug.Log(MyUser.Username);
        MyUser.Username = "林老闆";//向Set存入
        Debug.Log(MyUser.Username);


        ///練習題目
        Player player = new Player();

        player.pickAGold();
        player.HungerRate += 10; // 餓了，飢餓度上升
        Debug.Log("飢餓度：" + player.HungerRate);

        player.pickASilver();
        player.HungerRate += 10; // 餓了，飢餓度上升
        Debug.Log("飢餓度：" + player.HungerRate);
        player.pickASilver();
        player.HungerRate += 10; // 餓了，飢餓度上升


        Debug.Log("飢餓度：" + player.HungerRate + "，身上物品總值：" + player.TotalValue);

        player.pickACopper();
        player.HungerRate -= 60; // 吃了一個可以減少 60 飢餓度的東西
        Debug.Log("飢餓度：" + player.HungerRate);
        player.pickAGold();
        player.HungerRate -= 60; // 吃了一個可以減少 60 飢餓度的東西


        Debug.Log("飢餓度：" + player.HungerRate + "，身上物品總值：" + player.TotalValue);

        Moster ms = new Moster(75, "大頭怪", 100);
        Debug.Log(ms.HP);
        ms.HP -= 10;
        Debug.Log(ms.HP);
        ms.HP += 90;
        Debug.Log(ms.HP);
        ms.HP -= 56;
        Debug.Log(ms.HP);
        Debug.Log(ms.SayMyname());
        Debug.Log(ms.Walk());




        Bot bt = new Bot(95, "阿諾", 100);
        Debug.Log(bt.HP);
        // bt.InJured(ms.AttAck);
        ms.AttAck(bt);
        Debug.Log(bt.HP);

        ms.SetAttAck = 200;
        //bt.InJured(ms.AttAck);
        ms.AttAck(bt);
        Debug.Log(bt.HP);
        Debug.Log(bt.SayMyname());
        Debug.Log(bt.Walk());

    }
}
