using UnityEngine;

public class CharacterLogic : MonoBehaviour
{
    __CharacterData Warrior = new __CharacterData();

    void Start()
    {
        Warrior.ccNAME = "Khaldro";
        Warrior.ccLVL = 99;
        Warrior.ccATTACK = 10;
        Warrior.AttackSpeed = 10;
        Warrior.HP = 100;
        //Debug.Log(CharacterData.ccNAME

        __Characters.CHARACTER_DICT.Add(1, Warrior);
    }
}