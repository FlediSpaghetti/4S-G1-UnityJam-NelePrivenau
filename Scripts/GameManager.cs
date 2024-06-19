using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject startPanel;
    public GameObject winscreen;
    public GameObject losscr;

    private void Start()
    {
        startPanel.SetActive(true);
        Time.timeScale = 0f;
        winscreen.SetActive(false);
        losscr.SetActive(false);
    }

    public void PlayButton()
    {
        Time.timeScale = 1f;
        startPanel.SetActive (false);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene (1);
    }
}
