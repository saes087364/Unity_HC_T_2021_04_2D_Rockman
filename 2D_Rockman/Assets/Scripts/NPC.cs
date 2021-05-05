using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    #region 方法

    /// <summary>
    /// 對話
    /// </summary>
    /// <param name="content"></param>
    private void Talk(string content)
    {
        print(content);
    }

    /// <summary>
    /// 開啟商店
    /// </summary>
    /// <returns></returns>
    private bool Shop()
    {
        return true;
    }

    /// <summary>
    /// 購買道具
    /// </summary>
    /// <param name="item"></param>
    /// <returns></returns>
    private int Buy(int item = 100)
    {
        if (item == 100)
            return 0;

        return -1;
    }

    /// <summary>
    /// 取得任務
    /// </summary>
    /// <param name="num"></param>
    private void Mission(int num)
    {
        print(num);
    }

    /// <summary>
    /// 任務更新
    /// </summary>
    /// <param name="amount"></param>
    /// <returns></returns>
    private int Dead(int amount = 1)
    {
        if (amount == 1)
            return 0;

        return -1;
    }

    /// <summary>
    /// 完成任務
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    private bool Item(int num)
    {
        print(num);

        return false;
    }

    #endregion
}
