using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public void ClickStartButton()
    {
        PlayerPrefs.SetString("Milestone", "Spawn");
        ClickLoadButton();
    }

    public void ClickLoadButton()
    {
        SceneManager.LoadScene(PlayerPrefs.GetString("Milestone"));
    }

    public void ClickQuitButton()
    {
        Application.Quit();
    }
}
