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
    // Start is called before the first frame update
    void Start()
    {

        ZoneButtonTemplatePrefab = (GameObject)Resources.Load("ZoneButtonTemplate");
        ZoneTemplatePrefab       = (GameObject)Resources.Load("ZoneTemplate");



        GenerateZoneButton("First Zone", 1, 1, null);
        GenerateZoneButton("First Zone", 10, 2, null);
        GenerateZoneButton("Third zone", 20, 3, null);
    }

    void GenerateZoneButton(string name, short lvl, short zoneID, string imagePath)
    {
        Image zoneImage = (Image)Resources.Load(imagePath);

        //__ZoneButtonData zoneButton;
        //zoneButton.ZONE_ID = zoneID;
        //zoneButton.ZONE_NAME = name;
        //zoneButton.IMAGE_PATH = imagePath;
        //zoneButton.ZONE_LVL = lvl;
        //__ZoneButtonData.ZoneButtonsList.Add(zoneButton);

        GameObject ZoneButton;
        ZoneButton = Instantiate(ZoneButtonTemplatePrefab, this.transform.GetChild(0).transform.GetChild(0).transform);
        ZoneButton.name = name + "Button";
        
        //ZoneButton.GetComponent<Image>().sprite = zoneImage.sprite;
        ZoneButton.GetComponentsInChildren<Text>()[0].text = name;
        ZoneButton.GetComponentsInChildren<Text>()[1].text = "Lvl " + lvl;
        ZoneButton.GetComponent<RectTransform>().rect.Set(0,0, this.GetComponent<RectTransform>().rect.width-50, 200);
        __AdventureData.ZONE_BUTTONS.Add(zoneID, ZoneButton);
        ZoneButton.GetComponent<Button>().onClick.AddListener(() => GotoZone(name, zoneID, lvl));
    }

    private void GotoZone(string name, short zoneID, short lvl)
    {
        GameObject zone = Instantiate<GameObject>(ZoneTemplatePrefab, this.transform);
        rect = zone.transform.GetChild(0).GetChild(1).GetComponent<RectTransform>().rect;
        Debug.Log(zone.transform.GetChild(0).name);
        zone.GetComponentInChildren<GridLayoutGroup>().cellSize = new Vector2(rect.width / 3.15f, rect.height / 3.20f);
    }
}
