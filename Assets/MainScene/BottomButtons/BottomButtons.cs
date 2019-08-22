using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BottomButtons : MonoBehaviour
{
    List<Button> Buttons;
    void Start()
    {
        Buttons = new List<Button>();
        for (int i = 0; i < gameObject.GetComponentsInChildren<Button>().Length; i++)
        {
            Buttons.Add(gameObject.GetComponentsInChildren<Button>()[i]);
        }

        Buttons[0].onClick.AddListener(Clicked);
    }

    private void Clicked()
    {
        Debug.Log(CharacterData.ccNAME);
    }
}
