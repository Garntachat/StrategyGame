using UnityEngine;
using TMPro;

public class SaveCollection : MonoBehaviour
{
    public TMP_Text[] collectionList;
    void Start()
    {

        CollectionData data = SaveSystem.LoadCollection();

        if (data != null)
        {
            for (int i = 0; i < collectionList.Length; i++)
            {
                collectionList[i].text = data.collectionStatus[i];
            }
        }
        
        string[] col = new string[collectionList.Length];

        for (int i = 0; i < collectionList.Length; i++)
        {
            col[i] = collectionList[i].text;
            Debug.Log(col);
        }
        
        
        SaveSystem.SaveCollection(col);
        

    }

    public void resetCol()
    {
        string[] col = new string[collectionList.Length];

        for (int i = 0; i < collectionList.Length; i++)
        {
            col[i] = "locked";
            collectionList[i].text = "locked";
        }
        
        
        SaveSystem.SaveCollection(col);
    }

}
