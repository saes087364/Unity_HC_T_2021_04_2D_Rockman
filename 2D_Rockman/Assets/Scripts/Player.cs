using UnityEngine;

public class Player : MonoBehaviour
{
    //移動速度
    [Header("Speed"), Tooltip("Speed"), Range(0, 1000)]
    public float speed = 10.5f;

    //跳躍高度
    [Header("Jump"), Tooltip("Jump high"), Range(0, 3000)]
    public int jump = 100;

    //血量
    [Header("Health"), Tooltip("Health point"), Range(0, 200)]
    public float hp = 100;

    //是否在地板上
    [Header("Ground"), Tooltip("It is on ground?")]
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

    #region 方法

    /// <summary>
    /// 動
    /// </summary>
    private void Move()
    {

    }

    /// <summary>
    /// 跳
    /// </summary>
    private void Jump()
    {

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
