using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class StartGame : MonoBehaviour
{
    public TMP_Text option1;
    public TMP_Text option2;
    public TMP_Text option3;
    
    void Start()
    {
        Randoming();
    }
    public void Randoming()
    {
        int random1 = Random.Range(0, 10);
        int random2 = Random.Range(0, 10);
        int random3 = Random.Range(0, 10);
        if (random1 <= 2)
        {
            option1.text = "loot";
        }else if(random1 <= 5)
        {
            option1.text = "fight";
        }else if(random1 <= 8)
        {
            option1.text = "dip";
        }else if(random1 == 9)
        {
            option1.text = "extract";
        }
        if (random2 <= 2)
        {
            option2.text = "loot";
        }else if(random2 <= 5)
        {
            option2.text = "fight";
        }else if(random2 <= 8)
        {
            option2.text = "dip";
        }else if(random2 == 9)
        {
            option2.text = "extract";
        }
        if (random3 <= 2)
        {
            option3.text = "loot";
        }else if(random3 <= 5)
        {
            option3.text = "fight";
        }else if(random3 <= 8)
        {
            option3.text = "dip";
        }else if(random3 == 9)
        {
            option3.text = "extract";
        }
    }
    public void Button1()
    {
        if (option1.text == "loot")
        {
            option1.text = "";
        }else if(option1.text == "fight")
        {
            SceneManager.LoadScene("fight");
        }else if(option1.text == "dip")
        {
            Randoming();
        }else if(option1.text == "extract")
        {
            SceneManager.LoadScene("Loadout");
        }
    }
    public void Button2()
    {
        if (option2.text == "loot")
        {
            option2.text = "";
        }else if(option2.text == "fight")
        {
            SceneManager.LoadScene("fight");
        }else if(option2.text == "dip")
        {
            Randoming();
        }else if(option2.text == "extract")
        {
            SceneManager.LoadScene("Loadout");
        }
    }
    public void Button3()
    {
        if (option3.text == "loot")
        {
            option3.text = "";
        }else if(option3.text == "fight")
        {
            SceneManager.LoadScene("fight");
        }else if(option3.text == "dip")
        {
            Randoming();
        }else if(option3.text == "extract")
        {
            SceneManager.LoadScene("Loadout");
        }
    }
}