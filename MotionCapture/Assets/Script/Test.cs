using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    //欄位
    //修飾詞 欄位類型 欄位名稱 (指定 值) ;
    [Header("分數"), Range (0,100)]  //Header 標題 Rangez範圍
    public int Score = 200;          // 整數
    [Header("速度"),Range(2.5f,10f)]
    [Tooltip ("速度最低2.5最高10")]  // 提示
    public float Speed = 2.5f;       // 浮點數
    [Header("血量")]
    public string HP = "Blood";      // 字串
    [Header("任務")]
    public bool misson = true;       // 布林值 (ture or false)

    //Unity 常用欄位類型

    [Header("二維")]
    public Vector2 v2 = new Vector2(1, 1);
    [Header("三維")]
    public Vector3 v3 = new Vector3(1, 1, 1);
    public Vector3 zero = Vector3.zero;

    [Header("顏色")]
    public Color blue = Color.blue;
    [Header("顏色")]
    public Color red = new Color(0.5f, 0.6f, 0.7f);


    //非靜態類別
    public AudioClip sound;
    public Camera cam;
    public Light lig;
    public Transform camPos;
    public GameObject obj;
    //靜態類別,不能宣告成欄位
    //public Debug deb;
    public Debug deb;

    private void Start()
    {   //非靜態類別
        //Camera.deth = 10.5f; //錯誤寫法

        cam.depth = 10.5f;


        //靜態類別
        Debug.Log("海狗");

    }

}
