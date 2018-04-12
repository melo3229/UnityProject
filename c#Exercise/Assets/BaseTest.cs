using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseTest : MonoBehaviour
{
    
    
    public int a;
    public abstract class Plant //abstract class (抽象類別) 無法被建立的物件類別
    {
        protected string name;
        public Plant(string name)
        {
            this.name = name;
        }
        public virtual string SayMyname()
        {
            return  "我是植物";
        }
        //abstract method(抽象方法) //Abstract method 主要的目標是預先宣告 method，但是把實作的工作交給"繼承"的類別來做。
        public abstract string Taste(); //味道
       
    }
    public class Flower : Plant
    {
        //想要呼叫基底類別的建構子(constructor) 時，可以在自己的建構子後加上 base 來呼叫
        public Flower(string name) : base(name)
        {
            //this.name = name;
        }
        public override string SayMyname()
        {
            //第二種可能用到 base 的狀況：當衍生類別 override 了一個基底類別的 method，若想存取原版 (原本在基底類別內的版本) 的 method，就可以用 base
            return base.SayMyname() + this.name;
        }
        public override string Taste() 
        {
            return this.name + "香香甜甜的";
        }
    }
    public class Tea : Plant
    {
        public Tea(string name): base(name)
        {
            this.name = name;
        }
        public override string SayMyname()
        {
            return base.SayMyname() + this.name;
        }
        public override string Taste()
        {
            return this.name+"苦苦澀澀的";
        }
    }
    void Start()
    {

       
        Plant tea = new Tea("高山茶葉");
        Plant flower = new Flower("大腸花");
        Debug.Log(flower.SayMyname());
        Debug.Log(flower.Taste());
        Debug.Log(tea.SayMyname());
        Debug.Log(tea.Taste());

    }
}
