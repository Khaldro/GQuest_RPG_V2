using System;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public struct CharacterData
{
    public string ccNAME;
    public short ccLVL;
    public short ccSTR;
    public short ccVIT;
    public short ccDEX;
    public int ccATTACK;
    public int ccDEFENSE;
}
public struct Characters
{
    public static Dictionary<int, CharacterData> CHARACTER_DICT = new Dictionary<int, CharacterData>();
}

public struct __WeaponData
{
    public int ID;
    public string wwSigle;

}
public struct __Weapons
{
    public static Dictionary<int, __Weapons> WEAPONS_DICT = new Dictionary<int, __Weapons>();
}

public struct __BottomButtonsData
{
    public static UnityEngine.Rect RECT;
}

public struct __AdventureData
{
    public static List<string> MOB_NAMES;   // TODO: Need to be querried from a file;
    public static short ZONES_COUNT = 10;
    public static GameObject ADVENTURE_PANEL;
    public static Dictionary<int, GameObject> ZONE_BUTTONS = new Dictionary<int, GameObject>();
}

public struct __ZoneButtonData
{
    public static List<__ZoneButtonData> ZoneButtonsList;

    public string IMAGE_PATH;
    public string ZONE_NAME;
    public short ZONE_LVL;

    public short ZONE_ID;
}

// ------------------------------MOBS------------------------------
// The way this works right know is that __MobData is generated in the Generator.cs => GenerateMobs()
// there are 9 __MobData per __MobsDataStruct
// there are as many __MobsDataStruct as there are zones (10)
// each __MobDataStruct is statically stored in __MobsDict.MOBS_DICT  Dictionary

public struct __MobData
{
    public int ID;
    public short LVL;
    public string mmName;
    public UnityEngine.UI.Image image;
    public int ATTACK;
    public int DEFENSE;
}

public struct __MobsDataStruct
{
    // must contain 9 mobs - 9th mob is a Boss
    public List<__MobData> Mobs;
}

public struct __MobsDict
{
    public static Dictionary<int, __MobsDataStruct> MOBS_DICT = new Dictionary<int, __MobsDataStruct>();
}
