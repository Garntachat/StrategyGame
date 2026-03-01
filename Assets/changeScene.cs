using UnityEngine;
using UnityEngine.SceneManagement;
public class changeScene : MonoBehaviour
{
    public string name = "mainmenu";
    public void LoadFight()
    {
        SceneManager.LoadScene("fight");
    }

    public void LoadMission()
    {
        SceneManager.LoadScene("Mission");
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("mainmenu");
    }

    public void LoadByName()
    {
        SceneManager.LoadScene(name);
    }
    public void LoadRecruit()
    {
        SceneManager.LoadScene("Recruit");
    }
    public void LoadCollection()
    {
        SceneManager.LoadScene("Collection");
    }
}
