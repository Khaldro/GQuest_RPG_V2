

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Destroys the gameObject this script is attached to when that object is disabled
/// (Great for closing UI panels with a Close button)
/// </summary>
public class DestroySelf : MonoBehaviour
{
    public UnityEngine.UI.Button Button;

    void Start()
    {

        Button.onClick.AddListener(CloseThis);
    }
    private void CloseThis()
    {
        gameObject.SetActive(false);
    }
    private void OnDisable()
    {
        Destroy(gameObject);
    }

    // TODO: Close Panel on press Return Button

}
