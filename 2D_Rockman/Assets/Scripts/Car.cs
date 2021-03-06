using UnityEngine;

public class Car : MonoBehaviour
{
    // 註解

    /* 註解
     * 註解 註解
     * 註解 註解 註解
     * 註解 註解
     * 註解
     */

    #region 欄位

    //[欄位名稱(屬性內容)]
    //[Header(""), ToolTip(""), Range(,)]
    [Header("C.C."), Tooltip("車的C.C."), Range(1000, 5000)]
    public int cc = 2000;
    [Header("重量"), Tooltip("車的重量"), Range(1.00f, 10.00f)]
    public float weight = 1.5f;
    [Header("品牌"), Tooltip("車的品牌")]
    public string brand = "BMW";
    [Header("窗戶"), Tooltip("車窗是否開啟")]
    public bool windows = false;

    public char c = 'c';

    // Unity
    // Color
    // 座標2維-4維 Vector2、Vector3、Vector4
    public Color color = Color.red;
    public Color purple = new Color(0.3f, 0, 0.6f);
    public Color grey = new Color(0.5f, 0.5f, 0.5f, 0.5f); //(R比例, G比例, B比例, 不透明度)

    public Vector2 v2Zero = Vector2.zero;
    public Vector2 v2One = Vector2.one;
    public Vector2 v2 = new Vector2(1.01f, 2.02f);
    public Vector2 v3 = new Vector3(1.01f, 2.02f, 3.03f);
    public Vector2 v4 = new Vector4(1.01f, 2.02f, 3.03f, 4.04f);

    //按鍵
    public KeyCode key01 = KeyCode.UpArrow;
    public KeyCode key02 = KeyCode.Mouse0;
    public KeyCode key03 = KeyCode.Joystick1Button0;

    //遊戲物件 與 元件
    //遊戲物件 GameObject
    //遊戲元件 Component
    public GameObject obj01;

    //名稱去空格
    public Transform tra;
    public SpriteRenderer spr;

    #endregion

    #region 事件

    public int num = 1;
    public bool sure = false;
    public string prop = "紅色藥水";

    private readonly int a = 10;
    private readonly int b = 5;
    private readonly string str;

    //Event：特定時間點會被執行的function
    //UNITY提供的事件：Start、Update

    //開始執行時間點與次數
    //ex：數值初始化、金幣量與生命值
    private void Start()
    {
        print("START");
        print(num);
        print(sure);
        sure = true;
        print(sure);
        print(prop);
        prop = "藍色藥水";
        print(prop);
        Attack();
        print(Cal());
        print(Cal(a, b));
        print(Cal(a, b, str));
        print(Cal(a, b, "Not Default"));
        print(Cal(a, b, z: "Not Default"));
        print(Cal(a, b, "Not Default", "Not Default"));
        print(BMI(1.79f, 74));
    }

    //更新事件執行時間點與次數：每秒60FPS
    //ex：監聽玩家輸入與物件持續行為
    private void Update()
    {
        print("UPDATE");
    }

    #endregion

    #region 方法

    //Method(Unity使用)、Function：保存複雜程式或演算法的程式區塊
    /// <summary>
    /// 攻擊用Method
    /// </summary>
    private void Attack()
    {
        print("ATTACK!!");
    }

    /// <summary>
    /// 回傳計算過程
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns>sum</returns>
    private int Cal(int x = 0, int y = 10)
    {
        int sum = x - y;

        return sum;
    }

    /// <summary>
    /// 回傳計算過程
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <param name="z"></param>
    /// <returns>sum</returns>
    private string Cal(int x, int y, string z = "Default")
    {
        int sum = x + y;

        return z + sum;
    }

    /// <summary>
    /// 回傳計算過程
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <param name="z"></param>
    /// <param name="w"></param>
    /// <returns>sum</returns>
    private string Cal(int x, int y, string z, string w = "Default")
    {
        int sum = x + y;

        return z + sum + w;
    }

    /// <summary>
    /// BMI計算
    /// </summary>
    /// <param name="height"></param>
    /// <param name="weight"></param>
    /// <returns>bmi</returns>
    private float BMI(float height, float weight)
    {
        float bmi = 0.00f;

        bmi = weight / (height * height);

        return bmi;
    }

    #endregion
}
