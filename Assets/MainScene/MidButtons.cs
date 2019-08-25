
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MidButtons : MonoBehaviour
{
    GameObject AdventurePanel;
    List<Button> Buttons;
    GridLayoutGroup layout;


    void Start()
    {
        layout = gameObject.GetComponent<GridLayoutGroup>();
        layout.cellSize = new Vector2(this.GetComponent<RectTransform>().rect.width / 2, this.GetComponent<RectTransform>().rect.height / 2);


        AdventurePanel = (GameObject)Resources.Load("Adventure");
        __AdventureData.ADVENTURE_PANEL = Instantiate(AdventurePanel, GameObject.Find("Canvas").transform);
        __AdventureData.ADVENTURE_PANEL.SetActive(false);
        __AdventureData.ADVENTURE_PANEL.tag = "Adventure";
        __AdventureData.ADVENTURE_PANEL.name = "Adventure";


        Buttons = new List<Button>();
        for (int i = 0; i < gameObject.GetComponentsInChildren<Button>().Length; i++)
        {
            Buttons.Add(gameObject.GetComponentsInChildren<Button>()[i]);
        }


        Buttons[0].onClick.AddListener(()=> { LoadAdventure(1); } );
    }


    private void LoadAdventure(int arg)
    {

        if (__AdventureData.ADVENTURE_PANEL.activeSelf == false)
            __AdventureData.ADVENTURE_PANEL.SetActive(true);
        else __AdventureData.ADVENTURE_PANEL.SetActive(false);
    }

    void Update()
    {
#if UNITY_EDITOR
        layout.cellSize = new Vector2(this.GetComponent<RectTransform>().rect.width / 2, this.GetComponent<RectTransform>().rect.height / 2);
#endif
    }
    
}
