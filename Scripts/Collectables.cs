using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Collectables : MonoBehaviour
{
    public int goldCount;
    public TextMeshProUGUI goldText;
    public GameObject winscr;

    private void Update()
    {
        goldText.text = goldCount.ToString();

        if (goldCount == 5)
        {
            winscr.SetActive(true);
        }
    }
}
