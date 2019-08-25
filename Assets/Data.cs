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
    public static Dictionary<int, CharacterData> CHARACTER_LIST = new Dictionary<int, CharacterData>();
}





public struct __WeaponData
{
    public int ID;
    public string wwSigle;

}
public struct __Weapons
{
    public static Dictionary<int, __Weapons> WEAPONS_LIST = new Dictionary<int, __Weapons>();
}

public struct __BottomButtonsData
{
    public static UnityEngine.Rect RECT;
}

public struct __AdventureData
{
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

public struct __MobData
{
    public int ID;
    public string mmName;
    public UnityEngine.UI.Image image;
    public int ATTACK;
    public int DEFENSE;

    
}
public struct __Mobs
{
    public static Dictionary<int, __MobData> ITEMS_LIST = new Dictionary<int, __MobData>();
}
public struct __ZoneData
{
   public __MobData mob;
}