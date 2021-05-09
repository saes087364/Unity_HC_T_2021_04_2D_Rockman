using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    //靜態方法處理：1.開始遊戲 2.結束遊戲
    //讓按鈕與程式溝通
    //公開的方法
    public void StartGame()
    {
        //！！！
        //記得在Build Settings放入場景
        //！！！

        //Application.LoadLevel("遊戲畫面"); //已過時
        //SceneManager.LoadScene("遊戲畫面");
        //SceneManager.LoadScene(1);

        Invoke("DelayStart", 1.0f);
    }

    public void QuitGame()
    {
        //Application.Quit();

        Invoke("DelayQuit", 1.0f);
    }

    private void DelayStart()
    {
        SceneManager.LoadScene("遊戲畫面");
    }

    private void DelayQuit()
    {
        Application.Quit();
    }
}
