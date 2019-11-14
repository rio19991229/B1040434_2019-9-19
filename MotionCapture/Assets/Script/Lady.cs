using UnityEngine;

public class Lady : MonoBehaviour
{

    private Animator ani;
    private Rigidbody rig;


    [Header("速度"), Range(0f, 50f)]
    public float speed = 10f;


    [Header("動畫控制器")]

    public string aniWalk = "走路開關";
    public string aniHurt = "受傷觸發";
    public string aniAtk = "攻擊01觸發";
    public string aniJump = "跳躍觸發";
    public string aniDead = "死亡開關";




    private void Start()
    {
        ani = GetComponent<Animator>();
        rig = GetComponent<Rigidbody>();
    }


    private void Update()
    {
        Walk();
        Jump();
        Attack();
    }
    // 定義方法
    // 修飾詞 傳回類型 方法名稱 ( 參數 ) { 敘述 }
    // void 無回傳


    /// <summary>
    /// 走路
    /// </summary>
    private void Walk()
    {
        ani.SetBool(aniWalk, Input.GetAxis("Vertical") != 0|| Input.GetAxis("Horizontal") != 0);
        //rig.AddForce(0, 0, Input.GetAxisRaw("Vertical") * speed);             // 以世界座標移動
        rig.AddForce(transform.forward * Input.GetAxisRaw("Vertical") * speed); // 以區域座標移動
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

    }

    /// <summary>
    /// 死亡
    /// </summary>
    private void Dead()
    {

        ani.SetTrigger(aniDead);

    }


}

