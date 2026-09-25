using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void LoadLv1()
    {
        SceneManager.LoadScene("lv1");
    }
    public void LoadLv2()
    {
        SceneManager.LoadScene("lv2");
    }
    public void LoadWin()
    {
        SceneManager.LoadScene("WinMenu");
    }

}