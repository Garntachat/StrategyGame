using UnityEngine;
using UnityEngine.SceneManagement;
public class ShowStat : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void LoadStat()
    {
        SceneManager.LoadScene("stat");
    }

    public void LoadRecruitStat()
    {
        SceneManager.LoadScene("recruitstat");
    }

    public void LoadSoldierStat()
    {
        SceneManager.LoadScene("Soldierstat");
    }
    public void LoadPsychoStat()
    {
        SceneManager.LoadScene("Psychostat");
    }     
}
