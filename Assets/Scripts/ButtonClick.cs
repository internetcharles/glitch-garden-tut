using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{

    [SerializeField] private Defender defenderPrefab;

    // Start is called before the first frame update
    private void OnMouseDown()
    {
        var buttons = FindObjectsOfType<ButtonClick>();
        foreach (ButtonClick button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(41, 41, 41, 255);
        }
        GetComponent<SpriteRenderer>().color = Color.white;
        FindObjectOfType<DefenderSpawner>().SetSelectedDefender(defenderPrefab);
    }


}
