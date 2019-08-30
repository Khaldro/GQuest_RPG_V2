using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FightManager : MonoBehaviour
{
    __CharacterData player;
    __MobData opponent;

    Image PlayerHealthBar;
    Image OpponentHealthBar;

    [SerializeField]
    float player_Current_HP;
    [SerializeField]
    float opponent_Current_HP;
    [SerializeField]
    float player_MAX_HP;
    [SerializeField]
    float opponent_MAX_HP;

    public float BattleSpeed = 1f;
    private bool playerFirst;

    void Awake()
    {
        //GameObject.Find("Background").gameObject.GetComponentInChildren<UnityEngine.UI.Image>().sprite = __FightScene.background.sprite; // TO BE SET LATER

        PlayerHealthBar     = GameObject.Find("PlayerHealth").GetComponent<Image>();
        OpponentHealthBar   = GameObject.Find("OpponentHealth").GetComponent<Image>();

        PlayerHealthBar.fillAmount = 1f;
        OpponentHealthBar.fillAmount = 1f;

        player = __FightScene.player;
        opponent = __FightScene.opponent;

        player_MAX_HP       = player.HP;
        player_Current_HP   = player.HP;
        opponent_MAX_HP     = opponent.HP;
        opponent_Current_HP = opponent.HP;

        player_Current_HP = 40;

        PlayerHealthBar.fillAmount      = player_Current_HP / player_MAX_HP;
        OpponentHealthBar.fillAmount    = opponent_Current_HP / opponent_MAX_HP;

        Debug.Log(player.ccNAME);
        Debug.Log(opponent.mmName);

    }

   
    IEnumerator Start()
    {
        if (player.AttackSpeed > opponent.AttackSpeed)
            playerFirst = true;
        else playerFirst = false;

        print("Starting Battle " + Time.time);

        // Start function WaitAndPrint as a coroutine
        yield return StartCoroutine("WaitAndPrint");
        print("Done " + Time.time);
    }
    IEnumerator WaitAndPrint()
    {
        do
        {
            if (playerFirst)
            {

            }

        } while (player_Current_HP <= 0 || opponent_Current_HP <= 0);

        yield return new WaitForSeconds(BattleSpeed);
    }
}