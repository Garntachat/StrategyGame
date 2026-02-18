using System;

[System.Serializable]
public class MissionData
{
    public string[] missionStatus;

    public MissionData(string[] status)
    {
        missionStatus = status;
    }
}
