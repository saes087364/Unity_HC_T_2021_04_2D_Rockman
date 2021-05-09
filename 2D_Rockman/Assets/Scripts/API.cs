using UnityEngine;

public class API : MonoBehaviour
{
    //1.非靜態API需要物件
    //2.定義一個欄位 - 物件
    public Transform tra01;
    public Transform tra02;
    public SpriteRenderer spr01;

    public Camera cam01;
    public SpriteRenderer spr02;
    public Transform tra03;
    public Rigidbody2D rig01;

    void Start()
    {
        //靜態
        //類別名稱.靜態屬性
        float f = Random.value;

        //非靜態
        //get
        //物件名稱.非靜態屬性
        print(tra01.position);

        //非靜態
        //set
        //物件名稱.非靜態屬性 指定 值
        tra02.localScale = new Vector3(3, 3, 3);
        spr01.flipX = true;

        print(cam01.depth);
        spr02.color = Color.gray;
        print(spr02.color);
        cam01.backgroundColor = Color.black;
        spr02.flipY = true;
    }

    private void Update()
    {
        //非靜態
        //使用方法
        //物件名稱.非靜態方法(參數)
        tra02.Translate(0.01f, 0, 0);

        tra03.Rotate(0, 1, 0);
        //tra03.Translate(0, 0.01f, 0);
        rig01.AddForce(new Vector2(0, 3));
    }
}
