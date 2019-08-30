using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BottomButtons : MonoBehaviour
{
    List<Button> Buttons;
    private static GameObject AdventurePanel;
    void Start()
    {
        AdventurePanel = GameObject.FindGameObjectWithTag("Adventure");


        Buttons = new List<Button>();
        for (int i = 0; i < gameObject.GetComponentsInChildren<Button>().Length; i++)
        {
            Buttons.Add(gameObject.GetComponentsInChildren<Button>()[i]);
        }
        __BottomButtonsData.RECT = this.GetComponent<RectTransform>().rect;
        

        Buttons[0].onClick.AddListener(Action0);
        Buttons[1].onClick.AddListener(Action1);
        Buttons[2].onClick.AddListener(Action2);
        Buttons[3].onClick.AddListener(Action3);
    }

    private void Action3()
    {
        CloseAdventurePanel();
    }

    private void Action2()
    {
        CloseAdventurePanel();
    }

    private void Action1()
    {
        CloseAdventurePanel();
    }

    private void Action0()
    {
        CloseAdventurePanel();
    }

    private static void CloseAdventurePanel()
    {
        AdventurePanel = GameObject.FindGameObjectWithTag("Adventure");
        if (AdventurePanel && AdventurePanel.activeSelf)
        {
            AdventurePanel.SetActive(false);
        }
    }
}
