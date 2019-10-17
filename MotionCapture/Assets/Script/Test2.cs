using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    public int studentA = 10;
    public int studentB = 20;
    public int studentC = 30;


    public int[] students = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };    //陣列


    public Color[] colors = { Color.black, Color.red };

    private void Start()
    {
        //取得資料
        Debug.Log(students[6]);


        //存入陣列資料
        students[2] = 33;


        //陣列數量(長度)

        Debug.Log("學生陣列的長度:" + students.Length);


        //數學運算子
        Debug.Log(10 + 5);
        Debug.Log(10 - 5);
        Debug.Log(10 * 5);
        Debug.Log(10 / 5);
        Debug.Log(10 % 5);

        //比較運算子
        Debug.Log(10 > 5);
        Debug.Log(10 < 5);
        Debug.Log(10 >= 5);
        Debug.Log(10 <= 5);
        Debug.Log(10 == 5);
        Debug.Log(10 != 5);


        //當 ( ) 內為 ture 會執行  {}
        if (studentA >= 60)
        {
            Debug.Log("你及格了!!");

        }

        else if (studentA >= 50)
        {
            Debug.Log("你可以補考!");
        }
        else if (studentA >= 40)
        {
            Debug.Log("下學期再來!");
        }
        //當 ( ) 內為 false 會執行 {}
        else
        {
            Debug.Log("你不及格!!");

        }
    }
    private void Update()
    {
        //Debug.Log(Input.GetKeyDown("Space"));
        Debug.Log(Input.GetKeyDown(KeyCode.Space));
    }
}

