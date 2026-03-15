using UnityEngine;
using TMPro;

public class SaveCollection : MonoBehaviour
{
    public TMP_Text[] collectionList;
    void Start()
    {

        CollectionData data = SaveSystem.LoadCollection();

        if (data == null)
        {
            for (int i = 0; i < collectionList.Length; i++)
            {
                collectionList[i].text = "Locked";
                
            }
            
        }
        
        int[] col = new int[collectionList.Length];
        
        for (int i = 0; i < collectionList.Length; i++)
        {
            Debug.Log(data.collectionStatus[i]);
            collectionList[i].text = data.collectionStatus[i].ToString();
            col[i] = int.Parse(collectionList[i].text);
            
        }
        
        
        SaveSystem.SaveCollection(col);
        

    }

    public void resetCol()
    {
        int[] col = new int[collectionList.Length];

        for (int i = 0; i < collectionList.Length; i++)
        {
            col[i] = 0;
            collectionList[i].text = "Locked";
        }
        
        
        SaveSystem.SaveCollection(col);
    }

}
