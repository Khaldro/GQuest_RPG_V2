using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
public class Generator : MonoBehaviour
{

    GameObject ZoneButtonTemplatePrefab;
    GameObject ZoneTemplatePrefab;
    Rect rect;
 
    void Awake()
    {
        //GenerateMobs();

        //UnityEngine.Debug.DrawLine(new Vector3(1f, 1f, 1f), new Vector3(100f, 100f, 100f), Color.green, 1000f);
        ZoneButtonTemplatePrefab    = (GameObject)Resources.Load("ZoneButtonTemplate");
        ZoneTemplatePrefab          = (GameObject)Resources.Load("ZoneTemplate");

        GenerateZoneButton("First Zone",    1,  1, null);
        GenerateZoneButton("First Zone",    10, 2, null);
        GenerateZoneButton("Third zone",    20, 3, null);
        GenerateZoneButton("ShitassButton", 30, 4, null);
    }

    /// <summary>
    /// Mobs are generated here and stored statically into __MobsDict.MOBS_DICT Dictionary
    /// </summary>
    private void GenerateMobs()
    {
        short mobsPerZone   = 9;
        short maxZones      = 10;
        short counter       = 1;

        for (short i = 1; i != maxZones; i++)
        {
            __MobsDataStruct tempMobDataStruct  = new __MobsDataStruct();
            tempMobDataStruct.Mobs              = new List<__MobData>(9);

            for (short j = 1; j != mobsPerZone + 1; j++)
            {
                __MobData mobData = new __MobData
                {
                    ID          = counter,
                    LVL         = counter,
                    mmName      = "mob" + counter,
                    ATTACK      = 2 * counter,
                    DEFENSE     = 3 * counter,
                    image       = null
                };
                //Debug.Log(mobData.LVL);
                tempMobDataStruct.Mobs.Add(mobData);
                ++counter;
            }
            __MobsDict.MOBS_DICT.Add(i, tempMobDataStruct);

            //Debug.Log(__MobsDict.MOBS_DICT[i].Mobs[i-1].mmName);
        }
    }


    void Start()
    {
        GenerateMobs();
    }


    void GenerateZoneButton(string name, short lvl, short zoneID, string imagePath)
    {
        Image       zoneImage = (Image)Resources.Load(imagePath);
        GameObject  zoneButton;

        zoneButton = Instantiate(ZoneButtonTemplatePrefab, this.transform.GetChild(0).transform.GetChild(0).transform);
        zoneButton.name = name + "Button";
        
        //ZoneButton.GetComponent<Image>().sprite = zoneImage.sprite;
        zoneButton.GetComponentsInChildren<Text>()[0].text = name;
        zoneButton.GetComponentsInChildren<Text>()[1].text = "Lvl " + lvl;
        zoneButton.GetComponent<RectTransform>().rect.Set(0,0, this.GetComponent<RectTransform>().rect.width-50, 200);
        zoneButton.GetComponent<Button>().onClick.AddListener(() => GotoZone(name, zoneID, lvl));

        __AdventureData.ZONE_BUTTONS.Add(zoneID, zoneButton);
        __AdventureData.ZONES_COUNT += 1;
    }

    private void GotoZone(string name, short zoneID, short lvl)
    {
    short MobID = 0;
        GameObject zone = Instantiate<GameObject>(ZoneTemplatePrefab, gameObject.transform);
        rect = zone.transform.GetChild(0).GetChild(1).GetComponent<RectTransform>().rect;
        zone.GetComponentInChildren<GridLayoutGroup>().cellSize = new Vector2(rect.width / 3.15f, rect.height / 3.20f);

        
        Transform tempTransform = zone.transform.GetChild(0).GetChild(1);
        for (short i = 0; i <= 8; i++)
        {
            //Debug.LogWarning("Generator.cs => zoneID: " + zoneID + " mobID " + MobID);

            tempTransform.GetChild(i).GetComponent<MobSlot>().zoneID = zoneID;
            tempTransform.GetChild(i).GetComponent<MobSlot>().mobID = MobID;
            ++MobID;
        }
    }
}
