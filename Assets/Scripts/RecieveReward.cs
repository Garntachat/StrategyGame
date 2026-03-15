using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class RecieveReward : MonoBehaviour
{
    public TMP_Text[] missionStatus;
    public Button[] completeButton;

    void Start()
    {
        for (int i = 0; i < completeButton.Length; i++)
        {
            int index = i; // Important! Prevents closure bug
            completeButton[i].onClick.AddListener(() => ChangeMissionStatus(index));
        }
    }

    void ChangeMissionStatus(int index)
    {
        if (missionStatus[index].text == "incomplete")
        {
            missionStatus[index].text = "complete";
        }
        else
        {
            missionStatus[index].text = "incomplete";
        }
        string[] status = new string[missionStatus.Length];

for (int i = 0; i < missionStatus.Length; i++)
{
    status[i] = missionStatus[i].text;
}

SaveSystem.SaveMission(status);
    }
}
