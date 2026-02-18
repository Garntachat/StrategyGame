using System;

[System.Serializable]
public class CollectionData
{
    public string[] collectionStatus;

    public CollectionData(string[] chara)
    {
        collectionStatus = chara;
    }
}
