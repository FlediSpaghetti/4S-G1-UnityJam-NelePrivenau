using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] Image uiFill;
    [SerializeField] TextMeshProUGUI uiText;

    public int duration = 42;

    private int remainingDuration;
    bool isPaused;

    public GameObject losScr;

    private void Start()
    {
        losScr.SetActive(false);
        Begin(42);
    }

    void Begin(int second)
    {
        remainingDuration = second;
        StartCoroutine(UpdateTimer());
    }

    IEnumerator UpdateTimer()
    {
        while (remainingDuration >= 0)
        {
            if (!isPaused)
            {
                uiText.text = $"{remainingDuration / 42:00} : {remainingDuration % 42:00}";
                uiFill.fillAmount = Mathf.InverseLerp(0, duration, remainingDuration);
                remainingDuration--;
                yield return new WaitForSeconds(1f);
            }
            
        }
        End();
    }

    void End()
    {
            losScr.SetActive(true);
    }

    


}
