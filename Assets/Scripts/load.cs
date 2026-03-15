using UnityEngine;
using TMPro;

public class load : MonoBehaviour
{
    public TMP_Text[] missionStatus;

    void Start()
    {
        MissionData data = SaveSystem.LoadMission();

        if (data != null)
        {
            for (int i = 0; i < missionStatus.Length; i++)
            {
                missionStatus[i].text = data.missionStatus[i];
            }
        }
    }
}
