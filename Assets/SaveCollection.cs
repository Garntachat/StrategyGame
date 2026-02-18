using UnityEngine;
using TMPro;

public class SaveCollection : MonoBehaviour
{
    public TMP_Text[] collectionList;
    void Start()
    {
        
        
        string[] col = new string[collectionList.Length];

        for (int i = 0; i < collectionList.Length; i++)
        {
            col[i] = collectionList[i].text;
        }

        SaveSystem.SaveCollection(col);
    }

}
