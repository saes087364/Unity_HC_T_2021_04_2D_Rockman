using UnityEngine;

public class APIStatic : MonoBehaviour
{
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

        print(Camera.allCamerasCount);
        print(Physics2D.gravity);
        //Physics2D.gravity{};
        //Application.OpenURL("https://unity.com/");
        print(Mathf.FloorToInt(9.999f));
    }

    private void Update()
    {
        print(Input.anyKeyDown);
        print("時間 = " + Time.time);
    }
}
