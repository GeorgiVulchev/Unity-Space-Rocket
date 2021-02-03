using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public void ClickPause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }
}
