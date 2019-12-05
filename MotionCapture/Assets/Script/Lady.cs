using UnityEngine;

public class Lady : MonoBehaviour
{

    private Animator ani;
    private Rigidbody rig;


    [Header("速度"), Range(0f, 50f)]
    public float speed = 10f;
    [Header("轉向速度"), Range(0f, 100f)]
    public float turn = 100f;
    [Header("血量"), Range(100,500)]
    public float HP = 100;

    [Header("動畫控制器")]

    public string aniWalk = "走路開關";
    public string aniHurt = "受傷觸發";
    public string aniAtk = "攻擊01觸發";
    public string aniJump = "跳躍觸發";
    public string aniDead = "死亡開關";



    public bool isAttack
    {
        get
        {
            return ani.GetCurrentAnimatorStateInfo(0).IsName("攻擊01");
        }

    }


    public bool isHurt
    {
        get
        {
            return ani.GetCurrentAnimatorStateInfo(0).IsName("受傷");
        }



    }

    
    private void Start()
    {
        ani = GetComponent<Animator>();
        rig = GetComponent<Rigidbody>();
    }


    private void Update()
    {
        // 判斷動畫狀態
        //print("是否為攻擊動畫：" + isAttack);
        //print("是否為受傷動畫：" + isHurt);

        if (isAttack || isHurt) return;  //跳出


        Attack();
        Turn();
    }


    private void FixedUpdate()
    {
        if (isAttack || isHurt) return;  //跳出

        Walk();
        Jump();
    }


    // 觸發事件：碰到勾選 IsTrigger 碰撞器開始時候執行一次
    private void OnTriggerEnter(Collider other)
    {
        print(other.tag);

        if (other.tag == "陷阱")
        {
            Hurt();
        }
    }
    // 定義方法
    // 修飾詞 傳回類型 方法名稱 ( 參數 ) { 敘述 }
    // void 無回傳


    /// <summary>
    /// 前後左右走路
    /// </summary>
    private void Walk()
    {
        ani.SetBool(aniWalk, Input.GetAxis("Vertical") != 0|| Input.GetAxis("Horizontal") != 0);
        //rig.AddForce(0, 0, Input.GetAxisRaw("Vertical") * speed);             // 以世界座標移動
        //rig.AddForce(transform.forward * Input.GetAxisRaw("Vertical") * speed); // 以區域座標移動

        ///transform.forward(0,0,1)
        //transform.right(1,0,0)
        //transform.up(0,1,0)

        rig.AddForce(transform.forward * Input.GetAxisRaw("Vertical") * speed + transform.right * Input.GetAxisRaw("Horizontal") * speed);


    }


    /// <summary>
    /// 左右旋轉
    /// </summary>
    private void Turn()
    {
        float x = Input.GetAxis("Mouse X");   // 滑鼠左右，左 -1、右 1
        //print("玩家滑鼠 X：" + x);
        transform.Rotate(0, x * turn * Time.deltaTime, 0);
    }



    /// <summary>
    /// 攻擊
    /// </summary>
    private void Attack()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            ani.SetTrigger(aniAtk);
        }

    }    
    
    /// <summary>
    /// 跳躍
    /// </summary>
    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ani.SetTrigger(aniJump);
        }

    }

    /// <summary>
    /// 受傷
    /// </summary>
    private void Hurt()
    {

      ani.SetTrigger(aniHurt);
        HP -= 25;
        if (HP <= 0) Dead();

    }

    /// <summary>
    /// 死亡
    /// </summary>
    private void Dead()
    {

        ani.SetTrigger(aniDead);

        //this 此腳本
        //enabled 啟動

        this.enabled = false;
    }


}

