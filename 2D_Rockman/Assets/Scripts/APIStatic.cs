using UnityEngine;

public class APIStatic : MonoBehaviour
{
    private bool isKeyDown = false;

    private void Start()
    {
        //Static Properties
        //ReadOnly
        float r = Random.value;
        print(r);

        //Static Properties
        //Can Write
        Cursor.visible = false;

        //Static Methods
        int rangeInt = Random.Range(10, 200);
        float rangeFloat = Random.Range(10, 200);
        print(rangeInt + " || " + rangeFloat);

        float abs = Mathf.Abs(-11.11f);
        print(abs);

        //所有攝影機數量
        print(Camera.allCamerasCount);
        //2D 的重力大小
        print(Physics2D.gravity);
        //2D 的重力大小設定為 Y -20
        Physics2D.gravity = new Vector2(Physics2D.gravity.x, -20);
        print(Physics2D.gravity);
        //開啟連結
        Application.OpenURL("https://unity.com/");
        //對 9.999 去小數點
        print(Mathf.FloorToInt(9.999f));
        //取得兩點的距離
        print(Vector3.Distance(new Vector3(1, 1, 1), new Vector3(22, 22, 22)));
    }

    private void Update()
    {
        if (isKeyDown == false)
        {
            //是否輸入任意鍵
            print(Input.anyKeyDown);
            //遊戲經過時間
            print("時間 = " + Time.time);
            //是否按下按鍵(指定為空白鍵)
            print(Input.GetKeyDown(KeyCode.Space));

            if (Input.anyKeyDown == true)
            {
                isKeyDown = true;
            }
        }
    }
}
