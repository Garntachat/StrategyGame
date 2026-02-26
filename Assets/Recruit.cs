using UnityEngine;
using TMPro;

public class Recruit : MonoBehaviour
{
    public TMP_Text result;
    public void randomRecruit()
    {
        CollectionData data = SaveSystem.LoadCollection();

        if (data == null || data.collectionStatus == null || data.collectionStatus.Length == 0)
        {
            Debug.LogError("No collection data found!");
            return;
        }

        int randomValue = Random.Range(0, data.collectionStatus.Length);

        Debug.Log("Recruited: " + data.collectionStatus[randomValue]);

        // Change the selected character
        data.collectionStatus[randomValue] = "";

        // Save directly
        SaveSystem.SaveCollection(data.collectionStatus);
        result.text = randomValue.ToString();
        
    }
}