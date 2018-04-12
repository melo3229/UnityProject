using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverrideTest : MonoBehaviour
{
    /*1. Override 指的是「改寫、覆寫」，主要是用來讓繼承的 class 改寫掉從 base class 繼承到的行為。
    2. 想要使用 Override，首先必須要先在繼承的 class 中定義一個名稱與參數皆相同的method，然後在原本的 method 前加上「virtual」關鍵字，而新的 method 前加上「override」關鍵字。
    補充
    Override 使用時機
    基本上在撰寫物件導向的程式時，為了要讓許多物件有相同的動作，通常會寫一個 class 包含該動作，並讓其他 class 繼承它。就像是這次課程中介紹的 move 或 attack。
    可是偏偏會有一些狀況會需要讓某些物件的行為與預設的不同，而當你需要這種修改時，就會用到 override。
    */
    public class Book
    {
        public string BookName;
        public Book()
        {
            this.BookName = "寫扣的藝術";
        }
        public virtual string ShowPrice()
        {
            return BookName + "200元";
        }
    }
    public class Encyclopedia : Book
    {
        public Encyclopedia(string bookname)
        {
            this.BookName = bookname;
        }
        public override string ShowPrice()
        {
            return this.BookName + "500元";
        }
    }
    void Start()
    {
        Book bk = new Book();
        Encyclopedia EL = new Encyclopedia("大英百科全書");
        Debug.Log(bk.ShowPrice());
        Debug.Log(EL.ShowPrice());
    }
}

