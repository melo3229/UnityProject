using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultidimensionalArrarys : MonoBehaviour
{
    public int[,] A = new int[2, 2] { { 5, 6 }, { 7, 8 } };
    public int[,] B = new int[2, 2] { { 1, 2 }, { 3, 4 } };

 	void Start ()
    {
        
        Add(A,B);
        SUBTRACT(A,B);
       
      
        Debug.Log(A_Plus(new int[] { 38 }));
        Debug.Log(B_Plus(22));
    }
    private int[,] Add (int[,] a , int[,] b)
    {
        int [,] a_b = new int [2,2];//相加後的答案

        for (int i = 0; i <2; i++)
        {
            for (int x = 0; x < 2; x++)
            {
                a_b[i, x] = A[i, x] + B[i, x];
            }
        }
        SayMyAB(a_b);

        return a_b;
    }
    private int[,] SUBTRACT(int[,] a, int[,] b)
    {
        int[,] a_b = new int[2, 2];//相加後的答案

        for (int i = 0; i < 2; i++)
        {
            for (int x = 0; x < 2; x++)
            {
                a_b[i, x] = A[i, x] - B[i, x];
            }
        }
        SayMyAB(a_b);
        return a_b;
    }
    void SayMyAB(int[,] a_b)
    {
        Debug.Log(a_b[0, 0] + "," + a_b[0, 1] + "\n" + a_b[1, 0] + "," + a_b[1, 1]);
       
    }
    int A_Plus(int[] a)
    {
    return a[0];
    }
    int B_Plus(params int[] b) //參數陣列
    {
    return b[0];
    }
}
