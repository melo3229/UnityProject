using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature //繼承用
{
    public string name;
    //private int hp;
    //套用 protected 的資源不可以直接從外界存取 (類似 private)，但是可以從繼承的 class 之中存取
    //開放程度：pubilc > protected > private
    protected int hp;
    public Creature()
    {
        //this.hp = 100;
    }
    public int HP  //血量 設定 觀看
    {
        get { return this.hp; }
        set
        {
            if (value > 100)
            {
                this.hp = 100;
            }
            else if (value <= 0)
            {
                this.hp = 0;
            }
            else
            {
                this.hp = value;
            }
        }
    }
    // public void InJured(int injured)
    // {
    //     if (injured > 0)
    //     {
    //         if (injured > 100)
    //         {
    //             this.hp = 0;
    //         }
    //         else
    //         {
    //             this.hp -= injured;
    //         }

    //     }
    protected string Say()
    {
        return "我是生物";
    }
    public void InJured(int injured)  //損傷值
    {
        if (injured > 0)
        {
            if (injured > 100)
            {
                this.hp = 0;
            }
            else
            {
                this.hp -= injured;
            }

        }


    }
    //1. Override 指的是「改寫、覆寫」，主要是用來讓繼承的 class 改寫掉從 base class 繼承到的行為。
    //2. 想要使用 Override，首先必須要先在繼承的 class 中定義一個名稱與參數皆相同的method，然後在原本的 method 前加上「virtual」關鍵字，而新的 method 前加上「override」關鍵字。
    public virtual string Walk()   //virtual 複寫 
    {
        return this.name + "開始狂奔般向前走";
    }
}
