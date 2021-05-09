using UnityEngine;

public class Player : MonoBehaviour
{
    #region 全域變數

    //移動速度
    [Header("Speed"), Tooltip("Speed"), Range(0, 1000)]
    public float speed = 1000.0f;

    //跳躍高度
    [Header("Jump"), Tooltip("Jump high"), Range(0, 3000)]
    public int jump = 500;

    //血量
    [Header("Health"), Tooltip("Health point"), Range(0, 200)]
    public float hp = 100;

    //是否在地板上
    [Header("Ground"), Tooltip("Is it on ground?")]
    public bool isGrounded = false;

    //子彈(遊戲物件)
    [Header("Bullet"), Tooltip("Bullet")]
    public GameObject bullet;

    //元件 子彈生成點(Transform)
    [Header("Bullet Transform"), Tooltip("Bullet transform")]
    public Transform bulletPoint;

    //子彈速度
    [Header("Bullet Speed"), Tooltip("Bullet speed"), Range(0, 5000)]
    public int bulletSpeed = 800;

    //開槍音效(AudioClip)
    [Header("Bullet Audio"), Tooltip("Bullet audio")]
    public AudioClip bulletSound;

    //元件 音效來源 (AudioSource)
    private AudioSource audio;

    //元件 2D 剛體 (Rigidbody2D)
    private Rigidbody2D rigid;

    //元件 動畫控制器 (Animator)
    private Animator ani;

    public Vector3 offset = new Vector3(-0.20f, -0.88f, 0.00f);
    public float radius = 0.05f;

    #endregion

    #region 事件

    private void Start()
    {
        //利用程式取得元件
        //傳回元件 取得元件<元件名稱>() - <泛型>
        rigid = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Move();
        Jump();
    }

    //繪製圖示 - 輔助編輯時的圖形線條
    private void OnDrawGizmos()
    {
        //1.指定顏色
        Gizmos.color = new Color(1, 0, 0, 0.5f);

        //2.繪製圖形
        Gizmos.DrawSphere(transform.position + offset, radius);
    }

    #endregion

    #region 方法

    /// <summary>
    /// 動
    /// </summary>
    private void Move()
    {
        float h = Input.GetAxis("Horizontal");

        print("X: " + h);
        //速度*一幀的時間(60fps即1/60s)
        rigid.velocity = new Vector2(h * speed * Time.deltaTime, rigid.velocity.y);
    }

    /// <summary>
    /// 跳
    /// </summary>
    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigid.AddForce(Vector2.up * jump);
        }
    }

    /// <summary>
    /// 開火
    /// </summary>
    private void Fire()
    {

    }

    /// <summary>
    /// 受傷
    /// </summary>
    /// <param name="damage"></param>
    private void Hurt(float damage)
    {

    }

    /// <summary>
    /// 死亡
    /// </summary>
    /// <returns></returns>
    private bool Dead()
    {
        return false;
    }

    /// <summary>
    /// 拾取物品
    /// </summary>
    /// <param name="name"></param>
    private void Item(string name)
    {

    }

    #endregion
}
