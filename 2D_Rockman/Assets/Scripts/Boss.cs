using UnityEngine;

public class Boss : MonoBehaviour
{
    //移動速度
    [Header("Speed"), Tooltip("Speed"), Range(0, 10)]
    public float speed = 3.5f;

    //攻擊力
    [Header("Damage"), Tooltip("Attack damage"), Range(0, 500)]
    public int damage = 100;

    //血量
    [Header("Health"), Tooltip("Health point"), Range(0, 5000)]
    public float hp = 350;

    //掉落道具(遊戲物件)
    [Header("Equip"), Tooltip("Falling equip")]
    public GameObject equip;

    //掉落機率
    [Header("Probability"), Tooltip("Equip probability"), Range(0, 1)]
    public float prob = 1.0000f;

    //掉落音效(AudioClip)
    [Header("Falling Sound"), Tooltip("Falling sound")]
    public AudioClip fallingSound;

    //元件 音效來源 (AudioSource)
    private AudioSource audio;

    //元件 2D 剛體 (Rigidbody2D)
    private Rigidbody2D rigid;

    //元件 動畫控制器 (Animator)
    private Animator ani;
}
