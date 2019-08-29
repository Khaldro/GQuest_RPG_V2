using UnityEngine;

public class CharacterLogic : MonoBehaviour
{
    CharacterData Warrior = new CharacterData();

    void Start()
    {
        Warrior.ccNAME = "Khaldro";
        Warrior.ccLVL = 99;
        //Debug.Log(CharacterData.ccNAME

        Characters.CHARACTER_DICT.Add(1, Warrior);
    }
}