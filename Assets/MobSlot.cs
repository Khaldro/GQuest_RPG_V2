using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MobSlot : MonoBehaviour
{
    Sprite sprite;
    public short zoneID;
    public short mobID;

    __MobData data;
    __MobsDataStruct tempStruct;

    void Start()
    {
        //Debug.LogWarning("MobSlot.cs => zoneID: " + zoneID + " mobID " + mobID);

        data = new __MobData();
        tempStruct = new __MobsDataStruct();
        tempStruct = __MobsDict.MOBS_DICT[zoneID];
        data = tempStruct.Mobs[mobID];
        this.GetComponent<Button>().GetComponentInChildren<Text>().text = data.mmName;
        
    }
}
